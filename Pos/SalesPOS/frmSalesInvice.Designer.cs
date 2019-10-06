namespace AssetInventory
{
    partial class frmSalesInvice
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSalesInvice));
            this.panel3 = new System.Windows.Forms.Panel();
            this.cmb_customer_type = new System.Windows.Forms.ComboBox();
            this.chkPO_NO = new System.Windows.Forms.CheckBox();
            this.txtPO_Number = new System.Windows.Forms.TextBox();
            this.chkVehicle = new System.Windows.Forms.CheckBox();
            this.cmb_manufacturer = new System.Windows.Forms.ComboBox();
            this.txtUnitPrice = new System.Windows.Forms.TextBox();
            this.txtQty = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnaddToList = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.cmb_model = new System.Windows.Forms.ComboBox();
            this.btnSearchProduct = new System.Windows.Forms.Button();
            this.txtItemCode = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtCustomerCode = new System.Windows.Forms.TextBox();
            this.btnSearchCustomer = new System.Windows.Forms.Button();
            this.txtVehicle = new System.Windows.Forms.TextBox();
            this.txtDues = new System.Windows.Forms.TextBox();
            this.btnResetForm = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.txtPaid = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtCustomerAddress = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblInword = new System.Windows.Forms.Label();
            this.txtCustomerPhone = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblTotalItemAmount = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dtpPurchaseDate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblInvoiceNo = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblStock = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvSalesGrid = new AssetInventory.DataGridViewEx();
            this.Sl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Model = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Manufacturer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SaleQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnitName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Vat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WarrentyName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SerialNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SalesPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalVat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DaysCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WarrentyID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StockQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductSizeID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalesGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.groupBox1);
            this.panel3.Controls.Add(this.cmb_customer_type);
            this.panel3.Controls.Add(this.chkPO_NO);
            this.panel3.Controls.Add(this.txtPO_Number);
            this.panel3.Controls.Add(this.chkVehicle);
            this.panel3.Controls.Add(this.cmb_manufacturer);
            this.panel3.Controls.Add(this.txtUnitPrice);
            this.panel3.Controls.Add(this.txtQty);
            this.panel3.Controls.Add(this.label13);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.btnaddToList);
            this.panel3.Controls.Add(this.btnReset);
            this.panel3.Controls.Add(this.label15);
            this.panel3.Controls.Add(this.label16);
            this.panel3.Controls.Add(this.cmb_model);
            this.panel3.Controls.Add(this.btnSearchProduct);
            this.panel3.Controls.Add(this.txtItemCode);
            this.panel3.Controls.Add(this.label17);
            this.panel3.Controls.Add(this.txtCustomerCode);
            this.panel3.Controls.Add(this.btnSearchCustomer);
            this.panel3.Controls.Add(this.txtVehicle);
            this.panel3.Controls.Add(this.txtDues);
            this.panel3.Controls.Add(this.btnResetForm);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.txtCustomerName);
            this.panel3.Controls.Add(this.txtPaid);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.btnClose);
            this.panel3.Controls.Add(this.btnPrint);
            this.panel3.Controls.Add(this.label14);
            this.panel3.Controls.Add(this.btnSave);
            this.panel3.Controls.Add(this.dgvSalesGrid);
            this.panel3.Controls.Add(this.txtCustomerAddress);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.lblInword);
            this.panel3.Controls.Add(this.txtCustomerPhone);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.lblTotalItemAmount);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 51);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(846, 448);
            this.panel3.TabIndex = 26;
            this.panel3.TabStop = true;
            // 
            // cmb_customer_type
            // 
            this.cmb_customer_type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_customer_type.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmb_customer_type.FormattingEnabled = true;
            this.cmb_customer_type.Items.AddRange(new object[] {
            "ALL",
            "CNG",
            "ECR",
            "OTHERS"});
            this.cmb_customer_type.Location = new System.Drawing.Point(259, 325);
            this.cmb_customer_type.Name = "cmb_customer_type";
            this.cmb_customer_type.Size = new System.Drawing.Size(81, 21);
            this.cmb_customer_type.TabIndex = 115;
            // 
            // chkPO_NO
            // 
            this.chkPO_NO.AutoSize = true;
            this.chkPO_NO.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkPO_NO.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.chkPO_NO.Location = new System.Drawing.Point(379, 328);
            this.chkPO_NO.Name = "chkPO_NO";
            this.chkPO_NO.Size = new System.Drawing.Size(75, 17);
            this.chkPO_NO.TabIndex = 114;
            this.chkPO_NO.Text = "Order No";
            this.chkPO_NO.UseVisualStyleBackColor = true;
            this.chkPO_NO.CheckedChanged += new System.EventHandler(this.chkPO_NO_CheckedChanged);
            // 
            // txtPO_Number
            // 
            this.txtPO_Number.BackColor = System.Drawing.Color.White;
            this.txtPO_Number.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPO_Number.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPO_Number.Location = new System.Drawing.Point(495, 326);
            this.txtPO_Number.MaxLength = 500;
            this.txtPO_Number.Name = "txtPO_Number";
            this.txtPO_Number.Size = new System.Drawing.Size(152, 21);
            this.txtPO_Number.TabIndex = 113;
            this.txtPO_Number.TabStop = false;
            this.txtPO_Number.Visible = false;
            // 
            // chkVehicle
            // 
            this.chkVehicle.AutoSize = true;
            this.chkVehicle.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkVehicle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.chkVehicle.Location = new System.Drawing.Point(379, 352);
            this.chkVehicle.Name = "chkVehicle";
            this.chkVehicle.Size = new System.Drawing.Size(113, 17);
            this.chkVehicle.TabIndex = 112;
            this.chkVehicle.Text = "Vehicle Number";
            this.chkVehicle.UseVisualStyleBackColor = true;
            this.chkVehicle.CheckedChanged += new System.EventHandler(this.chkVehicle_CheckedChanged);
            // 
            // cmb_manufacturer
            // 
            this.cmb_manufacturer.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmb_manufacturer.FormattingEnabled = true;
            this.cmb_manufacturer.Location = new System.Drawing.Point(101, 65);
            this.cmb_manufacturer.Name = "cmb_manufacturer";
            this.cmb_manufacturer.Size = new System.Drawing.Size(295, 21);
            this.cmb_manufacturer.TabIndex = 111;
            this.cmb_manufacturer.SelectedIndexChanged += new System.EventHandler(this.cmb_manufacturer_SelectedIndexChanged);
            this.cmb_manufacturer.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmb_manufacturer_KeyDown);
            // 
            // txtUnitPrice
            // 
            this.txtUnitPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUnitPrice.Location = new System.Drawing.Point(629, 38);
            this.txtUnitPrice.MaxLength = 100;
            this.txtUnitPrice.Name = "txtUnitPrice";
            this.txtUnitPrice.Size = new System.Drawing.Size(211, 21);
            this.txtUnitPrice.TabIndex = 102;
            this.txtUnitPrice.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtUnitPrice_KeyDown);
            this.txtUnitPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUnitPrice_KeyPress);
            // 
            // txtQty
            // 
            this.txtQty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtQty.Location = new System.Drawing.Point(629, 10);
            this.txtQty.MaxLength = 100;
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(211, 21);
            this.txtQty.TabIndex = 103;
            this.txtQty.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtQty_KeyDown);
            this.txtQty.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQty_KeyPress);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label13.Location = new System.Drawing.Point(549, 42);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(64, 13);
            this.label13.TabIndex = 110;
            this.label13.Text = "Unit Price ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(549, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 109;
            this.label5.Text = "Quantity ";
            // 
            // btnaddToList
            // 
            this.btnaddToList.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnaddToList.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnaddToList.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnaddToList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnaddToList.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnaddToList.Location = new System.Drawing.Point(755, 65);
            this.btnaddToList.Name = "btnaddToList";
            this.btnaddToList.Size = new System.Drawing.Size(85, 22);
            this.btnaddToList.TabIndex = 104;
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
            this.btnReset.Location = new System.Drawing.Point(629, 65);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(95, 22);
            this.btnReset.TabIndex = 105;
            this.btnReset.Text = "&Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label15.Location = new System.Drawing.Point(5, 71);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(84, 13);
            this.label15.TabIndex = 108;
            this.label15.Text = "Manufacturer";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label16.Location = new System.Drawing.Point(5, 43);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(41, 13);
            this.label16.TabIndex = 107;
            this.label16.Text = "Model";
            // 
            // cmb_model
            // 
            this.cmb_model.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmb_model.FormattingEnabled = true;
            this.cmb_model.Location = new System.Drawing.Point(101, 38);
            this.cmb_model.Name = "cmb_model";
            this.cmb_model.Size = new System.Drawing.Size(295, 21);
            this.cmb_model.TabIndex = 100;
            this.cmb_model.SelectedIndexChanged += new System.EventHandler(this.cmb_model_SelectedIndexChanged);
            this.cmb_model.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmb_model_KeyDown);
            // 
            // btnSearchProduct
            // 
            this.btnSearchProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnSearchProduct.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSearchProduct.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchProduct.Image = global::AssetInventory.Properties.Resources.search;
            this.btnSearchProduct.Location = new System.Drawing.Point(375, 10);
            this.btnSearchProduct.Name = "btnSearchProduct";
            this.btnSearchProduct.Size = new System.Drawing.Size(21, 22);
            this.btnSearchProduct.TabIndex = 99;
            this.btnSearchProduct.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSearchProduct.UseVisualStyleBackColor = false;
            this.btnSearchProduct.Click += new System.EventHandler(this.btnSearchProduct_Click);
            // 
            // txtItemCode
            // 
            this.txtItemCode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtItemCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtItemCode.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtItemCode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.txtItemCode.Location = new System.Drawing.Point(101, 10);
            this.txtItemCode.MaxLength = 10;
            this.txtItemCode.Name = "txtItemCode";
            this.txtItemCode.ReadOnly = true;
            this.txtItemCode.Size = new System.Drawing.Size(273, 22);
            this.txtItemCode.TabIndex = 98;
            this.txtItemCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtItemCode_KeyDown);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label17.Location = new System.Drawing.Point(5, 15);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(51, 13);
            this.label17.TabIndex = 106;
            this.label17.Text = "Product";
            // 
            // txtCustomerCode
            // 
            this.txtCustomerCode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtCustomerCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCustomerCode.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustomerCode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.txtCustomerCode.Location = new System.Drawing.Point(109, 325);
            this.txtCustomerCode.MaxLength = 30;
            this.txtCustomerCode.Name = "txtCustomerCode";
            this.txtCustomerCode.ReadOnly = true;
            this.txtCustomerCode.Size = new System.Drawing.Size(145, 21);
            this.txtCustomerCode.TabIndex = 87;
            // 
            // btnSearchCustomer
            // 
            this.btnSearchCustomer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnSearchCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSearchCustomer.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchCustomer.Image = global::AssetInventory.Properties.Resources.search;
            this.btnSearchCustomer.Location = new System.Drawing.Point(342, 325);
            this.btnSearchCustomer.Name = "btnSearchCustomer";
            this.btnSearchCustomer.Size = new System.Drawing.Size(21, 22);
            this.btnSearchCustomer.TabIndex = 86;
            this.btnSearchCustomer.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSearchCustomer.UseVisualStyleBackColor = false;
            this.btnSearchCustomer.Click += new System.EventHandler(this.btnSearchCustomer_Click);
            // 
            // txtVehicle
            // 
            this.txtVehicle.BackColor = System.Drawing.Color.White;
            this.txtVehicle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtVehicle.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVehicle.Location = new System.Drawing.Point(495, 350);
            this.txtVehicle.MaxLength = 500;
            this.txtVehicle.Name = "txtVehicle";
            this.txtVehicle.Size = new System.Drawing.Size(152, 21);
            this.txtVehicle.TabIndex = 9;
            this.txtVehicle.TabStop = false;
            this.txtVehicle.Visible = false;
            // 
            // txtDues
            // 
            this.txtDues.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDues.BackColor = System.Drawing.Color.White;
            this.txtDues.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDues.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDues.ForeColor = System.Drawing.Color.Red;
            this.txtDues.Location = new System.Drawing.Point(710, 404);
            this.txtDues.Name = "txtDues";
            this.txtDues.ReadOnly = true;
            this.txtDues.Size = new System.Drawing.Size(121, 30);
            this.txtDues.TabIndex = 11;
            this.txtDues.TabStop = false;
            this.txtDues.Text = "0.00";
            this.txtDues.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnResetForm
            // 
            this.btnResetForm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnResetForm.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnResetForm.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnResetForm.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResetForm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnResetForm.Image = global::AssetInventory.Properties.Resources.icon_reset;
            this.btnResetForm.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnResetForm.Location = new System.Drawing.Point(573, 377);
            this.btnResetForm.Name = "btnResetForm";
            this.btnResetForm.Size = new System.Drawing.Size(74, 25);
            this.btnResetForm.TabIndex = 14;
            this.btnResetForm.Text = "&Reset";
            this.btnResetForm.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnResetForm.UseVisualStyleBackColor = false;
            this.btnResetForm.Click += new System.EventHandler(this.btnResetForm_Click);
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label11.Location = new System.Drawing.Point(658, 410);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(49, 13);
            this.label11.TabIndex = 15;
            this.label11.Text = "Change";
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.BackColor = System.Drawing.Color.LemonChiffon;
            this.txtCustomerName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCustomerName.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustomerName.Location = new System.Drawing.Point(109, 350);
            this.txtCustomerName.MaxLength = 30;
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.ReadOnly = true;
            this.txtCustomerName.Size = new System.Drawing.Size(254, 21);
            this.txtCustomerName.TabIndex = 6;
            // 
            // txtPaid
            // 
            this.txtPaid.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPaid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtPaid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPaid.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPaid.Location = new System.Drawing.Point(710, 375);
            this.txtPaid.MaxLength = 10;
            this.txtPaid.Name = "txtPaid";
            this.txtPaid.Size = new System.Drawing.Size(121, 30);
            this.txtPaid.TabIndex = 10;
            this.txtPaid.Text = "0.00";
            this.txtPaid.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtPaid.TextChanged += new System.EventHandler(this.txtPaid_TextChanged);
            this.txtPaid.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtPaid_KeyUp);
            this.txtPaid.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPaid_KeyPress);
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label10.Location = new System.Drawing.Point(658, 382);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(31, 13);
            this.label10.TabIndex = 13;
            this.label10.Text = "Paid";
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClose.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnClose.Image = global::AssetInventory.Properties.Resources.Close1;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(573, 409);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(74, 25);
            this.btnClose.TabIndex = 15;
            this.btnClose.Text = "&Close";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrint.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnPrint.Enabled = false;
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPrint.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnPrint.Image = global::AssetInventory.Properties.Resources.pf_print_icon;
            this.btnPrint.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrint.Location = new System.Drawing.Point(495, 409);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(74, 25);
            this.btnPrint.TabIndex = 13;
            this.btnPrint.Text = "&Print";
            this.btnPrint.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label14.Location = new System.Drawing.Point(9, 351);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(97, 13);
            this.label14.TabIndex = 71;
            this.label14.Text = "Customer Name";
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSave.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSave.Image = global::AssetInventory.Properties.Resources.Save;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(495, 377);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(74, 25);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "&Save";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtCustomerAddress
            // 
            this.txtCustomerAddress.BackColor = System.Drawing.Color.LemonChiffon;
            this.txtCustomerAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCustomerAddress.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustomerAddress.Location = new System.Drawing.Point(109, 400);
            this.txtCustomerAddress.MaxLength = 500;
            this.txtCustomerAddress.Name = "txtCustomerAddress";
            this.txtCustomerAddress.ReadOnly = true;
            this.txtCustomerAddress.Size = new System.Drawing.Size(254, 21);
            this.txtCustomerAddress.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label6.Location = new System.Drawing.Point(9, 400);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 66;
            this.label6.Text = "Address";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(8, 325);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 13);
            this.label3.TabIndex = 62;
            this.label3.Text = "Customer Code";
            // 
            // lblInword
            // 
            this.lblInword.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInword.ForeColor = System.Drawing.Color.Sienna;
            this.lblInword.Location = new System.Drawing.Point(63, 294);
            this.lblInword.Name = "lblInword";
            this.lblInword.Size = new System.Drawing.Size(361, 26);
            this.lblInword.TabIndex = 77;
            this.lblInword.Text = "In Word: ";
            // 
            // txtCustomerPhone
            // 
            this.txtCustomerPhone.BackColor = System.Drawing.Color.LemonChiffon;
            this.txtCustomerPhone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCustomerPhone.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustomerPhone.Location = new System.Drawing.Point(109, 375);
            this.txtCustomerPhone.MaxLength = 30;
            this.txtCustomerPhone.Name = "txtCustomerPhone";
            this.txtCustomerPhone.ReadOnly = true;
            this.txtCustomerPhone.Size = new System.Drawing.Size(254, 21);
            this.txtCustomerPhone.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(9, 375);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 64;
            this.label4.Text = "Phone";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Sienna;
            this.label7.Location = new System.Drawing.Point(6, 294);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 13);
            this.label7.TabIndex = 76;
            this.label7.Text = "In Word : ";
            // 
            // lblTotalItemAmount
            // 
            this.lblTotalItemAmount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotalItemAmount.Font = new System.Drawing.Font("Tahoma", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalItemAmount.Location = new System.Drawing.Point(661, 295);
            this.lblTotalItemAmount.Name = "lblTotalItemAmount";
            this.lblTotalItemAmount.Size = new System.Drawing.Size(177, 50);
            this.lblTotalItemAmount.TabIndex = 72;
            this.lblTotalItemAmount.Text = "0.00";
            this.lblTotalItemAmount.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label9.Location = new System.Drawing.Point(514, 300);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(128, 13);
            this.label9.TabIndex = 71;
            this.label9.Text = "Total Amount (BDT) : ";
            // 
            // dtpPurchaseDate
            // 
            this.dtpPurchaseDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpPurchaseDate.CalendarMonthBackground = System.Drawing.Color.White;
            this.dtpPurchaseDate.CustomFormat = "dd/MMM/yyyy";
            this.dtpPurchaseDate.Enabled = false;
            this.dtpPurchaseDate.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpPurchaseDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpPurchaseDate.Location = new System.Drawing.Point(428, 14);
            this.dtpPurchaseDate.Name = "dtpPurchaseDate";
            this.dtpPurchaseDate.Size = new System.Drawing.Size(109, 21);
            this.dtpPurchaseDate.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(358, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 64;
            this.label2.Text = "Sales Date";
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::AssetInventory.Properties.Resources.form_banner;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lblInvoiceNo);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dtpPurchaseDate);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(846, 51);
            this.panel1.TabIndex = 23;
            // 
            // lblInvoiceNo
            // 
            this.lblInvoiceNo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblInvoiceNo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblInvoiceNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblInvoiceNo.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInvoiceNo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblInvoiceNo.Location = new System.Drawing.Point(628, 12);
            this.lblInvoiceNo.Name = "lblInvoiceNo";
            this.lblInvoiceNo.Size = new System.Drawing.Size(211, 24);
            this.lblInvoiceNo.TabIndex = 66;
            this.lblInvoiceNo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(78, 8);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(137, 23);
            this.label12.TabIndex = 20;
            this.label12.Text = "Sales Inovice";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(548, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 63;
            this.label1.Text = "Invoice No";
            // 
            // lblStock
            // 
            this.lblStock.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStock.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblStock.Location = new System.Drawing.Point(5, 20);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(82, 27);
            this.lblStock.TabIndex = 116;
            this.lblStock.Text = "StockQty";
            this.lblStock.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblStock);
            this.groupBox1.Location = new System.Drawing.Point(429, 15);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(92, 59);
            this.groupBox1.TabIndex = 117;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = " Stock in hand";
            // 
            // dgvSalesGrid
            // 
            this.dgvSalesGrid.AllowUserToAddRows = false;
            this.dgvSalesGrid.AllowUserToDeleteRows = false;
            this.dgvSalesGrid.AllowUserToResizeColumns = false;
            this.dgvSalesGrid.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvSalesGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSalesGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSalesGrid.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvSalesGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSalesGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Sl,
            this.ItemCode,
            this.ItemDescription,
            this.Model,
            this.Manufacturer,
            this.SaleQty,
            this.UnitName,
            this.Vat,
            this.WarrentyName,
            this.SerialNo,
            this.SalesPrice,
            this.TotalVat,
            this.TotalPrice,
            this.DaysCount,
            this.WarrentyID,
            this.StockQty,
            this.ProductSizeID});
            this.dgvSalesGrid.CurrentRowIndex = 0;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.LightBlue;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSalesGrid.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvSalesGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke;
            this.dgvSalesGrid.Location = new System.Drawing.Point(8, 93);
            this.dgvSalesGrid.MultiSelect = false;
            this.dgvSalesGrid.Name = "dgvSalesGrid";
            this.dgvSalesGrid.RowHeadersVisible = false;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvSalesGrid.RowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvSalesGrid.Size = new System.Drawing.Size(832, 198);
            this.dgvSalesGrid.TabIndex = 4;
            this.dgvSalesGrid.TabStop = false;
            this.dgvSalesGrid.CellMouseUp += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvSalesGrid_CellMouseUp);
            this.dgvSalesGrid.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvSalesGrid_CellMouseClick);
            this.dgvSalesGrid.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSalesGrid_CellEndEdit);
            this.dgvSalesGrid.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dgvSalesGrid_EditingControlShowing);
            this.dgvSalesGrid.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgvSalesGrid_DataError);
            this.dgvSalesGrid.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvSalesGrid_KeyDown);
            this.dgvSalesGrid.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dgvSalesGrid_KeyPress);
            // 
            // Sl
            // 
            this.Sl.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Sl.HeaderText = "Sl";
            this.Sl.Name = "Sl";
            this.Sl.Visible = false;
            this.Sl.Width = 20;
            // 
            // ItemCode
            // 
            this.ItemCode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ItemCode.DataPropertyName = "ItemCode";
            this.ItemCode.FillWeight = 76.8494F;
            this.ItemCode.HeaderText = "Code";
            this.ItemCode.Name = "ItemCode";
            this.ItemCode.ReadOnly = true;
            this.ItemCode.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ItemCode.Visible = false;
            this.ItemCode.Width = 85;
            // 
            // ItemDescription
            // 
            this.ItemDescription.DataPropertyName = "ItemDescription";
            this.ItemDescription.FillWeight = 13.10479F;
            this.ItemDescription.HeaderText = "Description";
            this.ItemDescription.Name = "ItemDescription";
            this.ItemDescription.ReadOnly = true;
            // 
            // Model
            // 
            this.Model.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Model.HeaderText = "Model";
            this.Model.Name = "Model";
            this.Model.ReadOnly = true;
            this.Model.Width = 80;
            // 
            // Manufacturer
            // 
            this.Manufacturer.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Manufacturer.HeaderText = "Manufacturer";
            this.Manufacturer.Name = "Manufacturer";
            this.Manufacturer.ReadOnly = true;
            this.Manufacturer.Width = 80;
            // 
            // SaleQty
            // 
            this.SaleQty.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.SaleQty.DataPropertyName = "SaleQty";
            this.SaleQty.HeaderText = "SaleQty";
            this.SaleQty.Name = "SaleQty";
            this.SaleQty.Width = 60;
            // 
            // UnitName
            // 
            this.UnitName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.UnitName.DataPropertyName = "UnitName";
            this.UnitName.FillWeight = 40.41515F;
            this.UnitName.HeaderText = "Unit";
            this.UnitName.Name = "UnitName";
            this.UnitName.ReadOnly = true;
            this.UnitName.Width = 50;
            // 
            // Vat
            // 
            this.Vat.DataPropertyName = "Vat";
            this.Vat.HeaderText = "Vat";
            this.Vat.Name = "Vat";
            this.Vat.ReadOnly = true;
            this.Vat.Visible = false;
            // 
            // WarrentyName
            // 
            this.WarrentyName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.WarrentyName.DataPropertyName = "WarrentyName";
            this.WarrentyName.HeaderText = "Warrenty";
            this.WarrentyName.Name = "WarrentyName";
            this.WarrentyName.ReadOnly = true;
            this.WarrentyName.Width = 70;
            // 
            // SerialNo
            // 
            this.SerialNo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.SerialNo.DataPropertyName = "SerialNo";
            this.SerialNo.HeaderText = "Serial No";
            this.SerialNo.Name = "SerialNo";
            this.SerialNo.Width = 90;
            // 
            // SalesPrice
            // 
            this.SalesPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.SalesPrice.DataPropertyName = "SalesPrice";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.SalesPrice.DefaultCellStyle = dataGridViewCellStyle2;
            this.SalesPrice.FillWeight = 72.8899F;
            this.SalesPrice.HeaderText = "SalesPrice";
            this.SalesPrice.Name = "SalesPrice";
            this.SalesPrice.Width = 80;
            // 
            // TotalVat
            // 
            this.TotalVat.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.TotalVat.DataPropertyName = "TotalVat";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight;
            this.TotalVat.DefaultCellStyle = dataGridViewCellStyle3;
            this.TotalVat.HeaderText = "Total Vat";
            this.TotalVat.Name = "TotalVat";
            this.TotalVat.ReadOnly = true;
            this.TotalVat.Width = 90;
            // 
            // TotalPrice
            // 
            this.TotalPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight;
            this.TotalPrice.DefaultCellStyle = dataGridViewCellStyle4;
            this.TotalPrice.HeaderText = "TotalPrice";
            this.TotalPrice.Name = "TotalPrice";
            this.TotalPrice.ReadOnly = true;
            this.TotalPrice.Width = 80;
            // 
            // DaysCount
            // 
            this.DaysCount.DataPropertyName = "DaysCount";
            this.DaysCount.HeaderText = "WarrentyDaysCount";
            this.DaysCount.Name = "DaysCount";
            this.DaysCount.ReadOnly = true;
            this.DaysCount.Visible = false;
            // 
            // WarrentyID
            // 
            this.WarrentyID.DataPropertyName = "WarrentyID";
            this.WarrentyID.HeaderText = "WarrentyID";
            this.WarrentyID.Name = "WarrentyID";
            this.WarrentyID.ReadOnly = true;
            this.WarrentyID.Visible = false;
            // 
            // StockQty
            // 
            this.StockQty.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.StockQty.DataPropertyName = "StockQty";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight;
            this.StockQty.DefaultCellStyle = dataGridViewCellStyle5;
            this.StockQty.FillWeight = 23.1422F;
            this.StockQty.HeaderText = "Stock";
            this.StockQty.Name = "StockQty";
            this.StockQty.ReadOnly = true;
            this.StockQty.Width = 50;
            // 
            // ProductSizeID
            // 
            this.ProductSizeID.HeaderText = "ProductSizeID";
            this.ProductSizeID.Name = "ProductSizeID";
            this.ProductSizeID.ReadOnly = true;
            this.ProductSizeID.Visible = false;
            // 
            // frmSalesInvice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(242)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(846, 499);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSalesInvice";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sales Invoice";
            this.Load += new System.EventHandler(this.frmSalesInvice_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalesGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DateTimePicker dtpPurchaseDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblInword;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblTotalItemAmount;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblInvoiceNo;
        private DataGridViewEx dgvSalesGrid;
        private System.Windows.Forms.TextBox txtDues;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtPaid;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtCustomerAddress;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCustomerPhone;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtVehicle;
        private System.Windows.Forms.Button btnResetForm;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSearchCustomer;
        private System.Windows.Forms.TextBox txtCustomerCode;
        private System.Windows.Forms.TextBox txtUnitPrice;
        private System.Windows.Forms.TextBox txtQty;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnaddToList;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox cmb_model;
        private System.Windows.Forms.Button btnSearchProduct;
        private System.Windows.Forms.TextBox txtItemCode;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ComboBox cmb_manufacturer;
        private System.Windows.Forms.CheckBox chkVehicle;
        private System.Windows.Forms.TextBox txtPO_Number;
        private System.Windows.Forms.CheckBox chkPO_NO;
        private System.Windows.Forms.ComboBox cmb_customer_type;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sl;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn Model;
        private System.Windows.Forms.DataGridViewTextBoxColumn Manufacturer;
        private System.Windows.Forms.DataGridViewTextBoxColumn SaleQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnitName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Vat;
        private System.Windows.Forms.DataGridViewTextBoxColumn WarrentyName;
        private System.Windows.Forms.DataGridViewTextBoxColumn SerialNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn SalesPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalVat;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn DaysCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn WarrentyID;
        private System.Windows.Forms.DataGridViewTextBoxColumn StockQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductSizeID;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}