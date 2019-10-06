namespace AssetInventory
{
    partial class frmAccountTransaction
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAccountTransaction));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnResetForm = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.dgvAccountTransaction = new System.Windows.Forms.DataGridView();
            this.ATID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TransactionDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TerminalID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AccountNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AccHolderName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ATTID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TransactionType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Debit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Credit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsEditable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RefNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtpFrom = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpTo = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.cmbAccTransTypeSearch = new System.Windows.Forms.ComboBox();
            this.chkTransactionType = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmb_supplier_search = new System.Windows.Forms.ComboBox();
            this.cmbRecordType = new System.Windows.Forms.ComboBox();
            this.btnSearchUser = new System.Windows.Forms.Button();
            this.lblRecordCount = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cmbAccTransType = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtAtid = new System.Windows.Forms.TextBox();
            this.lblDrCr = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpTransactionDate = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.cmb_supplier = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccountTransaction)).BeginInit();
            this.groupBox1.SuspendLayout();
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
            this.panel1.Size = new System.Drawing.Size(988, 42);
            this.panel1.TabIndex = 22;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(769, 8);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(202, 24);
            this.label12.TabIndex = 20;
            this.label12.Text = "Account Transaction";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btnResetForm);
            this.groupBox5.Controls.Add(this.btnClose);
            this.groupBox5.Controls.Add(this.btnSave);
            this.groupBox5.Location = new System.Drawing.Point(755, 541);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(232, 37);
            this.groupBox5.TabIndex = 79;
            this.groupBox5.TabStop = false;
            // 
            // btnResetForm
            // 
            this.btnResetForm.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnResetForm.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnResetForm.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResetForm.Image = global::AssetInventory.Properties.Resources.icon_reset;
            this.btnResetForm.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnResetForm.Location = new System.Drawing.Point(4, 8);
            this.btnResetForm.Name = "btnResetForm";
            this.btnResetForm.Size = new System.Drawing.Size(74, 25);
            this.btnResetForm.TabIndex = 17;
            this.btnResetForm.Text = "&Reset";
            this.btnResetForm.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnResetForm.UseVisualStyleBackColor = false;
            this.btnResetForm.Click += new System.EventHandler(this.btnResetForm_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClose.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Image = global::AssetInventory.Properties.Resources.Close1;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(154, 8);
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
            this.btnSave.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Image = global::AssetInventory.Properties.Resources.Save;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(79, 8);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(74, 25);
            this.btnSave.TabIndex = 16;
            this.btnSave.Text = "&Save";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // dgvAccountTransaction
            // 
            this.dgvAccountTransaction.AllowUserToAddRows = false;
            this.dgvAccountTransaction.AllowUserToDeleteRows = false;
            this.dgvAccountTransaction.AllowUserToResizeRows = false;
            this.dgvAccountTransaction.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAccountTransaction.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAccountTransaction.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAccountTransaction.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAccountTransaction.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ATID,
            this.TransactionDate,
            this.TerminalID,
            this.AccountNo,
            this.AccHolderName,
            this.ATTID,
            this.TransactionType,
            this.Debit,
            this.Credit,
            this.IsEditable,
            this.Description,
            this.RefNo});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(240)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAccountTransaction.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvAccountTransaction.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvAccountTransaction.Location = new System.Drawing.Point(220, 45);
            this.dgvAccountTransaction.MultiSelect = false;
            this.dgvAccountTransaction.Name = "dgvAccountTransaction";
            this.dgvAccountTransaction.RowHeadersVisible = false;
            this.dgvAccountTransaction.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAccountTransaction.Size = new System.Drawing.Size(768, 438);
            this.dgvAccountTransaction.TabIndex = 80;
            this.dgvAccountTransaction.TabStop = false;
            this.dgvAccountTransaction.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvAccountTransaction_CellMouseClick);
            this.dgvAccountTransaction.SelectionChanged += new System.EventHandler(this.dgvAccountTransaction_SelectionChanged);
            // 
            // ATID
            // 
            this.ATID.DataPropertyName = "ATID";
            this.ATID.HeaderText = "ATID";
            this.ATID.Name = "ATID";
            this.ATID.Visible = false;
            // 
            // TransactionDate
            // 
            this.TransactionDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.TransactionDate.DataPropertyName = "TransactionDate";
            dataGridViewCellStyle2.Format = "d";
            dataGridViewCellStyle2.NullValue = null;
            this.TransactionDate.DefaultCellStyle = dataGridViewCellStyle2;
            this.TransactionDate.FillWeight = 534.2331F;
            this.TransactionDate.HeaderText = "Date";
            this.TransactionDate.Name = "TransactionDate";
            this.TransactionDate.Width = 80;
            // 
            // TerminalID
            // 
            this.TerminalID.DataPropertyName = "TerminalID";
            this.TerminalID.HeaderText = "Terminal";
            this.TerminalID.Name = "TerminalID";
            this.TerminalID.Visible = false;
            // 
            // AccountNo
            // 
            this.AccountNo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.AccountNo.DataPropertyName = "AccountNo";
            this.AccountNo.FillWeight = 15.995F;
            this.AccountNo.HeaderText = "Account No";
            this.AccountNo.Name = "AccountNo";
            this.AccountNo.Width = 110;
            // 
            // AccHolderName
            // 
            this.AccHolderName.DataPropertyName = "AccHolderName";
            this.AccHolderName.FillWeight = 15.995F;
            this.AccHolderName.HeaderText = "Account Name";
            this.AccHolderName.Name = "AccHolderName";
            // 
            // ATTID
            // 
            this.ATTID.DataPropertyName = "ATTID";
            this.ATTID.HeaderText = "ATTID";
            this.ATTID.Name = "ATTID";
            this.ATTID.Visible = false;
            // 
            // TransactionType
            // 
            this.TransactionType.DataPropertyName = "TransactionType";
            this.TransactionType.FillWeight = 15.995F;
            this.TransactionType.HeaderText = "Transaction Type";
            this.TransactionType.Name = "TransactionType";
            // 
            // Debit
            // 
            this.Debit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Debit.DataPropertyName = "Debit";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.Debit.DefaultCellStyle = dataGridViewCellStyle3;
            this.Debit.FillWeight = 15.995F;
            this.Debit.HeaderText = "Debit";
            this.Debit.Name = "Debit";
            this.Debit.Width = 90;
            // 
            // Credit
            // 
            this.Credit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Credit.DataPropertyName = "Credit";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.Credit.DefaultCellStyle = dataGridViewCellStyle4;
            this.Credit.FillWeight = 15.995F;
            this.Credit.HeaderText = "Credit";
            this.Credit.Name = "Credit";
            this.Credit.Width = 90;
            // 
            // IsEditable
            // 
            this.IsEditable.DataPropertyName = "IsEditable";
            this.IsEditable.HeaderText = "Editable";
            this.IsEditable.Name = "IsEditable";
            this.IsEditable.Visible = false;
            // 
            // Description
            // 
            this.Description.DataPropertyName = "Description";
            this.Description.FillWeight = 15.995F;
            this.Description.HeaderText = "Description";
            this.Description.Name = "Description";
            this.Description.Visible = false;
            // 
            // RefNo
            // 
            this.RefNo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.RefNo.DataPropertyName = "RefNo";
            this.RefNo.HeaderText = "RefNo";
            this.RefNo.Name = "RefNo";
            this.RefNo.Width = 110;
            // 
            // dtpFrom
            // 
            this.dtpFrom.CustomFormat = "dd-MMM-yyyy";
            this.dtpFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFrom.Location = new System.Drawing.Point(87, 17);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(120, 20);
            this.dtpFrom.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(10, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 82;
            this.label1.Text = "Date From ";
            // 
            // dtpTo
            // 
            this.dtpTo.CustomFormat = "dd-MMM-yyyy";
            this.dtpTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTo.Location = new System.Drawing.Point(87, 45);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Size = new System.Drawing.Size(120, 20);
            this.dtpTo.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(10, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 84;
            this.label2.Text = "Date To ";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label20.Location = new System.Drawing.Point(10, 70);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(73, 13);
            this.label20.TabIndex = 87;
            this.label20.Text = "Account No ";
            // 
            // cmbAccTransTypeSearch
            // 
            this.cmbAccTransTypeSearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAccTransTypeSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbAccTransTypeSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbAccTransTypeSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cmbAccTransTypeSearch.FormattingEnabled = true;
            this.cmbAccTransTypeSearch.Location = new System.Drawing.Point(10, 130);
            this.cmbAccTransTypeSearch.Name = "cmbAccTransTypeSearch";
            this.cmbAccTransTypeSearch.Size = new System.Drawing.Size(197, 21);
            this.cmbAccTransTypeSearch.TabIndex = 6;
            // 
            // chkTransactionType
            // 
            this.chkTransactionType.AutoSize = true;
            this.chkTransactionType.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkTransactionType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.chkTransactionType.Location = new System.Drawing.Point(10, 111);
            this.chkTransactionType.Name = "chkTransactionType";
            this.chkTransactionType.Size = new System.Drawing.Size(124, 17);
            this.chkTransactionType.TabIndex = 5;
            this.chkTransactionType.Text = "Transaction Type";
            this.chkTransactionType.UseVisualStyleBackColor = true;
            this.chkTransactionType.CheckedChanged += new System.EventHandler(this.chkTransactionType_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmb_supplier_search);
            this.groupBox1.Controls.Add(this.cmbRecordType);
            this.groupBox1.Controls.Add(this.btnSearchUser);
            this.groupBox1.Controls.Add(this.lblRecordCount);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.dtpFrom);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.chkTransactionType);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cmbAccTransTypeSearch);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dtpTo);
            this.groupBox1.Controls.Add(this.label20);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Blue;
            this.groupBox1.Location = new System.Drawing.Point(2, 42);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(213, 234);
            this.groupBox1.TabIndex = 92;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search";
            // 
            // cmb_supplier_search
            // 
            this.cmb_supplier_search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmb_supplier_search.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_supplier_search.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cmb_supplier_search.FormattingEnabled = true;
            this.cmb_supplier_search.Location = new System.Drawing.Point(10, 85);
            this.cmb_supplier_search.Name = "cmb_supplier_search";
            this.cmb_supplier_search.Size = new System.Drawing.Size(197, 21);
            this.cmb_supplier_search.TabIndex = 108;
            // 
            // cmbRecordType
            // 
            this.cmbRecordType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRecordType.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbRecordType.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbRecordType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cmbRecordType.FormattingEnabled = true;
            this.cmbRecordType.Items.AddRange(new object[] {
            "Editable",
            "NotEditable",
            "Both"});
            this.cmbRecordType.Location = new System.Drawing.Point(10, 172);
            this.cmbRecordType.Name = "cmbRecordType";
            this.cmbRecordType.Size = new System.Drawing.Size(195, 21);
            this.cmbRecordType.TabIndex = 7;
            // 
            // btnSearchUser
            // 
            this.btnSearchUser.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnSearchUser.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSearchUser.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSearchUser.Image = global::AssetInventory.Properties.Resources.search;
            this.btnSearchUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearchUser.Location = new System.Drawing.Point(136, 199);
            this.btnSearchUser.Name = "btnSearchUser";
            this.btnSearchUser.Size = new System.Drawing.Size(69, 25);
            this.btnSearchUser.TabIndex = 8;
            this.btnSearchUser.Text = "Search";
            this.btnSearchUser.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSearchUser.UseVisualStyleBackColor = false;
            this.btnSearchUser.Click += new System.EventHandler(this.btnSearchUser_Click);
            // 
            // lblRecordCount
            // 
            this.lblRecordCount.AutoSize = true;
            this.lblRecordCount.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecordCount.ForeColor = System.Drawing.Color.Black;
            this.lblRecordCount.Location = new System.Drawing.Point(103, 204);
            this.lblRecordCount.Name = "lblRecordCount";
            this.lblRecordCount.Size = new System.Drawing.Size(14, 13);
            this.lblRecordCount.TabIndex = 97;
            this.lblRecordCount.Text = "0";
            this.lblRecordCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label11.Location = new System.Drawing.Point(10, 156);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(78, 13);
            this.label11.TabIndex = 98;
            this.label11.Text = "Record Type";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(7, 204);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(90, 13);
            this.label10.TabIndex = 96;
            this.label10.Text = "Record Found :";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmbAccTransType
            // 
            this.cmbAccTransType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAccTransType.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbAccTransType.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbAccTransType.FormattingEnabled = true;
            this.cmbAccTransType.Location = new System.Drawing.Point(334, 519);
            this.cmbAccTransType.Name = "cmbAccTransType";
            this.cmbAccTransType.Size = new System.Drawing.Size(316, 21);
            this.cmbAccTransType.TabIndex = 13;
            this.cmbAccTransType.SelectedIndexChanged += new System.EventHandler(this.cmbAccTransType_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(218, 519);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 13);
            this.label6.TabIndex = 97;
            this.label6.Text = "Transaction Type :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(23, 396);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 13);
            this.label7.TabIndex = 99;
            this.label7.Text = "Serial No :";
            this.label7.Visible = false;
            // 
            // txtAtid
            // 
            this.txtAtid.BackColor = System.Drawing.Color.White;
            this.txtAtid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAtid.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAtid.Location = new System.Drawing.Point(15, 428);
            this.txtAtid.Name = "txtAtid";
            this.txtAtid.ReadOnly = true;
            this.txtAtid.Size = new System.Drawing.Size(164, 20);
            this.txtAtid.TabIndex = 9;
            this.txtAtid.Visible = false;
            // 
            // lblDrCr
            // 
            this.lblDrCr.AutoSize = true;
            this.lblDrCr.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDrCr.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblDrCr.Location = new System.Drawing.Point(218, 545);
            this.lblDrCr.Name = "lblDrCr";
            this.lblDrCr.Size = new System.Drawing.Size(98, 13);
            this.lblDrCr.TabIndex = 100;
            this.lblDrCr.Text = "DR/CR Amount :";
            this.lblDrCr.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtAmount
            // 
            this.txtAmount.BackColor = System.Drawing.Color.White;
            this.txtAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAmount.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAmount.Location = new System.Drawing.Point(334, 545);
            this.txtAmount.MaxLength = 10;
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(316, 30);
            this.txtAmount.TabIndex = 14;
            this.txtAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAmount_KeyPress);
            // 
            // txtDescription
            // 
            this.txtDescription.BackColor = System.Drawing.Color.White;
            this.txtDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescription.Location = new System.Drawing.Point(774, 520);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(210, 20);
            this.txtDescription.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(658, 520);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 13);
            this.label9.TabIndex = 103;
            this.label9.Text = "Description :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(218, 493);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 94;
            this.label4.Text = "Account No :";
            // 
            // dtpTransactionDate
            // 
            this.dtpTransactionDate.CustomFormat = "dd-MMM-yyyy";
            this.dtpTransactionDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpTransactionDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTransactionDate.Location = new System.Drawing.Point(774, 494);
            this.dtpTransactionDate.Name = "dtpTransactionDate";
            this.dtpTransactionDate.Size = new System.Drawing.Size(210, 20);
            this.dtpTransactionDate.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(657, 494);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(110, 13);
            this.label8.TabIndex = 105;
            this.label8.Text = "Transaction Date :";
            // 
            // cmb_supplier
            // 
            this.cmb_supplier.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_supplier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmb_supplier.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_supplier.ForeColor = System.Drawing.Color.DimGray;
            this.cmb_supplier.FormattingEnabled = true;
            this.cmb_supplier.Location = new System.Drawing.Point(334, 493);
            this.cmb_supplier.Name = "cmb_supplier";
            this.cmb_supplier.Size = new System.Drawing.Size(316, 21);
            this.cmb_supplier.TabIndex = 107;
            // 
            // frmAccountTransaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(242)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(988, 579);
            this.Controls.Add(this.cmb_supplier);
            this.Controls.Add(this.dtpTransactionDate);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.lblDrCr);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtAtid);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmbAccTransType);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvAccountTransaction);
            this.Controls.Add(this.groupBox5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAccountTransaction";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Account Transaction Info";
            this.Load += new System.EventHandler(this.frmAccountTransaction_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccountTransaction)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btnResetForm;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DataGridView dgvAccountTransaction;
        private System.Windows.Forms.DateTimePicker dtpFrom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpTo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.ComboBox cmbAccTransTypeSearch;
        private System.Windows.Forms.CheckBox chkTransactionType;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbAccTransType;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtAtid;
        private System.Windows.Forms.Label lblDrCr;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnSearchUser;
        private System.Windows.Forms.Label lblRecordCount;
        private System.Windows.Forms.ComboBox cmbRecordType;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmb_supplier_search;
        private System.Windows.Forms.DateTimePicker dtpTransactionDate;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmb_supplier;
        private System.Windows.Forms.DataGridViewTextBoxColumn ATID;
        private System.Windows.Forms.DataGridViewTextBoxColumn TransactionDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn TerminalID;
        private System.Windows.Forms.DataGridViewTextBoxColumn AccountNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn AccHolderName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ATTID;
        private System.Windows.Forms.DataGridViewTextBoxColumn TransactionType;
        private System.Windows.Forms.DataGridViewTextBoxColumn Debit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Credit;
        private System.Windows.Forms.DataGridViewTextBoxColumn IsEditable;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn RefNo;
    }
}