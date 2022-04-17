namespace GesObras
{
    partial class loginFom
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
            System.Windows.Forms.Label nomeuserLabel;
            System.Windows.Forms.Label passwordLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(loginFom));
            this.TB_User = new System.Windows.Forms.TextBox();
            this.TB_Password = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.radProgressBar1 = new MetroFramework.Controls.MetroProgressBar();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            nomeuserLabel = new System.Windows.Forms.Label();
            passwordLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // nomeuserLabel
            // 
            nomeuserLabel.AutoSize = true;
            nomeuserLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            nomeuserLabel.Location = new System.Drawing.Point(310, 24);
            nomeuserLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            nomeuserLabel.Name = "nomeuserLabel";
            nomeuserLabel.Size = new System.Drawing.Size(66, 21);
            nomeuserLabel.TabIndex = 3;
            nomeuserLabel.Text = "Usuario";
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            passwordLabel.Location = new System.Drawing.Point(310, 84);
            passwordLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new System.Drawing.Size(68, 21);
            passwordLabel.TabIndex = 5;
            passwordLabel.Text = "Codigo";
            // 
            // TB_User
            // 
            this.TB_User.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usersBindingSource, "nomeuser", true));
            this.TB_User.Location = new System.Drawing.Point(314, 50);
            this.TB_User.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TB_User.Name = "TB_User";
            this.TB_User.Size = new System.Drawing.Size(268, 27);
            this.TB_User.TabIndex = 4;
            // 
            // TB_Password
            // 
            this.TB_Password.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usersBindingSource, "password", true));
            this.TB_Password.Location = new System.Drawing.Point(314, 110);
            this.TB_Password.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TB_Password.Name = "TB_Password";
            this.TB_Password.PasswordChar = '*';
            this.TB_Password.Size = new System.Drawing.Size(268, 27);
            this.TB_Password.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Teal;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(476, 146);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 38);
            this.button1.TabIndex = 7;
            this.button1.Text = "Entrar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button2.Location = new System.Drawing.Point(314, 146);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(107, 38);
            this.button2.TabIndex = 7;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(132, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 19);
            this.label1.TabIndex = 9;
            this.label1.Text = "Ordem de servico";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.Location = new System.Drawing.Point(9, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 21);
            this.label4.TabIndex = 11;
            this.label4.Text = "label2";
            // 
            // radProgressBar1
            // 
            this.radProgressBar1.Location = new System.Drawing.Point(13, 207);
            this.radProgressBar1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radProgressBar1.Name = "radProgressBar1";
            this.radProgressBar1.Size = new System.Drawing.Size(569, 28);
            this.radProgressBar1.Style = MetroFramework.MetroColorStyle.Blue;
            this.radProgressBar1.TabIndex = 31;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(11, 239);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 9);
            this.label2.TabIndex = 9;
            this.label2.Text = "FLDService E.i";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(422, 143);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(53, 40);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 32;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(13, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(289, 154);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // usersBindingSource
            // 
            this.usersBindingSource.DataSource = typeof(dbges.utilizadores);
            // 
            // loginFom
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.CancelButton = this.button2;
            this.ClientSize = new System.Drawing.Size(633, 272);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.radProgressBar1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(nomeuserLabel);
            this.Controls.Add(this.TB_User);
            this.Controls.Add(passwordLabel);
            this.Controls.Add(this.TB_Password);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "loginFom";
            this.Padding = new System.Windows.Forms.Padding(22, 63, 22, 21);
            this.Load += new System.EventHandler(this.loginFom_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource usersBindingSource;
        private System.Windows.Forms.TextBox TB_User;
        private System.Windows.Forms.TextBox TB_Password;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label4;
        private MetroFramework.Controls.MetroProgressBar radProgressBar1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}