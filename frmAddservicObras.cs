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
    public partial class frmAddservicObras : Form
    {
        private teteenginhierEntities si = new teteenginhierEntities();
        Decimal valr = 0;
        public Decimal re = 0;
        public frmAddservicObras()
        {
            InitializeComponent();
            autocomplet();
        }
        public int idobra { get; set; }
        private void frmAddservicObras_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {

                calcura();
            }
            else if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    for (int i = 0; i < dataGridView1.RowCount; i++)
                    {



                        int quant = Convert.ToInt16(dataGridView1[4, i].Value);
                        if (quant != 0)
                        {


                            Decimal prexo = Convert.ToDecimal(dataGridView1[3, i].Value);


                            // Decimal total = Convert.ToDecimal(dataGridView1[6, i].Value); //* Convert.ToDecimal(detalhes_de_VendaDataGridView[3, 1].Value);
                            dataGridView1[6, i].Value = quant * prexo;
                        }

                    }
                    calcura();
                }
                catch (Exception ex)
                {
                    return;

                }
            }
        }
        void autocomplet()
        {

            AutoCompleteStringCollection cl = new AutoCompleteStringCollection();
            
            var pro = si.Servicos.ToList();
            foreach (var item in pro)
            {

                cl.Add(item.NOmeServico.ToString());
            }
            textpro_nome.AutoCompleteCustomSource = cl;

        }
        private void Procurarpornome(string nomepro)
        {
           
            int ver;
            ver = si.Servicos.Where(r => r.NOmeServico.Contains(nomepro)).Count();
            if (ver == 1)
            {



                var pr = si.Servicos.Where(r => r.NOmeServico.Equals(nomepro)).FirstOrDefault();

                int row = 0;
                dataGridView1.Rows.Add();
                row = dataGridView1.Rows.Count - 2;
                dataGridView1["id", row].Value = pr.idservicos;
               // dataGridView1["refer", row].Value = textBox2.Text;
                dataGridView1["Nomeprodutos", row].Value = pr.NOmeServico;
                dataGridView1["PrexoVenda", row].Value = textpUnit.Text;

                if (!txtQuantidade.Text.Trim().Equals(""))
                {
                   // int saldo = int.Parse(pr.pro_stoque.ToString()) - int.Parse(txtQuantidade.Text);
                   // dataGridView1["saldose", row].Value = saldo;
                    dataGridView1["Quantidade", row].Value = txtQuantidade.Text;
                   // prexototal(txtQuantidade.Text, decimal.Parse(pr.pro_val_venda.ToString()));
                }
                else
                {
                   // int saldo = int.Parse(pr.pro_stoque.ToString()) - 1;
                   // dataGridView1["saldose", row].Value = saldo;
                    dataGridView1["Quantidade", row].Value = 1;
                  //  prexototal("1", decimal.Parse(pr.pro_val_venda.ToString()));
                }
                dataGridView1["Valors", row].Value = re;
                // produtos.Add(pr);
                calcura();
                dataGridView1.Refresh();
                // radTextBox1.Text = "";
                // radTextBox1.Focus();
            }


            else
            {

                DialogResult resp = MessageBox.Show("Produto nao registrado \n gostaria de o registrar", "Novo Produto", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resp == DialogResult.Yes)
                {
                   // var cat = si.Categorias_prod.Where(c => c.idEmpresass == idempresa && c.controlStock.Equals("Nao")).FirstOrDefault();
                    Servicos pr = new Servicos();

                    pr.NOmeServico = textpro_nome.Text;
                    pr.PrecoServic = textpUnit.Text;
                   // pr.pro_referencia = textBox2.Text;
                  //  pr.pro_categoid = cat.id_catego;
                    si.Servicos.Add(pr);
                    si.SaveChanges();
                    Procurarpornome(textpro_nome.Text);

                }


            }
        }
        // obter o subtolta da venda
        private void calcura()
        {
            try
            {
                valr = 0;
                for (int i = 0; i < dataGridView1.RowCount; i++)
                {
                    valr += Convert.ToDecimal(dataGridView1[6, i].Value);//* Convert.ToDecimal(detalhes_de_VendaDataGridView[3, 1].Value);

                }

                //double subtotal = double.Parse(valr.ToString());
                ////calcular o total
                //double total = 1.17 * double.Parse(valr.ToString());
                ////calcular o iva
                //double iva = 0.17 * double.Parse(valr.ToString());
                //if (checkBox1.Checked == true)
                //{
                //    textsub.Text = subtotal.ToString();
                //    texiva.Text = iva.ToString();
                //    textTotal.Text = Convert.ToString(total);
                //}
                //else
                //{
                //    textsub.Text = subtotal.ToString();
                //    texiva.Text = "0";
                //    textTotal.Text = Convert.ToString(subtotal);

                //}
            }
            catch (SystemException es)
            {
                MessageBox.Show(es.Message);
            }
        }

        private void textpro_nome_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {

                    Procurarpornome(textpro_nome.Text);
                    //radTextBox1.Text = "";
                    //radTextBox1.Focus();
                    txtQuantidade.Text = "1";
                    textpUnit.Text = "";
                }
                catch (System.Exception ex)
                {
                    System.Windows.Forms.MessageBox.Show(ex.Message);
                }
            }
        }
        //adicionar item na tabela pedidos_item
        public void adicionaritemfactura()
        {
            try
            {

                //buscar o pedido feito recentimente
                var idpdido = idobra;
                for (int i = 0; i < dataGridView1.RowCount; i++)
                {


                    int idvenda = idpdido;
                    int quant = Convert.ToInt16(dataGridView1[4, i].Value);
                    if (quant != 0)
                    {
                       // var refe = dataGridView1[1, i].Value.ToString();
                        String nome = Convert.ToString(dataGridView1[2, i].Value);

                        Decimal prexo = Convert.ToDecimal(dataGridView1[3, i].Value);
                        int idpro = Convert.ToInt16(dataGridView1[0, i].Value);//obter o numero do Produto (ID)
                        // DateTime data = Convert.ToDateTime(DateTime.Now.ToShortDateString());
                        Decimal total = Convert.ToDecimal(dataGridView1[6, i].Value); //* Convert.ToDecimal(detalhes_de_VendaDataGridView[3, 1].Value);
                        int stok = Convert.ToInt32(dataGridView1[4, i].Value);

                        ///iserir dados na tabela item pedidos
                        AdServObra deta = new AdServObra()
                        {
                            idobra = idobra,
                            qtyServ = quant,

                            Valortota = total,
                            idservic = idpro
                           


                        };
                        si.AdServObra.Add(deta);
                        si.SaveChanges();
                       
                       

                    }

                }

                //frm_facturas fr = new frm_facturas();
                //fr.IdsPedido = idpdido.id_Pedidos;
                //fr.Show();
                //imprimirreceita();

                // imprimir(Idventasgo );
                // imprimir(Idventasgo);

            }
            catch (SystemException es)
            {
                MessageBox.Show("Problema " + es.Message);
                // MetroMessageBox.Show()
            }


        }


        private void radButton1_Click(object sender, EventArgs e)
        {
            adicionaritemfactura();
           

            dataGridView1.Rows.Clear();
            //recalcular
            calcura();
            dataGridView1.Refresh();
        }
    }
}
