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
    public partial class Categoriasc : Form
    {
        private teteenginhierEntities t = new teteenginhierEntities();
        public Categoriasc()
        {
            InitializeComponent();
        }

        private void radButton1_Click(object sender, EventArgs e)
        {
            categoriaBindingSource.AddNew();
        }

        private void radButton2_Click(object sender, EventArgs e)
        {
            try
            {

                int id = int.Parse(idcateTextBox.Text);
                if (id <= 0)
                {
                    categoria c = new categoria();
                    c.proCategorias = proCategoriasTextBox.Text;
                    c.Descricao = descricaoTextBox.Text;
                    t.categoria.Add(c);
                    t.SaveChanges();
                }
                else
                {
                    categoria c =t.categoria .Where(f=>f.idcate==id ).FirstOrDefault();
                    c.proCategorias = proCategoriasTextBox.Text;
                    c.Descricao = descricaoTextBox.Text;
                   
                    t.SaveChanges();
                }
            MessageBox.Show("Salvo com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
 }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void Categoriasc_Load(object sender, EventArgs e)
        {
            categoriaBindingSource.DataSource = t.categoria.ToList();
        }
    }
}
