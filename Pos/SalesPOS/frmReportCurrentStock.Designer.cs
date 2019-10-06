namespace AssetInventory
{
    partial class frmReportCurrentStock
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReportCurrentStock));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnShow = new System.Windows.Forms.Button();
            this.dgvStockGrid = new System.Windows.Forms.DataGridView();
            this.btn2Excel = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.cmbProduct = new System.Windows.Forms.ComboBox();
            this.optSummary = new System.Windows.Forms.RadioButton();
            this.optDetails = new System.Windows.Forms.RadioButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStockGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::AssetInventory.Properties.Resources.reportbg;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label12);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(921, 50);
            this.panel1.TabIndex = 28;
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(531, 8);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(377, 24);
            this.label12.TabIndex = 20;
            this.label12.Text = "Current Stock Analysis Report";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(2, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 126;
            this.label3.Text = "Product Type";
            // 
            // btnShow
            // 
            this.btnShow.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnShow.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnShow.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShow.Image = global::AssetInventory.Properties.Resources.New;
            this.btnShow.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnShow.Location = new System.Drawing.Point(711, 65);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(81, 25);
            this.btnShow.TabIndex = 129;
            this.btnShow.Text = "Show";
            this.btnShow.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnShow.UseVisualStyleBackColor = false;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // dgvStockGrid
            // 
            this.dgvStockGrid.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvStockGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvStockGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvStockGrid.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvStockGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvStockGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.PowderBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvStockGrid.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvStockGrid.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvStockGrid.Location = new System.Drawing.Point(0, 96);
            this.dgvStockGrid.MultiSelect = false;
            this.dgvStockGrid.Name = "dgvStockGrid";
            this.dgvStockGrid.ReadOnly = true;
            this.dgvStockGrid.RowHeadersVisible = false;
            this.dgvStockGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStockGrid.Size = new System.Drawing.Size(921, 480);
            this.dgvStockGrid.TabIndex = 130;
            // 
            // btn2Excel
            // 
            this.btn2Excel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn2Excel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn2Excel.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn2Excel.Image = global::AssetInventory.Properties.Resources.New;
            this.btn2Excel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn2Excel.Location = new System.Drawing.Point(798, 65);
            this.btn2Excel.Name = "btn2Excel";
            this.btn2Excel.Size = new System.Drawing.Size(111, 25);
            this.btn2Excel.TabIndex = 131;
            this.btn2Excel.Text = "Export to Excel";
            this.btn2Excel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn2Excel.UseVisualStyleBackColor = false;
            this.btn2Excel.Click += new System.EventHandler(this.btn2Excel_Click);
            // 
            // cmbProduct
            // 
            this.cmbProduct.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProduct.FormattingEnabled = true;
            this.cmbProduct.Location = new System.Drawing.Point(91, 64);
            this.cmbProduct.Name = "cmbProduct";
            this.cmbProduct.Size = new System.Drawing.Size(195, 21);
            this.cmbProduct.TabIndex = 135;
            // 
            // optSummary
            // 
            this.optSummary.AutoSize = true;
            this.optSummary.Location = new System.Drawing.Point(376, 65);
            this.optSummary.Name = "optSummary";
            this.optSummary.Size = new System.Drawing.Size(68, 17);
            this.optSummary.TabIndex = 137;
            this.optSummary.Text = "Summary";
            this.optSummary.UseVisualStyleBackColor = true;
            // 
            // optDetails
            // 
            this.optDetails.AutoSize = true;
            this.optDetails.Checked = true;
            this.optDetails.Location = new System.Drawing.Point(304, 64);
            this.optDetails.Name = "optDetails";
            this.optDetails.Size = new System.Drawing.Size(57, 17);
            this.optDetails.TabIndex = 136;
            this.optDetails.TabStop = true;
            this.optDetails.Text = "Details";
            this.optDetails.UseVisualStyleBackColor = true;
            // 
            // frmReportCurrentStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(242)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(921, 576);
            this.Controls.Add(this.optSummary);
            this.Controls.Add(this.optDetails);
            this.Controls.Add(this.cmbProduct);
            this.Controls.Add(this.btn2Excel);
            this.Controls.Add(this.dgvStockGrid);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmReportCurrentStock";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Current Stock Analysis Report";
            this.Load += new System.EventHandler(this.frmReportCurrentStock_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStockGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.DataGridView dgvStockGrid;
        private System.Windows.Forms.Button btn2Excel;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ComboBox cmbProduct;
        private System.Windows.Forms.RadioButton optSummary;
        private System.Windows.Forms.RadioButton optDetails;
    }
}