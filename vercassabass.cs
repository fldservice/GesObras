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
    public partial class vercassabass : Form
    {
        private teteenginhierEntities tete = new teteenginhierEntities();
        public vercassabass()
        {
            InitializeComponent();
        }

        private void radTextBox1_TextChanged(object sender, EventArgs e)
        {
            if (!radTextBox1.Text.Equals(""))
            {
                clientesBindingSource.DataSource = tete.Clientes.Where(y => y.nomecli.Contains(radTextBox1.Text)).ToList();

            }
            else
            {
                clientesBindingSource.DataSource = tete.Clientes.ToList();

            }
        }
        private int idobra = 0;
        private void vercassabass_Load(object sender, EventArgs e)
        {
            clientesBindingSource.DataSource = tete.Clientes.ToList();

        }

        private void radGridView1_Click(object sender, EventArgs e)
        {
            idobra = int.Parse(radGridView1.CurrentRow.Cells[0].Value.ToString());

        }

        private void imprimirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (idobra != 0)
            {
              
                gesreport.verobras  ad = new gesreport.verobras();
                ad.idcassamba = idobra;
               
                ad.Show();
            }
        }
    }
}
