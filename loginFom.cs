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
using System.Threading;
using SplashScreenTesting;
using System.Security.Cryptography;

namespace GesObras
{
    public partial class loginFom : MetroFramework .Forms .MetroForm
    {
        private teteenginhierEntities d = new teteenginhierEntities();
        private splashBog splashScreen;
        private bool done = false;
        public loginFom()
        {
            InitializeComponent();
            this.Load += new EventHandler(HandleFormLoad);
            this.splashScreen = new splashBog();
        }
        private void HandleFormLoad(object sender, EventArgs e)
        {
            this.Hide();
            Thread thread = new Thread(new ThreadStart(this.ShowSplashScreen));
            thread.Start();
            Hardworker worker = new Hardworker();
            worker.ProgressChanged += (o, ex) =>
            {
                this.splashScreen.UpdateProgress(ex.Progress);
            };
            worker.HardWorkDone += (o, ex) =>
            {
                done = true;
                this.Show();
            };
            worker.DoHardWork();
        }
        private void ShowSplashScreen()
        {
            splashScreen.Show();
            while (!done)
            {
                Application.DoEvents();
            }
            splashScreen.Close();
            this.splashScreen.Dispose();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            login(TB_User.Text , TB_Password.Text);
            //try
            //{
            //    var usern = d.utilizadores.ToList();
            //    foreach (var item in usern)
            //    {
            //        var us = d.utilizadores.Where(f => f.iduuutilizadores == item.iduuutilizadores).FirstOrDefault();
            //        var username = us.Password;

            //        us.Password = passecri(username);
            //        d.SaveChanges();
            //    }
            //}
            //catch (Exception ex)
            //{

            //    return;
            //}
            TB_Password.Text = "";
        }
        string has = "Fr@ncoLu(KY%@m!a01254[]<>*&NSsbzxX";
        String passecri(string passs)
        {
            Byte[] dados = UTF8Encoding.UTF8.GetBytes(passs);

            String decrip = "";
           // Byte[] dados = Convert.FromBase64String(passs);
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
        private void loginFom_Load(object sender, EventArgs e)
        {
        //    DateTime g = Properties.Settings.Default.hoje;
        //    if (g>=DateTime .Now )
        //    {
        //        pictureBox2.Visible = false ;
        //    }
        //    else 
        //    {
        //        pictureBox2.Visible = true;
        //      timer1.Stop();
        //        label4.Text = "Aguardando a validacao do Administrador";
        //       button2.Enabled = false;
        //       button1.Enabled = false;
        //    }
        }
        void login(string user, string pass)
        {
            if (TB_User.Text == "" && TB_Password.Text == "")
            {

                MetroFramework.MetroMessageBox.Show(this, " Insira Nome e senha ", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //si = new MozEletricadbEntities();
                // var pass = usecaixa.usr_pass;
                var username = d.utilizadores.Where(t => t.Nomeuser.Equals(TB_User.Text)).Count();
                if (username == 1)
                {
                    //primeiro verficar o username
                    var Chekuser = d.utilizadores.Where(t => t.Nomeuser.Equals(TB_User.Text)).FirstOrDefault();
                    //segundo verficar o password passecri(
                    var password =passecri( TB_Password.Text);
                    if (Chekuser.Password.Equals(password))
                    {
                        MDIParent1 f = new MDIParent1();
                        f.user = Chekuser.Nome;
                        f.Iduser = Chekuser.iduuutilizadores;
                        f.ShowDialog();

                      
                        TB_Password.Text = "";

                    }
                    else
                    {

                        MetroFramework.MetroMessageBox.Show(this, "Password Incorecto", "", MessageBoxButtons.OK, MessageBoxIcon.Stop);

                    }
                }
                else
                {

                    MetroFramework.MetroMessageBox.Show(this, "Usuario nao encontrado", "", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }



                TB_Password.Text = "";
            }
           
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {


                if (radProgressBar1.Value == 100)
                {
                    timer1.Stop();
                    button1.Enabled = true;
                    label4.Text = "Sistema inicializado com sucesso";
                    //lo.Show();
                    //this.Visible = false;
                    //    Dispose();
                }
                else if (radProgressBar1.Value == 20)
                {
                    label4.Text = "Verficando a Empresa";
                    var verempr = d.empresa.Count();
                    if (verempr <= 0)
                    {
                        timer1.Stop();
                        MetroFramework.MetroMessageBox.Show(this, "Não existe empresa registrada \n Por favor Registe", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        frmescritorioas em = new frmescritorioas();
                        em.ShowDialog();

                        timer1.Start();
                    }
                    else
                    {
                        radProgressBar1.Value += 10;
                    }


                }
                else if (radProgressBar1.Value == 50)
                {
                    label4.Text = "Verficando Administrador";

                    //var empr = d.TP_Plano.Count();
                    //if (empr <= 0)
                    //{
                    //    despesas_class d = new despesas_class();
                    //    d.tspplanos();
                    //    d.inserides();
                    //}

                    var verempr = d.utilizadores.Count();
                    if (verempr <= 0)
                    {
                        timer1.Stop();
                        MetroFramework.MetroMessageBox.Show(this, "Nao existe Usuario registrada ,\n Porfavor Registe", "Informacao", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        userfom em = new userfom();
                        em.ShowDialog();
                        timer1.Start();

                    }
                    else
                    {

                        radProgressBar1.Value += 10;
                    }
                }
                else if (radProgressBar1.Value == 60)
                {
                    var frm_pag = d.formaPagamento.Count();
                    if (frm_pag <= 1)
                    {
                        timer1.Stop();
                        label4.Text = "Verficando formas de pagamento";
                        despesas_class d = new despesas_class();
                        d.frmPaga();



                        timer1.Start();

                    }

                    label4.Text = "Salvando as comfiguracaoes";
                    radProgressBar1.Value += 10;
                }

                else
                {

                    radProgressBar1.Value += 10;
                    label4.Text = "Activando componetes";
                }
            }
            catch (Exception ex)
            {
                timer1.Stop();
                MetroFramework.MetroMessageBox.Show(this, "Contacte ao Administrador do Systema \n Erro ao inicializar a base de Dados" + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);


            }

          //  TB_User.Focus();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
