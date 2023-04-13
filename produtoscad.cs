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
using Tulpep.NotificationWindow;

namespace GesObras
{
    public partial class produtoscad : Telerik.WinControls.UI.RadForm 
    { private teteenginhierEntities tete =new teteenginhierEntities ();
        public produtoscad()
        {
            InitializeComponent();
        }

        private void radButton1_Click(object sender, EventArgs e)
        {
           // produtosBindingSource.AddNew();
            lisprodutoBindingSource.AddNew();
            codprodutoTextBox.Text = "MT-";
            precosTextBox.Text = "0";
            radButton2.Enabled = true;
            radButton3.Enabled = false;
        }

        private void produtoscad_Load(object sender, EventArgs e)
        {
            //produtos nao tangivies
            lisprodutoDataGridView.DataSource = tete.lisproduto.Where (c=>c.activoTangivel .Equals("false")).ToList();
            categoriaBindingSource.DataSource = tete.categoria.Where(c => c.activoTangivel.Equals("false")).ToList();
            // tamanhosBindingSource.DataSource = tete.tamanhos.ToList();
            var conta = tete.lisproduto.Where(c => c.activoTangivel.Equals("false")).Count();
            var popupNotifier = new PopupNotifier();
            popupNotifier.TitleText = "Quantidades na ferramentaria";
            popupNotifier.ContentText = "Exitem cerca de " + conta + " produtos com estoque \n menor ou iguala 50";
            // popupNotifier.IsRightToLeft = false;
            popupNotifier.Popup();
            groupBox1.Enabled = false;
        }

        private void radSplitContainer3_Click(object sender, EventArgs e)
        {

        }
        //fixar avariavel constate da densidade
        private const int densidade = 7850;
        private const Int64 metros = 1000000000;
     
