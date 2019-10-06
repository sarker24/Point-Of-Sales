namespace AssetInventory
{
    partial class frmUserMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUserMenu));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.BtnSave = new System.Windows.Forms.Button();
            this.cmbUserList = new System.Windows.Forms.ComboBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.grdUserMenu = new System.Windows.Forms.DataGridView();
            this.chkScreen = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.MenuCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MenuName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ScreenCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ScreenName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ScreenDisplay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdUserMenu)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnClose);
            this.groupBox1.Controls.Add(this.BtnSave);
            this.groupBox1.Controls.Add(this.cmbUserList);
            this.groupBox1.Controls.Add(this.txtUserName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(0, 46);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(506, 70);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Image = global::AssetInventory.Properties.Resources.Close1;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(357, 38);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(69, 25);
            this.btnClose.TabIndex = 9;
            this.btnClose.Text = "&Close";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // BtnSave
            // 
            this.BtnSave.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BtnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSave.Image = ((System.Drawing.Image)(resources.GetObject("BtnSave.Image")));
            this.BtnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnSave.Location = new System.Drawing.Point(430, 38);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(69, 25);
            this.BtnSave.TabIndex = 8;
            this.BtnSave.Text = "&Save";
            this.BtnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnSave.UseVisualStyleBackColor = false;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // cmbUserList
            // 
            this.cmbUserList.DisplayMember = "SoftUser";
            this.cmbUserList.FormattingEnabled = true;
            this.cmbUserList.Location = new System.Drawing.Point(60, 12);
            this.cmbUserList.Name = "cmbUserList";
            this.cmbUserList.Size = new System.Drawing.Size(154, 21);
            this.cmbUserList.TabIndex = 7;
            this.cmbUserList.ValueMember = "UserInfoId";
            this.cmbUserList.SelectedValueChanged += new System.EventHandler(this.cmbUserList_SelectedValueChanged);
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(293, 12);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(206, 20);
            this.txtUserName.TabIndex = 3;
            this.txtUserName.TextChanged += new System.EventHandler(this.txtUserName_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(220, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "User Name  :";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "User ID :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.grdUserMenu);
            this.groupBox2.Location = new System.Drawing.Point(0, 115);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(506, 423);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // grdUserMenu
            // 
            this.grdUserMenu.AllowUserToAddRows = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(240)))), ((int)(((byte)(250)))));
            this.grdUserMenu.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.grdUserMenu.BackgroundColor = System.Drawing.Color.White;
            this.grdUserMenu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdUserMenu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.chkScreen,
            this.MenuCode,
            this.MenuName,
            this.ScreenCode,
            this.ScreenName,
            this.ScreenDisplay});
            this.grdUserMenu.Location = new System.Drawing.Point(6, 11);
            this.grdUserMenu.Name = "grdUserMenu";
            this.grdUserMenu.Size = new System.Drawing.Size(493, 404);
            this.grdUserMenu.TabIndex = 0;
            // 
            // chkScreen
            // 
            this.chkScreen.FillWeight = 13.60544F;
            this.chkScreen.HeaderText = "";
            this.chkScreen.Name = "chkScreen";
            this.chkScreen.TrueValue = "1";
            this.chkScreen.Width = 20;
            // 
            // MenuCode
            // 
            this.MenuCode.DataPropertyName = "MenuCode";
            this.MenuCode.HeaderText = "Menu Code";
            this.MenuCode.Name = "MenuCode";
            this.MenuCode.Visible = false;
            // 
            // MenuName
            // 
            this.MenuName.DataPropertyName = "MenuDescription";
            this.MenuName.FillWeight = 120.0456F;
            this.MenuName.HeaderText = "Menu Name";
            this.MenuName.Name = "MenuName";
            this.MenuName.Width = 176;
            // 
            // ScreenCode
            // 
            this.ScreenCode.DataPropertyName = "ScreenCode";
            this.ScreenCode.HeaderText = "Screen Code";
            this.ScreenCode.Name = "ScreenCode";
            this.ScreenCode.Visible = false;
            // 
            // ScreenName
            // 
            this.ScreenName.DataPropertyName = "FormName";
            this.ScreenName.HeaderText = "Screen Name";
            this.ScreenName.Name = "ScreenName";
            this.ScreenName.Visible = false;
            this.ScreenName.Width = 245;
            // 
            // ScreenDisplay
            // 
            this.ScreenDisplay.DataPropertyName = "ScreenName";
            this.ScreenDisplay.FillWeight = 166.3489F;
            this.ScreenDisplay.HeaderText = "Display Name";
            this.ScreenDisplay.Name = "ScreenDisplay";
            this.ScreenDisplay.Width = 245;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::AssetInventory.Properties.Resources.form_banner;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label12);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(510, 46);
            this.panel1.TabIndex = 26;
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(201, 8);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(296, 24);
            this.label12.TabIndex = 20;
            this.label12.Text = "User Menu Setup";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // frmUserMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(242)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(510, 540);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmUserMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "User Menu Setup";
            this.Load += new System.EventHandler(this.frmUserMenu_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdUserMenu)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView grdUserMenu;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn chkScreen;
        private System.Windows.Forms.DataGridViewTextBoxColumn MenuCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn MenuName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ScreenCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn ScreenName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ScreenDisplay;
        private System.Windows.Forms.ComboBox cmbUserList;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label12;
    }
}