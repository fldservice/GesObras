namespace GesObras
{
    partial class frmAddservicObras
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddservicObras));
            this.radSplitContainer1 = new Telerik.WinControls.UI.RadSplitContainer();
            this.splitPanel1 = new Telerik.WinControls.UI.SplitPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radButton1 = new Telerik.WinControls.UI.RadButton();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.textpUnit = new System.Windows.Forms.TextBox();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtQuantidade = new System.Windows.Forms.TextBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textpro_nome = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.splitPanel2 = new Telerik.WinControls.UI.SplitPanel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.refer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nomeprodutos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrexoVenda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saldose = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valors = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idvendass = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.radSplitContainer1)).BeginInit();
            this.radSplitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitPanel1)).BeginInit();
            this.splitPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).BeginInit();
            this.panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitPanel2)).BeginInit();
            this.splitPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // radSplitContainer1
            // 
            this.radSplitContainer1.Controls.Add(this.splitPanel1);
            this.radSplitContainer1.Controls.Add(this.splitPanel2);
            this.radSplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radSplitContainer1.Location = new System.Drawing.Point(0, 0);
            this.radSplitContainer1.Name = "radSplitContainer1";
            this.radSplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // 
            // 
            this.radSplitContainer1.RootElement.MinSize = new System.Drawing.Size(25, 25);
            this.radSplitContainer1.Size = new System.Drawing.Size(919, 426);
            this.radSplitContainer1.TabIndex = 0;
            this.radSplitContainer1.TabStop = false;
            this.radSplitContainer1.Text = "radSplitContainer1";
            // 
            // splitPanel1
            // 
            this.splitPanel1.Controls.Add(this.groupBox1);
            this.splitPanel1.Location = new System.Drawing.Point(0, 0);
            this.splitPanel1.Name = "splitPanel1";
            // 
            // 
            // 
            this.splitPanel1.RootElement.MinSize = new System.Drawing.Size(25, 25);
            this.splitPanel1.Size = new System.Drawing.Size(919, 96);
            this.splitPanel1.SizeInfo.AutoSizeScale = new System.Drawing.SizeF(0F, -0.2732558F);
            this.splitPanel1.SizeInfo.SplitterCorrection = new System.Drawing.Size(0, -83);
            this.splitPanel1.TabIndex = 0;
            this.splitPanel1.TabStop = false;
            this.splitPanel1.Text = "splitPanel1";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.radButton1);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.panel9);
            this.groupBox1.Controls.Add(this.panel3);
            this.groupBox1.Controls.Add(this.panel2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.groupBox1.Location = new System.Drawing.Point(13, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(906, 81);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "buscar produto";
            // 
            // radButton1
            // 
            this.radButton1.Location = new System.Drawing.Point(744, 34);
            this.radButton1.Name = "radButton1";
            this.radButton1.Size = new System.Drawing.Size(130, 33);
            this.radButton1.TabIndex = 4;
            this.radButton1.Text = "Salvar";
            this.radButton1.Click += new System.EventHandler(this.radButton1_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.label8.Location = new System.Drawing.Point(601, 24);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 16);
            this.label8.TabIndex = 3;
            this.label8.Text = "Pr_Unit";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.label7.Location = new System.Drawing.Point(436, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 16);
            this.label7.TabIndex = 3;
            this.label7.Text = "Quant";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.label6.Location = new System.Drawing.Point(48, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 16);
            this.label6.TabIndex = 3;
            this.label6.Text = "Designacao";
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.textpUnit);
            this.panel9.Controls.Add(this.pictureBox10);
            this.panel9.Location = new System.Drawing.Point(543, 43);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(195, 29);
            this.panel9.TabIndex = 2;
            // 
            // textpUnit
            // 
            this.textpUnit.Dock = System.Windows.Forms.DockStyle.Right;
            this.textpUnit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textpUnit.Location = new System.Drawing.Point(57, 0);
            this.textpUnit.Name = "textpUnit";
            this.textpUnit.Size = new System.Drawing.Size(138, 26);
            this.textpUnit.TabIndex = 0;
            // 
            // pictureBox10
            // 
            this.pictureBox10.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox10.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox10.Image")));
            this.pictureBox10.Location = new System.Drawing.Point(0, 0);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(51, 29);
            this.pictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox10.TabIndex = 1;
            this.pictureBox10.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txtQuantidade);
            this.panel3.Controls.Add(this.pictureBox3);
            this.panel3.Location = new System.Drawing.Point(386, 43);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(142, 29);
            this.panel3.TabIndex = 1;
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.Dock = System.Windows.Forms.DockStyle.Right;
            this.txtQuantidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtQuantidade.Location = new System.Drawing.Point(53, 0);
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(89, 26);
            this.txtQuantidade.TabIndex = 0;
            this.txtQuantidade.Text = "1";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(0, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(51, 29);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox3.TabIndex = 1;
            this.pictureBox3.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.textpro_nome);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Location = new System.Drawing.Point(6, 43);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(374, 32);
            this.panel2.TabIndex = 0;
            // 
            // textpro_nome
            // 
            this.textpro_nome.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.textpro_nome.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.textpro_nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textpro_nome.Location = new System.Drawing.Point(41, 3);
            this.textpro_nome.Name = "textpro_nome";
            this.textpro_nome.Size = new System.Drawing.Size(327, 26);
            this.textpro_nome.TabIndex = 0;
            this.textpro_nome.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textpro_nome_KeyUp);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(51, 32);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // splitPanel2
            // 
            this.splitPanel2.Controls.Add(this.dataGridView1);
            this.splitPanel2.Location = new System.Drawing.Point(0, 99);
            this.splitPanel2.Name = "splitPanel2";
            // 
            // 
            // 
            this.splitPanel2.RootElement.MinSize = new System.Drawing.Size(25, 25);
            this.splitPanel2.Size = new System.Drawing.Size(919, 327);
            this.splitPanel2.SizeInfo.AutoSizeScale = new System.Drawing.SizeF(0F, 0.2732558F);
            this.splitPanel2.SizeInfo.SplitterCorrection = new System.Drawing.Size(0, 83);
            this.splitPanel2.TabIndex = 1;
            this.splitPanel2.TabStop = false;
            this.splitPanel2.Text = "splitPanel2";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.refer,
            this.Nomeprodutos,
            this.PrexoVenda,
            this.Quantidade,
            this.saldose,
            this.Valors,
            this.idvendass});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(919, 327);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.dataGridView1_KeyUp);
            // 
            // id
            // 
            this.id.HeaderText = "Idproduto";
            this.id.Name = "id";
            this.id.Visible = false;
            // 
            // refer
            // 
            this.refer.HeaderText = "refe";
            this.refer.Name = "refer";
            // 
            // Nomeprodutos
            // 
            this.Nomeprodutos.HeaderText = "Designação";
            this.Nomeprodutos.Name = "Nomeprodutos";
            this.Nomeprodutos.Width = 350;
            // 
            // PrexoVenda
            // 
            this.PrexoVenda.HeaderText = "P_Unit";
            this.PrexoVenda.Name = "PrexoVenda";
            // 
            // Quantidade
            // 
            this.Quantidade.HeaderText = "Quant";
            this.Quantidade.Name = "Quantidade";
            this.Quantidade.Width = 50;
            // 
            // saldose
            // 
            this.saldose.HeaderText = "sal";
            this.saldose.Name = "saldose";
            this.saldose.Visible = false;
            // 
            // Valors
            // 
            this.Valors.HeaderText = "Total";
            this.Valors.Name = "Valors";
            // 
            // idvendass
            // 
            this.idvendass.HeaderText = "idvendasss";
            this.idvendass.Name = "idvendass";
            this.idvendass.Visible = false;
            // 
            // frmAddservicObras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(919, 426);
            this.Controls.Add(this.radSplitContainer1);
            this.Name = "frmAddservicObras";
            this.Text = "frmAddservicObras";
            this.Load += new System.EventHandler(this.frmAddservicObras_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radSplitContainer1)).EndInit();
            this.radSplitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitPanel1)).EndInit();
            this.splitPanel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).EndInit();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitPanel2)).EndInit();
            this.splitPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadSplitContainer radSplitContainer1;
        private Telerik.WinControls.UI.SplitPanel splitPanel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private Telerik.WinControls.UI.RadButton radButton1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.TextBox textpUnit;
        private System.Windows.Forms.PictureBox pictureBox10;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtQuantidade;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textpro_nome;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Telerik.WinControls.UI.SplitPanel splitPanel2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn refer;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nomeprodutos;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrexoVenda;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn saldose;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valors;
        private System.Windows.Forms.DataGridViewTextBoxColumn idvendass;
    }
}