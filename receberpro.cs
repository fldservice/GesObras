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
    public partial class receberpro : Form
    {
        private teteenginhierEntities tete = new teteenginhierEntities();
        public receberpro()
        {
            InitializeComponent();
        }
        public int idreq { get; set; }
        public void adicionaritemfactura()
        {
            try
            {

                //buscar o pedido feito recentimente
                // var idpdido = novopedido();
                for (int i = 0; i < viewrequizicaoDataGridView.RowCount; i++)
                {


                    // int idvenda = Convert.ToInt16(idobra);
                    int quant = Convert.ToInt16(viewrequizicaoDataGridView[0, i].Value);
                    if (quant != 0)
                    {
                        int qty = Convert.ToInt16(viewrequizicaoDataGridView[4, i].Value);

                        // var refe = dataGridView2[1, i].Value.ToString();
                        String nome = Convert.ToString(viewrequizicaoDataGridView[1, i].Value);

                        //  int ares = int.Parse(dataGridView2[3, i].Value.ToString());
                        int idpro = Convert.ToInt16(viewrequizicaoDataGridView[0, i].Value);//obter o numero do Produto (ID)
                                                                               
                        decimal total = Convert.ToDecimal(viewrequizicaoDataGridView[5, i].Value.ToString());

                        
                        if (construir(idpro, qty, total) ==true)
                        {

                        registrardetalhe(qty, idpro );
                        }

                    // destruirstok(idpro, qty, 0);
                       
                    }
                    
                }
                    actualizarre();


            }
            catch (SystemException es)
            {
                MessageBox.Show("Problema " + es.Message);
                // MetroMessageBox.Show()
            }

            
        }
        //registrar as ocorencias
        void registrardetalhe(int quant,int idpro)
        {
            ///iserir dados na tabela item pedidos
            detalhesderequiza dt = tete.detalhesderequiza.Where(t => t.idrequiz == idreq && t.idpprod == idpro).FirstOrDefault();
            //}

            int qtarequizi = (int)dt.qty;
            if (quant == 0)
            {
                dt.estados = "Pendente";
                dt.qtyreceb = 0;
            }
               else  if (qtarequizi == quant)
            {
                dt.estados = "Recebido";
                dt.qtyreceb = quant;
            }
            else if
                (qtarequizi > quant)
            {
                dt.estados = "Pendente";
                dt.qtyreceb = qtarequizi - quant;
            }
            else 
            {
               
                MessageBox.Show( " Quantidade nao requizitado", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }

            

            tete.SaveChanges();
        }
        //fixar avariavel constate da densidade
        private const int densidade = 7850;
        private const Int64 metros = 1000000000;
        public Boolean construir(int idproduto, int qtys, Decimal precos)
        {

            try
            {
                // verficar se tem algum preco registrado
                var contar = tete.Precos_pro.Where(t => t.idpro == idproduto).Count();
                if (contar != 0)
                {
                    //colocado o ultimo preco na tabel de produto
                    var produtoss = tete.produtos.FirstOrDefault(f => f.idprodutos == idproduto);
                    Boolean resposta = false;
                    //lista todos o precos e as quantidades do produto
                    var listar = tete.Precos_pro.Where(t => t.idpro == idproduto).ToList();
                    foreach (var item in listar)
                    {
                        // se o preco inserido fo iguar a alguns dos precos existente ele deve somente actualizar aquele produto
                        if (item.preco_pro == precos)
                        {
                            var verpre = tete.Precos_pro.Where(t => t.idprecoPro == item.idprecoPro).FirstOrDefault();
                            verpre.qtypro += qtys;

                            produtoss.prexo_venda = precos;
                            tete.SaveChanges();
                            resposta = true;
                            break;
                        }
                        //caso contrario de incluir uma nova linha de preco e qty
                        else
                        {
                            resposta = false;
                            continue;
                        }     

                       
                    }
                    if (resposta ==false )
                    {
                        var produt = tete.produtos.Where(v => v.idprodutos == idproduto).FirstOrDefault();

                        var verAre = produt.aRea.ToString();
                        decimal calarea=0, kilograms = 0;
                        if (verAre != "")
                        {
                             calarea = decimal.Parse(produt.aRea.ToString());
                            //buscar o peso em kilogramas de cada chapa
                            kilograms = decimal.Parse(produt.kilosingle.ToString());

                        }

                        Precos_pro pr = new Precos_pro();
                        pr.idpro = idproduto;
                        pr.preco_pro = precos;
                        pr.areatotal = calarea * qtys;
                        pr.Kilogramas = kilograms * qtys;
                        pr.qtypro = qtys;
                        pr.Observacao = nomeTextBox.Text;
                        tete.Precos_pro.Add(pr);
                        produtoss.prexo_venda = precos;
                        tete.SaveChanges();
                        
                    }

                }
                else
                {
                    //MessageBox.Show("Este produto nao tem preços definido\n insira pelo menos um preço", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    var produt = tete.produtos.Where(v => v.idprodutos == idproduto).FirstOrDefault();

                    decimal calarea = (decimal)produt.aRea;
                    //buscar o peso em kilogramas de cada chapa
                    Decimal kilograms = (decimal)produt.kilosingle;
                    //se o produto nao tiver nenhum preco o sitema vai cria 
                    Precos_pro pr = new Precos_pro();
                    pr.idpro = idproduto;
                    pr.preco_pro = precos;
                    pr.areatotal = calarea * qtys;
                    pr.Kilogramas = kilograms * qtys;
                    pr.qtypro = qtys;
                    pr.Observacao = nomeTextBox.Text;
                    tete.Precos_pro.Add(pr);
                  //  produtoss.prexo_venda = precos;
                    tete.SaveChanges();

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Problema na iclusao do produto\n" + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return false ;
            }

            return true;
        }
        void prenchergrelha(int obra)
        {
            int row = 0;
          var k = tete.viewrequizicao.Where(t => t.idrequiz == obra).ToList();
            foreach (var pr in k)
            {
               
                viewrequizicaoDataGridView.Rows.Add();
               // row = viewrequizicaoDataGridView.Rows.Count - 2;
                viewrequizicaoDataGridView["idpprod", row].Value = pr.idpprod;
                viewrequizicaoDataGridView["proCategorias", row].Value = pr.proCategorias;
                viewrequizicaoDataGridView["produtos_nome", row].Value = pr.produtos_nome;
                viewrequizicaoDataGridView["tamanhos_pro", row].Value = pr.tamanhos_pro;
                viewrequizicaoDataGridView["qty", row].Value = pr.qty;
                viewrequizicaoDataGridView["valor", row].Value = pr.valor;
                row++;
            }
                      }
        //actualizar a requizicao
        void actualizarre()
                {
            requizicao re = tete.requizicao.Where(w => w.idrequisica == idreq).FirstOrDefault();
            re.datarecebimento = DateTime.Now;
            re.nfactura = nfacturaTextBox.Text;
            re.estadore = "Recebido";
            tete.SaveChanges();

            }
       
        private void radButton1_Click(object sender, EventArgs e)
        {
            adicionaritemfactura();
            MessageBox.Show("Compras realizadas com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Dispose();
        }
        
        private void receberpro_Load(object sender, EventArgs e)
        {
           var ver = tete.View_reqforn.Where(t => t.idrequisica == idreq).FirstOrDefault();
            nomeTextBox.Text = ver.Nome;
            nuitTextBox.Text = nuitTextBox.Text;
            prenchergrelha(idreq);
           // viewrequizicaoDataGridView.DataSource=tete.viewrequizicao.Where(t => t.idrequiz == idreq).ToList();
        }
    }
}
