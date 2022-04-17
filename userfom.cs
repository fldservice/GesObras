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
using System.Security.Cryptography;

namespace GesObras
{
    public partial class userfom : Telerik.WinControls.UI.RadForm
    {
        private teteenginhierEntities te = new teteenginhierEntities();
        public userfom()
        {
            InitializeComponent();
        }
        private int idus;
        private void radButton1_Click(object sender, EventArgs e)
        {
            utilizadoresBindingSource.AddNew();
            nomeTextBox.Text = "";
            nomeuserTextBox.Text = "";
            passwordTextBox.Text = "";
            iduuutilizadoresTextBox.Text = "0";
            
        }
        string has = "Fr@ncoLu(KY%@m!a01254[]<>*&NSsbzxX";
        String passecri(string passs)
        {
            String decrip = "";
            Byte[] dados = UTF8Encoding.UTF8.GetBytes(passs);
            using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
            {
                Byte[] chave = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(has));
                using (TripleDESCryptoServiceProvider dat = new TripleDESCryptoServiceProvider() { Key = chave, Mode = CipherMode.ECB, Padding = PaddingMode.PKCS7 })
                {
                    ICryptoTransform tras = dat.CreateEncryptor();
                    byte[] resulta = tras.TransformFinalBlock(dados, 0, dados.Length);
                    decrip = Convert.ToBase64String(resulta, 0, resulta.Length);
                }

            }
            return decrip;
        }

        private void userfom_Load(object sender, EventArgs e)
        {
            utilizadoresBindingSource.DataSource = te.utilizadores.ToList();
        }
        void Actualizaruser(int idus)
        {

            utilizadores ut = te.utilizadores.Where(i => i.iduuutilizadores == idus).FirstOrDefault();
            ut.Nome = nomeTextBox.Text;
            ut.Nomeuser = nomeuserTextBox.Text;
            ut.Password =passecri( passwordTextBox.Text);
            ut.permissao = permissaoComboBox.SelectedItem.ToString(); 
           // te.utilizadores.Add(ut);
            te.SaveChanges();

         


        }
        private void radButton2_Click(object sender, EventArgs e)
        {
            try
            {
                int iduser = int.Parse(iduuutilizadoresTextBox.Text);
                if (iduser > 0)
                {
                    Actualizaruser(iduser);
                   
                }
                else
                {
                    utilizadores ut = new utilizadores();
                    ut.Nome = nomeTextBox.Text;
                    ut.Nomeuser = nomeuserTextBox.Text;
                    ut.Password =passecri( passwordTextBox.Text);
                    ut.permissao = permissaoComboBox.SelectedItem.ToString();
                    te.utilizadores.Add(ut);
                    te.SaveChanges();
                    MessageBox.Show("Utilizador cadastrado com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    idus = 0;
                }
                }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message , "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
