namespace AssetInventory
{
    partial class frmWarrantyCheck
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmWarrantyCheck));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.cmbProduct = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbVariation = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSerialNo = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pnlVehicle = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pnlSerial = new System.Windows.Forms.Panel();
            this.optVehicle = new System.Windows.Forms.RadioButton();
            this.optSerial = new System.Windows.Forms.RadioButton();
            this.lblMsg = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblVehicle1 = new System.Windows.Forms.Label();
            this.lblVehicle = new System.Windows.Forms.Label();
            this.lbl_exp_extend = new System.Windows.Forms.Label();
            this.txt_exp_extend = new System.Windows.Forms.TextBox();
            this.dtpExpDate = new System.Windows.Forms.DateTimePicker();
            this.label16 = new System.Windows.Forms.Label();
            this.lblCustomerID = new System.Windows.Forms.Label();
            this.txt_manufacturer = new System.Windows.Forms.TextBox();
            this.txt_model = new System.Windows.Forms.TextBox();
            this.btnSearchCustomer = new System.Windows.Forms.Button();
            this.chk_free_service = new System.Windows.Forms.CheckBox();
            this.cmb_status = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtCustomerCode = new System.Windows.Forms.TextBox();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.txtCustomerAddress = new System.Windows.Forms.TextBox();
            this.txtCustomerPhone = new System.Windows.Forms.TextBox();
            this.txtSerial = new System.Windows.Forms.TextBox();
            this.btnSearchProduct = new System.Windows.Forms.Button();
            this.txtItem = new System.Windows.Forms.TextBox();
            this.txtInvoiceNo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.chk_new_fare = new System.Windows.Forms.CheckBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnPayment = new System.Windows.Forms.Button();
            this.btnReceivePrint = new System.Windows.Forms.Button();
            this.btnReceive = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgvAccountHolderList = new System.Windows.Forms.DataGridView();
            this.ServiceNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReceivedDateTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PaidAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsNewFareAdded = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Free = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.pnlVehicle.SuspendLayout();
            this.pnlSerial.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccountHolderList)).BeginInit();
            this.SuspendLayout();
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
            this.panel1.Size = new System.Drawing.Size(995, 51);
            this.panel1.TabIndex = 23;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(718, 8);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(272, 23);
            this.label12.TabIndex = 20;
            this.label12.Text = "Product Receive for Service";
            // 
            // cmbProduct
            // 
            this.cmbProduct.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProduct.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbProduct.FormattingEnabled = true;
            this.cmbProduct.Location = new System.Drawing.Point(66, 2);
            this.cmbProduct.Name = "cmbProduct";
            this.cmbProduct.Size = new System.Drawing.Size(199, 21);
            this.cmbProduct.TabIndex = 2;
            this.cmbProduct.SelectedIndexChanged += new System.EventHandler(this.cmbProduct_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(5, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 14);
            this.label3.TabIndex = 136;
            this.label3.Text = "Product";
            // 
            // cmbVariation
            // 
            this.cmbVariation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbVariation.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbVariation.FormattingEnabled = true;
            this.cmbVariation.Location = new System.Drawing.Point(326, 2);
            this.cmbVariation.Name = "cmbVariation";
            this.cmbVariation.Size = new System.Drawing.Size(199, 21);
            this.cmbVariation.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(278, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 14);
            this.label1.TabIndex = 138;
            this.label1.Text = "Model";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(542, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 14);
            this.label2.TabIndex = 140;
            this.label2.Text = "Serial No";
            // 
            // txtSerialNo
            // 
            this.txtSerialNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSerialNo.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSerialNo.ForeColor = System.Drawing.Color.Maroon;
            this.txtSerialNo.Location = new System.Drawing.Point(604, 2);
            this.txtSerialNo.Name = "txtSerialNo";
            this.txtSerialNo.Size = new System.Drawing.Size(199, 21);
            this.txtSerialNo.TabIndex = 4;
            this.txtSerialNo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSerialNo_KeyDown);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.White;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSearch.Image = global::AssetInventory.Properties.Resources.search;
            this.btnSearch.Location = new System.Drawing.Point(807, 2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(35, 21);
            this.btnSearch.TabIndex = 5;
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pnlVehicle);
            this.groupBox1.Controls.Add(this.pnlSerial);
            this.groupBox1.Controls.Add(this.optVehicle);
            this.groupBox1.Controls.Add(this.optSerial);
            this.groupBox1.Controls.Add(this.lblMsg);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.groupBox1.Location = new System.Drawing.Point(0, 51);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(995, 74);
            this.groupBox1.TabIndex = 143;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Warranty Checking";
            // 
            // pnlVehicle
            // 
            this.pnlVehicle.Controls.Add(this.button1);
            this.pnlVehicle.Controls.Add(this.label13);
            this.pnlVehicle.Controls.Add(this.textBox1);
            this.pnlVehicle.Location = new System.Drawing.Point(3, 43);
            this.pnlVehicle.Name = "pnlVehicle";
            this.pnlVehicle.Size = new System.Drawing.Size(377, 28);
            this.pnlVehicle.TabIndex = 162;
            this.pnlVehicle.Visible = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Image = global::AssetInventory.Properties.Resources.search;
            this.button1.Location = new System.Drawing.Point(333, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(35, 21);
            this.button1.TabIndex = 7;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label13.Location = new System.Drawing.Point(4, 6);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(93, 14);
            this.label13.TabIndex = 142;
            this.label13.Text = "Vehicle Number";
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.Maroon;
            this.textBox1.Location = new System.Drawing.Point(103, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(224, 21);
            this.textBox1.TabIndex = 6;
            // 
            // pnlSerial
            // 
            this.pnlSerial.Controls.Add(this.cmbProduct);
            this.pnlSerial.Controls.Add(this.label1);
            this.pnlSerial.Controls.Add(this.label2);
            this.pnlSerial.Controls.Add(this.cmbVariation);
            this.pnlSerial.Controls.Add(this.txtSerialNo);
            this.pnlSerial.Controls.Add(this.btnSearch);
            this.pnlSerial.Controls.Add(this.label3);
            this.pnlSerial.Location = new System.Drawing.Point(3, 43);
            this.pnlSerial.Name = "pnlSerial";
            this.pnlSerial.Size = new System.Drawing.Size(858, 28);
            this.pnlSerial.TabIndex = 145;
            // 
            // optVehicle
            // 
            this.optVehicle.AutoSize = true;
            this.optVehicle.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optVehicle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.optVehicle.Location = new System.Drawing.Point(153, 20);
            this.optVehicle.Name = "optVehicle";
            this.optVehicle.Size = new System.Drawing.Size(128, 18);
            this.optVehicle.TabIndex = 1;
            this.optVehicle.Text = "By Vehicle Number";
            this.optVehicle.UseVisualStyleBackColor = true;
            this.optVehicle.Visible = false;
            this.optVehicle.Click += new System.EventHandler(this.optVehicle_Click);
            // 
            // optSerial
            // 
            this.optSerial.AutoSize = true;
            this.optSerial.Checked = true;
            this.optSerial.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optSerial.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.optSerial.Location = new System.Drawing.Point(11, 20);
            this.optSerial.Name = "optSerial";
            this.optSerial.Size = new System.Drawing.Size(117, 18);
            this.optSerial.TabIndex = 0;
            this.optSerial.TabStop = true;
            this.optSerial.Text = "By Serial Number";
            this.optSerial.UseVisualStyleBackColor = true;
            this.optSerial.Click += new System.EventHandler(this.optSerial_Click);
            // 
            // lblMsg
            // 
            this.lblMsg.BackColor = System.Drawing.Color.Transparent;
            this.lblMsg.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMsg.Location = new System.Drawing.Point(340, 11);
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.Size = new System.Drawing.Size(521, 36);
            this.lblMsg.TabIndex = 0;
            this.lblMsg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblVehicle1);
            this.groupBox2.Controls.Add(this.lblVehicle);
            this.groupBox2.Controls.Add(this.lbl_exp_extend);
            this.groupBox2.Controls.Add(this.txt_exp_extend);
            this.groupBox2.Controls.Add(this.dtpExpDate);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.lblCustomerID);
            this.groupBox2.Controls.Add(this.txt_manufacturer);
            this.groupBox2.Controls.Add(this.txt_model);
            this.groupBox2.Controls.Add(this.btnSearchCustomer);
            this.groupBox2.Controls.Add(this.chk_free_service);
            this.groupBox2.Controls.Add(this.cmb_status);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.txtCustomerCode);
            this.groupBox2.Controls.Add(this.txtCustomerName);
            this.groupBox2.Controls.Add(this.txtCustomerAddress);
            this.groupBox2.Controls.Add(this.txtCustomerPhone);
            this.groupBox2.Controls.Add(this.txtSerial);
            this.groupBox2.Controls.Add(this.btnSearchProduct);
            this.groupBox2.Controls.Add(this.txtItem);
            this.groupBox2.Controls.Add(this.txtInvoiceNo);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.chk_new_fare);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.btnPayment);
            this.groupBox2.Controls.Add(this.btnReceivePrint);
            this.groupBox2.Controls.Add(this.btnReceive);
            this.groupBox2.Controls.Add(this.btnReset);
            this.groupBox2.Controls.Add(this.btnClose);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.groupBox2.Location = new System.Drawing.Point(0, 125);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(355, 447);
            this.groupBox2.TabIndex = 144;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Result";
            // 
            // lblVehicle1
            // 
            this.lblVehicle1.AutoSize = true;
            this.lblVehicle1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVehicle1.ForeColor = System.Drawing.Color.Maroon;
            this.lblVehicle1.Location = new System.Drawing.Point(8, 15);
            this.lblVehicle1.Name = "lblVehicle1";
            this.lblVehicle1.Size = new System.Drawing.Size(97, 18);
            this.lblVehicle1.TabIndex = 143;
            this.lblVehicle1.Text = "Vehicle No :";
            // 
            // lblVehicle
            // 
            this.lblVehicle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblVehicle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblVehicle.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVehicle.ForeColor = System.Drawing.Color.Maroon;
            this.lblVehicle.Location = new System.Drawing.Point(111, 14);
            this.lblVehicle.Name = "lblVehicle";
            this.lblVehicle.Size = new System.Drawing.Size(228, 22);
            this.lblVehicle.TabIndex = 196;
            this.lblVehicle.Text = "Vehicle No : ";
            this.lblVehicle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblVehicle.Visible = false;
            // 
            // lbl_exp_extend
            // 
            this.lbl_exp_extend.AutoSize = true;
            this.lbl_exp_extend.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lbl_exp_extend.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_exp_extend.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_exp_extend.Location = new System.Drawing.Point(130, 364);
            this.lbl_exp_extend.Name = "lbl_exp_extend";
            this.lbl_exp_extend.Size = new System.Drawing.Size(35, 13);
            this.lbl_exp_extend.TabIndex = 21;
            this.lbl_exp_extend.Text = "Days";
            this.lbl_exp_extend.Visible = false;
            // 
            // txt_exp_extend
            // 
            this.txt_exp_extend.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txt_exp_extend.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_exp_extend.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_exp_extend.ForeColor = System.Drawing.Color.Blue;
            this.txt_exp_extend.Location = new System.Drawing.Point(111, 361);
            this.txt_exp_extend.MaxLength = 500;
            this.txt_exp_extend.Name = "txt_exp_extend";
            this.txt_exp_extend.ReadOnly = true;
            this.txt_exp_extend.Size = new System.Drawing.Size(228, 23);
            this.txt_exp_extend.TabIndex = 20;
            this.txt_exp_extend.TabStop = false;
            this.txt_exp_extend.Text = "60";
            this.txt_exp_extend.Visible = false;
            // 
            // dtpExpDate
            // 
            this.dtpExpDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpExpDate.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dtpExpDate.CalendarMonthBackground = System.Drawing.Color.White;
            this.dtpExpDate.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dtpExpDate.CustomFormat = "dd/MMM/yyyy";
            this.dtpExpDate.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpExpDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpExpDate.Location = new System.Drawing.Point(111, 333);
            this.dtpExpDate.Name = "dtpExpDate";
            this.dtpExpDate.Size = new System.Drawing.Size(228, 21);
            this.dtpExpDate.TabIndex = 18;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label16.Location = new System.Drawing.Point(12, 335);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(70, 14);
            this.label16.TabIndex = 192;
            this.label16.Text = "Expire Date";
            // 
            // lblCustomerID
            // 
            this.lblCustomerID.AutoSize = true;
            this.lblCustomerID.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblCustomerID.Location = new System.Drawing.Point(9, 162);
            this.lblCustomerID.Name = "lblCustomerID";
            this.lblCustomerID.Size = new System.Drawing.Size(64, 13);
            this.lblCustomerID.TabIndex = 191;
            this.lblCustomerID.Text = "CustomerID";
            this.lblCustomerID.Visible = false;
            // 
            // txt_manufacturer
            // 
            this.txt_manufacturer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txt_manufacturer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_manufacturer.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_manufacturer.Location = new System.Drawing.Point(111, 120);
            this.txt_manufacturer.Name = "txt_manufacturer";
            this.txt_manufacturer.ReadOnly = true;
            this.txt_manufacturer.Size = new System.Drawing.Size(228, 21);
            this.txt_manufacturer.TabIndex = 10;
            this.txt_manufacturer.TabStop = false;
            // 
            // txt_model
            // 
            this.txt_model.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txt_model.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_model.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_model.Location = new System.Drawing.Point(111, 94);
            this.txt_model.Name = "txt_model";
            this.txt_model.ReadOnly = true;
            this.txt_model.Size = new System.Drawing.Size(228, 21);
            this.txt_model.TabIndex = 10;
            this.txt_model.TabStop = false;
            // 
            // btnSearchCustomer
            // 
            this.btnSearchCustomer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnSearchCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSearchCustomer.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchCustomer.Image = global::AssetInventory.Properties.Resources.search;
            this.btnSearchCustomer.Location = new System.Drawing.Point(318, 172);
            this.btnSearchCustomer.Name = "btnSearchCustomer";
            this.btnSearchCustomer.Size = new System.Drawing.Size(21, 21);
            this.btnSearchCustomer.TabIndex = 180;
            this.btnSearchCustomer.TabStop = false;
            this.btnSearchCustomer.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSearchCustomer.UseVisualStyleBackColor = false;
            this.btnSearchCustomer.Visible = false;
            // 
            // chk_free_service
            // 
            this.chk_free_service.AutoSize = true;
            this.chk_free_service.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_free_service.Location = new System.Drawing.Point(111, 304);
            this.chk_free_service.Name = "chk_free_service";
            this.chk_free_service.Size = new System.Drawing.Size(93, 18);
            this.chk_free_service.TabIndex = 17;
            this.chk_free_service.Text = "Free Service";
            this.chk_free_service.UseVisualStyleBackColor = true;
            // 
            // cmb_status
            // 
            this.cmb_status.Enabled = false;
            this.cmb_status.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmb_status.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_status.FormattingEnabled = true;
            this.cmb_status.Items.AddRange(new object[] {
            "Received",
            "Delivered"});
            this.cmb_status.Location = new System.Drawing.Point(111, 276);
            this.cmb_status.Name = "cmb_status";
            this.cmb_status.Size = new System.Drawing.Size(228, 21);
            this.cmb_status.TabIndex = 16;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label15.Location = new System.Drawing.Point(9, 280);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(42, 14);
            this.label15.TabIndex = 186;
            this.label15.Text = "Status";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label14.Location = new System.Drawing.Point(9, 200);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(94, 14);
            this.label14.TabIndex = 185;
            this.label14.Text = "Customer Name";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label7.Location = new System.Drawing.Point(9, 251);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 14);
            this.label7.TabIndex = 184;
            this.label7.Text = "Address";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label8.Location = new System.Drawing.Point(9, 173);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 14);
            this.label8.TabIndex = 182;
            this.label8.Text = "Customer Code";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label10.Location = new System.Drawing.Point(9, 226);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(42, 14);
            this.label10.TabIndex = 183;
            this.label10.Text = "Phone";
            // 
            // txtCustomerCode
            // 
            this.txtCustomerCode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtCustomerCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCustomerCode.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustomerCode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.txtCustomerCode.Location = new System.Drawing.Point(111, 172);
            this.txtCustomerCode.MaxLength = 30;
            this.txtCustomerCode.Name = "txtCustomerCode";
            this.txtCustomerCode.ReadOnly = true;
            this.txtCustomerCode.Size = new System.Drawing.Size(228, 21);
            this.txtCustomerCode.TabIndex = 12;
            this.txtCustomerCode.TabStop = false;
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtCustomerName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCustomerName.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustomerName.Location = new System.Drawing.Point(111, 198);
            this.txtCustomerName.MaxLength = 30;
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.ReadOnly = true;
            this.txtCustomerName.Size = new System.Drawing.Size(228, 21);
            this.txtCustomerName.TabIndex = 13;
            this.txtCustomerName.TabStop = false;
            // 
            // txtCustomerAddress
            // 
            this.txtCustomerAddress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtCustomerAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCustomerAddress.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustomerAddress.Location = new System.Drawing.Point(111, 250);
            this.txtCustomerAddress.MaxLength = 500;
            this.txtCustomerAddress.Name = "txtCustomerAddress";
            this.txtCustomerAddress.ReadOnly = true;
            this.txtCustomerAddress.Size = new System.Drawing.Size(228, 21);
            this.txtCustomerAddress.TabIndex = 15;
            this.txtCustomerAddress.TabStop = false;
            // 
            // txtCustomerPhone
            // 
            this.txtCustomerPhone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtCustomerPhone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCustomerPhone.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustomerPhone.Location = new System.Drawing.Point(111, 224);
            this.txtCustomerPhone.MaxLength = 30;
            this.txtCustomerPhone.Name = "txtCustomerPhone";
            this.txtCustomerPhone.ReadOnly = true;
            this.txtCustomerPhone.Size = new System.Drawing.Size(228, 21);
            this.txtCustomerPhone.TabIndex = 14;
            this.txtCustomerPhone.TabStop = false;
            // 
            // txtSerial
            // 
            this.txtSerial.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtSerial.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSerial.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSerial.Location = new System.Drawing.Point(111, 146);
            this.txtSerial.Name = "txtSerial";
            this.txtSerial.ReadOnly = true;
            this.txtSerial.Size = new System.Drawing.Size(228, 21);
            this.txtSerial.TabIndex = 11;
            this.txtSerial.TabStop = false;
            // 
            // btnSearchProduct
            // 
            this.btnSearchProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnSearchProduct.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSearchProduct.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchProduct.Image = global::AssetInventory.Properties.Resources.search;
            this.btnSearchProduct.Location = new System.Drawing.Point(318, 67);
            this.btnSearchProduct.Name = "btnSearchProduct";
            this.btnSearchProduct.Size = new System.Drawing.Size(21, 21);
            this.btnSearchProduct.TabIndex = 173;
            this.btnSearchProduct.TabStop = false;
            this.btnSearchProduct.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSearchProduct.UseVisualStyleBackColor = false;
            this.btnSearchProduct.Visible = false;
            // 
            // txtItem
            // 
            this.txtItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtItem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtItem.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.txtItem.Location = new System.Drawing.Point(111, 67);
            this.txtItem.MaxLength = 10;
            this.txtItem.Name = "txtItem";
            this.txtItem.ReadOnly = true;
            this.txtItem.Size = new System.Drawing.Size(228, 21);
            this.txtItem.TabIndex = 9;
            this.txtItem.TabStop = false;
            // 
            // txtInvoiceNo
            // 
            this.txtInvoiceNo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtInvoiceNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtInvoiceNo.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInvoiceNo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.txtInvoiceNo.Location = new System.Drawing.Point(111, 41);
            this.txtInvoiceNo.Name = "txtInvoiceNo";
            this.txtInvoiceNo.Size = new System.Drawing.Size(228, 21);
            this.txtInvoiceNo.TabIndex = 8;
            this.txtInvoiceNo.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(9, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 14);
            this.label4.TabIndex = 169;
            this.label4.Text = "Serial No";
            // 
            // chk_new_fare
            // 
            this.chk_new_fare.AutoSize = true;
            this.chk_new_fare.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_new_fare.Location = new System.Drawing.Point(12, 362);
            this.chk_new_fare.Name = "chk_new_fare";
            this.chk_new_fare.Size = new System.Drawing.Size(78, 18);
            this.chk_new_fare.TabIndex = 19;
            this.chk_new_fare.Text = "New Fare";
            this.chk_new_fare.UseVisualStyleBackColor = true;
            this.chk_new_fare.Visible = false;
            this.chk_new_fare.CheckedChanged += new System.EventHandler(this.chk_new_fare_CheckedChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label11.Location = new System.Drawing.Point(9, 94);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(39, 14);
            this.label11.TabIndex = 167;
            this.label11.Text = "Model";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label9.Location = new System.Drawing.Point(9, 121);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(79, 14);
            this.label9.TabIndex = 166;
            this.label9.Text = "Manufacturer";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(9, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 14);
            this.label5.TabIndex = 165;
            this.label5.Text = "Product";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label6.Location = new System.Drawing.Point(9, 43);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 14);
            this.label6.TabIndex = 164;
            this.label6.Text = "Receive No";
            // 
            // btnPayment
            // 
            this.btnPayment.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnPayment.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPayment.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPayment.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnPayment.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPayment.Location = new System.Drawing.Point(5, 406);
            this.btnPayment.Name = "btnPayment";
            this.btnPayment.Size = new System.Drawing.Size(66, 35);
            this.btnPayment.TabIndex = 23;
            this.btnPayment.Text = "Payment";
            this.btnPayment.UseVisualStyleBackColor = false;
            this.btnPayment.Click += new System.EventHandler(this.btnPayment_Click);
            // 
            // btnReceivePrint
            // 
            this.btnReceivePrint.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnReceivePrint.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnReceivePrint.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReceivePrint.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnReceivePrint.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReceivePrint.Location = new System.Drawing.Point(73, 406);
            this.btnReceivePrint.Name = "btnReceivePrint";
            this.btnReceivePrint.Size = new System.Drawing.Size(66, 35);
            this.btnReceivePrint.TabIndex = 22;
            this.btnReceivePrint.Text = "Print";
            this.btnReceivePrint.UseVisualStyleBackColor = false;
            // 
            // btnReceive
            // 
            this.btnReceive.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnReceive.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnReceive.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReceive.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnReceive.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReceive.Location = new System.Drawing.Point(141, 406);
            this.btnReceive.Name = "btnReceive";
            this.btnReceive.Size = new System.Drawing.Size(66, 35);
            this.btnReceive.TabIndex = 21;
            this.btnReceive.Text = "Receive Product";
            this.btnReceive.UseVisualStyleBackColor = false;
            this.btnReceive.Click += new System.EventHandler(this.btnReceiveProduct_Click);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnReset.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnReset.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReset.Location = new System.Drawing.Point(209, 406);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(66, 35);
            this.btnReset.TabIndex = 24;
            this.btnReset.Text = "&Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnResetForm_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClose.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(277, 406);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(66, 35);
            this.btnClose.TabIndex = 25;
            this.btnClose.Text = "&Close";
            this.btnClose.UseVisualStyleBackColor = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgvAccountHolderList);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox3.Location = new System.Drawing.Point(361, 125);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(634, 447);
            this.groupBox3.TabIndex = 145;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Service List";
            // 
            // dgvAccountHolderList
            // 
            this.dgvAccountHolderList.AllowUserToAddRows = false;
            this.dgvAccountHolderList.AllowUserToDeleteRows = false;
            this.dgvAccountHolderList.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(240)))), ((int)(((byte)(250)))));
            this.dgvAccountHolderList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAccountHolderList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAccountHolderList.BackgroundColor = System.Drawing.Color.White;
            this.dgvAccountHolderList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvAccountHolderList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAccountHolderList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ServiceNumber,
            this.description,
            this.ReceivedDateTime,
            this.PaidAmount,
            this.IsNewFareAdded,
            this.Free});
            this.dgvAccountHolderList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAccountHolderList.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvAccountHolderList.Location = new System.Drawing.Point(3, 17);
            this.dgvAccountHolderList.MultiSelect = false;
            this.dgvAccountHolderList.Name = "dgvAccountHolderList";
            this.dgvAccountHolderList.RowHeadersVisible = false;
            this.dgvAccountHolderList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAccountHolderList.Size = new System.Drawing.Size(628, 427);
            this.dgvAccountHolderList.StandardTab = true;
            this.dgvAccountHolderList.TabIndex = 6;
            // 
            // ServiceNumber
            // 
            this.ServiceNumber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ServiceNumber.DataPropertyName = "ServiceNumber";
            this.ServiceNumber.HeaderText = "ServiceNo";
            this.ServiceNumber.Name = "ServiceNumber";
            this.ServiceNumber.ReadOnly = true;
            this.ServiceNumber.Width = 80;
            // 
            // description
            // 
            this.description.DataPropertyName = "description";
            this.description.HeaderText = "Description";
            this.description.Name = "description";
            this.description.ReadOnly = true;
            // 
            // ReceivedDateTime
            // 
            this.ReceivedDateTime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ReceivedDateTime.DataPropertyName = "ReceivedDateTime";
            this.ReceivedDateTime.HeaderText = "Date";
            this.ReceivedDateTime.Name = "ReceivedDateTime";
            this.ReceivedDateTime.ReadOnly = true;
            this.ReceivedDateTime.Width = 90;
            // 
            // PaidAmount
            // 
            this.PaidAmount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.PaidAmount.DataPropertyName = "PaidAmount";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Format = "N0";
            dataGridViewCellStyle2.NullValue = null;
            this.PaidAmount.DefaultCellStyle = dataGridViewCellStyle2;
            this.PaidAmount.HeaderText = "PaidAmount";
            this.PaidAmount.Name = "PaidAmount";
            this.PaidAmount.ReadOnly = true;
            this.PaidAmount.Width = 90;
            // 
            // IsNewFareAdded
            // 
            this.IsNewFareAdded.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.IsNewFareAdded.DataPropertyName = "IsNewFareAdded";
            this.IsNewFareAdded.HeaderText = "FareChange";
            this.IsNewFareAdded.Name = "IsNewFareAdded";
            this.IsNewFareAdded.ReadOnly = true;
            this.IsNewFareAdded.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.IsNewFareAdded.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.IsNewFareAdded.Width = 80;
            // 
            // Free
            // 
            this.Free.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Free.DataPropertyName = "IsWarrentyApplicable";
            this.Free.HeaderText = "Free";
            this.Free.Name = "Free";
            this.Free.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Free.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Free.Width = 90;
            // 
            // frmWarrantyCheck
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(242)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(995, 572);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmWarrantyCheck";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Warranty Check";
            this.Load += new System.EventHandler(this.frmWarrantyCheck_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.pnlVehicle.ResumeLayout(false);
            this.pnlVehicle.PerformLayout();
            this.pnlSerial.ResumeLayout(false);
            this.pnlSerial.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccountHolderList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cmbProduct;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbVariation;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSerialNo;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblMsg;
        private System.Windows.Forms.Button btnReceive;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgvAccountHolderList;
        private System.Windows.Forms.RadioButton optVehicle;
        private System.Windows.Forms.RadioButton optSerial;
        private System.Windows.Forms.Panel pnlSerial;
        private System.Windows.Forms.Panel pnlVehicle;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnPayment;
        private System.Windows.Forms.Button btnReceivePrint;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox chk_new_fare;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtInvoiceNo;
        private System.Windows.Forms.Button btnSearchProduct;
        private System.Windows.Forms.TextBox txtItem;
        private System.Windows.Forms.TextBox txtSerial;
        private System.Windows.Forms.TextBox txtCustomerCode;
        private System.Windows.Forms.Button btnSearchCustomer;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.TextBox txtCustomerAddress;
        private System.Windows.Forms.TextBox txtCustomerPhone;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cmb_status;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.CheckBox chk_free_service;
        private System.Windows.Forms.TextBox txt_manufacturer;
        private System.Windows.Forms.TextBox txt_model;
        private System.Windows.Forms.Label lblCustomerID;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.DateTimePicker dtpExpDate;
        private System.Windows.Forms.Label lbl_exp_extend;
        private System.Windows.Forms.TextBox txt_exp_extend;
        private System.Windows.Forms.Label lblVehicle;
        private System.Windows.Forms.Label lblVehicle1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ServiceNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn description;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReceivedDateTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn PaidAmount;
        private System.Windows.Forms.DataGridViewCheckBoxColumn IsNewFareAdded;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Free;
    }
}