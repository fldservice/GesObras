using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GesObras
{
    public partial class MDIParent1 : Form
    {
        private int childFormNumber = 0;

        public MDIParent1()
        {
            InitializeComponent();
        }

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
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void MDIParent1_Load(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Bem vindo(a) :" + user;

        }
        public string user { get; set; }
        private void radRibbonBar1_Click(object sender, EventArgs e)
        {
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
          requizicoess pro = new requizicoess();
            pro.MdiParent = this;
            pro.Show();
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
            AboutBox1 d = new AboutBox1();
            d.ShowDialog();
        }

        private void radButtonElement10_Click(object sender, EventArgs e)
        {
            gesreport.frmentradasver g = new gesreport.frmentradasver();
            g.ShowDialog();
        }
    }
}
