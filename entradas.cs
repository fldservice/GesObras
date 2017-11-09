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
    public partial class entradas : Form
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
        public void destruirstok(int idproduto, int saldo, double area)
        {

            try
            {
                //verficar se o produto esta permitido a ser controlado ou nao

                var emp = tete.produtos.Where(s => s.idprodutos == idproduto).FirstOrDefault();

                if (saldo > 0 && area <= 0)
                {


                    //se o produto estiver permitido sera retirado a aquantidade vendida
                    var py = tete.produtos.Where(p => p.idprodutos == idproduto).FirstOrDefault();

                    py.Quatidade += saldo;
                    tete.SaveChanges();
                }
                else if (saldo <= 0 && area > 0)
                {

                    // se o capo de areas for prienchido realizada estas funcoes

                    double areas = (Double)emp.Areatotal;//buscar areatotal actual
                                                         //  decimal area = decimal.Parse(TextBox3.Text); ;// verficar a area requeriad
                    if (areas > area)
                    {
                        // decimal val = decimal.Parse("0." + TextBox3.Text);

                        decimal presai = decimal.Parse(emp.precos.ToString());
                        //decimal prexoto = val * presai;//obter o valor total
                        try
                        {


                            //  var pro = tete.produtos.Where(id => id.idprodutos == cl).FirstOrDefault();
                            /*
                             * iniciar aginastica
                            */
                            //area totao menos area introduzida=area restante
                            int ater = int.Parse(emp.Areatotal.ToString()) - int.Parse(area.ToString());

                            //obter o a prexo de saida
                            // decimal prexosaida = (decimal)(area * pro.prexototal) / (decimal)pro.Areatotal;

                            //obeter quantidade numerica removida
                            Double quant = (double)(area *(Double) emp.Quatidade) / (double)emp.Areatotal;

                            //obter a quantidade rstante
                            int qrem = int.Parse(emp.Quatidade.ToString()) -(int) quant;



                            //obert o valor pela quantidade removida
                            // double valorremo = qrem * (double)presai;

                            emp.Quatidade = qrem;
                            emp.Areatotal = ater;
                            // emp.prexototal = (decimal)qrem * pro.precos;
                            tete.SaveChanges();
                        }
                        catch (Exception ex)
                        {

                        }

                        //else if (emp.controlStock.Equals("Nao"))
                        //{
                        //    //caso contrario nada se faz

                        //}
                        //  int saldo = int.Parse(quantidadeRadTextBox.Text) - int.Parse(radTextBox3.Text);
                    }
                }
            }
            catch
            {

                MessageBox.Show("Nao foi possivel atualizar o estoke");
            }


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

                      //  int ares = int.Parse(dataGridView2[3, i].Value.ToString());
                        int idpro = Convert.ToInt16(dataGridView2[4, i].Value);//obter o numero do Produto (ID)
                                                                               // DateTime data = Convert.ToDateTime(DateTime.Now.ToShortDateString());
                                                                               // Decimal total = Convert.ToDecimal(dataGridView1[6, i].Value); //* Convert.ToDecimal(detalhes_de_VendaDataGridView[3, 1].Value);
                        int stok = Convert.ToInt32(dataGridView2[2, i].Value);

                        ///iserir dados na tabela item pedidos
                        dbges.entradas deta = new dbges.entradas()
                        {
                            // idproduto = idvenda,
                            qantidade = quant,

                            //item_preco = total,
                            idproduto = idpro,
                            //referencias_ped = refe,
                            //  areass = ares,
                            otrasinformacaoes = radTextBox2.Text,
                            dataentrada = DateTime.Now


                        };
                        tete.entradas.Add(deta);
                        tete.SaveChanges();

                        destruirstok(idpro, stok, 0);

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
