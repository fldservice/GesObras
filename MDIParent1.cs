using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tulpep.NotificationWindow;
using dbges;
using System.IO;
using gesInvent;
using FoxLearn.License;
using Telerik.WinControls.UI;
using System.Security.Cryptography;
using System.Configuration;

namespace GesObras
{
    public partial class MDIParent1 : Form
    {
        private int childFormNumber = 0;
        private teteenginhierEntities te = new teteenginhierEntities();
        public MDIParent1()
        {
            InitializeComponent();
        }
        public int Iduser { get; set; }
        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //toolStrip.Visible = toolBarToolStripMenuItem.Checked;
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
           // statusStrip.Visible = statusBarToolStripMenuItem.Checked;
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
           // LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
           // LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //foreach (Form childForm in MdiChildren)
            //{
            //    childForm.Close();
            //}
        }
        void getimag()
        {
            empresa emp = te.empresa.FirstOrDefault();
            byte[] logos = emp.logoem;
            MemoryStream ms = new MemoryStream(logos);

            pictureBox1.Image = Image.FromStream(ms);
          //  radLabelElement5.Text = em.Nome_empr;
        }
        static void ToggleConfigEncryption(string exeConfigName)
        {
            // Takes the executable file name without the
            // .config extension.
            try
            {
                // Open the configuration file and retrieve 
                // the connectionStrings section.
                Configuration config = ConfigurationManager.
                    OpenExeConfiguration(exeConfigName);

                ConnectionStringsSection section =
                    config.GetSection("connectionStrings")
                    as ConnectionStringsSection;

                if (section.SectionInformation.IsProtected)
                {
                    // Remove encryption.
                    section.SectionInformation.UnprotectSection();
                }
                else
                {
                    // Encrypt the section.
                    section.SectionInformation.ProtectSection(
                        "DataProtectionConfigurationProvider");
                }
                // Save the current configuration.
                config.Save();

                Console.WriteLine("Protected={0}",
                    section.SectionInformation.IsProtected);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        private void MDIParent1_Load(object sender, EventArgs e)
        {
            try
            {
                ToggleConfigEncryption("GesObras");
                var pcid = ComputerInfo.GetComputerId();
                KeyManager ky = new KeyManager(pcid);
                LicenseInfo lic = new LicenseInfo();
                int valu = ky.LoadSuretyFile(string.Format(@"{0}\key.lic", Application.StartupPath), ref lic);
                string licensa = lic.ProductKey;
                if (licensa != null)
                {

                    //  MessageBox.Show("registrado");

                    if (ky.ValidKey(ref licensa))
                    {
                        KeyValuesClass kv = new KeyValuesClass();
                        if (ky.DisassembleKey(licensa, ref kv))
                        {
                            //  this.Text = user.nome_utiliza + ": ApGes";
                            // metrolince.Text = licensa.ToString();
                            if (kv.Type == LicenseType.TRIAL)
                            {
                                int dias = (kv.Expiration - DateTime.Now.Date).Days;
                                txtinfo.Text = string.Format("{0} Dias", dias);
                                if (dias <= 0 || txtinfo.Text.Equals("info"))
                                {
                                    MetroFramework.MetroMessageBox.Show(this, "Sistema nao registrado", "APGes", MessageBoxButtons.OK, MessageBoxIcon.Stop);

                                    //ribbonTab1.Enabled = false;
                                    //ribbonTab2.Enabled = false;
                                    radRibbonBarGroup2.Enabled = false;
                                    radRibbonBarGroup8.Enabled = false;
                                    radRibbonBarGroup3.Enabled = false;
                                    //radRibbonBarGroup4.Enabled = false;
                                    //radRibbonBarGroup1.Enabled = false;
                                    //radRibbonBarGroup6.Enabled = false;
                                    //radRibbonBarGroup7.Enabled = false;
                                    ////radButtonElement10.Enabled = false;
                                    //radButtonElement12.Enabled = false;
                                    //radRibbonBarGroup5.Enabled = false;
                                    //try
                                    //{
                                    //    var usern = te.utilizadores.ToList();
                                    //    foreach (var item in usern)
                                    //    {
                                    //        var us = te.utilizadores.Where(f => f.iduuutilizadores == item.iduuutilizadores).FirstOrDefault();
                                    //        var username = us.Password;

                                    //        us.Password = passecri(username);
                                    //        te.SaveChanges();
                                    //    }
                                    //}
                                    //catch (Exception ex)
                                    //{

                                    //    return;
                                    //}
                                    // ribbonTab1.Enabled = false; 
                                    // ribbonTab2.Enabled = false;
                                    //ribbonTab1.Enabled = false;
                                    //ribbonTab3.Enabled = false;

                                }
                                else
                                {
                                    //var m = si.Modulos.ToList();

                                    //ribbonTab1.Enabled =Boolean .Parse ( estaModulo("Gescom"));
                                    //ribbonTab2.Enabled = Boolean.Parse(estaModulo("GesLanc"));
                                    //ribbonTab4.Enabled = Boolean.Parse(estaModulo("GesClinica"));
                                    //ribbonTab3.Enabled = Boolean.Parse(estaModulo("RH"));

                                }

                            }
                            else
                            {

                            }

                        }
                    }
                }
                else
                {
                    MetroFramework.MetroMessageBox.Show(this, "Sistema nao registrado", "APGes", MessageBoxButtons.OK, MessageBoxIcon.Stop);

                    txtinfo.Text = "Sistema Nao Registrado";
                    radRibbonBarGroup2.Enabled = false;
                    radRibbonBarGroup8.Enabled = false;
                    radRibbonBarGroup4.Enabled = false;
                    radRibbonBarGroup1.Enabled = false;
                    radButtonElement10.Enabled = false;
                    radButtonElement12.Enabled = false;
                    // ribbonTab1.Enabled = false; 
                    // ribbonTab2.Enabled = false;
                    ribbonTab1.Enabled = false;
                    // ribbonTab4.Enabled = false;

                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            toolStripStatusLabel1.Text = "Bem vindo(a) :" + user;
            toolStripStatusLabel2.Text = DateTime.Now.ToShortDateString();
            getimag();
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
       
        public string user { get; set; }
        private void radRibbonBar1_Click(object sender, EventArgs e)
        {
            
        
        var conta = te.lisproduto.Where(c => c.activoTangivel.Equals("false") & c.qtyp <= 50).Count();
            var popupNotifier = new PopupNotifier();
            popupNotifier.TitleText = "Quantidades na ferramentaria";
            popupNotifier.ContentText = "Exitem cerca de "+conta+" produtos com estoque \n menor ou iguala 50";
           // popupNotifier.IsRightToLeft = false;
            popupNotifier.Popup();

        }

        private void radButtonElement1_Click(object sender, EventArgs e)
        {
            produtoscad pro = new produtoscad();
           pro.MdiParent = this;
            pro.Show(); 
        }

        private void radButtonElement2_Click(object sender, EventArgs e)
        {
            entradas pro = new entradas();
            pro.MdiParent = this;
            pro.Show();
        }

        private void radButtonElement3_Click(object sender, EventArgs e)
        {
            lisObras pro = new lisObras();
            pro.MdiParent = this;
            pro.Show();
        }

        private void radButtonElement4_Click(object sender, EventArgs e)
        {
            Form1 pro = new Form1();
            pro.MdiParent = this;
            pro.Show();
        }

        private void radButtonElement5_Click(object sender, EventArgs e)
        {
            vercompras pro = new vercompras();
            pro.MdiParent = this;
            pro.Show();
        }

        private void radButtonElement6_Click(object sender, EventArgs e)
        {
            vercassabass pro = new vercassabass();
            pro.MdiParent = this;
            pro.Show();
        }

        private void radButtonElement7_Click(object sender, EventArgs e)
        {
            gesreport.saidasprod pro = new gesreport.saidasprod();
            pro.MdiParent = this;
            pro.Show();
        }

        private void radButtonElement8_Click(object sender, EventArgs e)
        {
            try
            {
 requizicoess pro = new requizicoess();
            pro.MdiParent = this;
            pro.Show(); ;
            }
            catch (Exception)
            {

              
            }
         
        }

        private void radButtonElement9_Click(object sender, EventArgs e)
        {
            frmfornecidore pro = new frmfornecidore();
            pro.MdiParent = this;
            pro.Show();
        }

        private void radMenuItem1_Click(object sender, EventArgs e)
        {
            frmescritorioas pro = new frmescritorioas();
            pro.MdiParent = this;
            pro.Show();
        }

        private void radMenuItem2_Click(object sender, EventArgs e)
        {
            userfom d = new userfom();
            d.ShowDialog();
        }

        private void radButtonElement10_Click(object sender, EventArgs e)
        {
            gesreport.frmentradasver g = new gesreport.frmentradasver();
            g.MdiParent = this;
            g.Show();
        }

        private void radButtonElement11_Click(object sender, EventArgs e)
        {
            gesreport.relatoriPFornecedor g = new gesreport.relatoriPFornecedor();
            g.MdiParent = this;
            g.Show();
        }

        private void radButtonElement12_Click(object sender, EventArgs e)
        {
            try
            {
                Process[] processList = Process.GetProcessesByName("calc");
                if (processList.Length >= 1)
                {
                    // process already running, kill it and start again
                    foreach (Process item in processList)
                    {
                        item.Kill();
                    }
                    Process.Start("calc.exe");
                }
                else
                {
                    Process.Start("calc.exe");
                }

                //  Telerik.WinControls.NativeMethods.SetParent(p.MainWindowHandle, this.Handle);
            }
            catch (Exception)
            {

                return;
            }

        }

        private void radRibbonBarGroup8_Click(object sender, EventArgs e)
        {

        }

        private void radButtonElement13_Click(object sender, EventArgs e)
        {
            gesInvent.frmLisaInvetar  ca = new gesInvent.frmLisaInvetar();
            ca.MdiParent = this;
            ca.Show();
           // MessageBox.Show("Modulo em manutencao"); 
        }

        private void radButtonElement14_Click(object sender, EventArgs e)
        {
            try
            {
                     gesInvent.lisObras ca = new gesInvent.lisObras();
           ca.MdiParent = this;
            ca.Show();
            }
            catch (Exception)
            {

          
            }
          
        }

        private void radDropDownButtonElement1_Click(object sender, EventArgs e)
        {

        }
        private void radMenumIntem3_click(object sender, EventArgs e)
        {

        }

        private void radButtonElement15_Click(object sender, EventArgs e)
        {
            frm_api f = new frm_api();
            f.MdiParent = this;
           // f.Show();

        }

        private void radButtonElement16_Click(object sender, EventArgs e)
        {
            frm_reportApi f = new frm_reportApi();
            f.MdiParent = this;
            f.Show();
        }

        private void radMenuItem3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void radButtonElement17_Click(object sender, EventArgs e)
        {
            frmEquipamentos fr = new frmEquipamentos();
          fr.MdiParent = this;
            fr.Show();
        }

        private void radButtonElement18_Click(object sender, EventArgs e)
        {
           // GesHonorario.Vendaprodutos vp = new GesHonorario.Vendaprodutos();
           //vp.MdiParent = this;
           // vp.Show();
            // MetroFramework.MetroMessageBox.Show(this, "BrevMente\n modulo de gestão de Vendas de produtos \n Facturacao e Recibos ", "Aguarde", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void radButtonElement19_Click(object sender, EventArgs e)
        {
            frmFunci de = new frmFunci();
            de.MdiParent = this;
            de.Show();
        }

        private void radButtonElement20_Click(object sender, EventArgs e)
        {
            sisfince.fmr_contas_pagar g = new sisfince.fmr_contas_pagar();
          g.MdiParent = this;
            g.Show();

            //  MetroFramework .MetroMessageBox.Show(this,"BrevMente\n modulo de gestão finaceiras\n Gastos e Rendimentos ","Aguarde",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void radButtonElement21_Click(object sender, EventArgs e)
        {
            //GesHonorario.frm_lista_clintes ft = new GesHonorario.frm_lista_clintes();
            //ft.MdiParent = this;
            //ft.Show();
        }

        private void radButtonElement22_Click(object sender, EventArgs e)
        {
            gesreport.frmpivote p = new gesreport.frmpivote();
            p.MdiParent = this;
            p.Show();
        }

        private void toolStripStatusLabel_Click(object sender, EventArgs e)
        {
            using (Gescom .Registo. frm_gerar_senhas ger = new Gescom.Registo.frm_gerar_senhas())
            {

                ger.ShowDialog();

            }
        }

        private void radMenuItem4_Click(object sender, EventArgs e)
        {
            Gescom.Registo.form_registo g = new Gescom.Registo.form_registo();
            g.ShowDialog();
        }

        private void radButtonElement23_Click(object sender, EventArgs e)
        {
            sisfince.Planos_form g = new sisfince.Planos_form();
            g.MdiParent = this;
            g.Show();
        }

        private void radButtonElement24_Click(object sender, EventArgs e)
        {
            sisfince.verlanc g = new sisfince.verlanc();
            g.MdiParent = this;
            g.Show();
        }

        private void radButtonElement25_Click(object sender, EventArgs e)
        {
            sisfince.Form_Pra_Pagar g = new sisfince.Form_Pra_Pagar();
            g.MdiParent = this;
            g.Show();
        }

        private void radButtonElement26_Click(object sender, EventArgs e)
        {
            
        }

        private void radButtonElement27_Click(object sender, EventArgs e)
        {
            
        }

        private void radButtonElement28_Click(object sender, EventArgs e)
        {
            
        }

        private void radButtonElement29_Click(object sender, EventArgs e)
        {

        }

        private void radButtonElement30_Click(object sender, EventArgs e)
        {
           
        }

        private void radButtonElement31_Click(object sender, EventArgs e)
        {
           

        }

        private void radMenuItem5_Click(object sender, EventArgs e)
        {
            uploadProdutos g = new uploadProdutos();
            g.MdiParent = this;
            g.Show();
        }

        private void radButtonElement18_Click_1(object sender, EventArgs e)
        {
            //relatoriosSaidaMensais f = new relatoriosSaidaMensais();
            //f.ShowDialog();
        }

        private void radButtonElement21_Click_1(object sender, EventArgs e)
        {
            //frm_reqBymes by = new frm_reqBymes();
            //by.Show();
        }

        //public void getItems()
        //{
        //    foreach (RadMenuItem  item in RadMenuButtonItem.it)
        //    {
        //        // d.Add(item.Name, item.ZIndex);RadMenuItem parentItem
        //        // 
        //        //if (permissoes(item.Name) == true)
        //        //{
        //        //    //  MessageBox.Show(item .Name );
        //        //}
        //        //else
        //        //{
        //        //    item.Enabled = false;
        //        //}
        //    }
        //}
        //bool permissoes(string nomeitem)

        //{


        //    bool resp = false;
        //    var user = te.utilizadores.Where(y => y.iduuutilizadores == idcaixa).FirstOrDefault();
        //    //   var per = si.User_group.Where(r => r.id_usegru == user.idgoupo).FirstOrDefault();

        //    var p = te.View_Permissoes.Where(o => o.idgrup == user.idgoupo & o.nomeForm.Equals(nomeitem)).Count();
        //    if (p != 0)
        //    {
        //        resp = true;
        //    }


        //    return resp;
        //}
    }
}
