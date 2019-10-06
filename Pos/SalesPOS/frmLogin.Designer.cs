namespace AssetInventory
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.pnl1 = new System.Windows.Forms.Panel();
            this.txtDll_HDDNo = new System.Windows.Forms.TextBox();
            this.chkRemember = new System.Windows.Forms.CheckBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pnl2 = new System.Windows.Forms.Panel();
            this.txtIP = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDBUser = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDBPass = new System.Windows.Forms.TextBox();
            this.btnDBNameGet = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbDBName = new System.Windows.Forms.ComboBox();
            this.pnl3 = new System.Windows.Forms.Panel();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnOption = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.pnl1.SuspendLayout();
            this.pnl2.SuspendLayout();
            this.pnl3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::AssetInventory.Properties.Resources.form_banner;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(360, 42);
            this.panel1.TabIndex = 47;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(358, 40);
            this.label3.TabIndex = 20;
            this.label3.Text = "Login";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnl1
            // 
            this.pnl1.Controls.Add(this.txtDll_HDDNo);
            this.pnl1.Controls.Add(this.chkRemember);
            this.pnl1.Controls.Add(this.txtUserName);
            this.pnl1.Controls.Add(this.txtPassword);
            this.pnl1.Controls.Add(this.label1);
            this.pnl1.Controls.Add(this.label2);
            this.pnl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl1.Location = new System.Drawing.Point(0, 42);
            this.pnl1.Name = "pnl1";
            this.pnl1.Size = new System.Drawing.Size(360, 114);
            this.pnl1.TabIndex = 50;
            // 
            // txtDll_HDDNo
            // 
            this.txtDll_HDDNo.Location = new System.Drawing.Point(13, 81);
            this.txtDll_HDDNo.Name = "txtDll_HDDNo";
            this.txtDll_HDDNo.Size = new System.Drawing.Size(62, 20);
            this.txtDll_HDDNo.TabIndex = 42;
            this.txtDll_HDDNo.Visible = false;
            // 
            // chkRemember
            // 
            this.chkRemember.AutoSize = true;
            this.chkRemember.Location = new System.Drawing.Point(98, 89);
            this.chkRemember.Name = "chkRemember";
            this.chkRemember.Size = new System.Drawing.Size(94, 17);
            this.chkRemember.TabIndex = 41;
            this.chkRemember.Text = "Remember me";
            this.chkRemember.UseVisualStyleBackColor = true;
            // 
            // txtUserName
            // 
            this.txtUserName.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtUserName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUserName.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtUserName.Location = new System.Drawing.Point(98, 14);
            this.txtUserName.MaxLength = 50;
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(234, 21);
            this.txtUserName.TabIndex = 0;
            this.txtUserName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUserName_KeyPress);
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPassword.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPassword.Location = new System.Drawing.Point(98, 42);
            this.txtPassword.MaxLength = 20;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(234, 21);
            this.txtPassword.TabIndex = 1;
            this.txtPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPassword_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(24, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "User Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(24, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Password";
            // 
            // pnl2
            // 
            this.pnl2.Controls.Add(this.txtIP);
            this.pnl2.Controls.Add(this.label7);
            this.pnl2.Controls.Add(this.txtDBUser);
            this.pnl2.Controls.Add(this.label4);
            this.pnl2.Controls.Add(this.label6);
            this.pnl2.Controls.Add(this.txtDBPass);
            this.pnl2.Controls.Add(this.btnDBNameGet);
            this.pnl2.Controls.Add(this.label5);
            this.pnl2.Controls.Add(this.cmbDBName);
            this.pnl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl2.Location = new System.Drawing.Point(0, 156);
            this.pnl2.Name = "pnl2";
            this.pnl2.Size = new System.Drawing.Size(360, 113);
            this.pnl2.TabIndex = 51;
            this.pnl2.Visible = false;
            // 
            // txtIP
            // 
            this.txtIP.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtIP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIP.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtIP.Location = new System.Drawing.Point(98, 6);
            this.txtIP.MaxLength = 30;
            this.txtIP.Name = "txtIP";
            this.txtIP.Size = new System.Drawing.Size(234, 21);
            this.txtIP.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label7.Location = new System.Drawing.Point(24, 35);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 13);
            this.label7.TabIndex = 34;
            this.label7.Text = "DB User";
            // 
            // txtDBUser
            // 
            this.txtDBUser.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtDBUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDBUser.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDBUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtDBUser.Location = new System.Drawing.Point(98, 32);
            this.txtDBUser.MaxLength = 20;
            this.txtDBUser.Name = "txtDBUser";
            this.txtDBUser.Size = new System.Drawing.Size(234, 21);
            this.txtDBUser.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(24, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 36;
            this.label4.Text = "DB Pass";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label6.Location = new System.Drawing.Point(24, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(19, 13);
            this.label6.TabIndex = 41;
            this.label6.Text = "IP";
            // 
            // txtDBPass
            // 
            this.txtDBPass.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtDBPass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDBPass.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDBPass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtDBPass.Location = new System.Drawing.Point(98, 58);
            this.txtDBPass.MaxLength = 20;
            this.txtDBPass.Name = "txtDBPass";
            this.txtDBPass.PasswordChar = '*';
            this.txtDBPass.Size = new System.Drawing.Size(234, 21);
            this.txtDBPass.TabIndex = 4;
            // 
            // btnDBNameGet
            // 
            this.btnDBNameGet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnDBNameGet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDBNameGet.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDBNameGet.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnDBNameGet.Location = new System.Drawing.Point(277, 85);
            this.btnDBNameGet.Name = "btnDBNameGet";
            this.btnDBNameGet.Size = new System.Drawing.Size(55, 21);
            this.btnDBNameGet.TabIndex = 5;
            this.btnDBNameGet.Text = "Get DB";
            this.btnDBNameGet.UseVisualStyleBackColor = false;
            this.btnDBNameGet.Click += new System.EventHandler(this.btnDBNameGet_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(24, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 38;
            this.label5.Text = "DB Name";
            // 
            // cmbDBName
            // 
            this.cmbDBName.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cmbDBName.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDBName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cmbDBName.FormattingEnabled = true;
            this.cmbDBName.Location = new System.Drawing.Point(98, 85);
            this.cmbDBName.Name = "cmbDBName";
            this.cmbDBName.Size = new System.Drawing.Size(173, 21);
            this.cmbDBName.TabIndex = 6;
            // 
            // pnl3
            // 
            this.pnl3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(228)))), ((int)(((byte)(239)))));
            this.pnl3.Controls.Add(this.btnLogin);
            this.pnl3.Controls.Add(this.btnOption);
            this.pnl3.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl3.Location = new System.Drawing.Point(0, 269);
            this.pnl3.Name = "pnl3";
            this.pnl3.Size = new System.Drawing.Size(360, 42);
            this.pnl3.TabIndex = 52;
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnLogin.Location = new System.Drawing.Point(256, 6);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(76, 25);
            this.btnLogin.TabIndex = 7;
            this.btnLogin.Text = "&Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnOption
            // 
            this.btnOption.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnOption.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOption.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnOption.Location = new System.Drawing.Point(174, 6);
            this.btnOption.Name = "btnOption";
            this.btnOption.Size = new System.Drawing.Size(76, 25);
            this.btnOption.TabIndex = 8;
            this.btnOption.Text = "&Option >>";
            this.btnOption.UseVisualStyleBackColor = false;
            this.btnOption.Click += new System.EventHandler(this.btnOption_Click);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(228)))), ((int)(((byte)(239)))));
            this.ClientSize = new System.Drawing.Size(360, 310);
            this.Controls.Add(this.pnl3);
            this.Controls.Add(this.pnl2);
            this.Controls.Add(this.pnl1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "User Login";
            this.TransparencyKey = System.Drawing.Color.Gainsboro;
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.panel1.ResumeLayout(false);
            this.pnl1.ResumeLayout(false);
            this.pnl1.PerformLayout();
            this.pnl2.ResumeLayout(false);
            this.pnl2.PerformLayout();
            this.pnl3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel pnl1;
        private System.Windows.Forms.TextBox txtDll_HDDNo;
        private System.Windows.Forms.CheckBox chkRemember;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pnl2;
        private System.Windows.Forms.TextBox txtIP;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtDBUser;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDBPass;
        private System.Windows.Forms.Button btnDBNameGet;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbDBName;
        private System.Windows.Forms.Panel pnl3;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnOption;


    }
}