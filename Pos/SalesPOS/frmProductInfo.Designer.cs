namespace AssetInventory
{
    partial class frmProductInfo
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProductInfo));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label16 = new System.Windows.Forms.Label();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tab_view = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvProductInfo = new System.Windows.Forms.DataGridView();
            this.Code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.tab_add_edit = new System.Windows.Forms.TabPage();
            this.panel4 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSave2 = new System.Windows.Forms.Button();
            this.btnReset2 = new System.Windows.Forms.Button();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.dgvSize = new System.Windows.Forms.DataGridView();
            this.ProductSizeID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtVariation = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tab_view.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductInfo)).BeginInit();
            this.tab_add_edit.SuspendLayout();
            this.panel4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSize)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::AssetInventory.Properties.Resources.form_banner;
            this.panel1.Controls.Add(this.label16);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(434, 55);
            this.panel1.TabIndex = 29;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(150, 18);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(269, 23);
            this.label16.TabIndex = 20;
            this.label16.Text = "Product Model Information";
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tab_view);
            this.tabControl.Controls.Add(this.tab_add_edit);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 55);
            this.tabControl.Margin = new System.Windows.Forms.Padding(0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(434, 517);
            this.tabControl.TabIndex = 31;
            // 
            // tab_view
            // 
            this.tab_view.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(242)))), ((int)(((byte)(255)))));
            this.tab_view.Controls.Add(this.groupBox2);
            this.tab_view.Location = new System.Drawing.Point(4, 22);
            this.tab_view.Name = "tab_view";
            this.tab_view.Padding = new System.Windows.Forms.Padding(3);
            this.tab_view.Size = new System.Drawing.Size(426, 491);
            this.tab_view.TabIndex = 0;
            this.tab_view.Text = "View";
            this.tab_view.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvProductInfo);
            this.groupBox2.Controls.Add(this.txtSearch);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(182)))));
            this.groupBox2.Location = new System.Drawing.Point(3, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(420, 485);
            this.groupBox2.TabIndex = 32;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Search";
            // 
            // dgvProductInfo
            // 
            this.dgvProductInfo.AllowUserToAddRows = false;
            this.dgvProductInfo.AllowUserToDeleteRows = false;
            this.dgvProductInfo.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(240)))), ((int)(((byte)(250)))));
            this.dgvProductInfo.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvProductInfo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProductInfo.BackgroundColor = System.Drawing.Color.White;
            this.dgvProductInfo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvProductInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Code,
            this.Description});
            this.dgvProductInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvProductInfo.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvProductInfo.Location = new System.Drawing.Point(3, 37);
            this.dgvProductInfo.MultiSelect = false;
            this.dgvProductInfo.Name = "dgvProductInfo";
            this.dgvProductInfo.RowHeadersVisible = false;
            this.dgvProductInfo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProductInfo.Size = new System.Drawing.Size(414, 445);
            this.dgvProductInfo.TabIndex = 5;
            this.dgvProductInfo.TabStop = false;
            this.dgvProductInfo.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvProductInfo_CellMouseDoubleClick);
            // 
            // Code
            // 
            this.Code.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Code.DataPropertyName = "PID";
            this.Code.HeaderText = "Code";
            this.Code.Name = "Code";
            this.Code.Width = 90;
            // 
            // Description
            // 
            this.Description.DataPropertyName = "ProductName";
            this.Description.HeaderText = "Name";
            this.Description.Name = "Description";
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.Color.White;
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtSearch.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.ForeColor = System.Drawing.Color.Black;
            this.txtSearch.Location = new System.Drawing.Point(3, 16);
            this.txtSearch.MaxLength = 14;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(414, 21);
            this.txtSearch.TabIndex = 6;
            this.txtSearch.TabStop = false;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // tab_add_edit
            // 
            this.tab_add_edit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(242)))), ((int)(((byte)(255)))));
            this.tab_add_edit.Controls.Add(this.panel4);
            this.tab_add_edit.Location = new System.Drawing.Point(4, 22);
            this.tab_add_edit.Margin = new System.Windows.Forms.Padding(0);
            this.tab_add_edit.Name = "tab_add_edit";
            this.tab_add_edit.Size = new System.Drawing.Size(426, 491);
            this.tab_add_edit.TabIndex = 1;
            this.tab_add_edit.Text = "Add/Edit";
            this.tab_add_edit.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.groupBox1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(426, 491);
            this.panel4.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSave2);
            this.groupBox1.Controls.Add(this.btnReset2);
            this.groupBox1.Controls.Add(this.txtCode);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.dgvSize);
            this.groupBox1.Controls.Add(this.txtVariation);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.ForeColor = System.Drawing.Color.Blue;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(426, 491);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            // 
            // btnSave2
            // 
            this.btnSave2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnSave2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSave2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave2.ForeColor = System.Drawing.Color.Black;
            this.btnSave2.Image = global::AssetInventory.Properties.Resources.Save;
            this.btnSave2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave2.Location = new System.Drawing.Point(294, 18);
            this.btnSave2.Name = "btnSave2";
            this.btnSave2.Size = new System.Drawing.Size(61, 21);
            this.btnSave2.TabIndex = 11;
            this.btnSave2.Text = "&Save";
            this.btnSave2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave2.UseVisualStyleBackColor = false;
            this.btnSave2.Click += new System.EventHandler(this.btnSave2_Click);
            // 
            // btnReset2
            // 
            this.btnReset2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnReset2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnReset2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset2.ForeColor = System.Drawing.Color.Black;
            this.btnReset2.Image = global::AssetInventory.Properties.Resources.icon_reset;
            this.btnReset2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReset2.Location = new System.Drawing.Point(357, 18);
            this.btnReset2.Name = "btnReset2";
            this.btnReset2.Size = new System.Drawing.Size(65, 21);
            this.btnReset2.TabIndex = 12;
            this.btnReset2.Text = "&Reset";
            this.btnReset2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnReset2.UseVisualStyleBackColor = false;
            this.btnReset2.Click += new System.EventHandler(this.btnReset2_Click);
            // 
            // txtCode
            // 
            this.txtCode.Location = new System.Drawing.Point(72, 105);
            this.txtCode.Name = "txtCode";
            this.txtCode.ReadOnly = true;
            this.txtCode.Size = new System.Drawing.Size(77, 20);
            this.txtCode.TabIndex = 18;
            this.txtCode.Visible = false;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label14.Location = new System.Drawing.Point(6, 22);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(44, 13);
            this.label14.TabIndex = 9;
            this.label14.Text = "Model ";
            // 
            // dgvSize
            // 
            this.dgvSize.AllowUserToAddRows = false;
            this.dgvSize.AllowUserToDeleteRows = false;
            this.dgvSize.AllowUserToResizeRows = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            this.dgvSize.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvSize.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSize.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSize.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvSize.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSize.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductSizeID,
            this.dataGridViewTextBoxColumn2});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.PowderBlue;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSize.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvSize.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvSize.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvSize.Location = new System.Drawing.Point(3, 45);
            this.dgvSize.MultiSelect = false;
            this.dgvSize.Name = "dgvSize";
            this.dgvSize.ReadOnly = true;
            this.dgvSize.RowHeadersVisible = false;
            this.dgvSize.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvSize.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSize.Size = new System.Drawing.Size(420, 443);
            this.dgvSize.TabIndex = 8;
            this.dgvSize.TabStop = false;
            this.dgvSize.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvSize_CellMouseClick);
            // 
            // ProductSizeID
            // 
            this.ProductSizeID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ProductSizeID.DataPropertyName = "ProductSizeID";
            this.ProductSizeID.Frozen = true;
            this.ProductSizeID.HeaderText = "ProductSizeID";
            this.ProductSizeID.Name = "ProductSizeID";
            this.ProductSizeID.ReadOnly = true;
            this.ProductSizeID.Visible = false;
            this.ProductSizeID.Width = 70;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "VariationName";
            this.dataGridViewTextBoxColumn2.HeaderText = "Model";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // txtVariation
            // 
            this.txtVariation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtVariation.Location = new System.Drawing.Point(56, 19);
            this.txtVariation.Name = "txtVariation";
            this.txtVariation.Size = new System.Drawing.Size(232, 20);
            this.txtVariation.TabIndex = 10;
            this.txtVariation.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtVariation_KeyDown);
            this.txtVariation.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtVariation_KeyPress);
            // 
            // frmProductInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(242)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(434, 572);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmProductInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Product Details Information";
            this.Load += new System.EventHandler(this.frmProductInfo_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.tab_view.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductInfo)).EndInit();
            this.tab_add_edit.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSize)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tab_view;
        private System.Windows.Forms.TabPage tab_add_edit;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txtVariation;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DataGridView dgvSize;
        private System.Windows.Forms.Button btnSave2;
        private System.Windows.Forms.Button btnReset2;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductSizeID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvProductInfo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Code;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.TextBox txtSearch;
    }
}