namespace AssetInventory
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.lblVersion = new System.Windows.Forms.Label();
            this.lblSoftName = new System.Windows.Forms.Label();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatus_lblUserID = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatus_lblTerminalNo = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel4 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatus_lblTodaysDate = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.Color.SlateGray;
            this.menuStrip.BackgroundImage = global::AssetInventory.Properties.Resources.menu_back;
            this.menuStrip.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1028, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // lblVersion
            // 
            this.lblVersion.AutoSize = true;
            this.lblVersion.BackColor = System.Drawing.Color.Transparent;
            this.lblVersion.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVersion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblVersion.Location = new System.Drawing.Point(63, 94);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(35, 13);
            this.lblVersion.TabIndex = 5;
            this.lblVersion.Text = "label2";
            // 
            // lblSoftName
            // 
            this.lblSoftName.AutoSize = true;
            this.lblSoftName.BackColor = System.Drawing.Color.Transparent;
            this.lblSoftName.Font = new System.Drawing.Font("Times New Roman", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoftName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblSoftName.Location = new System.Drawing.Point(58, 53);
            this.lblSoftName.Name = "lblSoftName";
            this.lblSoftName.Size = new System.Drawing.Size(84, 31);
            this.lblSoftName.TabIndex = 4;
            this.lblSoftName.Text = "label1";
            // 
            // statusStrip
            // 
            this.statusStrip.BackColor = System.Drawing.Color.Transparent;
            this.statusStrip.BackgroundImage = global::AssetInventory.Properties.Resources.menu_back;
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatus_lblUserID,
            this.toolStripStatusLabel2,
            this.toolStripStatus_lblTerminalNo,
            this.toolStripStatusLabel4,
            this.toolStripStatus_lblTodaysDate});
            this.statusStrip.Location = new System.Drawing.Point(0, 720);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(1028, 22);
            this.statusStrip.TabIndex = 6;
            this.statusStrip.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(74, 17);
            this.toolStripStatusLabel1.Text = "Logged User :";
            // 
            // toolStripStatus_lblUserID
            // 
            this.toolStripStatus_lblUserID.ActiveLinkColor = System.Drawing.Color.DarkRed;
            this.toolStripStatus_lblUserID.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripStatus_lblUserID.ForeColor = System.Drawing.Color.DarkRed;
            this.toolStripStatus_lblUserID.Name = "toolStripStatus_lblUserID";
            this.toolStripStatus_lblUserID.Size = new System.Drawing.Size(32, 17);
            this.toolStripStatus_lblUserID.Text = "-----";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(70, 17);
            this.toolStripStatusLabel2.Text = "Terminal No :";
            // 
            // toolStripStatus_lblTerminalNo
            // 
            this.toolStripStatus_lblTerminalNo.ActiveLinkColor = System.Drawing.Color.DarkRed;
            this.toolStripStatus_lblTerminalNo.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripStatus_lblTerminalNo.ForeColor = System.Drawing.Color.DarkRed;
            this.toolStripStatus_lblTerminalNo.Name = "toolStripStatus_lblTerminalNo";
            this.toolStripStatus_lblTerminalNo.Size = new System.Drawing.Size(32, 17);
            this.toolStripStatus_lblTerminalNo.Text = "-----";
            // 
            // toolStripStatusLabel4
            // 
            this.toolStripStatusLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.toolStripStatusLabel4.Name = "toolStripStatusLabel4";
            this.toolStripStatusLabel4.Size = new System.Drawing.Size(69, 17);
            this.toolStripStatusLabel4.Text = "Today date :";
            // 
            // toolStripStatus_lblTodaysDate
            // 
            this.toolStripStatus_lblTodaysDate.ActiveLinkColor = System.Drawing.Color.DarkRed;
            this.toolStripStatus_lblTodaysDate.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripStatus_lblTodaysDate.ForeColor = System.Drawing.Color.DarkRed;
            this.toolStripStatus_lblTodaysDate.Name = "toolStripStatus_lblTodaysDate";
            this.toolStripStatus_lblTodaysDate.Size = new System.Drawing.Size(27, 17);
            this.toolStripStatus_lblTodaysDate.Text = "----";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 742);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.lblVersion);
            this.Controls.Add(this.lblSoftName);
            this.Controls.Add(this.menuStrip);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.Name = "frmMain";
            this.Text = "Easy Sales & Inventory System";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        //private System.Windows.Forms.SplitContainer slipMain;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.Label lblSoftName;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatus_lblUserID;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatus_lblTerminalNo;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel4;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatus_lblTodaysDate;


    }
}

