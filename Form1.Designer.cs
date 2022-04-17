namespace GesObras
{
    partial class Form1
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
            System.Windows.Forms.Label contactocliLabel;
            System.Windows.Forms.Label emailcliLabel;
            System.Windows.Forms.Label enderecocliLabel;
            System.Windows.Forms.Label idclientesLabel;
            System.Windows.Forms.Label nomecliLabel;
            System.Windows.Forms.Label nuitLabel;
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.contactocliTextBox = new System.Windows.Forms.TextBox();
            this.clientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.emailcliTextBox = new System.Windows.Forms.TextBox();
            this.enderecocliTextBox = new System.Windows.Forms.TextBox();
            this.idclientesTextBox = new System.Windows.Forms.TextBox();
            this.nomecliTextBox = new System.Windows.Forms.TextBox();
            this.nuitTextBox = new System.Windows.Forms.TextBox();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.radTextBox1 = new Telerik.WinControls.UI.RadTextBox();
            this.clientesDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.eliminarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            contactocliLabel = new System.Windows.Forms.Label();
            emailcliLabel = new System.Windows.Forms.Label();
            enderecocliLabel = new System.Windows.Forms.Label();
            idclientesLabel = new System.Windows.Forms.Label();
            nomecliLabel = new System.Windows.Forms.Label();
            nuitLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radTextBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesDataGridView)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // contactocliLabel
            // 
            contactocliLabel.AutoSize = true;
            contactocliLabel.Location = new System.Drawing.Point(42, 120);
            contactocliLabel.Name = "contactocliLabel";
            contactocliLabel.Size = new System.Drawing.Size(68, 17);
            contactocliLabel.TabIndex = 0;
            contactocliLabel.Text = "Contacto:";
            // 
            // emailcliLabel
            // 
            emailcliLabel.AutoSize = true;
            emailcliLabel.Location = new System.Drawing.Point(42, 146);
            emailcliLabel.Name = "emailcliLabel";
            emailcliLabel.Size = new System.Drawing.Size(46, 17);
            emailcliLabel.TabIndex = 2;
            emailcliLabel.Text = "Email:";
            // 
            // enderecocliLabel
            // 
            enderecocliLabel.AutoSize = true;
            enderecocliLabel.Location = new System.Drawing.Point(42, 172);
            enderecocliLabel.Name = "enderecocliLabel";
            enderecocliLabel.Size = new System.Drawing.Size(73, 17);
            enderecocliLabel.TabIndex = 4;
            enderecocliLabel.Text = "Endereco:";
            // 
            // idclientesLabel
            // 
            idclientesLabel.AutoSize = true;
            idclientesLabel.Location = new System.Drawing.Point(42, 62);
            idclientesLabel.Name = "idclientesLabel";
            idclientesLabel.Size = new System.Drawing.Size(18, 17);
            idclientesLabel.TabIndex = 6;
            idclientesLabel.Text = "N";
            // 
            // nomecliLabel
            // 
            nomecliLabel.AutoSize = true;
            nomecliLabel.Location = new System.Drawing.Point(42, 91);
            nomecliLabel.Name = "nomecliLabel";
            nomecliLabel.Size = new System.Drawing.Size(49, 17);
            nomecliLabel.TabIndex = 8;
            nomecliLabel.Text = "Nome:";
            // 
            // nuitLabel
            // 
            nuitLabel.AutoSize = true;
            nuitLabel.Location = new System.Drawing.Point(42, 201);
            nuitLabel.Name = "nuitLabel";
            nuitLabel.Size = new System.Drawing.Size(37, 17);
            nuitLabel.TabIndex = 10;
            nuitLabel.Text = "Nuit:";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.radLabel1);
            this.splitContainer1.Panel1.Controls.Add(this.button3);
            this.splitContainer1.Panel1.Controls.Add(this.button2);
            this.splitContainer1.Panel1.Controls.Add(this.button1);
            this.splitContainer1.Panel1.Controls.Add(contactocliLabel);
            this.splitContainer1.Panel1.Controls.Add(this.contactocliTextBox);
            this.splitContainer1.Panel1.Controls.Add(emailcliLabel);
            this.splitContainer1.Panel1.Controls.Add(this.emailcliTextBox);
            this.splitContainer1.Panel1.Controls.Add(enderecocliLabel);
            this.splitContainer1.Panel1.Controls.Add(this.enderecocliTextBox);
            this.splitContainer1.Panel1.Controls.Add(idclientesLabel);
            this.splitContainer1.Panel1.Controls.Add(this.idclientesTextBox);
            this.splitContainer1.Panel1.Controls.Add(nomecliLabel);
            this.splitContainer1.Panel1.Controls.Add(this.nomecliTextBox);
            this.splitContainer1.Panel1.Controls.Add(nuitLabel);
            this.splitContainer1.Panel1.Controls.Add(this.nuitTextBox);
            this.splitContainer1.Panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(764, 323);
            this.splitContainer1.SplitterDistance = 361;
            this.splitContainer1.TabIndex = 0;
            // 
            // radLabel1
            // 
            this.radLabel1.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.radLabel1.Location = new System.Drawing.Point(40, 12);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(183, 33);
            this.radLabel1.TabIndex = 14;
            this.radLabel1.Text = "Ordem de Serviço";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(243, 252);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(103, 42);
            this.button3.TabIndex = 13;
            this.button3.Text = "Actualizar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(134, 252);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(103, 42);
            this.button2.TabIndex = 13;
            this.button2.Text = "Salvar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Image = global::GesObras.Properties.Resources.plus_32px;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(19, 252);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 42);
            this.button1.TabIndex = 12;
            this.button1.Text = "Novo";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // contactocliTextBox
            // 
            this.contactocliTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientesBindingSource, "contactocli", true));
            this.contactocliTextBox.Location = new System.Drawing.Point(130, 117);
            this.contactocliTextBox.Name = "contactocliTextBox";
            this.contactocliTextBox.Size = new System.Drawing.Size(173, 23);
            this.contactocliTextBox.TabIndex = 1;
            // 
            // clientesBindingSource
            // 
            this.clientesBindingSource.DataSource = typeof(dbges.Clientes);
            // 
            // emailcliTextBox
            // 
            this.emailcliTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientesBindingSource, "emailcli", true));
            this.emailcliTextBox.Location = new System.Drawing.Point(130, 143);
            this.emailcliTextBox.Name = "emailcliTextBox";
            this.emailcliTextBox.Size = new System.Drawing.Size(173, 23);
            this.emailcliTextBox.TabIndex = 3;
            // 
            // enderecocliTextBox
            // 
            this.enderecocliTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientesBindingSource, "enderecocli", true));
            this.enderecocliTextBox.Location = new System.Drawing.Point(130, 169);
            this.enderecocliTextBox.Name = "enderecocliTextBox";
            this.enderecocliTextBox.Size = new System.Drawing.Size(173, 23);
            this.enderecocliTextBox.TabIndex = 5;
            // 
            // idclientesTextBox
            // 
            this.idclientesTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientesBindingSource, "idclientes", true));
            this.idclientesTextBox.Location = new System.Drawing.Point(130, 59);
            this.idclientesTextBox.Name = "idclientesTextBox";
            this.idclientesTextBox.Size = new System.Drawing.Size(173, 23);
            this.idclientesTextBox.TabIndex = 7;
            // 
            // nomecliTextBox
            // 
            this.nomecliTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientesBindingSource, "nomecli", true));
            this.nomecliTextBox.Location = new System.Drawing.Point(130, 88);
            this.nomecliTextBox.Name = "nomecliTextBox";
            this.nomecliTextBox.Size = new System.Drawing.Size(173, 23);
            this.nomecliTextBox.TabIndex = 9;
            // 
            // nuitTextBox
            // 
            this.nuitTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientesBindingSource, "Nuit", true));
            this.nuitTextBox.Location = new System.Drawing.Point(130, 198);
            this.nuitTextBox.Name = "nuitTextBox";
            this.nuitTextBox.Size = new System.Drawing.Size(173, 23);
            this.nuitTextBox.TabIndex = 11;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.radLabel2);
            this.splitContainer2.Panel1.Controls.Add(this.radTextBox1);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.AutoScroll = true;
            this.splitContainer2.Panel2.Controls.Add(this.clientesDataGridView);
            this.splitContainer2.Panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.splitContainer2.Size = new System.Drawing.Size(399, 323);
            this.splitContainer2.SplitterDistance = 37;
            this.splitContainer2.TabIndex = 0;
            // 
            // radLabel2
            // 
            this.radLabel2.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.radLabel2.Location = new System.Drawing.Point(17, 5);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(61, 29);
            this.radLabel2.TabIndex = 14;
            this.radLabel2.Text = "Nome";
            // 
            // radTextBox1
            // 
            this.radTextBox1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.radTextBox1.Location = new System.Drawing.Point(100, 7);
            this.radTextBox1.Name = "radTextBox1";
            this.radTextBox1.Size = new System.Drawing.Size(251, 27);
            this.radTextBox1.TabIndex = 0;
            this.radTextBox1.TabStop = false;
            this.radTextBox1.ThemeName = "Office2010Silver";
            this.radTextBox1.TextChanged += new System.EventHandler(this.radTextBox1_TextChanged);
            // 
            // clientesDataGridView
            // 
            this.clientesDataGridView.AllowUserToAddRows = false;
            this.clientesDataGridView.AutoGenerateColumns = false;
            this.clientesDataGridView.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.clientesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.clientesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.clientesDataGridView.ContextMenuStrip = this.contextMenuStrip1;
            this.clientesDataGridView.DataSource = this.clientesBindingSource;
            this.clientesDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clientesDataGridView.Location = new System.Drawing.Point(0, 0);
            this.clientesDataGridView.Name = "clientesDataGridView";
            this.clientesDataGridView.Size = new System.Drawing.Size(399, 282);
            this.clientesDataGridView.TabIndex = 0;
            this.clientesDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.clientesDataGridView_CellClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "idclientes";
            this.dataGridViewTextBoxColumn1.HeaderText = "N";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "nomecli";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nome";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "enderecocli";
            this.dataGridViewTextBoxColumn3.HeaderText = "Endereco";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "emailcli";
            this.dataGridViewTextBoxColumn4.HeaderText = "emailcli";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "contactocli";
            this.dataGridViewTextBoxColumn5.HeaderText = "contactocli";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Nuit";
            this.dataGridViewTextBoxColumn6.HeaderText = "Nuit";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.eliminarToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(118, 26);
            // 
            // eliminarToolStripMenuItem
            // 
            this.eliminarToolStripMenuItem.Image = global::GesObras.Properties.Resources.delete_sign_75px;
            this.eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
            this.eliminarToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.eliminarToolStripMenuItem.Text = "Eliminar";
            this.eliminarToolStripMenuItem.Click += new System.EventHandler(this.eliminarToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 323);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.ShowIcon = false;
            this.Text = "Clientes";
            this.ThemeName = "Office2010Silver";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).EndInit();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radTextBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesDataGridView)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.DataGridView clientesDataGridView;
        private System.Windows.Forms.BindingSource clientesBindingSource;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox contactocliTextBox;
        private System.Windows.Forms.TextBox emailcliTextBox;
        private System.Windows.Forms.TextBox enderecocliTextBox;
        private System.Windows.Forms.TextBox idclientesTextBox;
        private System.Windows.Forms.TextBox nomecliTextBox;
        private System.Windows.Forms.TextBox nuitTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private Telerik.WinControls.UI.RadTextBox radTextBox1;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem eliminarToolStripMenuItem;
    }
}

