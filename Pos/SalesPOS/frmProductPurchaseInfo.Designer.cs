namespace AssetInventory
{
    partial class frmProductPurchaseInfo
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProductPurchaseInfo));
            this.dtpPurchaseDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMemoNo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblTotalItemAmount = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPaid = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblInword = new System.Windows.Forms.Label();
            this.btnSearchProduct = new System.Windows.Forms.Button();
            this.btnResetForm = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.txtPurchaseNo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtItemCode = new System.Windows.Forms.TextBox();
            this.btnSearchSupplier = new System.Windows.Forms.Button();
            this.txtSupplierCode = new System.Windows.Forms.TextBox();
            this.txtSupplierName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cmb_model = new System.Windows.Forms.ComboBox();
            this.txtManufacture = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btnaddToList = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.txtUnitPrice = new System.Windows.Forms.TextBox();
            this.txtQty = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.dgvPurchaseGrid = new AssetInventory.DataGridViewEx();
            this.sl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Model = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Manufacturer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unit_price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total_price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductSizeID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPurchaseGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpPurchaseDate
            // 
            this.dtpPurchaseDate.CustomFormat = "dd-MMM-yyyy";
            this.dtpPurchaseDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpPurchaseDate.Location = new System.Drawing.Point(96, 57);
            this.dtpPurchaseDate.Name = "dtpPurchaseDate";
            this.dtpPurchaseDate.Size = new System.Drawing.Size(295, 20);
            this.dtpPurchaseDate.TabIndex = 1;
            this.dtpPurchaseDate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dtpPurchaseDate_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(4, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 44;
            this.label1.Text = "Purchase Date";
            // 
            // txtMemoNo
            // 
            this.txtMemoNo.BackColor = System.Drawing.Color.White;
            this.txtMemoNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMemoNo.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMemoNo.Location = new System.Drawing.Point(91, 491);
            this.txtMemoNo.Name = "txtMemoNo";
            this.txtMemoNo.Size = new System.Drawing.Size(226, 22);
            this.txtMemoNo.TabIndex = 14;
            this.txtMemoNo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMemoNo_KeyDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(4, 495);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 46;
            this.label4.Text = "Memo No";
            // 
            // lblTotalItemAmount
            // 
            this.lblTotalItemAmount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblTotalItemAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTotalItemAmount.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalItemAmount.ForeColor = System.Drawing.Color.Black;
            this.lblTotalItemAmount.Location = new System.Drawing.Point(704, 412);
            this.lblTotalItemAmount.Name = "lblTotalItemAmount";
            this.lblTotalItemAmount.Size = new System.Drawing.Size(126, 26);
            this.lblTotalItemAmount.TabIndex = 15;
            this.lblTotalItemAmount.Text = "0.00";
            this.lblTotalItemAmount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label9.Location = new System.Drawing.Point(574, 416);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(128, 13);
            this.label9.TabIndex = 55;
            this.label9.Text = "Total Amount (BDT) : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(4, 440);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 65;
            this.label2.Text = "Supplier Code";
            // 
            // txtPaid
            // 
            this.txtPaid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtPaid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPaid.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPaid.ForeColor = System.Drawing.Color.Blue;
            this.txtPaid.Location = new System.Drawing.Point(704, 443);
            this.txtPaid.MaxLength = 12;
            this.txtPaid.Name = "txtPaid";
            this.txtPaid.Size = new System.Drawing.Size(126, 30);
            this.txtPaid.TabIndex = 16;
            this.txtPaid.Text = "0.00";
            this.txtPaid.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtPaid.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPaid_KeyDown);
            this.txtPaid.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPaid_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(574, 447);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 68;
            this.label3.Text = "Paid Amount :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label6.Location = new System.Drawing.Point(4, 89);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 13);
            this.label6.TabIndex = 72;
            this.label6.Text = "Product";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Maroon;
            this.label7.Location = new System.Drawing.Point(4, 410);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 13);
            this.label7.TabIndex = 74;
            this.label7.Text = "In Word: ";
            // 
            // lblInword
            // 
            this.lblInword.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInword.ForeColor = System.Drawing.Color.Maroon;
            this.lblInword.Location = new System.Drawing.Point(57, 410);
            this.lblInword.Name = "lblInword";
            this.lblInword.Size = new System.Drawing.Size(433, 15);
            this.lblInword.TabIndex = 75;
            this.lblInword.Text = "Zero Tk.";
            // 
            // btnSearchProduct
            // 
            this.btnSearchProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnSearchProduct.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSearchProduct.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchProduct.Image = global::AssetInventory.Properties.Resources.search;
            this.btnSearchProduct.Location = new System.Drawing.Point(370, 84);
            this.btnSearchProduct.Name = "btnSearchProduct";
            this.btnSearchProduct.Size = new System.Drawing.Size(21, 22);
            this.btnSearchProduct.TabIndex = 3;
            this.btnSearchProduct.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSearchProduct.UseVisualStyleBackColor = false;
            this.btnSearchProduct.Click += new System.EventHandler(this.btnSearchProduct_Click);
            // 
            // btnResetForm
            // 
            this.btnResetForm.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnResetForm.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnResetForm.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResetForm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnResetForm.Image = global::AssetInventory.Properties.Resources.icon_reset;
            this.btnResetForm.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnResetForm.Location = new System.Drawing.Point(676, 484);
            this.btnResetForm.Name = "btnResetForm";
            this.btnResetForm.Size = new System.Drawing.Size(74, 25);
            this.btnResetForm.TabIndex = 18;
            this.btnResetForm.Text = "&Reset";
            this.btnResetForm.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnResetForm.UseVisualStyleBackColor = false;
            this.btnResetForm.Click += new System.EventHandler(this.btnResetForm_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClose.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnClose.Image = global::AssetInventory.Properties.Resources.Close1;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(756, 484);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(74, 25);
            this.btnClose.TabIndex = 19;
            this.btnClose.Text = "&Close";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSave.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSave.Image = global::AssetInventory.Properties.Resources.Save;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(598, 484);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(74, 25);
            this.btnSave.TabIndex = 17;
            this.btnSave.Text = "&Save";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::AssetInventory.Properties.Resources.form_banner;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.txtPurchaseNo);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(840, 51);
            this.panel1.TabIndex = 21;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(100, 8);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(176, 23);
            this.label12.TabIndex = 20;
            this.label12.Text = "Product Purchase";
            // 
            // txtPurchaseNo
            // 
            this.txtPurchaseNo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtPurchaseNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPurchaseNo.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPurchaseNo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.txtPurchaseNo.Location = new System.Drawing.Point(619, 13);
            this.txtPurchaseNo.Name = "txtPurchaseNo";
            this.txtPurchaseNo.ReadOnly = true;
            this.txtPurchaseNo.Size = new System.Drawing.Size(211, 22);
            this.txtPurchaseNo.TabIndex = 0;
            this.txtPurchaseNo.TabStop = false;
            this.txtPurchaseNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(539, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 13);
            this.label5.TabIndex = 70;
            this.label5.Text = "Purchase No";
            // 
            // txtItemCode
            // 
            this.txtItemCode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtItemCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtItemCode.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtItemCode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.txtItemCode.Location = new System.Drawing.Point(96, 84);
            this.txtItemCode.MaxLength = 10;
            this.txtItemCode.Name = "txtItemCode";
            this.txtItemCode.ReadOnly = true;
            this.txtItemCode.Size = new System.Drawing.Size(273, 22);
            this.txtItemCode.TabIndex = 2;
            this.txtItemCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtItemCode_KeyDown);
            // 
            // btnSearchSupplier
            // 
            this.btnSearchSupplier.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnSearchSupplier.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSearchSupplier.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchSupplier.Image = global::AssetInventory.Properties.Resources.search;
            this.btnSearchSupplier.Location = new System.Drawing.Point(319, 437);
            this.btnSearchSupplier.Name = "btnSearchSupplier";
            this.btnSearchSupplier.Size = new System.Drawing.Size(21, 22);
            this.btnSearchSupplier.TabIndex = 12;
            this.btnSearchSupplier.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSearchSupplier.UseVisualStyleBackColor = false;
            this.btnSearchSupplier.Click += new System.EventHandler(this.btnSearchSupplier_Click);
            // 
            // txtSupplierCode
            // 
            this.txtSupplierCode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtSupplierCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSupplierCode.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSupplierCode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.txtSupplierCode.Location = new System.Drawing.Point(91, 437);
            this.txtSupplierCode.MaxLength = 10;
            this.txtSupplierCode.Name = "txtSupplierCode";
            this.txtSupplierCode.ReadOnly = true;
            this.txtSupplierCode.Size = new System.Drawing.Size(226, 22);
            this.txtSupplierCode.TabIndex = 11;
            this.txtSupplierCode.TabStop = false;
            // 
            // txtSupplierName
            // 
            this.txtSupplierName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtSupplierName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSupplierName.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSupplierName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.txtSupplierName.Location = new System.Drawing.Point(91, 464);
            this.txtSupplierName.MaxLength = 10;
            this.txtSupplierName.Name = "txtSupplierName";
            this.txtSupplierName.ReadOnly = true;
            this.txtSupplierName.Size = new System.Drawing.Size(226, 22);
            this.txtSupplierName.TabIndex = 13;
            this.txtSupplierName.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label8.Location = new System.Drawing.Point(4, 467);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 13);
            this.label8.TabIndex = 87;
            this.label8.Text = "Supplier Name";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label10.Location = new System.Drawing.Point(4, 117);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 13);
            this.label10.TabIndex = 89;
            this.label10.Text = "Model";
            // 
            // cmb_model
            // 
            this.cmb_model.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmb_model.FormattingEnabled = true;
            this.cmb_model.Location = new System.Drawing.Point(96, 113);
            this.cmb_model.Name = "cmb_model";
            this.cmb_model.Size = new System.Drawing.Size(295, 21);
            this.cmb_model.TabIndex = 4;
            this.cmb_model.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmb_model_KeyDown);
            // 
            // txtManufacture
            // 
            this.txtManufacture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtManufacture.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtManufacture.Location = new System.Drawing.Point(96, 140);
            this.txtManufacture.MaxLength = 10;
            this.txtManufacture.Name = "txtManufacture";
            this.txtManufacture.Size = new System.Drawing.Size(295, 22);
            this.txtManufacture.TabIndex = 5;
            this.txtManufacture.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtManufacture_KeyDown);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label11.Location = new System.Drawing.Point(4, 145);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(84, 13);
            this.label11.TabIndex = 91;
            this.label11.Text = "Manufacturer";
            // 
            // btnaddToList
            // 
            this.btnaddToList.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnaddToList.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnaddToList.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnaddToList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnaddToList.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnaddToList.Location = new System.Drawing.Point(746, 112);
            this.btnaddToList.Name = "btnaddToList";
            this.btnaddToList.Size = new System.Drawing.Size(85, 22);
            this.btnaddToList.TabIndex = 8;
            this.btnaddToList.Text = "&Add To List";
            this.btnaddToList.UseVisualStyleBackColor = false;
            this.btnaddToList.Click += new System.EventHandler(this.btnaddToList_Click);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnReset.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnReset.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReset.Location = new System.Drawing.Point(620, 112);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(95, 22);
            this.btnReset.TabIndex = 9;
            this.btnReset.Text = "&Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // txtUnitPrice
            // 
            this.txtUnitPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUnitPrice.Location = new System.Drawing.Point(620, 85);
            this.txtUnitPrice.MaxLength = 100;
            this.txtUnitPrice.Name = "txtUnitPrice";
            this.txtUnitPrice.Size = new System.Drawing.Size(211, 20);
            this.txtUnitPrice.TabIndex = 7;
            this.txtUnitPrice.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtUnitPrice_KeyDown);
            this.txtUnitPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUnitPrice_KeyPress);
            // 
            // txtQty
            // 
            this.txtQty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtQty.Location = new System.Drawing.Point(620, 57);
            this.txtQty.MaxLength = 100;
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(211, 20);
            this.txtQty.TabIndex = 6;
            this.txtQty.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtQty_KeyDown);
            this.txtQty.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQty_KeyPress);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label13.Location = new System.Drawing.Point(540, 89);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(64, 13);
            this.label13.TabIndex = 97;
            this.label13.Text = "Unit Price ";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label14.Location = new System.Drawing.Point(540, 61);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(59, 13);
            this.label14.TabIndex = 96;
            this.label14.Text = "Quantity ";
            // 
            // dgvPurchaseGrid
            // 
            this.dgvPurchaseGrid.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvPurchaseGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPurchaseGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPurchaseGrid.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPurchaseGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPurchaseGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPurchaseGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sl,
            this.ItemCode,
            this.ItemDescription,
            this.Model,
            this.Manufacturer,
            this.qty,
            this.unit,
            this.unit_price,
            this.total_price,
            this.ProductSizeID});
            this.dgvPurchaseGrid.CurrentRowIndex = 0;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPurchaseGrid.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvPurchaseGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke;
            this.dgvPurchaseGrid.Location = new System.Drawing.Point(2, 174);
            this.dgvPurchaseGrid.MultiSelect = false;
            this.dgvPurchaseGrid.Name = "dgvPurchaseGrid";
            this.dgvPurchaseGrid.RowHeadersVisible = false;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvPurchaseGrid.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvPurchaseGrid.Size = new System.Drawing.Size(829, 233);
            this.dgvPurchaseGrid.TabIndex = 10;
            this.dgvPurchaseGrid.TabStop = false;
            this.dgvPurchaseGrid.CellMouseUp += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvPurchaseGrid_CellMouseUp);
            this.dgvPurchaseGrid.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvPurchaseGrid_CellMouseClick);
            this.dgvPurchaseGrid.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPurchaseGrid_CellEndEdit);
            this.dgvPurchaseGrid.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dgvPurchaseGrid_EditingControlShowing);
            this.dgvPurchaseGrid.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgvPurchaseGrid_DataError);
            this.dgvPurchaseGrid.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvPurchaseGrid_KeyDown);
            this.dgvPurchaseGrid.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dgvPurchaseGrid_KeyPress);
            // 
            // sl
            // 
            this.sl.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.sl.FillWeight = 7F;
            this.sl.HeaderText = "Sl";
            this.sl.Name = "sl";
            this.sl.ReadOnly = true;
            this.sl.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.sl.Visible = false;
            this.sl.Width = 30;
            // 
            // ItemCode
            // 
            this.ItemCode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ItemCode.HeaderText = "Item Code";
            this.ItemCode.Name = "ItemCode";
            this.ItemCode.ReadOnly = true;
            this.ItemCode.Width = 95;
            // 
            // ItemDescription
            // 
            this.ItemDescription.HeaderText = "Item Description";
            this.ItemDescription.Name = "ItemDescription";
            this.ItemDescription.ReadOnly = true;
            // 
            // Model
            // 
            this.Model.HeaderText = "Model";
            this.Model.Name = "Model";
            this.Model.ReadOnly = true;
            // 
            // Manufacturer
            // 
            this.Manufacturer.HeaderText = "Manufacturer";
            this.Manufacturer.Name = "Manufacturer";
            this.Manufacturer.ReadOnly = true;
            // 
            // qty
            // 
            this.qty.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.qty.FillWeight = 30.29671F;
            this.qty.HeaderText = "Quantity";
            this.qty.Name = "qty";
            this.qty.Width = 70;
            // 
            // unit
            // 
            this.unit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.unit.FillWeight = 52.90965F;
            this.unit.HeaderText = "Unit";
            this.unit.Name = "unit";
            this.unit.ReadOnly = true;
            this.unit.Width = 45;
            // 
            // unit_price
            // 
            this.unit_price.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.unit_price.HeaderText = "UnitPrice";
            this.unit_price.Name = "unit_price";
            this.unit_price.Width = 75;
            // 
            // total_price
            // 
            this.total_price.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.total_price.DefaultCellStyle = dataGridViewCellStyle3;
            this.total_price.FillWeight = 95.4241F;
            this.total_price.HeaderText = "TotalPrice";
            this.total_price.Name = "total_price";
            this.total_price.ReadOnly = true;
            this.total_price.Width = 85;
            // 
            // ProductSizeID
            // 
            this.ProductSizeID.HeaderText = "ProductSizeID";
            this.ProductSizeID.Name = "ProductSizeID";
            this.ProductSizeID.Visible = false;
            // 
            // frmProductPurchaseInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(242)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(840, 526);
            this.Controls.Add(this.txtUnitPrice);
            this.Controls.Add(this.txtQty);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.btnaddToList);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.txtManufacture);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cmb_model);
            this.Controls.Add(this.txtSupplierName);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtSupplierCode);
            this.Controls.Add(this.btnSearchSupplier);
            this.Controls.Add(this.btnSearchProduct);
            this.Controls.Add(this.txtItemCode);
            this.Controls.Add(this.btnResetForm);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblInword);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtPaid);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvPurchaseGrid);
            this.Controls.Add(this.lblTotalItemAmount);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtMemoNo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtpPurchaseDate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmProductPurchaseInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Product Purchase";
            this.Load += new System.EventHandler(this.frmProductPurchaseInfo_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPurchaseGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DateTimePicker dtpPurchaseDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMemoNo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblTotalItemAmount;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPaid;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPurchaseNo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblInword;
        private System.Windows.Forms.TextBox txtItemCode;
        private System.Windows.Forms.Button btnResetForm;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSave;
        private DataGridViewEx dgvPurchaseGrid;
        private System.Windows.Forms.Button btnSearchProduct;
        private System.Windows.Forms.Button btnSearchSupplier;
        private System.Windows.Forms.TextBox txtSupplierCode;
        private System.Windows.Forms.TextBox txtSupplierName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cmb_model;
        private System.Windows.Forms.TextBox txtManufacture;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnaddToList;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.TextBox txtUnitPrice;
        private System.Windows.Forms.TextBox txtQty;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DataGridViewTextBoxColumn sl;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn Model;
        private System.Windows.Forms.DataGridViewTextBoxColumn Manufacturer;
        private System.Windows.Forms.DataGridViewTextBoxColumn qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn unit;
        private System.Windows.Forms.DataGridViewTextBoxColumn unit_price;
        private System.Windows.Forms.DataGridViewTextBoxColumn total_price;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductSizeID;
    }
}