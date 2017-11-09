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
    public partial class produtoscad : Form
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
           // produtos1TextBox.Text = "";
            radButton2.Enabled = true;
            radButton3.Enabled = false;
        }

        private void produtoscad_Load(object sender, EventArgs e)
        {
            lisprodutoDataGridView.DataSource = tete.lisproduto.ToList();
            categoriaBindingSource.DataSource = tete.categoria.ToList();
           // tamanhosBindingSource.DataSource = tete.tamanhos.ToList();
        }

        private void radSplitContainer3_Click(object sender, EventArgs e)
        {

        }

        private void radButton2_Click(object sender, EventArgs e)
        {
            try
            {
               // cod = int.Parse(Request.QueryString["categoria"].ToString());
                produtos pro = new produtos();
                pro.idcategoria =int.Parse(idcategoriaComboBox.SelectedValue.ToString() ) ;
                pro.tamanhos_pro =textBox1.Text + idtamanhosComboBox.SelectedItem.ToString();
                pro.produtos_nome = produtos1TextBox.Text;
                pro.Descricao = "The bog";
                pro.codproduto = codprodutoTextBox.Text;


                 pro.Quatidade = int.Parse(quatidadeTextBox.Text);
                if (aReaTextBox.Text.Length>10)
                {

                    decimal calarea = decimal.Parse(quatidadeTextBox.Text) * int.Parse(aReaTextBox.Text);
                    pro.aRea = int.Parse(aReaTextBox.Text);
                    pro.Areatotal = calarea;
                }
                if (precosTextBox.Text .Length>1)
                {
                pro.prexo_venda = decimal.Parse(precosTextBox.Text );
                    pro.prexototal = decimal.Parse(quatidadeTextBox.Text) * decimal.Parse(precosTextBox.Text);
                }
              
                
                tete.produtos.Add(pro);
                tete.SaveChanges();
                lisprodutoDataGridView.DataSource=tete .lisproduto .ToList ();
                MessageBox.Show("Salvo com sucesso","Sucesso",MessageBoxButtons.OK,MessageBoxIcon.Information);
                radButton2.Enabled = false;
                radButton3.Enabled = false;
            }
            catch (SystemException ex)
            {
                MessageBox.Show("Porfavor preencha todos os campos correctamente"+ ex.Message);
            }



        }

        private void radTextBox1_TextChanged(object sender, EventArgs e)
        {
            if (!radTextBox1.Text.Equals(""))
            {
                lisprodutoDataGridView.DataSource = tete.lisproduto.Where(y => y.produtos_nome.Contains(radTextBox1.Text)).ToList();

            }
            else
            {
                lisprodutoDataGridView.DataSource = tete.lisproduto.ToList();

            }
        }

        private void radButton4_Click(object sender, EventArgs e)
        {
            gesreport.verprodutos g = new gesreport.verprodutos();
            g.ShowDialog();
        }

        int idpro;
        private void lisprodutoDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            idpro =int.Parse ( lisprodutoDataGridView.CurrentRow.Cells [0].Value.ToString ());
           codprodutoTextBox.Text  = lisprodutoDataGridView.CurrentRow.Cells[2].Value.ToString();
            produtos1TextBox.Text = lisprodutoDataGridView.CurrentRow.Cells[3].Value.ToString();
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
            if (aReaTextBox.Text.Length > 10)
            {

               // decimal calarea = (decimal)pro.Quatidade * int.Parse(aReaTextBox.Text);
                pro.aRea = int.Parse(aReaTextBox.Text);
              //  pro.Areatotal = calarea;
            }
            if (precosTextBox.Text.Length > 1)
            {
                pro.prexo_venda = decimal.Parse(precosTextBox.Text);
               // pro.prexototal = decimal.Parse(quatidadeTextBox.Text) * decimal.Parse(precosTextBox.Text);
            }


           // tete.produtos.Add(pro);
            tete.SaveChanges();
            lisprodutoDataGridView.DataSource = tete.lisproduto.ToList();
            MessageBox.Show("Salvo com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            radButton2.Enabled = false;
            radButton3.Enabled = false;
        }

        private void radButton5_Click(object sender, EventArgs e)
        {
            Categoriasc c = new Categoriasc();
            c.ShowDialog();
            categoriaBindingSource.DataSource = tete.categoria.ToList(); 
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

                MessageBox.Show("Nao foi possive eliminar  ?"+ex.Message , "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }
    }
}
