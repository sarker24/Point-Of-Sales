namespace AssetInventory
{
    partial class frmTerminalInfo
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTerminalInfo));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pnlRequestList = new System.Windows.Forms.Panel();
            this.dgvReqList = new System.Windows.Forms.DataGridView();
            this.RegID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RegDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RegtIP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RegValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RegtHostName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RegComments = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblClose = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dgvTerminalList = new System.Windows.Forms.DataGridView();
            this.TerminalID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoftUser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Attribute = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValueOfAttribute = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ActivationDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExpireDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ActivityID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtIPAddress = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.dtpExpiryDate = new System.Windows.Forms.DateTimePicker();
            this.dtpActivationDate = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAttributeValue = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAttribute = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbActivity = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTerminalName = new System.Windows.Forms.TextBox();
            this.lblUserName = new System.Windows.Forms.Label();
            this.err_terminalInfo = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblPendingNo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.pnlRequestList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReqList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTerminalList)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.err_terminalInfo)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pnlRequestList);
            this.groupBox1.Controls.Add(this.dgvTerminalList);
            this.groupBox1.Location = new System.Drawing.Point(0, 67);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(580, 195);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // pnlRequestList
            // 
            this.pnlRequestList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlRequestList.Controls.Add(this.dgvReqList);
            this.pnlRequestList.Controls.Add(this.lblClose);
            this.pnlRequestList.Controls.Add(this.label7);
            this.pnlRequestList.Location = new System.Drawing.Point(3, 9);
            this.pnlRequestList.Name = "pnlRequestList";
            this.pnlRequestList.Size = new System.Drawing.Size(574, 183);
            this.pnlRequestList.TabIndex = 2;
            this.pnlRequestList.Visible = false;
            // 
            // dgvReqList
            // 
            this.dgvReqList.AllowUserToAddRows = false;
            this.dgvReqList.AllowUserToDeleteRows = false;
            this.dgvReqList.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(240)))), ((int)(((byte)(250)))));
            this.dgvReqList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvReqList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvReqList.BackgroundColor = System.Drawing.Color.White;
            this.dgvReqList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvReqList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvReqList.ColumnHeadersHeight = 22;
            this.dgvReqList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvReqList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RegID,
            this.RegDate,
            this.RegtIP,
            this.RegValue,
            this.RegtHostName,
            this.RegComments});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(182)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvReqList.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvReqList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvReqList.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvReqList.Location = new System.Drawing.Point(0, 20);
            this.dgvReqList.MultiSelect = false;
            this.dgvReqList.Name = "dgvReqList";
            this.dgvReqList.RowHeadersVisible = false;
            this.dgvReqList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvReqList.Size = new System.Drawing.Size(572, 161);
            this.dgvReqList.TabIndex = 3;
            this.dgvReqList.TabStop = false;
            this.dgvReqList.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvReqList_CellMouseDoubleClick);
            // 
            // RegID
            // 
            this.RegID.DataPropertyName = "RegID";
            this.RegID.HeaderText = "RegID";
            this.RegID.Name = "RegID";
            this.RegID.Visible = false;
            // 
            // RegDate
            // 
            this.RegDate.DataPropertyName = "RegDate";
            dataGridViewCellStyle3.Format = "d";
            dataGridViewCellStyle3.NullValue = null;
            this.RegDate.DefaultCellStyle = dataGridViewCellStyle3;
            this.RegDate.HeaderText = "RegDate";
            this.RegDate.Name = "RegDate";
            // 
            // RegtIP
            // 
            this.RegtIP.DataPropertyName = "RegtIP";
            this.RegtIP.HeaderText = "RegtIP";
            this.RegtIP.Name = "RegtIP";
            // 
            // RegValue
            // 
            this.RegValue.DataPropertyName = "RegValue";
            this.RegValue.HeaderText = "RegValue";
            this.RegValue.Name = "RegValue";
            this.RegValue.Visible = false;
            // 
            // RegtHostName
            // 
            this.RegtHostName.DataPropertyName = "RegtHostName";
            this.RegtHostName.HeaderText = "Host Name";
            this.RegtHostName.Name = "RegtHostName";
            // 
            // RegComments
            // 
            this.RegComments.DataPropertyName = "RegComments";
            this.RegComments.HeaderText = "Comments";
            this.RegComments.Name = "RegComments";
            // 
            // lblClose
            // 
            this.lblClose.BackColor = System.Drawing.Color.PaleTurquoise;
            this.lblClose.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClose.Location = new System.Drawing.Point(549, -1);
            this.lblClose.Name = "lblClose";
            this.lblClose.Size = new System.Drawing.Size(22, 20);
            this.lblClose.TabIndex = 1;
            this.lblClose.Text = "X";
            this.lblClose.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblClose.Click += new System.EventHandler(this.lblClose_Click);
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.PaleTurquoise;
            this.label7.Dock = System.Windows.Forms.DockStyle.Top;
            this.label7.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label7.Location = new System.Drawing.Point(0, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(572, 20);
            this.label7.TabIndex = 0;
            this.label7.Text = "Request for Terminal Registration. Please double click on a pending record to sel" +
                "ect.";
            // 
            // dgvTerminalList
            // 
            this.dgvTerminalList.AllowUserToAddRows = false;
            this.dgvTerminalList.AllowUserToDeleteRows = false;
            this.dgvTerminalList.AllowUserToResizeRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(240)))), ((int)(((byte)(250)))));
            this.dgvTerminalList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvTerminalList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTerminalList.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTerminalList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvTerminalList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTerminalList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TerminalID,
            this.SoftUser,
            this.Attribute,
            this.ValueOfAttribute,
            this.ActivationDate,
            this.ExpireDate,
            this.ActivityID});
            this.dgvTerminalList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTerminalList.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvTerminalList.Location = new System.Drawing.Point(3, 16);
            this.dgvTerminalList.MultiSelect = false;
            this.dgvTerminalList.Name = "dgvTerminalList";
            this.dgvTerminalList.RowHeadersVisible = false;
            this.dgvTerminalList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvTerminalList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTerminalList.Size = new System.Drawing.Size(574, 176);
            this.dgvTerminalList.TabIndex = 1;
            this.dgvTerminalList.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvUnitList_CellMouseClick);
            this.dgvTerminalList.SelectionChanged += new System.EventHandler(this.dgvTerminalList_SelectionChanged);
            // 
            // TerminalID
            // 
            this.TerminalID.DataPropertyName = "TerminalID";
            this.TerminalID.HeaderText = "UnitId";
            this.TerminalID.Name = "TerminalID";
            this.TerminalID.Visible = false;
            // 
            // SoftUser
            // 
            this.SoftUser.DataPropertyName = "TerminalName";
            this.SoftUser.HeaderText = "Terminal";
            this.SoftUser.Name = "SoftUser";
            // 
            // Attribute
            // 
            this.Attribute.DataPropertyName = "Attribute";
            this.Attribute.HeaderText = "Attribute";
            this.Attribute.Name = "Attribute";
            this.Attribute.Visible = false;
            // 
            // ValueOfAttribute
            // 
            this.ValueOfAttribute.DataPropertyName = "ValueOfAttribute";
            this.ValueOfAttribute.HeaderText = "ValueOfAttribute";
            this.ValueOfAttribute.Name = "ValueOfAttribute";
            this.ValueOfAttribute.Visible = false;
            // 
            // ActivationDate
            // 
            this.ActivationDate.DataPropertyName = "ActivationDate";
            dataGridViewCellStyle7.Format = "d";
            dataGridViewCellStyle7.NullValue = null;
            this.ActivationDate.DefaultCellStyle = dataGridViewCellStyle7;
            this.ActivationDate.HeaderText = "Activation Date";
            this.ActivationDate.Name = "ActivationDate";
            // 
            // ExpireDate
            // 
            this.ExpireDate.DataPropertyName = "ExpireDate";
            dataGridViewCellStyle8.Format = "d";
            dataGridViewCellStyle8.NullValue = null;
            this.ExpireDate.DefaultCellStyle = dataGridViewCellStyle8;
            this.ExpireDate.HeaderText = "Expire Date";
            this.ExpireDate.Name = "ExpireDate";
            // 
            // ActivityID
            // 
            this.ActivityID.DataPropertyName = "Activity";
            this.ActivityID.HeaderText = "Activity";
            this.ActivityID.Name = "ActivityID";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtIPAddress);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.btnClose);
            this.groupBox2.Controls.Add(this.btnNew);
            this.groupBox2.Controls.Add(this.btnSave);
            this.groupBox2.Controls.Add(this.dtpExpiryDate);
            this.groupBox2.Controls.Add(this.dtpActivationDate);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtAttributeValue);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtAttribute);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.cmbActivity);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtTerminalName);
            this.groupBox2.Controls.Add(this.lblUserName);
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.groupBox2.Location = new System.Drawing.Point(0, 261);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(580, 149);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Details";
            // 
            // txtIPAddress
            // 
            this.txtIPAddress.BackColor = System.Drawing.Color.White;
            this.txtIPAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIPAddress.Location = new System.Drawing.Point(119, 94);
            this.txtIPAddress.MaxLength = 16;
            this.txtIPAddress.Name = "txtIPAddress";
            this.txtIPAddress.Size = new System.Drawing.Size(179, 20);
            this.txtIPAddress.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label8.Location = new System.Drawing.Point(8, 96);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "IP Address";
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClose.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(495, 104);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(69, 25);
            this.btnClose.TabIndex = 11;
            this.btnClose.Text = "&Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnNew
            // 
            this.btnNew.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnNew.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNew.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnNew.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNew.Location = new System.Drawing.Point(345, 104);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(69, 25);
            this.btnNew.TabIndex = 10;
            this.btnNew.Text = "&New";
            this.btnNew.UseVisualStyleBackColor = false;
            this.btnNew.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSave.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(420, 104);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(69, 25);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "&Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // dtpExpiryDate
            // 
            this.dtpExpiryDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpExpiryDate.Location = new System.Drawing.Point(389, 69);
            this.dtpExpiryDate.Name = "dtpExpiryDate";
            this.dtpExpiryDate.Size = new System.Drawing.Size(175, 20);
            this.dtpExpiryDate.TabIndex = 7;
            this.dtpExpiryDate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dtpExpiryDate_KeyPress);
            // 
            // dtpActivationDate
            // 
            this.dtpActivationDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpActivationDate.Location = new System.Drawing.Point(119, 68);
            this.dtpActivationDate.Name = "dtpActivationDate";
            this.dtpActivationDate.Size = new System.Drawing.Size(179, 20);
            this.dtpActivationDate.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label6.Location = new System.Drawing.Point(313, 68);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Expiry Date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(8, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Activation Date";
            // 
            // txtAttributeValue
            // 
            this.txtAttributeValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAttributeValue.Location = new System.Drawing.Point(119, 42);
            this.txtAttributeValue.MaxLength = 20;
            this.txtAttributeValue.Name = "txtAttributeValue";
            this.txtAttributeValue.Size = new System.Drawing.Size(179, 20);
            this.txtAttributeValue.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(8, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Value of Attribute";
            // 
            // txtAttribute
            // 
            this.txtAttribute.BackColor = System.Drawing.Color.White;
            this.txtAttribute.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAttribute.Location = new System.Drawing.Point(389, 16);
            this.txtAttribute.Name = "txtAttribute";
            this.txtAttribute.ReadOnly = true;
            this.txtAttribute.Size = new System.Drawing.Size(175, 20);
            this.txtAttribute.TabIndex = 3;
            this.txtAttribute.Text = "HDD";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(313, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Attribute";
            // 
            // cmbActivity
            // 
            this.cmbActivity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbActivity.FormattingEnabled = true;
            this.cmbActivity.Location = new System.Drawing.Point(389, 42);
            this.cmbActivity.Name = "cmbActivity";
            this.cmbActivity.Size = new System.Drawing.Size(175, 21);
            this.cmbActivity.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(313, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Activity";
            // 
            // txtTerminalName
            // 
            this.txtTerminalName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTerminalName.Location = new System.Drawing.Point(119, 16);
            this.txtTerminalName.MaxLength = 50;
            this.txtTerminalName.Name = "txtTerminalName";
            this.txtTerminalName.Size = new System.Drawing.Size(179, 20);
            this.txtTerminalName.TabIndex = 2;
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblUserName.Location = new System.Drawing.Point(8, 16);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(57, 13);
            this.lblUserName.TabIndex = 0;
            this.lblUserName.Text = "Terminal";
            // 
            // err_terminalInfo
            // 
            this.err_terminalInfo.ContainerControl = this;
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
            this.panel1.Size = new System.Drawing.Size(583, 46);
            this.panel1.TabIndex = 25;
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(277, 8);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(296, 24);
            this.label12.TabIndex = 20;
            this.label12.Text = "Terminal Information";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel2.Controls.Add(this.lblPendingNo);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 46);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(583, 23);
            this.panel2.TabIndex = 27;
            // 
            // lblPendingNo
            // 
            this.lblPendingNo.AutoSize = true;
            this.lblPendingNo.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPendingNo.ForeColor = System.Drawing.Color.Red;
            this.lblPendingNo.Location = new System.Drawing.Point(170, 5);
            this.lblPendingNo.Name = "lblPendingNo";
            this.lblPendingNo.Size = new System.Drawing.Size(41, 13);
            this.lblPendingNo.TabIndex = 28;
            this.lblPendingNo.Text = "label7";
            this.lblPendingNo.Click += new System.EventHandler(this.lblPendingNo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(3, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 13);
            this.label1.TabIndex = 27;
            this.label1.Text = "Pending Terminal Request :";
            // 
            // frmTerminalInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(242)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(583, 414);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmTerminalInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Terminal Information";
            this.Load += new System.EventHandler(this.frmTerminalInfo_Load);
            this.groupBox1.ResumeLayout(false);
            this.pnlRequestList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReqList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTerminalList)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.err_terminalInfo)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvTerminalList;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cmbActivity;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTerminalName;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.TextBox txtAttributeValue;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAttribute;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpActivationDate;
        private System.Windows.Forms.DateTimePicker dtpExpiryDate;
        private System.Windows.Forms.ErrorProvider err_terminalInfo;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridViewTextBoxColumn TerminalID;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoftUser;
        private System.Windows.Forms.DataGridViewTextBoxColumn Attribute;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValueOfAttribute;
        private System.Windows.Forms.DataGridViewTextBoxColumn ActivationDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExpireDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ActivityID;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblPendingNo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlRequestList;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblClose;
        private System.Windows.Forms.DataGridView dgvReqList;
        private System.Windows.Forms.TextBox txtIPAddress;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridViewTextBoxColumn RegID;
        private System.Windows.Forms.DataGridViewTextBoxColumn RegDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn RegtIP;
        private System.Windows.Forms.DataGridViewTextBoxColumn RegValue;
        private System.Windows.Forms.DataGridViewTextBoxColumn RegtHostName;
        private System.Windows.Forms.DataGridViewTextBoxColumn RegComments;
    }
}