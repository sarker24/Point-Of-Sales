namespace AssetInventory
{
    partial class frmReceiveWarrentyProduct
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label16 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvItem = new System.Windows.Forms.DataGridView();
            this.ServiceNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WarrentyApplicable = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.cmb_status = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtInvoiceNo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblVehicle1 = new System.Windows.Forms.Label();
            this.lblVehicle = new System.Windows.Forms.Label();
            this.btnPayment = new System.Windows.Forms.Button();
            this.btnReceivePrint = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.txtPaid = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.chk_new_fare = new System.Windows.Forms.CheckBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.txtCustomerAddress = new System.Windows.Forms.TextBox();
            this.lblCustomerID = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItem)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::AssetInventory.Properties.Resources.form_banner;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label16);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(709, 51);
            this.panel1.TabIndex = 24;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(534, 10);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(168, 23);
            this.label16.TabIndex = 21;
            this.label16.Text = "Service Payment";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvItem);
            this.groupBox1.Controls.Add(this.txtSearch);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Location = new System.Drawing.Point(0, 51);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(383, 360);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pending Payment && Delivery";
            // 
            // dgvItem
            // 
            this.dgvItem.AllowUserToAddRows = false;
            this.dgvItem.AllowUserToDeleteRows = false;
            this.dgvItem.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(240)))), ((int)(((byte)(250)))));
            this.dgvItem.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvItem.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvItem.BackgroundColor = System.Drawing.Color.White;
            this.dgvItem.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ServiceNumber,
            this.Description,
            this.WarrentyApplicable});
            this.dgvItem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvItem.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvItem.Location = new System.Drawing.Point(3, 38);
            this.dgvItem.MultiSelect = false;
            this.dgvItem.Name = "dgvItem";
            this.dgvItem.RowHeadersVisible = false;
            this.dgvItem.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvItem.Size = new System.Drawing.Size(377, 319);
            this.dgvItem.TabIndex = 1;
            this.dgvItem.TabStop = false;
            this.dgvItem.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvItem_CellClick);
            // 
            // ServiceNumber
            // 
            this.ServiceNumber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ServiceNumber.DataPropertyName = "ServiceNumber";
            this.ServiceNumber.HeaderText = "Number";
            this.ServiceNumber.Name = "ServiceNumber";
            this.ServiceNumber.ReadOnly = true;
            this.ServiceNumber.Width = 90;
            // 
            // Description
            // 
            this.Description.DataPropertyName = "Description";
            this.Description.HeaderText = "Description";
            this.Description.Name = "Description";
            this.Description.ReadOnly = true;
            // 
            // WarrentyApplicable
            // 
            this.WarrentyApplicable.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.WarrentyApplicable.DataPropertyName = "IsWarrentyApplicable";
            this.WarrentyApplicable.HeaderText = "IsWarrenty";
            this.WarrentyApplicable.Name = "WarrentyApplicable";
            this.WarrentyApplicable.ReadOnly = true;
            this.WarrentyApplicable.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.WarrentyApplicable.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.WarrentyApplicable.Width = 80;
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.Color.White;
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtSearch.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.ForeColor = System.Drawing.Color.Black;
            this.txtSearch.Location = new System.Drawing.Point(3, 17);
            this.txtSearch.MaxLength = 14;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(377, 21);
            this.txtSearch.TabIndex = 0;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // cmb_status
            // 
            this.cmb_status.Enabled = false;
            this.cmb_status.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmb_status.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_status.FormattingEnabled = true;
            this.cmb_status.Items.AddRange(new object[] {
            "Received",
            "Delivered"});
            this.cmb_status.Location = new System.Drawing.Point(491, 122);
            this.cmb_status.Name = "cmb_status";
            this.cmb_status.Size = new System.Drawing.Size(206, 24);
            this.cmb_status.TabIndex = 4;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label15.Location = new System.Drawing.Point(389, 126);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(42, 14);
            this.label15.TabIndex = 190;
            this.label15.Text = "Status";
            // 
            // txtInvoiceNo
            // 
            this.txtInvoiceNo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtInvoiceNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtInvoiceNo.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInvoiceNo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.txtInvoiceNo.Location = new System.Drawing.Point(491, 68);
            this.txtInvoiceNo.Name = "txtInvoiceNo";
            this.txtInvoiceNo.Size = new System.Drawing.Size(206, 21);
            this.txtInvoiceNo.TabIndex = 2;
            this.txtInvoiceNo.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label6.Location = new System.Drawing.Point(389, 70);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 14);
            this.label6.TabIndex = 189;
            this.label6.Text = "Receive No";
            // 
            // txtDescription
            // 
            this.txtDescription.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDescription.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescription.Location = new System.Drawing.Point(491, 95);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.ReadOnly = true;
            this.txtDescription.Size = new System.Drawing.Size(206, 21);
            this.txtDescription.TabIndex = 3;
            this.txtDescription.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(389, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 14);
            this.label4.TabIndex = 192;
            this.label4.Text = "Description";
            // 
            // lblVehicle1
            // 
            this.lblVehicle1.AutoSize = true;
            this.lblVehicle1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVehicle1.ForeColor = System.Drawing.Color.Maroon;
            this.lblVehicle1.Location = new System.Drawing.Point(388, 207);
            this.lblVehicle1.Name = "lblVehicle1";
            this.lblVehicle1.Size = new System.Drawing.Size(73, 14);
            this.lblVehicle1.TabIndex = 197;
            this.lblVehicle1.Text = "Vehicle No :";
            this.lblVehicle1.Visible = false;
            // 
            // lblVehicle
            // 
            this.lblVehicle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblVehicle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblVehicle.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVehicle.ForeColor = System.Drawing.Color.Maroon;
            this.lblVehicle.Location = new System.Drawing.Point(491, 206);
            this.lblVehicle.Name = "lblVehicle";
            this.lblVehicle.Size = new System.Drawing.Size(206, 22);
            this.lblVehicle.TabIndex = 198;
            this.lblVehicle.Text = "Vehicle No : ";
            this.lblVehicle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblVehicle.Visible = false;
            // 
            // btnPayment
            // 
            this.btnPayment.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnPayment.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPayment.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPayment.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnPayment.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPayment.Location = new System.Drawing.Point(495, 362);
            this.btnPayment.Name = "btnPayment";
            this.btnPayment.Size = new System.Drawing.Size(66, 23);
            this.btnPayment.TabIndex = 6;
            this.btnPayment.Text = "Save";
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
            this.btnReceivePrint.Location = new System.Drawing.Point(427, 362);
            this.btnReceivePrint.Name = "btnReceivePrint";
            this.btnReceivePrint.Size = new System.Drawing.Size(66, 23);
            this.btnReceivePrint.TabIndex = 6;
            this.btnReceivePrint.Text = "Print";
            this.btnReceivePrint.UseVisualStyleBackColor = false;
            this.btnReceivePrint.Click += new System.EventHandler(this.btnReceivePrint_Click);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnReset.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnReset.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReset.Location = new System.Drawing.Point(563, 362);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(66, 23);
            this.btnReset.TabIndex = 7;
            this.btnReset.Text = "&Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClose.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(631, 362);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(66, 23);
            this.btnClose.TabIndex = 8;
            this.btnClose.Text = "&Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // txtPaid
            // 
            this.txtPaid.BackColor = System.Drawing.Color.White;
            this.txtPaid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPaid.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPaid.ForeColor = System.Drawing.Color.Green;
            this.txtPaid.Location = new System.Drawing.Point(491, 264);
            this.txtPaid.MaxLength = 8;
            this.txtPaid.Name = "txtPaid";
            this.txtPaid.Size = new System.Drawing.Size(206, 30);
            this.txtPaid.TabIndex = 5;
            this.txtPaid.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPaid_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(389, 266);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 14);
            this.label1.TabIndex = 204;
            this.label1.Text = "Paid";
            // 
            // chk_new_fare
            // 
            this.chk_new_fare.AutoSize = true;
            this.chk_new_fare.Enabled = false;
            this.chk_new_fare.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_new_fare.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.chk_new_fare.Location = new System.Drawing.Point(491, 240);
            this.chk_new_fare.Name = "chk_new_fare";
            this.chk_new_fare.Size = new System.Drawing.Size(78, 18);
            this.chk_new_fare.TabIndex = 205;
            this.chk_new_fare.Text = "New Fare";
            this.chk_new_fare.UseVisualStyleBackColor = true;
            this.chk_new_fare.Visible = false;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label14.Location = new System.Drawing.Point(389, 154);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(94, 14);
            this.label14.TabIndex = 211;
            this.label14.Text = "Customer Name";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label7.Location = new System.Drawing.Point(389, 180);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 14);
            this.label7.TabIndex = 210;
            this.label7.Text = "Address";
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtCustomerName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCustomerName.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustomerName.Location = new System.Drawing.Point(491, 152);
            this.txtCustomerName.MaxLength = 30;
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.ReadOnly = true;
            this.txtCustomerName.Size = new System.Drawing.Size(206, 21);
            this.txtCustomerName.TabIndex = 206;
            this.txtCustomerName.TabStop = false;
            // 
            // txtCustomerAddress
            // 
            this.txtCustomerAddress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtCustomerAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCustomerAddress.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustomerAddress.Location = new System.Drawing.Point(491, 179);
            this.txtCustomerAddress.MaxLength = 500;
            this.txtCustomerAddress.Name = "txtCustomerAddress";
            this.txtCustomerAddress.ReadOnly = true;
            this.txtCustomerAddress.Size = new System.Drawing.Size(206, 21);
            this.txtCustomerAddress.TabIndex = 208;
            this.txtCustomerAddress.TabStop = false;
            // 
            // lblCustomerID
            // 
            this.lblCustomerID.AutoSize = true;
            this.lblCustomerID.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblCustomerID.Location = new System.Drawing.Point(393, 315);
            this.lblCustomerID.Name = "lblCustomerID";
            this.lblCustomerID.Size = new System.Drawing.Size(64, 13);
            this.lblCustomerID.TabIndex = 212;
            this.lblCustomerID.Text = "CustomerID";
            this.lblCustomerID.Visible = false;
            // 
            // frmReceiveWarrentyProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 411);
            this.Controls.Add(this.lblCustomerID);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtCustomerName);
            this.Controls.Add(this.txtCustomerAddress);
            this.Controls.Add(this.chk_new_fare);
            this.Controls.Add(this.txtPaid);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnPayment);
            this.Controls.Add(this.btnReceivePrint);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblVehicle1);
            this.Controls.Add(this.lblVehicle);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmb_status);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.txtInvoiceNo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Name = "frmReceiveWarrentyProduct";
            this.Text = "Service Payment";
            this.Load += new System.EventHandler(this.frmReceiveWarrentyProduct_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvItem;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.ComboBox cmb_status;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtInvoiceNo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblVehicle1;
        private System.Windows.Forms.Label lblVehicle;
        private System.Windows.Forms.Button btnPayment;
        private System.Windows.Forms.Button btnReceivePrint;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TextBox txtPaid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chk_new_fare;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.TextBox txtCustomerAddress;
        private System.Windows.Forms.Label lblCustomerID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ServiceNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewCheckBoxColumn WarrentyApplicable;
        private System.Windows.Forms.Label label16;
    }
}