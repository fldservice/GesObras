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
                    int quant = Convert.ToInt16(viewrequizicaoDataGridView[4, i].Value);
                    if (quant != 0)
                    {
                        int qty = Convert.ToInt16(viewrequizicaoDataGridView[4, i].Value);

                        // var refe = dataGridView2[1, i].Value.ToString();
                        String nome = Convert.ToString(viewrequizicaoDataGridView[1, i].Value);

                        //  int ares = int.Parse(dataGridView2[3, i].Value.ToString());
                        int idpro = Convert.ToInt16(viewrequizicaoDataGridView[0, i].Value);//obter o numero do Produto (ID)
                                                                               
                        int total = Convert.ToInt32(viewrequizicaoDataGridView[5, i].Value);

                        ///iserir dados na tabela item pedidos
                        detalhesderequiza dt = tete.detalhesderequiza.Where(t => t.idrequiz == idreq && t.idpprod == idpro).FirstOrDefault();
                        //}

                        int qtarequizi =(int) dt.qty;
                        if (qtarequizi == quant)
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
                            MessageBox.Show(dt.produtos.produtos_nome+" Quantidade nao requizidate","Erro",MessageBoxButtons.OK,MessageBoxIcon.Stop);
                            return;
                        }
                     
                        //dt.qtyreceb=

                    //    valor = total,
                    //    idpprod = idpro,
                    //    //referencias_ped = refe,
                    //    //  areass = ares,
                    //   // dataentrada = DateTime.Now


                     

                     tete.SaveChanges();

                    destruirstok(idpro, qty, 0);
                       
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
        void actualizarre()
                {
            requizicao re = tete.requizicao.Where(w => w.idrequisica == idreq).FirstOrDefault();
            re.datarecebimento = DateTime.Now;
            re.nfactura = nfacturaTextBox.Text;
            re.estadore = "Recebido";
            tete.SaveChanges();

            }
        public void destruirstok(int idproduto, int qty, double area)
        {

            try
            {
                //verficar se o produto esta permitido a ser controlado ou nao

                var emp = tete.produtos.Where(s => s.idprodutos == idproduto).FirstOrDefault();

                if (qty > 0)
                {


                    //se o produto estiver permitido sera retirado a aquantidade vendida
                    var py = tete.produtos.Where(p => p.idprodutos == idproduto).FirstOrDefault();
                    int qt =(int)py.Quatidade;
                    py.Quatidade =qt+ qty;
                    tete.SaveChanges();
                }
                //else if (qty <= 0 && area > 0)
                //{

                //    // se o capo de areas for prienchido realizada estas funcoes

                //    double areas = (Double)emp.Areatotal;//buscar areatotal actual
                //                                         //  decimal area = decimal.Parse(TextBox3.Text); ;// verficar a area requeriad
                //    if (areas > area)
                //    {
                //        // decimal val = decimal.Parse("0." + TextBox3.Text);

                //        decimal presai = decimal.Parse(emp.precos.ToString());
                //        //decimal prexoto = val * presai;//obter o valor total
                //        try
                //        {


                //            //  var pro = tete.produtos.Where(id => id.idprodutos == cl).FirstOrDefault();
                //            /*
                //             * iniciar aginastica
                //            */
                //            //area totao menos area introduzida=area restante
                //            int ater = int.Parse(emp.Areatotal.ToString()) - int.Parse(area.ToString());

          
            }
            catch(Exception ex)
            {

                MessageBox.Show("Nao foi possivel atualizar o estoke" + ex.Message);
            }


        }//retirar a Quantidade no stock

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
