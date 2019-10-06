namespace AssetInventory
{
    partial class frmSalesInvoiceCNG
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSalesInvoiceCNG));
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.treeView = new System.Windows.Forms.TreeView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnResetForm = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtDues = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtPaid = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.cmb_salesman = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cmb_customer = new System.Windows.Forms.ComboBox();
            this.txtCustomerAddress = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCustomerPhone = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.dgvSalesGrid = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtItemName = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.btnAddtoGrid_byItemCode = new System.Windows.Forms.Button();
            this.btnAddtoGrid = new System.Windows.Forms.Button();
            this.dtpPurchaseDate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.txtItemCode = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblInword = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblTotalItemAmount = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSeachProduct = new System.Windows.Forms.Button();
            this.txtItemCode1 = new System.Windows.Forms.TextBox();
            this.lblInvoiceNo = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Sl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SaleQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnitName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Vat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WarrentyName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CNGNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SerialNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SalesPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalVat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DaysCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WarrentyID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StockQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalesGrid)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer
            // 
            this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer.Location = new System.Drawing.Point(0, 51);
            this.splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.Controls.Add(this.treeView);
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.panel3);
            this.splitContainer.Size = new System.Drawing.Size(1023, 461);
            this.splitContainer.SplitterDistance = 191;
            this.splitContainer.TabIndex = 26;
            this.splitContainer.DoubleClick += new System.EventHandler(this.splitContainer_DoubleClick);
            this.splitContainer.SplitterMoved += new System.Windows.Forms.SplitterEventHandler(this.splitContainer_SplitterMoved);
            // 
            // treeView
            // 
            this.treeView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treeView.Location = new System.Drawing.Point(0, 0);
            this.treeView.Name = "treeView";
            this.treeView.Size = new System.Drawing.Size(191, 461);
            this.treeView.TabIndex = 1;
            this.treeView.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView_NodeMouseDoubleClick);
            this.treeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView_AfterSelect);
            this.treeView.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView_NodeMouseClick);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.dgvSalesGrid);
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Controls.Add(this.lblInword);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.lblTotalItemAmount);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(828, 461);
            this.panel3.TabIndex = 26;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnResetForm);
            this.panel4.Controls.Add(this.groupBox2);
            this.panel4.Controls.Add(this.btnClose);
            this.panel4.Controls.Add(this.groupBox1);
            this.panel4.Controls.Add(this.btnPrint);
            this.panel4.Controls.Add(this.btnSave);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 308);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(828, 153);
            this.panel4.TabIndex = 80;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // btnResetForm
            // 
            this.btnResetForm.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnResetForm.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnResetForm.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResetForm.ForeColor = System.Drawing.Color.Black;
            this.btnResetForm.Image = global::AssetInventory.Properties.Resources.icon_reset;
            this.btnResetForm.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnResetForm.Location = new System.Drawing.Point(515, 47);
            this.btnResetForm.Name = "btnResetForm";
            this.btnResetForm.Size = new System.Drawing.Size(74, 25);
            this.btnResetForm.TabIndex = 9;
            this.btnResetForm.Text = "&Reset";
            this.btnResetForm.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnResetForm.UseVisualStyleBackColor = false;
            this.btnResetForm.Click += new System.EventHandler(this.btnResetForm_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.txtDues);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.txtPaid);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.ForeColor = System.Drawing.Color.Blue;
            this.groupBox2.Location = new System.Drawing.Point(648, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(178, 148);
            this.groupBox2.TabIndex = 72;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Payment Info";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // txtDues
            // 
            this.txtDues.BackColor = System.Drawing.Color.White;
            this.txtDues.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDues.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDues.ForeColor = System.Drawing.Color.Red;
            this.txtDues.Location = new System.Drawing.Point(67, 48);
            this.txtDues.Name = "txtDues";
            this.txtDues.ReadOnly = true;
            this.txtDues.Size = new System.Drawing.Size(104, 30);
            this.txtDues.TabIndex = 13;
            this.txtDues.TabStop = false;
            this.txtDues.Text = "0.00";
            this.txtDues.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtDues.TextChanged += new System.EventHandler(this.txtDues_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(9, 51);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(49, 13);
            this.label11.TabIndex = 15;
            this.label11.Text = "Change";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // txtPaid
            // 
            this.txtPaid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtPaid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPaid.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPaid.Location = new System.Drawing.Point(67, 19);
            this.txtPaid.MaxLength = 10;
            this.txtPaid.Name = "txtPaid";
            this.txtPaid.Size = new System.Drawing.Size(104, 30);
            this.txtPaid.TabIndex = 6;
            this.txtPaid.Text = "0.00";
            this.txtPaid.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtPaid.TextChanged += new System.EventHandler(this.txtPaid_TextChanged);
            this.txtPaid.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPaid_KeyPress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(9, 23);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(31, 13);
            this.label10.TabIndex = 13;
            this.label10.Text = "Paid";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClose.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.Black;
            this.btnClose.Image = global::AssetInventory.Properties.Resources.Close1;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(515, 74);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(74, 25);
            this.btnClose.TabIndex = 10;
            this.btnClose.Text = "&Close";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.txtCustomerName);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.cmb_salesman);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.cmb_customer);
            this.groupBox1.Controls.Add(this.txtCustomerAddress);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtCustomerPhone);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.ForeColor = System.Drawing.Color.Blue;
            this.groupBox1.Location = new System.Drawing.Point(4, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(416, 148);
            this.groupBox1.TabIndex = 70;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Invoice To";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.BackColor = System.Drawing.Color.LemonChiffon;
            this.txtCustomerName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCustomerName.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustomerName.Location = new System.Drawing.Point(107, 44);
            this.txtCustomerName.MaxLength = 30;
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.ReadOnly = true;
            this.txtCustomerName.Size = new System.Drawing.Size(297, 21);
            this.txtCustomerName.TabIndex = 3;
            this.txtCustomerName.TextChanged += new System.EventHandler(this.txtCustomerName_TextChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Black;
            this.label14.Location = new System.Drawing.Point(7, 45);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(97, 13);
            this.label14.TabIndex = 71;
            this.label14.Text = "Customer Name";
            this.label14.Click += new System.EventHandler(this.label14_Click);
            // 
            // cmb_salesman
            // 
            this.cmb_salesman.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmb_salesman.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmb_salesman.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_salesman.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cmb_salesman.FormattingEnabled = true;
            this.cmb_salesman.Location = new System.Drawing.Point(107, 123);
            this.cmb_salesman.Name = "cmb_salesman";
            this.cmb_salesman.Size = new System.Drawing.Size(297, 21);
            this.cmb_salesman.TabIndex = 1;
            this.cmb_salesman.Visible = false;
            this.cmb_salesman.SelectedIndexChanged += new System.EventHandler(this.cmb_salesman_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(6, 125);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 13);
            this.label8.TabIndex = 68;
            this.label8.Text = "Salesman";
            this.label8.Visible = false;
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // cmb_customer
            // 
            this.cmb_customer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_customer.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmb_customer.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_customer.ForeColor = System.Drawing.Color.Sienna;
            this.cmb_customer.FormattingEnabled = true;
            this.cmb_customer.Location = new System.Drawing.Point(107, 17);
            this.cmb_customer.Name = "cmb_customer";
            this.cmb_customer.Size = new System.Drawing.Size(297, 21);
            this.cmb_customer.TabIndex = 2;
            this.cmb_customer.SelectedIndexChanged += new System.EventHandler(this.cmb_customer_SelectedIndexChanged);
            // 
            // txtCustomerAddress
            // 
            this.txtCustomerAddress.BackColor = System.Drawing.Color.LemonChiffon;
            this.txtCustomerAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCustomerAddress.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustomerAddress.Location = new System.Drawing.Point(107, 96);
            this.txtCustomerAddress.MaxLength = 500;
            this.txtCustomerAddress.Name = "txtCustomerAddress";
            this.txtCustomerAddress.ReadOnly = true;
            this.txtCustomerAddress.Size = new System.Drawing.Size(297, 21);
            this.txtCustomerAddress.TabIndex = 5;
            this.txtCustomerAddress.TextChanged += new System.EventHandler(this.txtCustomerAddress_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(7, 96);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 66;
            this.label6.Text = "Address";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(6, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 62;
            this.label3.Text = "Customer";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtCustomerPhone
            // 
            this.txtCustomerPhone.BackColor = System.Drawing.Color.LemonChiffon;
            this.txtCustomerPhone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCustomerPhone.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustomerPhone.Location = new System.Drawing.Point(107, 71);
            this.txtCustomerPhone.MaxLength = 30;
            this.txtCustomerPhone.Name = "txtCustomerPhone";
            this.txtCustomerPhone.ReadOnly = true;
            this.txtCustomerPhone.Size = new System.Drawing.Size(297, 21);
            this.txtCustomerPhone.TabIndex = 4;
            this.txtCustomerPhone.TextChanged += new System.EventHandler(this.txtCustomerPhone_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(7, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 64;
            this.label4.Text = "Phone";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnPrint.Enabled = false;
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPrint.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.ForeColor = System.Drawing.Color.Black;
            this.btnPrint.Image = global::AssetInventory.Properties.Resources.pf_print_icon;
            this.btnPrint.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrint.Location = new System.Drawing.Point(437, 74);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(74, 25);
            this.btnPrint.TabIndex = 8;
            this.btnPrint.Text = "&Print";
            this.btnPrint.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSave.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.Black;
            this.btnSave.Image = global::AssetInventory.Properties.Resources.Save;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(437, 47);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(74, 25);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "&Save";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
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
            this.SaleQty,
            this.UnitName,
            this.Vat,
            this.WarrentyName,
            this.CNGNo,
            this.SerialNo,
            this.SalesPrice,
            this.TotalVat,
            this.TotalPrice,
            this.DaysCount,
            this.WarrentyID,
            this.StockQty,
            this.ItemID});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.LightBlue;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSalesGrid.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvSalesGrid.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvSalesGrid.Location = new System.Drawing.Point(0, 32);
            this.dgvSalesGrid.MultiSelect = false;
            this.dgvSalesGrid.Name = "dgvSalesGrid";
            this.dgvSalesGrid.RowHeadersVisible = false;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvSalesGrid.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvSalesGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSalesGrid.Size = new System.Drawing.Size(828, 249);
            this.dgvSalesGrid.TabIndex = 79;
            this.dgvSalesGrid.TabStop = false;
            this.dgvSalesGrid.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSalesGrid_CellEndEdit);
            this.dgvSalesGrid.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvSalesGrid_KeyDown);
            this.dgvSalesGrid.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dgvSalesGrid_KeyPress);
            this.dgvSalesGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSalesGrid_CellContentClick);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtItemName);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.btnAddtoGrid_byItemCode);
            this.panel2.Controls.Add(this.btnAddtoGrid);
            this.panel2.Controls.Add(this.dtpPurchaseDate);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txtItemCode);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(828, 32);
            this.panel2.TabIndex = 78;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // txtItemName
            // 
            this.txtItemName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtItemName.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtItemName.Location = new System.Drawing.Point(73, 6);
            this.txtItemName.MaxLength = 10;
            this.txtItemName.Name = "txtItemName";
            this.txtItemName.Size = new System.Drawing.Size(175, 22);
            this.txtItemName.TabIndex = 73;
            this.txtItemName.TextChanged += new System.EventHandler(this.txtItemName_TextChanged);
            this.txtItemName.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtItemName_KeyUp);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label13.Location = new System.Drawing.Point(4, 10);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(70, 13);
            this.label13.TabIndex = 74;
            this.label13.Text = "Item Name";
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // btnAddtoGrid_byItemCode
            // 
            this.btnAddtoGrid_byItemCode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnAddtoGrid_byItemCode.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddtoGrid_byItemCode.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddtoGrid_byItemCode.Location = new System.Drawing.Point(526, 7);
            this.btnAddtoGrid_byItemCode.Name = "btnAddtoGrid_byItemCode";
            this.btnAddtoGrid_byItemCode.Size = new System.Drawing.Size(20, 21);
            this.btnAddtoGrid_byItemCode.TabIndex = 67;
            this.btnAddtoGrid_byItemCode.Text = "+";
            this.btnAddtoGrid_byItemCode.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAddtoGrid_byItemCode.UseVisualStyleBackColor = false;
            this.btnAddtoGrid_byItemCode.Click += new System.EventHandler(this.btnAddtoGrid_byItemCode_Click);
            // 
            // btnAddtoGrid
            // 
            this.btnAddtoGrid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnAddtoGrid.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddtoGrid.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddtoGrid.Location = new System.Drawing.Point(250, 6);
            this.btnAddtoGrid.Name = "btnAddtoGrid";
            this.btnAddtoGrid.Size = new System.Drawing.Size(21, 22);
            this.btnAddtoGrid.TabIndex = 66;
            this.btnAddtoGrid.Text = "+";
            this.btnAddtoGrid.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAddtoGrid.UseVisualStyleBackColor = false;
            this.btnAddtoGrid.Click += new System.EventHandler(this.btnAddtoGrid_Click);
            // 
            // dtpPurchaseDate
            // 
            this.dtpPurchaseDate.CalendarMonthBackground = System.Drawing.Color.White;
            this.dtpPurchaseDate.CustomFormat = "dd/MMM/yyyy";
            this.dtpPurchaseDate.Enabled = false;
            this.dtpPurchaseDate.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpPurchaseDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpPurchaseDate.Location = new System.Drawing.Point(630, 3);
            this.dtpPurchaseDate.Name = "dtpPurchaseDate";
            this.dtpPurchaseDate.Size = new System.Drawing.Size(96, 21);
            this.dtpPurchaseDate.TabIndex = 65;
            this.dtpPurchaseDate.ValueChanged += new System.EventHandler(this.dtpPurchaseDate_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(557, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 64;
            this.label2.Text = "Sales Date";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtItemCode
            // 
            this.txtItemCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtItemCode.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtItemCode.Location = new System.Drawing.Point(361, 7);
            this.txtItemCode.MaxLength = 10;
            this.txtItemCode.Name = "txtItemCode";
            this.txtItemCode.Size = new System.Drawing.Size(163, 21);
            this.txtItemCode.TabIndex = 0;
            this.txtItemCode.TextChanged += new System.EventHandler(this.txtItemCode_TextChanged);
            this.txtItemCode.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtItemCode_KeyUp);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(290, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 61;
            this.label5.Text = "Item Code";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // lblInword
            // 
            this.lblInword.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInword.ForeColor = System.Drawing.Color.Sienna;
            this.lblInword.Location = new System.Drawing.Point(63, 282);
            this.lblInword.Name = "lblInword";
            this.lblInword.Size = new System.Drawing.Size(361, 26);
            this.lblInword.TabIndex = 77;
            this.lblInword.Text = "In Word: ";
            this.lblInword.Click += new System.EventHandler(this.lblInword_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Sienna;
            this.label7.Location = new System.Drawing.Point(6, 282);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 13);
            this.label7.TabIndex = 76;
            this.label7.Text = "In Word : ";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // lblTotalItemAmount
            // 
            this.lblTotalItemAmount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotalItemAmount.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalItemAmount.Location = new System.Drawing.Point(672, 283);
            this.lblTotalItemAmount.Name = "lblTotalItemAmount";
            this.lblTotalItemAmount.Size = new System.Drawing.Size(151, 22);
            this.lblTotalItemAmount.TabIndex = 72;
            this.lblTotalItemAmount.Text = "0.00";
            this.lblTotalItemAmount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblTotalItemAmount.Click += new System.EventHandler(this.lblTotalItemAmount_Click);
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(547, 287);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(128, 13);
            this.label9.TabIndex = 71;
            this.label9.Text = "Total Amount (BDT) : ";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::AssetInventory.Properties.Resources.form_banner;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnSeachProduct);
            this.panel1.Controls.Add(this.txtItemCode1);
            this.panel1.Controls.Add(this.lblInvoiceNo);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1023, 51);
            this.panel1.TabIndex = 23;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnSeachProduct
            // 
            this.btnSeachProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnSeachProduct.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSeachProduct.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeachProduct.Image = global::AssetInventory.Properties.Resources.search;
            this.btnSeachProduct.Location = new System.Drawing.Point(434, 14);
            this.btnSeachProduct.Name = "btnSeachProduct";
            this.btnSeachProduct.Size = new System.Drawing.Size(21, 22);
            this.btnSeachProduct.TabIndex = 68;
            this.btnSeachProduct.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSeachProduct.UseVisualStyleBackColor = false;
            this.btnSeachProduct.Visible = false;
            this.btnSeachProduct.Click += new System.EventHandler(this.btnSeachProduct_Click);
            // 
            // txtItemCode1
            // 
            this.txtItemCode1.Location = new System.Drawing.Point(257, 16);
            this.txtItemCode1.Name = "txtItemCode1";
            this.txtItemCode1.Size = new System.Drawing.Size(175, 21);
            this.txtItemCode1.TabIndex = 67;
            this.txtItemCode1.Visible = false;
            this.txtItemCode1.TextChanged += new System.EventHandler(this.txtItemCode1_TextChanged);
            // 
            // lblInvoiceNo
            // 
            this.lblInvoiceNo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblInvoiceNo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblInvoiceNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblInvoiceNo.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInvoiceNo.ForeColor = System.Drawing.Color.Maroon;
            this.lblInvoiceNo.Location = new System.Drawing.Point(852, 12);
            this.lblInvoiceNo.Name = "lblInvoiceNo";
            this.lblInvoiceNo.Size = new System.Drawing.Size(164, 24);
            this.lblInvoiceNo.TabIndex = 66;
            this.lblInvoiceNo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblInvoiceNo.Click += new System.EventHandler(this.lblInvoiceNo_Click);
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
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(782, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 63;
            this.label1.Text = "Invoice No";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Sl
            // 
            this.Sl.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Sl.HeaderText = "Sl";
            this.Sl.Name = "Sl";
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
            this.ItemCode.Width = 85;
            // 
            // ItemDescription
            // 
            this.ItemDescription.DataPropertyName = "ItemDescription";
            this.ItemDescription.FillWeight = 13.10479F;
            this.ItemDescription.HeaderText = "Item Description";
            this.ItemDescription.Name = "ItemDescription";
            this.ItemDescription.ReadOnly = true;
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
            // CNGNo
            // 
            this.CNGNo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.CNGNo.DataPropertyName = "CNGNo";
            this.CNGNo.HeaderText = "CNG No";
            this.CNGNo.Name = "CNGNo";
            this.CNGNo.Width = 70;
            // 
            // SerialNo
            // 
            this.SerialNo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.SerialNo.DataPropertyName = "SerialNo";
            this.SerialNo.HeaderText = "Meter No";
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
            this.StockQty.FillWeight = 23.1422F;
            this.StockQty.HeaderText = "StockQty";
            this.StockQty.Name = "StockQty";
            this.StockQty.ReadOnly = true;
            this.StockQty.Visible = false;
            this.StockQty.Width = 50;
            // 
            // ItemID
            // 
            this.ItemID.HeaderText = "ItemID";
            this.ItemID.Name = "ItemID";
            this.ItemID.Visible = false;
            // 
            // frmSalesInvoiceCNG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(242)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1023, 512);
            this.Controls.Add(this.splitContainer);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSalesInvoiceCNG";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sales Invice";
            this.Load += new System.EventHandler(this.frmSalesInvoiceCNG_Load);
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel2.ResumeLayout(false);
            this.splitContainer.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalesGrid)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.SplitContainer splitContainer;
        private System.Windows.Forms.TreeView treeView;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dgvSalesGrid;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DateTimePicker dtpPurchaseDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtItemCode;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblInword;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblTotalItemAmount;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtDues;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtPaid;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtCustomerAddress;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCustomerPhone;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblInvoiceNo;
        private System.Windows.Forms.ComboBox cmb_customer;
        private System.Windows.Forms.ComboBox cmb_salesman;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnAddtoGrid;
        private System.Windows.Forms.Button btnAddtoGrid_byItemCode;
        private System.Windows.Forms.TextBox txtItemName;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtItemCode1;
        private System.Windows.Forms.Button btnSeachProduct;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btnResetForm;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sl;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn SaleQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnitName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Vat;
        private System.Windows.Forms.DataGridViewTextBoxColumn WarrentyName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CNGNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn SerialNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn SalesPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalVat;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn DaysCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn WarrentyID;
        private System.Windows.Forms.DataGridViewTextBoxColumn StockQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemID;
    }
}