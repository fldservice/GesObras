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
    public partial class frm_detalhes_registo : MetroFramework .Forms .MetroForm 
    {
        public frm_detalhes_registo()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frm_detalhes_registo_Load(object sender, EventArgs e)
        {
            metroprodId.Text = ComputerInfo.GetComputerId();
            KeyManager ky = new KeyManager(metrolince.Text);
            LicenseInfo lic = new LicenseInfo();
            int valu = ky.LoadSuretyFile(string.Format(@"{0}\key.lic", Application.StartupPath),ref lic);
            string licensa = lic.ProductKey;
            if(ky.ValidKey (ref licensa))
            {
              KeyValuesClass kv = new KeyValuesClass();
              if (ky.DisassembleKey(licensa, ref kv))
              {
                  metroNome.Text = "Apges";
                  metrolince.Text = licensa.ToString();
                  if (kv.Type == LicenseType.TRIAL)
                  {
                      metrodias.Text = string.Format("{0} Dias", (kv.Expiration - DateTime.Now.Date).Days);

                  }
                  else {
                      metrodias.Text = "Completo";
                  
                  }

              }
            }
         }
    }
}
