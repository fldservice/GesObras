using FoxLearn.License;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Gescom.Registo
{
    public partial class form_registo : MetroFramework.Forms .MetroForm

    {
        public delegate void pagamentoevent(object sender, pagamentoeventargs e);
        public event pagamentoevent pagfeito;
       // const int codigo_do_produto = 1;
        public form_registo()
        {
            InitializeComponent();
        }
        public class pagamentoeventargs : EventArgs
        {
            private bool resposta;

            public bool Resposta
            {
                get
                {
                    return resposta;
                }

                set
                {
                    resposta = value;
                }
            }
        }
            private void button4_Click(object sender, EventArgs e)
        {
            KeyManager ky = new KeyManager(metroprodId.Text);
           // KeyValuesClass kv;
            string licenca = metrotplicenca.Text;
            if (ky.ValidKey(ref licenca))
            {
                KeyValuesClass kv = new KeyValuesClass();
                if (ky.DisassembleKey(licenca, ref kv))
                {


                    LicenseInfo lic = new LicenseInfo();
                    lic.ProductKey = licenca;
                    lic.FullName = "Gescom";
                    if (kv.Type == LicenseType.TRIAL)
                    {
                        lic.Day = kv.Expiration.Day;
                        lic.Month = kv.Expiration.Month;
                        lic.Year = kv.Expiration.Year;
                    }
                    ky.SaveSuretyFile(string.Format(@"{0}\key.lic", Application.StartupPath), lic);
                    MessageBox.Show("Sistema Registrado com sucesso", "Registo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                  //  pagfeito(this, new pagamentoeventargs() { Resposta = true});
                    this.Dispose();
                    
                }
                else
                {
                    MessageBox.Show("A sua licença é invalida", "Registo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    this.Close();
                }

            }
            else
            {
                MessageBox.Show("A sua licença é invalida", "Registo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Close();
            }
        }

        private void form_registo_Load(object sender, EventArgs e)
        {
           
            metroprodId.Text = ComputerInfo.GetComputerId();
        }
    }
}
