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
    public partial class Descregi : Form
    {
        private teteenginhierEntities t = new teteenginhierEntities();
        public Descregi()
        {
            InitializeComponent();
        }
        public int idobra { get; set; }
        private Obrass oba = null;
      public string nome { get; set; }
        private void Descregi_Load(object sender, EventArgs e)
        {
            oba = t.Obrass.Where(d => d.idobras == idobra).FirstOrDefault();
            radTextBox1.Text = oba.descricao;
            radLabel2.Text = nome;
            
        }

        private void radButton1_Click(object sender, EventArgs e)
        {
         var   obra = t.Obrass.Where(d => d.idobras == idobra).FirstOrDefault();
            obra.descricao = radTextBox1.Text;
            t.SaveChanges();
            MessageBox.Show("Descricao actualizada com sucesso","sucesso",MessageBoxButtons.OK,MessageBoxIcon.Information);
            this.Dispose();

        }
    }
}
