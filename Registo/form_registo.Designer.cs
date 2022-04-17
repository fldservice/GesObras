namespace Gescom.Registo
{
    partial class form_registo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_registo));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metrotplicenca = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroprodId = new MetroFramework.Controls.MetroTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.metroLabel1);
            this.groupBox1.Controls.Add(this.metrotplicenca);
            this.groupBox1.Controls.Add(this.metroLabel4);
            this.groupBox1.Controls.Add(this.metroprodId);
            this.groupBox1.Location = new System.Drawing.Point(10, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(465, 180);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Activar";
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.LavenderBlush;
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(290, 122);
            this.button4.Margin = new System.Windows.Forms.Padding(2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(149, 29);
            this.button4.TabIndex = 19;
            this.button4.Text = "Registrar";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(16, 52);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(72, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Produto Id";
            // 
            // metrotplicenca
            // 
            // 
            // 
            // 
            this.metrotplicenca.CustomButton.Image = null;
            this.metrotplicenca.CustomButton.Location = new System.Drawing.Point(298, 1);
            this.metrotplicenca.CustomButton.Name = "";
            this.metrotplicenca.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metrotplicenca.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metrotplicenca.CustomButton.TabIndex = 1;
            this.metrotplicenca.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metrotplicenca.CustomButton.UseSelectable = true;
            this.metrotplicenca.CustomButton.Visible = false;
            this.metrotplicenca.Lines = new string[0];
            this.metrotplicenca.Location = new System.Drawing.Point(119, 81);
            this.metrotplicenca.MaxLength = 32767;
            this.metrotplicenca.Name = "metrotplicenca";
            this.metrotplicenca.PasswordChar = '\0';
            this.metrotplicenca.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metrotplicenca.SelectedText = "";
            this.metrotplicenca.SelectionLength = 0;
            this.metrotplicenca.SelectionStart = 0;
            this.metrotplicenca.Size = new System.Drawing.Size(320, 23);
            this.metrotplicenca.TabIndex = 1;
            this.metrotplicenca.UseSelectable = true;
            this.metrotplicenca.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metrotplicenca.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(16, 85);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(44, 19);
            this.metroLabel4.TabIndex = 0;
            this.metroLabel4.Text = "Licnça";
            // 
            // metroprodId
            // 
            // 
            // 
            // 
            this.metroprodId.CustomButton.Image = null;
            this.metroprodId.CustomButton.Location = new System.Drawing.Point(298, 1);
            this.metroprodId.CustomButton.Name = "";
            this.metroprodId.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroprodId.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroprodId.CustomButton.TabIndex = 1;
            this.metroprodId.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroprodId.CustomButton.UseSelectable = true;
            this.metroprodId.CustomButton.Visible = false;
            this.metroprodId.Lines = new string[0];
            this.metroprodId.Location = new System.Drawing.Point(119, 52);
            this.metroprodId.MaxLength = 32767;
            this.metroprodId.Name = "metroprodId";
            this.metroprodId.PasswordChar = '\0';
            this.metroprodId.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroprodId.SelectedText = "";
            this.metroprodId.SelectionLength = 0;
            this.metroprodId.SelectionStart = 0;
            this.metroprodId.Size = new System.Drawing.Size(320, 23);
            this.metroprodId.TabIndex = 1;
            this.metroprodId.UseSelectable = true;
            this.metroprodId.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroprodId.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(10, 215);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(465, 140);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // form_registo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 378);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Name = "form_registo";
            this.Text = "Registo";
            this.Load += new System.EventHandler(this.form_registo_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button4;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox metrotplicenca;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTextBox metroprodId;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}