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
    public partial class loginFom : Form
    {
        private teteenginhierEntities d = new teteenginhierEntities();
        public loginFom()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            login(nomeuserTextBox.Text , passwordTextBox.Text);
            passwordTextBox.Text = "";
        }

        private void loginFom_Load(object sender, EventArgs e)
        {
            DateTime g = Properties.Settings.Default.hoje;
            if (g>=DateTime .Now )
            {
                
            }
            else 
            {
                timer1.Stop();
                label4.Text = "Periodo de teste terminou";
                button2.Enabled = false;
                button1.Enabled = false;
            }
        }
        void login(string user, string pass)
        {
            var ver = d.utilizadores.Where(u => u.Nomeuser.Equals(user) && u.Password.Equals(pass)).Count();
            if (ver == 1)
            {
                var userl = d.utilizadores.Where(u => u.Nomeuser.Equals(user) && u.Password.Equals(pass)).FirstOrDefault();


           //     MessageBox.Show("Bemvindo " + user );
                MDIParent1 f = new MDIParent1();
                f.user = userl.Nome;
                f.ShowDialog();
                this.Dispose();
            }
            else
            {

                MessageBox.Show("Usuario "+user +" Nao foi encontradao");
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                d = new teteenginhierEntities();

                if (progressBar1.Value == 100)
                {
                    timer1.Stop();
                    button2.Enabled = true;
                    label4.Text = "Sistema inicializado com sucesso";
                    //lo.Show();
                    //this.Visible = false;
                    //    Dispose();

                }
                else if (progressBar1.Value == 10)
                {
                    label4.Text = "Verficando a Impresa";
                    var verempr = d.empresa.Count();
                    if (verempr <= 0)
                    {
                       timer1.Stop();
                        MessageBox.Show(this, "Nao existe empresa registrada ,\n Porfavor Registe", "Informacao", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        frmescritorioas em = new frmescritorioas();
                        em.ShowDialog();
                        despesas_class des = new despesas_class();
                        des.Cadcategorias();
                      timer1.Start();
                   }
                    else
                    {
                     progressBar1.Value += 10;
                    }
                   

                }
                else if (progressBar1.Value == 50)
                {
                    label4.Text = "Verficando Administrador";

                    var empr = d.utilizadores.Count();
                    //if (empr <= 0)
                    //{
                    //    despesas_class d = new despesas_class();
                    //    d.userpermi();
                    //}

                   // var verempr = d.utilizadores.Count();
                    if (empr <= 0)
                    {
                        timer1.Stop();
                        MessageBox.Show(this, "Nao existe Usuario registrada ,\n Porfavor Registe", "Informacao", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                      userfom  em = new userfom();
                        em.ShowDialog();
                        timer1.Start();

                    }
                    else
                    {

                       progressBar1.Value += 10;
                    }
                   
                }
                 if (progressBar1.Value > 60)
                {
                   // progressBar1.Value += 10;
                }
                else
                {

                    progressBar1.Value += 10;
                    label4.Text = "Activando componetes";
                }
            }
            catch (Exception ex)
            {
                timer1.Stop();
               MessageBox.Show(this, "Contacte ao Administrador do Systema \n Erro ao inicializar a base de Dados" + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);


            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
