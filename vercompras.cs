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
using gesreport;

namespace GesObras
{
    public partial class vercompras : Telerik.WinControls.UI.RadForm
    {
        private teteenginhierEntities te = new teteenginhierEntities();
        public vercompras()
        {
            InitializeComponent();
        }

        private void vercompras_Load(object sender, EventArgs e)
        {
            radDateTimePicker1.Value = DateTime.Now;
            radDateTimePicker2.Value = DateTime.Now;
            
            empresaBindingSource.DataSource = te.empresa.ToList();
            requizicaoBindingSource.DataSource = te.requizicao.ToList().GroupBy(r=>r.datarecebimento ) ;
            viewrequizicaoBindingSource.DataSource = te.viewrequizicao.Where(f=>f.estados.Equals("Recebido")).ToList();
            this.reportViewer1.RefreshReport();
            this.reportViewer2.RefreshReport();
            this.reportViewer3.RefreshReport();
        }
        private DateTime d1, d2,d3;

        private void radDateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            d2 = DateTime.Parse(radDateTimePicker2.Value.ToShortDateString());
            lista();
        }

        private void radDateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            d1 = DateTime.Parse(radDateTimePicker1.Value.ToShortDateString());
            lista();
        }

        private void radButton1_Click(object sender, EventArgs e)
        {
            frm_reqBymes by = new frm_reqBymes();
            by.Show();
        }

        private void radGridView1_Click(object sender, EventArgs e)
        {//Where(f=>f.estados.Equals("Recebido"))
            d3 = DateTime.Parse(radGridView1 .CurrentRow .Cells [0].Value .ToString ());
            viewrequizicaoBindingSource.DataSource = te.viewrequizicao.Where(t =>t.estados.Equals("Recebido")& t.datarequiz == d3).ToList();
            this.reportViewer1.RefreshReport();
            this.reportViewer2.RefreshReport();
        }

        void lista()
        {
            viewrequizicaoBindingSource.DataSource = te.viewrequizicao.Where(t =>t.estados.Equals("Recebido")& t.datarequiz >= d1 && t.datarequiz <= d2).ToList();
            requizicaoBindingSource.DataSource = te.requizicao.Where(t => t.datarecebimento >= d1 && t.datarecebimento <= d2).ToList().GroupBy(r=>r.datarequiz);
            this.reportViewer1.RefreshReport();
            this.reportViewer2.RefreshReport();
        }
    }
}
