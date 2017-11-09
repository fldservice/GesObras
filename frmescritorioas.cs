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
using System.Text.RegularExpressions;
using System.IO;

namespace GesObras
{
    public partial class frmescritorioas : Form
    {
        private teteenginhierEntities si = new teteenginhierEntities();
        public frmescritorioas()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.InitialDirectory = "c:/Picture/";
            open.Filter = "Todos fichiros |*.*|jpeg|*.Jpg|Bitmaps|*.bmp ";
            open.FilterIndex = 2;
            if (open.ShowDialog() == DialogResult.OK)
            {

                pictureBox1.Image = Image.FromFile(open.FileName);
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                // nome_PictureTextBox.Text = open.SafeFileName.ToString();
            }
        }
        public void SalvarDocumer()
        {
            MemoryStream ms = new MemoryStream();
            pictureBox1.Image.Save(ms, pictureBox1.Image.RawFormat);
            byte[] logo = ms.GetBuffer();
            int b;
            b = si.empresa.Count();
            if (b > 0) {
                empresa dc = new empresa();
                dc.NomeEmpresa = nome_escritorioTextBox.Text;
                dc.Nuit = nuiteTextBox.Text;
               dc.Email = descricaoTextBox.Text;
                dc.Contacto = contactoTextBox.Text;
               // dc.Datainicioactivade = DateTime.Parse(datainicioactivadeDateTimePicker.Text);
                dc.Endereco = enderessoTextBox.Text;
                dc.logoem = logo;

                si.SaveChanges();
                MessageBox.Show(this, "Salvo com Sucesso", "Documento", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //   DecumentosproBindin

            }
            else
            {


                try
                {
                    empresa dc = new empresa();
                    dc.NomeEmpresa = nome_escritorioTextBox.Text;
                    dc.Nuit = nuiteTextBox.Text;
                    dc.Email = descricaoTextBox.Text;
                    dc.Contacto = contactoTextBox.Text;
                   // dc.Datainicioactivade = DateTime.Parse(datainicioactivadeDateTimePicker.Text);
                    dc.Endereco = enderessoTextBox.Text;
                    dc.logoem = logo;
                    si.empresa.Add(dc);
                    si.SaveChanges();
                    MessageBox.Show(this, "Documento adicionado com Sucesso", "Documento", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ///  DecumentosproBindingSource.DataSource = (From d In si.decumentos_pro Where d.idprocesso = idProcesso Select d).ToList()
                }
                catch (Exception)
                    {
                    return;
                }
            }
          
   }

        private void button2_Click(object sender, EventArgs e)
        {
            SalvarDocumer();
        }

        private void nov(object sender, EventArgs e)
        {
            empresaBindingSource.AddNew();
           
        }
    }
}
