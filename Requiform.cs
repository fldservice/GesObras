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
   
    public partial class Requiform : Telerik.WinControls.UI.RadForm 
    { private teteenginhierEntities tete = new teteenginhierEntities();
        public Requiform()
        {
            InitializeComponent();
            autocompliteprodut();
            autoforn();
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
        void autoforn()
        {

            AutoCompleteStringCollection cl = new AutoCompleteStringCollection();
            tete = new teteenginhierEntities();
            var pro = tete.fornecedor.ToList();
            foreach (var item in pro)
            {

                cl.Add(item.Nome.ToString());
            }
            radTextBox2.AutoCompleteCustomSource = cl;
        }
        private void Requiform_Load(object sender, EventArgs e)
        {

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

                    dataGridView2.Refresh();
                    // radTextBox1.Text = "";
                    // radTextBox1.Focus();
                
            }


            else
            {
MessageBox.Show("Produto nao registrado ", "Novo Produto", MessageBoxButtons.OK,MessageBoxIcon.Stop);
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
      private  double calcular()
        {
            double valor = 0;
            double valorto = 0;
           
            for (int i = 0; i < dataGridView2.RowCount; i++)
            {


                int quant = Convert.ToInt16(dataGridView2[2, i].Value);
                if (quant != 0)
                {
                   
                    valor = Convert.ToDouble(dataGridView2[3, i].Value);
                    valorto += quant * valor;

                }

            }
            radLabel4.Text = valorto.ToString();
                    return valorto;
        }
        public void adicionaritemfactura()
        {
            try
            {

                //buscar o pedido feito recentimente
                var idpdido = novopedido();
                for (int i = 0; i < dataGridView2.RowCount; i++)
                {


                    int idvenda = Convert.ToInt16(idpdido.idrequisica);
                    int quant = Convert.ToInt16(dataGridView2[2, i].Value);
                    if (quant != 0)
                    {
                        // var refe = dataGridView2[1, i].Value.ToString();
                        String nome = Convert.ToString(dataGridView2[1, i].Value);

                         Decimal prexo = Convert.ToDecimal(dataGridView2[3, i].Value);
                        int idpro = Convert.ToInt16(dataGridView2[4, i].Value);//obter o numero do Produto (ID)
                                                                               // DateTime data = Convert.ToDateTime(DateTime.Now.ToShortDateString());
                                                                               // Decimal total = Convert.ToDecimal(dataGridView1[6, i].Value); //* Convert.ToDecimal(detalhes_de_VendaDataGridView[3, 1].Value);
                        int stok = Convert.ToInt32(dataGridView2[2, i].Value);
                        
                        ///iserir dados na tabela item pedidos
                        detalhesderequiza deta = new detalhesderequiza();
                        
                            deta.idrequiz = idvenda;
                        
                        deta.qty = quant;

                        //item_preco = total,
                        deta.idpprod = idpro;
                        //referencias_ped = refe,
                        deta.valor = prexo;
                           // datarequi = DateTime.Now


                        
                        tete.detalhesderequiza.Add(deta);
                        tete.SaveChanges();

                     

                    }

                }



            }
            catch (SystemException es)
            {
                MessageBox.Show("Problema " + es.Message);
                // MetroMessageBox.Show()
            }


        }

        private requizicao  novopedido()
        {  requizicao re =null;
            try
            {
                double total = calcular();
                double iva = total * 0.17;
                double totaliva = total + iva;
                re = new requizicao();
                var contar = tete.requizicao.Count();
                
                //re.idrequisica= contar + 1;
                re.datarequiz = DateTime.Now;
                re.ifornecidor = idforn;
                re.estadore = "Requizitado";
                re.valortotal =decimal.Parse ( total.ToString("#.##"));
                re.ivaVa = decimal.Parse(iva.ToString("#.##"));
                re.Totaliva =decimal.Parse ( totaliva.ToString ("#.##"));
                re.requizitante = radTextBox2.Text;
                tete.requizicao.Add(re);
                tete.SaveChanges();
                
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
               
            }
            return re;

        }

        private void radButton1_Click(object sender, EventArgs e)
        {
            adicionaritemfactura();
            MessageBox.Show("Produtos inclusis com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Dispose();

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

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                calcular();
            }
            catch (Exception)
            {

                return;
            }

        }

        private void radTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private int idforn;
        private void radTextBox2_KeyUp(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                try
                {

                    var forn = tete.fornecedor.Where(r => r.Nome.Contains(radTextBox2.Text)).FirstOrDefault();
                   radLabel6.Text = forn.Nome.ToString();
                    idforn = forn.idforn;
                    //radTextBox1.Focus();
                    // txtQuantidade.Text = "1";
                    //textpUnit.Text = "";
                }
                catch (System.Exception ex)
                {
                    MessageBox.Show(ex.Message+ " nao encontrado");
                }
            }
        }
    }
}
