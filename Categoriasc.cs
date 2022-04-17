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
    public partial class Categoriasc : Telerik.WinControls.UI.RadForm
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
                    if (checkBox1.Checked == true)
                    {
                        c.activoTangivel = "Sim";
                    }
                    else
                    {
                        c.activoTangivel = "Nao";
                    }
                    t.categoria.Add(c);
                    t.SaveChanges();
                }
                else
                {
                    categoria c =t.categoria .Where(f=>f.idcate==id ).FirstOrDefault();
                    c.proCategorias = proCategoriasTextBox.Text;
                    c.Descricao = descricaoTextBox.Text;
                    if (checkBox1.Checked == true)
                    {
                        c.activoTangivel = "true";
                    }
                    else
                    {
                        c.activoTangivel = "false";
                    }

                    t.SaveChanges();
                    radLabel2.Text =c.proCategorias+ " Salvo com sucesso";
                }
          //  MessageBox.Show("", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
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

        private void categoriaDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
          //  checkBox1.Checked =bool.Parse ( categoriaDataGridView.CurrentRow.Cells[2].Value.ToString());
        }
    }
}
