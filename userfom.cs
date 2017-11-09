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
    public partial class userfom : Form
    {
        private teteenginhierEntities te = new teteenginhierEntities();
        public userfom()
        {
            InitializeComponent();
        }

        private void radButton1_Click(object sender, EventArgs e)
        {
            utilizadoresBindingSource.AddNew();
        }

        private void userfom_Load(object sender, EventArgs e)
        {
            utilizadoresBindingSource.DataSource = te.utilizadores.ToList();
        }

        private void radButton2_Click(object sender, EventArgs e)
        {
            try
            {
                utilizadores ut = new utilizadores();
                ut.Nome = nomeTextBox.Text;
                ut.Nomeuser = nomeuserTextBox.Text;
                ut.Password = passwordTextBox.Text;
                ut.permissao = passwordTextBox.Text;
                te.utilizadores.Add(ut);
                te.SaveChanges();
                MessageBox.Show("Utilizador cadastrado com sucesso","Sucesso",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message , "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
