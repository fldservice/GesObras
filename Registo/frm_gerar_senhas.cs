using FoxLearn.License;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FoxLearn;
using dbges;
using System.Security.Cryptography;

namespace Gescom.Registo
{
    public partial class frm_gerar_senhas : MetroFramework .Forms .MetroForm 
    {
        const int codigo_do_produto = 1;
        public frm_gerar_senhas()
        {
            InitializeComponent();
        }
        String passedecrip(string passs)
        {
            String decrip = "";
            Byte[] dados = Convert.FromBase64String(passs);
            using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
            {
                Byte[] chave = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(has));
                using (TripleDESCryptoServiceProvider dat = new TripleDESCryptoServiceProvider() { Key = chave, Mode = CipherMode.ECB, Padding = PaddingMode.PKCS7 })
                {
                    ICryptoTransform tras = dat.CreateDecryptor();
                    byte[] resulta = tras.TransformFinalBlock(dados, 0, dados.Length);
                    decrip = UTF8Encoding.UTF8.GetString(resulta);
                }

            }
            return decrip;
        }
        private string email,pass;
        private void frm_gerar_senhas_Load(object sender, EventArgs e)
        {
           email= passecri("fldservice@hotmail.com");
            pass = passecri("Babilonia@20789");

            groupBox1.Enabled = false;
            metrotplicenca.SelectedIndex = 0;
            metroprodId.Text = ComputerInfo.GetComputerId();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            KeyManager ky = new KeyManager(metroprodId.Text);
            KeyValuesClass kv;
            string licenca =string .Empty;
            if (metrotplicenca.SelectedIndex == 0)
            {
                kv = new KeyValuesClass()
                {

                    Type = LicenseType.FULL,
                    Header = Convert.ToByte(9),
                    Footer = Convert.ToByte(6),
                    ProductCode = (byte)codigo_do_produto,
                    Edition = Edition.ENTERPRISE,
                    Version = 1
                };
                if (!ky.GenerateKey(kv, ref licenca))
                {
                    metrolicenca.Text = "Error";
                }



            }
            else
            {
                kv = new KeyValuesClass()
                {

                    Type = LicenseType.TRIAL,
                    Header = Convert.ToByte(9),
                    Footer = Convert.ToByte(6),
                    ProductCode = (byte)codigo_do_produto,
                    Edition = Edition.ENTERPRISE,
                    Version = 1,
                    Expiration=DateTime.Now.AddDays(Convert .ToInt32(metroDias.Text ))
                };
            if (!ky.GenerateKey(kv, ref licenca))
                {
                    metrolicenca.Text = "Error";
                }
            }
            metrolicenca.Text  = licenca;

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
        int conta = 0;
        private void button1_Click(object sender, EventArgs e)
        {
           
            if (conta < 3)
            {
                if (metroEmail.Text .Equals(passedecrip(email)) && metroCodvenda.Text.Equals(passedecrip(pass)))
                {
                    groupBox1.Enabled = true;
                }
                else
                {
                    conta = +1;
                    MessageBox.Show("Dados  incorrectos \n mas "+ conta +" tentativas todos dados serao eliminados","Erro",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                    groupBox1.Enabled = false;

                }
            }
            else
            {
                //MessageBox.Show("Detectamos actividade suspeita \n Todos Dados do sistema serao eliminados ","Erro",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                //SistemaintegradoEntities si = new SistemaintegradoEntities();
                //Empresa rt = si.Empresa.Where(r => r.cod_empresa == 1).FirstOrDefault();
                //si.Empresa.Remove(rt);
                //si.SaveChanges();
                //Close();
            
            }
        }
    }
}
