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
    public partial class requizicoess : Telerik.WinControls.UI.RadForm 
    {
        private teteenginhierEntities t = new teteenginhierEntities();
        public requizicoess()
        {
            InitializeComponent();
        }

        private void radButton1_Click(object sender, EventArgs e)
        {
            Requiform re = new Requiform();
            re.ShowDialog();
               viewrequizicaoBindingSource.DataSource = t.viewrequizicao.ToList();
        }

        private void requizicoess_Load(object sender, EventArgs e)
        {
            radDateTimePicker1.Value = DateTime.Now;
            viewreqfornBindingSource.DataSource = t.requizicao.ToList();
            radDropDownList1.SelectedIndex = 0;
        }
        private int idobra;
        private string estado;
        private void radGridView1_Click(object sender, EventArgs e)
        {
            try
            {
                idobra = 0;
                idobra = int.Parse(radGridView1.CurrentRow.Cells[0].Value.ToString());

                viewrequizicaoBindingSource.DataSource = t.viewrequizicao.Where(t => t.idrequiz == idobra).ToList();
                buscar();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        void buscar()
        {
            var vree = t.View_reqforn.Where(r => r.idrequisica == idobra).FirstOrDefault();
            estado = vree.estadore;
        }
        private DateTime d1, d2, d3;
        private void radDateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            d1 = DateTime.Parse(radDateTimePicker1.Text);
            lista();
        }

        private void fecharToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ////if (idobra >0)
            ////{
            ////    var r = t.View_reqforn.Where(g => g.idrequisica == idobra).FirstOrDefault();
            ////    r.datarecebimento = DateTime.Now;
            ////    r.estadore = "Recebido";
            ////    t.SaveChanges();
            ////    MessageBox.Show("Requizicao recebida com sucesso","sucesso",MessageBoxButtons.OK,MessageBoxIcon.Information);
            ////}
        }

        private void radDropDownList1_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            try
            {
                var g = radDropDownList1.SelectedItem.ToString();
                viewreqfornBindingSource.DataSource = t.requizicao.Where(t => t.estadore.Equals(g)).ToList();

            }
            catch (Exception)
            {

                return;
            }

        }

        private void cancelarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (idobra > 0 && !estado.Equals("Recebido"))
            {
                requizicao r = t.requizicao.Where(g => g.idrequisica == idobra).FirstOrDefault();
                r.datarecebimento = DateTime.Now;
                r.estadore = "Cancelado";
                t.SaveChanges();
                MessageBox.Show("Requizicao camcelado  com sucesso", "sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                viewreqfornBindingSource.DataSource = t.requizicao.ToList();
            }
            else
            {
                MessageBox.Show(" Esta requizicao nao pode ser cancelada", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Stop);


            }
        }

        private void imprimirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gesreport.ordecompras op = new gesreport.ordecompras();
            op.idreq = idobra;
            op.ShowDialog();
            viewreqfornBindingSource.DataSource = t.requizicao.ToList();
        }

        private void viewrequizicaoBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void darEntradaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (idobra > 0 && !estado.Equals("Recebido"))
            {
                receberpro op = new receberpro();
                op.idreq = idobra;
                op.ShowDialog();
                viewreqfornBindingSource.DataSource = t.requizicao.ToList();
                viewrequizicaoBindingSource.DataSource = t.viewrequizicao.Where(t => t.idrequiz == idobra).ToList();

            }
            else
            {

                MessageBox.Show(" Esta requizicao ja foi dada a entrada", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Stop);

            }
        }
        private int idviewreq=0;
        private void actualizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (idviewreq!=0 )
            {
                actpendentes op = new actpendentes();
                op.idre = idviewreq;
                op.ShowDialog();
                viewreqfornBindingSource.DataSource = t.requizicao.ToList();
                viewrequizicaoBindingSource.DataSource = t.viewrequizicao.Where(t => t.idrequiz == idobra).ToList();

                buscar();
            }
        }

        private void radGridView3_Click(object sender, EventArgs e)
        {
            try
            {
                idviewreq = 0;
                idviewreq = int.Parse(radGridView3.CurrentRow.Cells[0].Value.ToString());
                viewrequizicaoBindingSource.DataSource = t.viewrequizicao.Where(t => t.idrequiz == idobra).ToList();

            }
            catch (Exception)
            {

                return;
            }
        }

        private void consumidoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (idobra > 0 && !estado.Equals("Recebido"))
            {
                requizicao r = t.requizicao.Where(g => g.idrequisica == idobra).FirstOrDefault();
                r.datarecebimento = DateTime.Now;
                r.estadore = "Recebido";
                t.SaveChanges();
                MessageBox.Show("Requizicao Recebida  com sucesso", "sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                viewreqfornBindingSource.DataSource = t.requizicao.ToList();
            }
            else
            {
                MessageBox.Show(" Este material ja foi consumido", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Stop);


            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                // buscarnumeros de factura
                viewreqfornBindingSource.DataSource = t.requizicao.Where(t => t.nfactura.Contains(textBox1.Text)).ToList();

            }
            catch ( Exception ex)
            {

                throw;
            }
        }

        private void lista()
        {
            try
            {

           
            var g = radDropDownList1.SelectedItem.ToString();
            if (g.Equals(""))
            {
                    viewreqfornBindingSource.DataSource = t.requizicao.Where(t => t.datarequiz <= d1 && t.datarequiz <= d2).ToList();

            }
            else
            {

                    viewreqfornBindingSource.DataSource = t.requizicao.Where(t => t.datarequiz <= d1 && t.datarequiz >= d2 & t.estadore .Equals(g)).ToList();

            }
            }
            catch (Exception)
            {

                return;
            }
             // viewrequizicaoBindingSource.DataSource = te.View_compras.Where(t => t.dataentrada >= d1 && t.dataentrada <= d2).ToList();
            // this.reportViewer1.RefreshReport();
        }

        private void radDateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
          //  d2 = DateTime.Parse(radDateTimePicker2.Text);
          //  lista();
        }
    }
}
