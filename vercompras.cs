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
    public partial class vercompras : Form
    {
        private teteenginhierEntities te = new teteenginhierEntities();
        public vercompras()
        {
            InitializeComponent();
        }

        private void vercompras_Load(object sender, EventArgs e)
        {
            entradasBindingSource.DataSource = te.entradas.ToList().GroupBy(r=>r.dataentrada ) ;
            View_comprasBindingSource.DataSource = te.View_compras.ToList();
            this.reportViewer1.RefreshReport();
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

        private void radGridView1_Click(object sender, EventArgs e)
        {
            d3 = DateTime.Parse(radGridView1 .CurrentRow .Cells [0].Value .ToString ());
            View_comprasBindingSource.DataSource = te.View_compras.Where(t => t.dataentrada == d3).ToList();
            this.reportViewer1.RefreshReport();
        }

        void lista()
        {
            View_comprasBindingSource.DataSource = te.View_compras.Where(t => t.dataentrada >= d1 && t.dataentrada <= d2).ToList();
           entradasBindingSource .DataSource = te.entradas.Where(t => t.dataentrada >= d1 && t.dataentrada <= d2).ToList().GroupBy(r=>r.dataentrada);
            this.reportViewer1.RefreshReport();
        }
    }
}
