using dbges;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GesObras
{
    public partial class frm_updaeDetalhes : Form
    {
        private teteenginhierEntities te = new teteenginhierEntities();
        public frm_updaeDetalhes()
        {
            InitializeComponent();
        }
        public int iddetalhesobra { get; set; }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                var detaobra = te.detalhesdobra.Where(x => x.iddetalhessa == iddetalhesobra).FirstOrDefault();
                decimal qty = detaobra.quantidaes;//guardar a quantidade
                detaobra.quantidaes = int.Parse(textBox1.Text);//actualizar a nova quantidade
                decimal newqty=qty - int.Parse(textBox1.Text);
                var preco = te.Precos_pro.Where(d => d.idpro == detaobra.idprodutos).OrderByDescending(b => b.idprecoPro).FirstOrDefault();
                preco.qtypro += newqty;// incluir nova quantidade
                te.SaveChanges();
                MessageBox.Show(this, "Atualizado com sucesso");
                this.Dispose();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void frm_updaeDetalhes_Load(object sender, EventArgs e)
        {
            try
            {
                var detaobra = te.detalhesdobra.Where(x => x.iddetalhessa == iddetalhesobra).FirstOrDefault();
                lab_qty.Text = detaobra.quantidaes.ToString();
            }
            catch (Exception ex)
            {

                throw;
            }
        }
    }
}
