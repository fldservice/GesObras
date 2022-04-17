using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dbges;

namespace GesObras
{
    public partial class entradas : Telerik.WinControls.UI.RadForm 
    {
        private teteenginhierEntities tete =new teteenginhierEntities();
        public entradas()
        {
            InitializeComponent();
            autocompliteprodut();
        }
        void autocompliteprodut()
        {

            AutoCompleteStringCollection cl = new AutoCompleteStringCollection();
            tete = new teteenginhierEntities();
            var pro = tete.lisproduto.ToList();
            foreach (var item in pro)
            {

                cl.Add(item.produtos_nome.ToString());
            }
            radTextBox1.AutoCompleteCustomSource = cl;
        }
        private void entradas_Load(object sender, EventArgs e)
        {

        }
        public Boolean construir(int idproduto, int qtys, double area)
        {

            try
            {
                var contar = tete.Precos_pro.Where(t => t.idpro == idproduto).Count();
                if (contar != 0)
                {



                    var verpre = tete.Precos_pro.Where(t => t.idpro == idproduto).OrderByDescending(i => i.preco_pro).FirstOrDefault();

                    verpre.qtypro += qtys;
                    tete.SaveChanges();

                }
                else
                {
                   MessageBox.Show("Este produto nao tem preços definido\n insira pelo menos um preço", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return false;
                    
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Problema na iclusao do produto\n"+ex.Message , "Erro", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return false;
            }

            return true;
        }//retirar a Quantidade no stock


        //adicionar item na tabela pedidos_item
        public void adicionaritemfactura()
        {
            try
            {

                //buscar o pedido feito recentimente
                // var idpdido = novopedido();
                for (int i = 0; i < dataGridView2.RowCount; i++)
                {


                   // int idvenda = Convert.ToInt16(idobra);
                    int quant = Convert.ToInt16(dataGridView2[2, i].Value);
                    if (quant != 0)
                    {
                        // var refe = dataGridView2[1, i].Value.ToString();
                        String nome = Convert.ToString(dataGridView2[1, i].Value);

                       decimal ares = decimal.Parse(dataGridView2[3, i].Value.ToString());
                        int idpro = Convert.ToInt16(dataGridView2[4, i].Value);//obter o numero do Produto (ID)
                                                                               // DateTime data = Convert.ToDateTime(DateTime.Now.ToShortDateString());
                                                                               // Decimal total = Convert.ToDecimal(dataGridView1[6, i].Value); //* Convert.ToDecimal(detalhes_de_VendaDataGridView[3, 1].Value);
                        int stok = Convert.ToInt32(dataGridView2[2, i].Value);

                        ///iserir dados na tabela item pedidos
                        if (construir(idpro, stok, 0) ==true )
                        {
                            dbges.entradas deta = new dbges.entradas();

                            // idproduto = idvenda,
                            deta.qantidade = quant;

                            //item_preco = total,
                            deta.idproduto = idpro;
                            //referencias_ped = refe,
                            //  areass = ares,
                            deta.precoss = ares;
                            deta.otrasinformacaoes = radTextBox2.Text;
                            deta.dataentrada = DateTime.Now;


                           
                            tete.entradas.Add(deta);
                            tete.SaveChanges();
                        }

                       
                    }

                }



            }
            catch (SystemException es)
            {
                MessageBox.Show("Problema " + es.Message);
                // MetroMessageBox.Show()
            }


        }
        private void Procurarpornome(string nomepro)
        {
            tete = new teteenginhierEntities();
            int ver;
            ver = tete.lisproduto.Where(r => r.produtos_nome.Equals(nomepro)).Count();
            if (ver == 1)
            {

                var cli = tete.lisproduto.Where(r => r.produtos_nome.Equals(nomepro)).FirstOrDefault();

               

                    var pr = tete.lisproduto.Where(r => r.produtos_nome.Equals(nomepro)).FirstOrDefault();

                    int row = 0;
                    dataGridView2.Rows.Add();
                    row = dataGridView2.Rows.Count - 2;
                    dataGridView2["id", row].Value = pr.idprodutos;
                    dataGridView2["Categoria", row].Value = pr.proCategorias;
                    dataGridView2["Produto", row].Value = pr.produtos_nome;
                     dataGridView2["Area", row].Value = 0;

                dataGridView2.Refresh();
                
                    // radTextBox1.Text = "";
                    // radTextBox1.Focus();
                }
            


            else
            {

                DialogResult resp = MessageBox.Show("Produto nao registrado ", "Novo Produto", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                //if (resp == DialogResult.Yes)
                //{
                //    var cat = si.Categorias_prod.Where(c => c.idEmpresass == idempresa && c.controlStock.Equals("Nao")).FirstOrDefault();
                //    Produtos_integ pr = new Produtos_integ();

                //    pr.pro_nome = textpro_nome.Text;
                //    pr.pro_val_venda = decimal.Parse(textpUnit.Text);
                //    pr.pro_referencia = textBox2.Text;
                //    pr.pro_categoid = cat.id_catego;
                //    si.Produtos_integ.Add(pr);
                //    si.SaveChanges();
                //    Procurarpornome(textpro_nome.Text);

                //}


            }
        }

        private void radTextBox1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {

                    Procurarpornome(radTextBox1.Text);
                    radTextBox1.Text = "";
                    //radTextBox1.Focus();
                    // txtQuantidade.Text = "1";
                    //textpUnit.Text = "";
                }
                catch (System.Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void radButton1_Click(object sender, EventArgs e)
        {
            adicionaritemfactura();
            MessageBox.Show("Compras realizadas com sucesso","Sucesso",MessageBoxButtons.OK,MessageBoxIcon.Information);
            this.Dispose();
        }

        private void radTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
