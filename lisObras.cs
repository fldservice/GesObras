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
    public partial class lisObras : Telerik.WinControls.UI.RadForm 
    {
        private teteenginhierEntities tete = new teteenginhierEntities();
        public lisObras()
        {
            InitializeComponent();
        }

        private void lisObras_Load(object sender, EventArgs e)
        {
            veiwobrasBindingSource.DataSource = tete.veiwobras.Where(k=>k.estado.Equals("Agendado")).ToList();
        ///    viewprodDetalhesBindingSource.DataSource = tete.viewprodDetalhes.ToList();
        }
        private int idobra = 0;
        private string nome = "";
        private void produtosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (idobra != 0 && !estado.Equals("finalizada"))
            {
                addprodutos ad = new addprodutos();
                ad.idobra = idobra;
                ad.nomecli = nome;
                ad.ShowDialog();
            }
            else { MessageBox.Show("Escolha a obra \n ou Não e possivel efectuar esta operação.\n a Obra está finalizada","Erro",MessageBoxButtons.OK,MessageBoxIcon.Warning); }
        }
        private string estado;
        private void radGridView1_Click(object sender, EventArgs e)
        {
            try
            {
                idobra = 0;
 idobra = int.Parse(radGridView1 .CurrentRow .Cells[0].Value .ToString());
            nome  = radGridView1.CurrentRow.Cells[2].Value.ToString();
estado= radGridView1.CurrentRow.Cells[5].Value.ToString();
                viewprodDetalhesBindingSource.DataSource = tete.viewprodDetalhes.Where(t=>t.idobra==idobra).ToList();
               // var getidobr = tete.AdServObra.Where(t => t.idobra == idobra).FirstOrDefault();
                servicosBindingSource.DataSource = tete.View_Servicos.Where(r => r.idobra == idobra).ToList();
            }
            catch (Exception)
            {

                return;
            }
           

        }

        private void terminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (!estado.Equals("finalizada"))
                {

                    DialogResult de = MessageBox.Show("Quer realmente finalizar esta obra? \n ao pressionar 'Yes' não podera fazer alterações a obra.\n Deseja continuar  ", "Informação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (de == DialogResult.Yes)
                {


                    var PLAY = tete.tblhoras.Where(h => h.idobras == idobra & h.estado.Equals("Agendado")).FirstOrDefault();
                    PLAY.horafinal = DateTime.Now;
                    PLAY.estado = "finalizada";
                    tete.SaveChanges();
                    MessageBox.Show("Obra terminada com sucesso", "Feicho", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                }
                else { MessageBox.Show("Não e possivel efectuar esta operação.\n a Obra está finalizada", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Stop); }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        
           
        }

        private void radButton1_Click(object sender, EventArgs e)
        {
            Cadobras cad = new Cadobras();
            cad.ShowDialog();
            radGridView1.DataSource = tete.veiwobras.Where(k => k.estado.Equals("Agendado")).ToList();

        }

        private void descricaoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (idobra != 0 && !estado.Equals("finalizada"))
            {
                Descregi ad = new Descregi();
                ad.idobra = idobra;
                ad.nome = nome;
                ad.ShowDialog();
                veiwobrasBindingSource.DataSource = tete.veiwobras.Where(k => k.estado.Equals("Agendado")).ToList();

            }
            else
            {

                MessageBox.Show("Não e possivel efectuar esta operação.\n a Obra está finalizada", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void radCheckBox1_ToggleStateChanged(object sender, Telerik.WinControls.UI.StateChangedEventArgs args)
        {
            if (radCheckBox1.Checked == true)
            {
                veiwobrasBindingSource.DataSource = tete.veiwobras.Where(k => !k.estado.Equals("Agendado")).ToList();

            }
            else
            {
                veiwobrasBindingSource.DataSource = tete.veiwobras.Where(k => k.estado.Equals("Agendado")).ToList();

            }

        }

        private void imprimirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (idobra != 0)
            {
             gesreport.verobras    ad = new gesreport.verobras();
                ad.idobra = idobra;
              //  ad.idcassamba = ;
                ad.ShowDialog();
            }
        }

        private void equipeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (idobra != 0)
            {
                frmAddservicObras gf = new frmAddservicObras();
                gf.idobra = idobra;
                gf.ShowDialog();
            }
        }

        private void cancelarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {

                if (idobra != 0 && !estado.Equals("finalizada"))
                {
                    DialogResult de = MessageBox.Show("Quer realmente eliminar esta obra? \n ao pressionar 'Yes' nao podera estornar os produto usado.\n Deseja continuar  ", "Informação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (de == DialogResult.Yes)
                    {

                        var PLAY = tete.tblhoras.Where(h => h.idobras == idobra & h.estado.Equals("Agendado")).FirstOrDefault();
                        PLAY.horafinal = DateTime.Now;
                        PLAY.estado = "Cancelada";
                        tete.SaveChanges();
                        MessageBox.Show("Obra terminada com sucesso", "Feicho", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {

                    MessageBox.Show("Não e possivel efectuar esta operação.\n a Obra está finalizada", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                veiwobrasBindingSource.DataSource = tete.veiwobras.Where(k => k.nomecli.Contains(textBox1.Text)).ToList();

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void acertoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
             //   var detalhe = tete.detalhesdobra.Where(v => v.iddetalhessa == idpros).FirstOrDefault();
               // frm_updaeDetalhes pd = new frm_updaeDetalhes();
               // pd.iddetalhesobra = idpros;
               // pd.ShowDialog();
               // viewprodDetalhesBindingSource.DataSource = tete.viewprodDetalhes.Where(t => t.idobra == idobra).ToList();

            }
            catch (Exception)
            {

                throw;
            }
        }
        int idpros;
        private void radGridView2_CellClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            try
            {
                idpros = int.Parse(radGridView2.CurrentRow.Cells[0].Value.ToString());
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