        private decimal kilograms = 0;
        private void radButton2_Click(object sender, EventArgs e)
        {
            try
            {
                // cod = int.Parse(Request.QueryString["categoria"].ToString());
                if (!quatidadeTextBox.Text.Equals("") & !precosTextBox.Text.Equals(""))
                {
                    produtos pro = new produtos();
                pro.idcategoria =int.Parse(idcategoriaComboBox.SelectedValue.ToString() ) ;
                pro.tamanhos_pro =textBox1.Text + idtamanhosComboBox.SelectedItem.ToString();
                pro.produtos_nome = produtos1TextBox.Text;
                pro.Descricao = "The bog";
                    pro.codproduto = codprodutoTextBox.Text;
                    pro.prexo_venda = decimal.Parse(precosTextBox .Text  );
                    decimal calarea = 0;
            //  pro.Quatidade = int.Parse(quatidadeTextBox.Text);
                if (checkBox1.Checked)
                {

                    calarea = decimal.Parse(textcomprim.Text) * decimal.Parse(textlargura.Text);
                        //buscar o peso em kilogramas de cada chapa
                        kilograms = (calarea * int.Parse(textBox1.Text) * densidade)/metros;
                    pro.aRea = calarea;
                        pro.Largura = decimal.Parse(textlargura.Text);
                        pro.comprimentos = decimal.Parse(textcomprim.Text);
                        pro.kilosingle = kilograms;//salvar kilogramas do produto 
                    }
               
              
                
                tete.produtos.Add(pro);
                    tete.SaveChanges();
                    //  var prost = tete.produtos.OrderByDescending(x=>x.idprodutos).FirstOrDefault();


                     
                    Precos_pro pr = new Precos_pro();
                    pr.preco_pro = decimal.Parse(precosTextBox.Text);
                    pr.idpro = pro.idprodutos;
                     pr.Kilogramas= kilograms * int.Parse(quatidadeTextBox.Text); // multiplicar com a quantidade de chapas
                    pr.Observacao = "Cadastro inicial";
                    pr.areatotal = calarea*int.Parse(quatidadeTextBox.Text);
                    pr.qtypro = int.Parse(quatidadeTextBox.Text);
                    tete.Precos_pro.Add(pr);
                    tete.SaveChanges();
                    MetroFramework.MetroMessageBox.Show(this, "Salvo com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
 lisprodutoDataGridView.DataSource=tete .lisproduto.Where(c => c.activoTangivel.Equals("false")).ToList();
                    radButton2.Enabled = false;
                radButton3.Enabled = false;
                }
                else
                {
                    MetroFramework.MetroMessageBox.Show(this, "Informe as qty iniciais e o preco\n ex:0", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

               
            }
            catch (SystemException ex)
            {
                MetroFramework.MetroMessageBox.Show(this, "Porfavor preencha todos os campos correctamente" + ex.Message);
            }



        }

        private void radTextBox1_TextChanged(object sender, EventArgs e)
        {
            if (!radTextBox1.Text.Equals(""))
            {
                lisprodutoDataGridView.DataSource = tete.lisproduto.Where(y => y.produtos_nome.Contains(radTextBox1.Text) & y.activoTangivel.Equals("false")).ToList();

            }
            else
            {
                lisprodutoDataGridView.DataSource = tete.lisproduto.Where(c => c.activoTangivel.Equals("false")).ToList();

            }
        }

        private void radButton4_Click(object sender, EventArgs e)
        {
            MDIParent1 gs=new MDIParent1 ();
            gesreport.verprodutos g = new gesreport.verprodutos();
       
            g.ShowDialog();
        }

        int idpro;
        private void lisprodutoDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            idpro =int.Parse ( lisprodutoDataGridView.CurrentRow.Cells [0].Value.ToString ());
           codprodutoTextBox.Text  = lisprodutoDataGridView.CurrentRow.Cells[2].Value.ToString();
            produtos1TextBox.Text = lisprodutoDataGridView.CurrentRow.Cells[3].Value.ToString();
            dataGridView1.DataSource = tete.Precos_pro.Where(y => y.idpro == idpro).ToList();
            radLabel3.Text = produtos1TextBox.Text;

            radButton2.Enabled = false;
           
            radButton3.Enabled = true;

        }

        private void radButton3_Click(object sender, EventArgs e)
        {
          // idpro= int.Parse(idprodutosTextBox.Text);
            produtos pro = tete.produtos.Where(y=>y.idprodutos==idpro).FirstOrDefault();
            pro.idcategoria = int.Parse(idcategoriaComboBox.SelectedValue.ToString());
            if (!textBox1.Text .Equals(""))
            {
            pro.tamanhos_pro = textBox1.Text + idtamanhosComboBox.SelectedText.ToString();

            }
            pro.produtos_nome = produtos1TextBox.Text;
            pro.Descricao = "The bog";
            pro.codproduto = codprodutoTextBox.Text;


          //  pro.Quatidade = double.Parse(quatidadeTextBox.Text);
            if (checkBox1.Checked)
            {


               var calarea = decimal.Parse(textcomprim.Text) * decimal.Parse(textlargura.Text);
                kilograms = calarea * int.Parse(textBox1.Text) * metros;
                pro.aRea = calarea;

                pro.Largura = decimal.Parse(textlargura.Text);
                pro.comprimentos = decimal.Parse(textcomprim.Text);
            }
            if (precosTextBox.Text.Length > 1)
            {
                pro.prexo_venda = decimal.Parse(precosTextBox.Text);
           // pro.prexototal = decimal.Parse(quatidadeTextBox.Text) * decimal.Parse(precosTextBox.Text);
            }


           // tete.produtos.Add(pro);
            tete.SaveChanges();
            lisprodutoDataGridView.DataSource = tete.lisproduto.ToList();
            MetroFramework.MetroMessageBox.Show(this, "Salvo com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            radButton2.Enabled = false;
            radButton3.Enabled = false;
        }

        private void radButton5_Click(object sender, EventArgs e)
        {
            Categoriasc c = new Categoriasc();
            c.ShowDialog();
            categoriaBindingSource.DataSource = tete.categoria.Where(r=>r.activoTangivel.Equals("false")).ToList(); 
        }

        private void elininarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
 if (idpro>0 && MessageBox.Show ("Quer realmente eliminar este Produto ?","Eliminar",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes )

            {
                produtos pro = tete.produtos.Where(y => y.idprodutos == idpro).FirstOrDefault();
                tete.produtos.Remove(pro);
                tete.SaveChanges();
                    lisprodutoDataGridView.DataSource = tete.lisproduto.ToList();

                }
            }
            catch (Exception ex)
            {

                MetroFramework.MetroMessageBox.Show(this, "Nao foi possive eliminar  ?" +ex.Message , "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                groupBox1.Enabled = true;
            }
            else
            {
                groupBox1.Enabled = false;
            }
        }

        private void actualizarQtyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (idprecoss > 0)
                {


                    gesInvent.updatepreco update = new gesInvent.updatepreco();
                    update.idpreco = idprecoss;
                    update.Show();



                }
            }
            catch (Exception ex)
            {

                throw;
            }
        }
        int idprecoss;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            idprecoss = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
        }
    }
}
