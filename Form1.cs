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
    public partial class Form1 : Form
    {
        private teteenginhierEntities tete = new teteenginhierEntities();
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Clientes cli = new Clientes();
                cli.contactocli = contactocliTextBox.Text;
                cli.emailcli = emailcliTextBox.Text;
                cli.enderecocli = enderecocliTextBox.Text;
                cli.nomecli = nomecliTextBox.Text;
                cli.Nuit = nuitTextBox.Text;

                int tr = tete.Clientes.Where(v => v.nomecli == cli.nomecli ).Count();

                if (tr == 0)
                {
                    tete.Clientes.Add(cli);
                    tete.SaveChanges();
                    clientesDataGridView.DataSource = tete.Clientes.ToList();
                    button3.Enabled = false;
                    button1.Enabled = true;
                    button2.Enabled = false;
                }
                else
                {
                    MessageBox.Show("cliente " + cli.nomecli + " ou  nuit" + cli.Nuit + " Ja existe");

                }

            }
            catch (SystemException ex)
            {
                MessageBox.Show(ex.Message );
              //  Response.Write("<div class ='container' ><div class ='alert alert-danger' >" + ex.Message + "</div></div>");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            clientesBindingSource.DataSource = tete.Clientes.ToList();
            
            button3.Enabled = false;
            button2.Enabled = false;
            button1.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            clientesBindingSource.AddNew();
            button3.Enabled = false;
            button2.Enabled = true;
            button1.Enabled = false;
        }

        private void radTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
        public int idclinete { get; set; }
        private void clientesDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            button3.Enabled = true;
            button2.Enabled = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                idclinete = int.Parse(idclientesTextBox.Text);
            var client = tete.Clientes.Where(t => t.idclientes == idclinete).FirstOrDefault();
            client.nomecli = nomecliTextBox.Text;
            client.Nuit = nuitTextBox.Text;
            client.emailcli = emailcliTextBox.Text;
            client.enderecocli = enderecocliTextBox.Text;
           // tete.Clientes.Add(client);
            tete.SaveChanges();
                MessageBox.Show("Cliente actualizado com sucesso", "sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception EX)
            {

                MessageBox.Show(EX.Message ,"ERROR",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
           
        }
    }
}
