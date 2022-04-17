namespace GesObras
{
    partial class receberpro
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label nomeLabel;
            System.Windows.Forms.Label nuitLabel;
            System.Windows.Forms.Label nfacturaLabel;
            this.radSplitContainer1 = new Telerik.WinControls.UI.RadSplitContainer();
            this.splitPanel1 = new Telerik.WinControls.UI.SplitPanel();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.radButton1 = new Telerik.WinControls.UI.RadButton();
            this.nfacturaTextBox = new System.Windows.Forms.TextBox();
            this.nuitTextBox = new System.Windows.Forms.TextBox();
            this.nomeTextBox = new System.Windows.Forms.TextBox();
            this.splitPanel2 = new Telerik.WinControls.UI.SplitPanel();
            this.viewrequizicaoDataGridView = new System.Windows.Forms.DataGridView();
            this.idpprod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proCategorias = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.produtos_nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tamanhos_pro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.viewrequizicaoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            nomeLabel = new System.Windows.Forms.Label();
            nuitLabel = new System.Windows.Forms.Label();
            nfacturaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.radSplitContainer1)).BeginInit();
            this.radSplitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitPanel1)).BeginInit();
            this.splitPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitPanel2)).BeginInit();
            this.splitPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.viewrequizicaoDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewrequizicaoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // nomeLabel
            // 
            nomeLabel.AutoSize = true;
            nomeLabel.Font = new System.Drawing.Font("Segoe UI", 10F);
            nomeLabel.Location = new System.Drawing.Point(7, 41);
            nomeLabel.Name = "nomeLabel";
            nomeLabel.Size = new System.Drawing.Size(81, 19);
            nomeLabel.TabIndex = 0;
            nomeLabel.Text = "Fornecedor:";
            // 
            // nuitLabel
            // 
            nuitLabel.AutoSize = true;
            nuitLabel.Font = new System.Drawing.Font("Segoe UI", 10F);
            nuitLabel.Location = new System.Drawing.Point(9, 69);
            nuitLabel.Name = "nuitLabel";
            nuitLabel.Size = new System.Drawing.Size(38, 19);
            nuitLabel.TabIndex = 2;
            nuitLabel.Text = "Nuit:";
            // 
            // nfacturaLabel
            // 
            nfacturaLabel.AutoSize = true;
            nfacturaLabel.Font = new System.Drawing.Font("Segoe UI", 10F);
            nfacturaLabel.Location = new System.Drawing.Point(324, 44);
            nfacturaLabel.Name = "nfacturaLabel";
            nfacturaLabel.Size = new System.Drawing.Size(68, 19);
            nfacturaLabel.TabIndex = 4;
            nfacturaLabel.Text = "N factura:";
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
            this.radSplitContainer1.Size = new System.Drawing.Size(733, 450);
            this.radSplitContainer1.TabIndex = 0;
            this.radSplitContainer1.TabStop = false;
            this.radSplitContainer1.Text = "radSplitContainer1";
            // 
            // splitPanel1
            // 
            this.splitPanel1.Controls.Add(this.radLabel1);
            this.splitPanel1.Controls.Add(this.radButton1);
            this.splitPanel1.Controls.Add(nfacturaLabel);
            this.splitPanel1.Controls.Add(this.nfacturaTextBox);
            this.splitPanel1.Controls.Add(nuitLabel);
            this.splitPanel1.Controls.Add(this.nuitTextBox);
            this.splitPanel1.Controls.Add(nomeLabel);
            this.splitPanel1.Controls.Add(this.nomeTextBox);
            this.splitPanel1.Location = new System.Drawing.Point(0, 0);
            this.splitPanel1.Name = "splitPanel1";
            // 
            // 
            // 
            this.splitPanel1.RootElement.MinSize = new System.Drawing.Size(25, 25);
            this.splitPanel1.Size = new System.Drawing.Size(733, 105);
            this.splitPanel1.SizeInfo.AutoSizeScale = new System.Drawing.SizeF(0F, -0.2651007F);
            this.splitPanel1.SizeInfo.SplitterCorrection = new System.Drawing.Size(0, -119);
            this.splitPanel1.TabIndex = 0;
            this.splitPanel1.TabStop = false;
            this.splitPanel1.Text = "splitPanel1";
            // 
            // radLabel1
            // 
            this.radLabel1.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.radLabel1.Location = new System.Drawing.Point(9, 5);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(93, 33);
            this.radLabel1.TabIndex = 7;
            this.radLabel1.Text = "Entradas";
            // 
            // radButton1
            // 
            this.radButton1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.radButton1.Location = new System.Drawing.Point(588, 57);
            this.radButton1.Name = "radButton1";
            this.radButton1.Size = new System.Drawing.Size(130, 37);
            this.radButton1.TabIndex = 6;
            this.radButton1.Text = "Confirmar";
            this.radButton1.ThemeName = "Office2010Silver";
            this.radButton1.Click += new System.EventHandler(this.radButton1_Click);
            // 
            // nfacturaTextBox
            // 
            this.nfacturaTextBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.nfacturaTextBox.Location = new System.Drawing.Point(398, 41);
            this.nfacturaTextBox.Name = "nfacturaTextBox";
            this.nfacturaTextBox.Size = new System.Drawing.Size(100, 25);
            this.nfacturaTextBox.TabIndex = 5;
            // 
            // nuitTextBox
            // 
            this.nuitTextBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.nuitTextBox.Location = new System.Drawing.Point(91, 69);
            this.nuitTextBox.Name = "nuitTextBox";
            this.nuitTextBox.ReadOnly = true;
            this.nuitTextBox.Size = new System.Drawing.Size(186, 25);
            this.nuitTextBox.TabIndex = 3;
            // 
            // nomeTextBox
            // 
            this.nomeTextBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.nomeTextBox.Location = new System.Drawing.Point(92, 41);
            this.nomeTextBox.Name = "nomeTextBox";
            this.nomeTextBox.ReadOnly = true;
            this.nomeTextBox.Size = new System.Drawing.Size(188, 25);
            this.nomeTextBox.TabIndex = 1;
            // 
            // splitPanel2
            // 
            this.splitPanel2.Controls.Add(this.viewrequizicaoDataGridView);
            this.splitPanel2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.splitPanel2.Location = new System.Drawing.Point(0, 108);
            this.splitPanel2.Name = "splitPanel2";
            // 
            // 
            // 
            this.splitPanel2.RootElement.MinSize = new System.Drawing.Size(25, 25);
            this.splitPanel2.Size = new System.Drawing.Size(733, 342);
            this.splitPanel2.SizeInfo.AutoSizeScale = new System.Drawing.SizeF(0F, 0.2651007F);
            this.splitPanel2.SizeInfo.SplitterCorrection = new System.Drawing.Size(0, 119);
            this.splitPanel2.TabIndex = 1;
            this.splitPanel2.TabStop = false;
            this.splitPanel2.Text = "splitPanel2";
            // 
            // viewrequizicaoDataGridView
            // 
            this.viewrequizicaoDataGridView.AllowUserToAddRows = false;
            this.viewrequizicaoDataGridView.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.viewrequizicaoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.viewrequizicaoDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idpprod,
            this.proCategorias,
            this.produtos_nome,
            this.tamanhos_pro,
            this.qty,
            this.valor});
            this.viewrequizicaoDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.viewrequizicaoDataGridView.Location = new System.Drawing.Point(0, 0);
            this.viewrequizicaoDataGridView.Name = "viewrequizicaoDataGridView";
            this.viewrequizicaoDataGridView.Size = new System.Drawing.Size(733, 342);
            this.viewrequizicaoDataGridView.TabIndex = 0;
            // 
            // idpprod
            // 
            this.idpprod.HeaderText = "N";
            this.idpprod.Name = "idpprod";
            // 
            // proCategorias
            // 
            this.proCategorias.HeaderText = "Categoria";
            this.proCategorias.Name = "proCategorias";
            // 
            // produtos_nome
            // 
            this.produtos_nome.HeaderText = "produto";
            this.produtos_nome.Name = "produtos_nome";
            // 
            // tamanhos_pro
            // 
            this.tamanhos_pro.HeaderText = "M";
            this.tamanhos_pro.Name = "tamanhos_pro";
            // 
            // qty
            // 
            this.qty.HeaderText = "Qty";
            this.qty.Name = "qty";
            // 
            // valor
            // 
            this.valor.HeaderText = "Preco";
            this.valor.Name = "valor";
            // 
            // viewrequizicaoBindingSource
            // 
            this.viewrequizicaoBindingSource.DataSource = typeof(dbges.viewrequizicao);
            // 
            // receberpro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 450);
            this.Controls.Add(this.radSplitContainer1);
            this.Name = "receberpro";
            this.ShowIcon = false;
            this.Text = "receberpro";
            this.Load += new System.EventHandler(this.receberpro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radSplitContainer1)).EndInit();
            this.radSplitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitPanel1)).EndInit();
            this.splitPanel1.ResumeLayout(false);
            this.splitPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitPanel2)).EndInit();
            this.splitPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.viewrequizicaoDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewrequizicaoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadSplitContainer radSplitContainer1;
        private Telerik.WinControls.UI.SplitPanel splitPanel1;
        private Telerik.WinControls.UI.RadButton radButton1;
        private System.Windows.Forms.TextBox nfacturaTextBox;
        private System.Windows.Forms.TextBox nuitTextBox;
        private System.Windows.Forms.TextBox nomeTextBox;
        private Telerik.WinControls.UI.SplitPanel splitPanel2;
        private System.Windows.Forms.DataGridView viewrequizicaoDataGridView;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private System.Windows.Forms.BindingSource viewrequizicaoBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idpprod;
        private System.Windows.Forms.DataGridViewTextBoxColumn proCategorias;
        private System.Windows.Forms.DataGridViewTextBoxColumn produtos_nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn tamanhos_pro;
        private System.Windows.Forms.DataGridViewTextBoxColumn qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn valor;
    }
}