using dbges;
using ExcelDataReader;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GesObras
{
    public partial class uploadProdutos : Form
    {
        private teteenginhierEntities tete = new teteenginhierEntities();
        public uploadProdutos()
        {
            InitializeComponent();
        }
        public string caminho { get; set; }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog fil = new OpenFileDialog();
                fil.ShowDialog();
                 caminho = fil.FileName.ToString();
                lerdadosdapalnilna(caminho);

            }
            catch (Exception)
            {

                throw;
            }
        }
        private void lerdadosdapalnilna(string caminho)
        {

            var strem = File.Open(caminho, FileMode.Open, FileAccess.Read);
            var ler = ExcelReaderFactory.CreateReader(strem);
            var result = ler.AsDataSet();
            var tabela = result.Tables.Cast<DataTable>();
            foreach (DataTable tabe in tabela)
            {
                dataGridView1.DataSource = tabe;
            }
         }
        private void salvardados()
        {
            try
            {
                for (int i = 1; i < dataGridView1.RowCount; i++)
                {



                    int quant = Convert.ToInt16(dataGridView1[5, i].Value);
                    if (quant >= 0)
                    {

                        var categora= dataGridView1[0, i].Value.ToString();
                        var produto = dataGridView1[1, i].Value.ToString();
                        var medidas = dataGridView1[2, i].Value.ToString();
                        var grandeza = dataGridView1[3, i].Value.ToString();
                        var qty =Convert.ToDecimal( dataGridView1[4, i].Value.ToString());
                        var preco =Convert.ToDecimal( dataGridView1[5, i].Value.ToString());
                        var fornecedor = dataGridView1[6, i].Value.ToString();
                        decimal obschek = Math.Abs(preco - quant);

                        int idcategoria = 0;
                        //cadastrar produto
                        var vercategria = tete.categoria.Where(f => f.proCategorias.Trim().Equals(categora)).FirstOrDefault();
                        if (vercategria != null)
                        {
                            idcategoria = vercategria.idcate;
                        }
                        else
                        {
                            categoria c = new categoria();
                            c.proCategorias = categora;
                            c.Descricao = categora;
                            tete.categoria.Add(c);
                            idcategoria = c.idcate;
                        }
                        Random g = new Random();
                        produtos pro = new produtos();
                        pro.idcategoria = idcategoria;
                        pro.tamanhos_pro = medidas+grandeza;
                        pro.produtos_nome = produto;
                        pro.Descricao = fornecedor;
                        pro.codproduto =g.Next(999999).ToString() ;
                        pro.prexo_venda = preco;
                        
                       
                        tete.produtos.Add(pro);


                        Precos_pro pr = new Precos_pro();
                        pr.preco_pro = preco;
                        pr.idpro = pro.idprodutos;
                        pr.Kilogramas = 0; // multiplicar com a quantidade de chapas
                        pr.Observacao = "Cadastro inicial";
                        pr.areatotal = 0;
                        pr.qtypro = qty;
                        tete.Precos_pro.Add(pr);
                        tete.SaveChanges();


                    }
                }
            }

            catch (Exception x)
            {

                throw new Exception(x.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            salvardados();
        }
    }
}
