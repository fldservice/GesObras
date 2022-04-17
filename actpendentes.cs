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
    public partial class actpendentes : Form
    {
        private teteenginhierEntities te = new teteenginhierEntities();
        public actpendentes()
        {
            InitializeComponent();
        }
        public int idre { get; set; }
        private int idpro;
        private int qtyserto;
        private void actpendentes_Load(object sender, EventArgs e)
        {
            try
            {
 var verre = te.viewrequizicao.Where(P => P.iddRequi == idre).FirstOrDefault();
            //
            qtyserto = (int)verre.qtyreceb;
            radTextBox1.Text = qtyserto.ToString();

            label2.Text = verre.produtos_nome;
            idpro =(int) verre.idpprod;
            }
            catch (Exception)
            {

                MessageBox.Show("O produto ainda nao foi dado entrada");
            }
           
        }
        public void destruirstok(int idproduto, int qty)//actualizar o stoque
        {

            try
            {
                //verficar se o produto esta permitido a ser controlado ou nao

                var emp = te.produtos.Where(s => s.idprodutos == idproduto).FirstOrDefault();

                if (qty > 0)
                {


                    //se o produto estiver permitido sera retirado a aquantidade vendida
                    var py = te.Precos_pro.Where(p => p.idpro == idproduto).OrderByDescending(x=>x.idprecoPro).FirstOrDefault();
                    int qt = (int)py.qtypro;
                  py.qtypro = qt + qty;
             te.SaveChanges();
                }

                MessageBox.Show("Actualizado com sucesso" );
                this.Dispose();

            }
            catch (Exception ex)
            {

                MessageBox.Show("Nao foi possivel atualizar o estoke" + ex.Message);
            }


        }//retirar a Quantidade no stock

        private void radButton1_Click(object sender, EventArgs e)
        {
            try
            {

           
            var dt = te.detalhesderequiza.Where(t => t.iddRequi == idre && t.idpprod == idpro).FirstOrDefault();
            //}   
            int quant = int.Parse(radTextBox1.Text);
            int qtarequizi = (int)qtyserto;
            if (qtarequizi == quant)
            {
               
                dt.qtyreceb = dt.qty;//manter o valor da qty requerida
                    dt.estados = "Recebido";
            }
            else if
                (qtarequizi > quant)
            {
                dt.estados = "Pendente";
                dt.qtyreceb = dt.qtyreceb + quant;// obter o valo depositado
            }
            else
            {
                MessageBox.Show( " Quantidade não requizitado", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
                destruirstok(idpro ,quant );
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message ,"",MessageBoxButtons.OK,MessageBoxIcon.Error );
            }
            
        }
    }
}
