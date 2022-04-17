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
    public partial class frmfornecidore : Telerik.WinControls.UI.RadForm
    {
        private teteenginhierEntities tete = new teteenginhierEntities();
        public frmfornecidore()
        {
            InitializeComponent();
        }

        private void radTextBox1_TextChanged(object sender, EventArgs e)
        {
            if (true)
            {

            }
        }
        private int idforn;
        private void radButton2_Click(object sender, EventArgs e)
        {
            try
            {
                if (idforn > 0)
                {
                    idforn = int.Parse(idfornTextBox.Text);
                    var forn = tete.fornecedor.Where(t => t.idforn == idforn).FirstOrDefault();
                    forn.Nome = nomeTextBox.Text;
                    forn.Nuit = nuitTextBox.Text;
                    forn.email = emailTextBox.Text;
                    forn.Enderesso = enderessoTextBox.Text;
                    forn.tipodefor = tipodeforComboBox.SelectedItem.ToString();
                     
                    tete.SaveChanges();
                }
                else
                {
                    fornecedor forn = new fornecedor();
                    forn.Nome = nomeTextBox.Text;
                    forn.Nuit = nuitTextBox.Text;
                    forn.email = emailTextBox.Text;
                    forn.Enderesso = enderessoTextBox.Text;
                    forn.tipodefor = tipodeforComboBox.SelectedItem.ToString();
                    tete.fornecedor.Add(forn);
                    tete.SaveChanges();
                }
                MessageBox.Show("Cliente actualizado com sucesso", "sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                fornecedorBindingSource.DataSource = tete.fornecedor.ToList();
            }
            catch (Exception EX)
            {

                MessageBox.Show(EX.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmfornecidore_Load(object sender, EventArgs e)
        {
            fornecedorBindingSource.DataSource = tete.fornecedor.ToList();
        }

        private void radButton1_Click(object sender, EventArgs e)
        {
            fornecedorBindingSource.AddNew();
        }
    }
}
