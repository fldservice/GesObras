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
    public partial class Cadobras : Form
    {
        private teteenginhierEntities te = new teteenginhierEntities();
        public Cadobras()
        {
            InitializeComponent();
            autocompliteprodut();
        }
        void autocompliteprodut()
        {

            AutoCompleteStringCollection cl = new AutoCompleteStringCollection();
            te = new teteenginhierEntities();
            var pro = te.Clientes.ToList();
            foreach (var item in pro)
            {

                cl.Add(item.nomecli.ToString());
            }
            radTextBox1.AutoCompleteCustomSource = cl;
        }
        private int idclinte;
        private void Procurarpornome(string nomepro)
        {
            te = new teteenginhierEntities();
            int ver;
            ver = te.Clientes.Where(r => r.nomecli.Contains(nomepro)).Count();
            if (ver == 1)
            {



                var pr = te.Clientes.Where(r => r.nomecli.Contains(nomepro)).FirstOrDefault();
                idclinte = pr.idclientes;
                radLabel3.Text = pr.nomecli;

            }
        }
        private void radLabel2_Click(object sender, EventArgs e)
        {

        }

        private void radButton1_Click(object sender, EventArgs e)
        {
            try
            {
                var contarobra = te.Obrass.Count();
                Obrass ob = new Obrass();
                ob.idclient = idclinte;
                ob.descricao = radTextBox2.Text;
                ob.localobra = radTextBox3.Text;
                ob.nivelobra = int.Parse (radDropDownList1 .SelectedItem.ToString());
                ob.Nobra = contarobra + 1;
                ob.estado = "Aberta";
                te.Obrass.Add(ob);
                tblhoras tb = new tblhoras();
                tb.datarealizacao = DateTime.Now;
                tb.estado = "Agendado";
                tb.horaini = DateTime.Now;
                tb.idobras = ob.idobras;
                te.tblhoras.Add(tb);

                te.SaveChanges();
                MessageBox.Show("Nova obra criada com sucesso","Sucesso",MessageBoxButtons.OK,MessageBoxIcon.Information );
                this.Dispose();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "problema", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void radTextBox1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {

                    Procurarpornome(radTextBox1.Text);
                    radTextBox1.Text = "";
                    //radTextBox1.Focus();
                    // txtQuantidade.Text = "1";
                    // textpUnit.Text = "";
                }
                catch (System.Exception ex)
                {
                    System.Windows.Forms.MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
