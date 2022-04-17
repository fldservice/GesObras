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
using Tulpep.NotificationWindow;

namespace GesObras
{
    public partial class addprodutos : Telerik.WinControls.UI.RadForm
    {
        private teteenginhierEntities tete = new teteenginhierEntities();
        public addprodutos()
        {
            InitializeComponent();
          //  autocompliteprodut();
        }
        public int idobra { get; set; }
        public string nomecli { get; set; }
        private void addprodutos_Load(object sender, EventArgs e)
        {
            var verob = tete.veiwobras.Where(t => t.idobras == idobra).FirstOrDefault();
            radLabel1.Text = verob.nomecli;
            // dataGridView1.DataSource = tete.lisproduto.ToList();
            var conta = tete.lisproduto.Where(c => c.activoTangivel.Equals("false") & c.qtyp<=50).Count();
            var popupNotifier = new PopupNotifier();
            popupNotifier.TitleText = "Quantidades na ferramentaria";
            popupNotifier.ContentText = "Exitem cerca de " + conta + " produtos com estoque \n menor ou iguala 50";
            // popupNotifier.IsRightToLeft = false;
            popupNotifier.Popup();
            
        }

        private void radTextBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (!radTextBox1.Text .Equals (""))
                {
                    var verob = tete.lisproduto.Where(t => t.produtos_nome.Contains(radTextBox1.Text)).ToList();
                    dataGridView1.DataSource = verob;
                }
                else
                {
                    return;

                }
                
            }
            catch (Exception)
            {

                MessageBox.Show("Produto nao encontradao");
            }
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
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            //row = 0;
            //dataGridView1.Rows.Add();
            //row = dataGridView1.Rows.Count - 2;
            //dataGridView1["id", row].Value = pr.id_produto;
            //dataGridView1["refer", row].Value = pr.referencias_ped;
            //dataGridView1["Nomeprodutos", row].Value = pr.pro_nome;
            //dataGridView1["PrexoVenda", row].Value = pr.item_pUnite;
        }
        private void Procurarpornome(string nomepro)
        {
            tete = new teteenginhierEntities();
            int ver;
            ver = tete.lisproduto.Where(r => r.produtos_nome.Equals(nomepro)).Count();
            if (ver == 1)
            {

                var cli = tete.lisproduto.Where(r => r.produtos_nome.Equals(nomepro)).FirstOrDefault();

                if (cli.qtyp <= 0)
                {
                    MessageBox.Show("Sem quantidades no stoque");

                }
                else
                {

                    var pr = tete.lisproduto.Where(r => r.produtos_nome.Equals(nomepro)).FirstOrDefault();

                    int row = 0;
                    dataGridView2.Rows.Add();
                    row = dataGridView2.Rows.Count - 2;
                    dataGridView2["id", row].Value = pr.idprodutos;
                    dataGridView2["Categoria", row].Value = pr.proCategorias;
                    dataGridView2["Produto", row].Value = pr.produtos_nome; 
                    dataGridView2["punit", row].Value = pr.prexo_venda;
                    dataGridView2.Refresh();
                    // radTextBox1.Text = "";
                    // radTextBox1.Focus();
                }
            }


            else
            {

                DialogResult resp = MessageBox.Show("Produto nao registrado ", "Novo Produto", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
               
            }
        }


        //buscar por codigo
        private void Procurarporcodigo(int idpro)
        {
            tete = new teteenginhierEntities();
            int ver;
            ver = tete.lisproduto.Where(r => r.idprodutos.Equals(idpro)).Count();
            if (ver == 1)
            {

                var cli = tete.lisproduto.Where(r => r.idprodutos.Equals(idpro)).FirstOrDefault();

                if (cli.qtyp <= 0)
                {
                    MetroFramework.MetroMessageBox.Show(this, "Sem quantidades no stoque");

                }
                else
                {

                    var pr = tete.lisproduto.Where(r => r.idprodutos.Equals(idpro)).FirstOrDefault();

                    int row = 0;
                    dataGridView2.Rows.Add();
                    row = dataGridView2.Rows.Count - 2;
                    dataGridView2["id", row].Value = pr.idprodutos;
                    dataGridView2["Categoria", row].Value = pr.proCategorias;
                    dataGridView2["Produto", row].Value = pr.produtos_nome;
                    dataGridView2["punit", row].Value = pr.prexo_venda;
                    dataGridView2.Refresh();
                    // radTextBox1.Text = "";
                    // radTextBox1.Focus();
                }
            }


            else
            {

                DialogResult resp = MessageBox.Show("Produto nao registrado ", "Novo Produto", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

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
                  
                }
                catch (System.Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        //    private int quantidaderesta = 0;
        //adicionar item na tabela pedidos_item
        //fixar avariavel constate da densidade
        private const int densidade = 7850;
        private const Int64 metros = 1000000000;

        private decimal kilograms = 0;
        public void adicionaritemfactura()
        {
            try
            {

                //buscar o pedido feito recentimente
               // var idpdido = novopedido();
                for (int i = 0; i < dataGridView2.RowCount; i++)
                {


                   // int idvenda = idobra;
                    int quant = Convert.ToInt16(dataGridView2[2, i].Value);
                    Decimal compr = Convert.ToDecimal(dataGridView2[3, i].Value);//ares
                    Decimal larg = Convert.ToDecimal(dataGridView2[4, i].Value);//ares

                    if (quant >0 || compr>0 && larg>0)
                    {
                       
                        int idpro = Convert.ToInt16(dataGridView2[6, i].Value);//obter o numero do Produto (ID)
                        decimal calarea = 0;                                                // DateTime data = Convert.ToDateTime(DateTime.Now.ToShortDateString());
             
                        decimal qty = decimal.Parse(quant.ToString());
                var py = tete.produtos.Where(p => p.idprodutos == idpro).FirstOrDefault();
                        //lifo(py.idprodutos,quant);
                       
                        if (compr > 0 && larg > 0)
                        {
                            calarea = compr * larg;
                            //buscar o peso em kilogramas de cada chapa recortada
                            kilograms = (calarea * int.Parse(py.tamanhos_pro.Replace("mm", "")) * densidade) / metros;

                            decimal totalqty = calarea / (decimal)py.aRea;
                            qty += totalqty;
                        }
                       
                        lifo(py.idprodutos, qty, calarea , kilograms);
                       
                        

                    }

                }



            }
            catch (SystemException es)
            {
                MessageBox.Show("Problema " + es.Message);
                // MetroMessageBox.Show()
            }


        }
        void detalhesdesaida(decimal qty,int idpro, decimal prexo,decimal area,decimal kil,string obs)
        {
            try
            {


                detalhesdobra deta = new detalhesdobra()
                {
                    idobra = idobra,
                    quantidaes = qty,

                    prexodevenda = prexo,
                    idprodutos = idpro,
                    totaldeta = qty * prexo,
                    areausada = area,
                    kilosusados = kil,
                    Obsforn = obs,
                //referencias_ped = refe,

                datadetalhes = DateTime.Now


            };
            tete.detalhesdobra.Add(deta);
            tete.SaveChanges();
            }
            catch (Exception ex)
            {

                MetroFramework.MetroMessageBox.Show(this,"Erro nos detalhes " +ex.Message,"Info",MessageBoxButtons.OK,MessageBoxIcon.Error );
            }
        }
        private void radButton1_Click(object sender, EventArgs e)
        {
            adicionaritemfactura();
          MetroFramework.MetroMessageBox.Show(this,"Produtos adicionados com sucesso","Sucesso",MessageBoxButtons.OK,MessageBoxIcon.Information);
            this.Dispose();

        }

        bool lifo( int idpros , decimal qtyp,decimal ares,decimal klg)
        {
            decimal calarea = 0;
            //verficar se tem quantidades e precos registados na tabela de precos
            var contar = tete.Precos_pro.Where(i => i.idpro == idpros).Count();
            if (contar != 0)
            {
                decimal qtpro = 0; decimal resto = 0;
            int roda = 0;
                decimal area = 0;
                // tiver produto percores a lista verficando as qantidades

                var listar = tete.Precos_pro.Where(i => i.idpro == idpros).ToList();
                foreach (var item in listar)
                {
                    roda++;
                   
                    qtpro = item.qtypro;
                    var py = tete.produtos.Where(p => p.idprodutos == idpros).FirstOrDefault();
                     if (py.aRea > 0)
                    {

                     calarea = qtyp * (decimal)py.aRea;
                        kilograms = (calarea * int.Parse(py.tamanhos_pro.Replace("mm", "")) * densidade) / metros;

                    }
                 //   area =(decimal) item.areatotal;
                    // se encotra produto > que zero, deve compara com o a quantidade requirida
                    if (qtpro > 0)
                    {
                        resto =  qtyp- qtpro ;
                        //se a quntidade requerida for maior que a do sitema/
                        //fa'ca somete o desconto do existente no sitema
                        if (qtyp >= qtpro)
                        {
                            //se aquantidade requerida for maior ou igual a qunatidade exixtente
                            saidadeproduto(item.idprecoPro, qtpro,ares,klg);
                            // envia a quantidade, o produto, e o preco do produto
                            detalhesdesaida(qtpro, item.idpro,(decimal)item.preco_pro , calarea, kilograms,item.Observacao);
                            //swap
                            qtyp = Math.Abs(resto);
                            
                        }
                        else
                        {
                            //se aquantidade requerida for menor  a quantidade exixtente
                            saidadeproduto(item.idprecoPro, qtyp,ares,klg);
                            detalhesdesaida(qtyp, item.idpro, (decimal)item.preco_pro, ares, kilograms, item.Observacao);
                            break;
                        }


                    }
                    else if(contar ==roda)
                    {
                        MetroFramework.MetroMessageBox.Show(this,  "Sem quantidaedes no stoque","Info",MessageBoxButtons.OK,MessageBoxIcon.Stop);
                        //quantidaderesta = resto;

                        return false;
                    }
                    else
                    {


                        continue;

                    }
                }

            }
            else
            {
             
                return false;
            }
            
            return true;

        }
        void saidadeproduto( int idprexo, decimal qty,decimal ares,decimal klg)
        {
            try

            {//verficar a rea 
            var listar = tete.Precos_pro.Where(i => i.idprecoPro == idprexo).FirstOrDefault();
            listar.qtypro -= qty;

               
                    //verficara a re exixtente
                    var listarPro = tete.produtos.Where(i => i.idprodutos == listar.idpro).FirstOrDefault();
                if (ares>0 )
                    {
                    decimal areas = (decimal)listarPro.aRea * qty;
                    listar.areatotal -= areas;
                    listar.Kilogramas -= klg;
                }



            tete.SaveChanges();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
           


        }

        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
 int idp = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            Procurarporcodigo(idp);
                radTextBox1.Text = "";
            }
            catch (Exception ex)
            {

                return;
            }
           
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                  autocompliteprodut();
            }
            else
            {
                radTextBox1.AutoCompleteCustomSource = null;
            }
        }
    }
}
