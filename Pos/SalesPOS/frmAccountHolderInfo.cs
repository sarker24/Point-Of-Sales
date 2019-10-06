using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using AssetInventory.BOL;
using AssetInventory.BLL;

namespace AssetInventory
{
    public partial class frmAccountHolderInfo : Form
    {

        private long _SelctedAccHolderInfoId = 0;
        //private Int32 _GridRowSelectedIndex = 0;
        private bool _isNew = true;
        private DataTable dtAccountHolderType = new DataTable();
        //private long maxAcctTypeValue;

        private void LoadGrid()
        {
            DataTable dt = new DataTable();
            dt = bllAccountHolderInfo.getAll();
            this.dgvAccountHolderList.AutoGenerateColumns = false;
            this.dgvAccountHolderList.DataSource = dt;

            //this.dgvUnitList.Rows[this._GridRowSelectedIndex].Selected = true;


        }
        public void LoadAccountHolderTypeCombo()
        {
            DataTable dt = new DataTable();
            dtAccountHolderType = null;
            dtAccountHolderType = bllAccountHolderType.getAll();
            this.cmbType.DisplayMember = "AccountHolderType";
            this.cmbType.ValueMember = "AccountHolderTypeID";            
            cmbType.DataSource = dtAccountHolderType;
            dt = dtAccountHolderType.Copy();

            cmbAccountTypeSearch.DisplayMember = "AccountHolderType";
            cmbAccountTypeSearch.ValueMember = "AccountHolderTypeID";
            DataRow dr = dt.NewRow();
            dr["AccountHolderType"] = "All";
            dr["AccountHolderTypeID"] = "0";
            dt.Rows.InsertAt(dr,0);

            cmbAccountTypeSearch.DataSource = dt;
        }

        private void ClearFields()
        {
            try
            {
                this.txtContactNum.Text = string.Empty;
                this.txtAccountHolderName.Text = string.Empty;
                this.txtAccountNumber.Text = string.Empty;
                this.cmbActivity.SelectedIndex = 0;
                this.txtAddress.Text = string.Empty;
                this.cmbType.SelectedIndex = 0;
                this.cmb_customer_type.Text = "OTHERS";
                this.err_accountholderinfo.Clear();                
                if (this.dgvAccountHolderList.Rows.Count > 0)
                    this.dgvAccountHolderList.Rows[0].Selected = false;
            }
            catch
            { }
        }

        private bool isValid()
        {
            bool chk = true;
            if (string.IsNullOrEmpty(this.txtAccountHolderName.Text))
            {
                this.err_accountholderinfo.SetError(txtAccountHolderName, "Name is mandatory");
                chk = false;
            }
            //if (string.IsNullOrEmpty(this.txtAccountNumber.Text))
            //{
            //    this.err_accountholderinfo.SetError(cmbType , "Type is mandatory");
            //    chk = false;
            //}
            
            return chk;
        }

        private void LoadAccountHolderInfoByID(long selectedID)
        {
            DataTable dt = new DataTable();
            dt = bllAccountHolderInfo.getById(selectedID);
            this.txtAccountHolderName.Text = dt.Rows[0]["AccHolderName"].ToString();            
            this.txtAddress.Text = dt.Rows[0]["Address"].ToString();
            this.txtContactNum.Text = dt.Rows[0]["ContactNo"].ToString();
            this.cmbType.SelectedValue = Convert.ToInt64(dt.Rows[0]["AccountHolderTypeID"].ToString());
            this.cmbActivity.SelectedValue = Convert.ToInt64(dt.Rows[0]["ActivityID"].ToString());
            this.txtAccountNumber.Text = dt.Rows[0]["AccountNo"].ToString();
            this.cmb_customer_type.Text = dt.Rows[0]["CustomerType"].ToString();
        }

        public frmAccountHolderInfo()
        {
            InitializeComponent();
        }

        private void frmAccountHolderInfo_Load(object sender, EventArgs e)
        {
            bllUtility.ResetGridColor(dgvAccountHolderList);
            this.ActiveControl = txtAccountHolderName;
            bllUtility.LoadAcitivityCombo(this.cmbActivity);
            LoadAccountHolderTypeCombo();
            LoadGrid();
            if (this.dgvAccountHolderList.Rows.Count > 0)
                this.dgvAccountHolderList.Rows[0].Selected = false;
            this.dgvAccountHolderList.DefaultCellStyle.ForeColor = Color.Black;

            // gridSearch1
            // 
            //this.gridSearch1.Location = new System.Drawing.Point(202, 0);
            //this.gridSearch1.Name = "gridSearch1";
            //this.gridSearch1.Size = new System.Drawing.Size(348, 28);
            //this.gridSearch1.Source_Grid = dgvAccountHolderList ;            
            //gridSearch1.Source_Grid = dgvAccountHolderList;
            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.err_accountholderinfo.Clear();
            if (isValid())
            {
                if (!this._isNew) 
                {
                    if (_SelctedAccHolderInfoId > 0)
                    {
                        //update here
                        bool chk = true;

                        AccountHolderInfo objAccountHolderInfo = new AccountHolderInfo();
                        objAccountHolderInfo.AccHolderInfoId = this._SelctedAccHolderInfoId;
                        objAccountHolderInfo.AccHolderName = this.txtAccountHolderName.Text.Trim();
                        objAccountHolderInfo.ContactNo = this.txtContactNum.Text.Trim();
                        objAccountHolderInfo.Address = this.txtAddress.Text;                        
                        objAccountHolderInfo.ActivityID = Convert.ToInt64(this.cmbActivity.SelectedValue);

                        objAccountHolderInfo.UpdatedBy = bllUtility.LoggedInSystemInformation.LoggedUserId;
                        objAccountHolderInfo.UpdatedDate = DateTime.Now;
                        objAccountHolderInfo.CustomerType = cmb_customer_type.Text;

                        chk = bllAccountHolderInfo.Update(objAccountHolderInfo);
                        if (chk)
                        {
                            LoadGrid();
                            //show success message here                            
                            MessageBox.Show("Successfully Updated the record", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ClearFields();
                            this._isNew = true;
                        }
                    }
                    else
                    {
                        MessageBox.Show("No data found for update.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    //this._GridRowSelectedIndex = this.dgvUnitList.Rows.Count;
                    bool chk = true;
                    //insert validation method

                    //insert here
                    AccountHolderInfo objAccountHolderInfo = new AccountHolderInfo();
                    //objAccountHolderInfo.AccHolderInfoId = this._SelctedAccHolderInfoId;
                    objAccountHolderInfo.AccHolderName = this.txtAccountHolderName.Text.Trim();
                    objAccountHolderInfo.AccountHolderTypeID = Convert.ToInt64(this.cmbType.SelectedValue);
                    objAccountHolderInfo.AccountNo = this.txtAccountNumber.Text;
                    objAccountHolderInfo.ActivityID = Convert.ToInt64(this.cmbActivity.SelectedValue);
                    objAccountHolderInfo.Address = this.txtAddress.Text;
                    objAccountHolderInfo.ContactNo = this.txtContactNum.Text;
                    objAccountHolderInfo.CreatedBy = bllUtility.LoggedInSystemInformation.LoggedUserId;
                    objAccountHolderInfo.CreatedDate = DateTime.Now;
                    objAccountHolderInfo.CustomerType = cmb_customer_type.Text;


                    chk = bllAccountHolderInfo.Insert(objAccountHolderInfo);
                    if (chk)
                    {
                        LoadGrid();
                        //show success message here
                        //string s = "AccountHolderTypeID = " + this.cmbType.SelectedValue.ToString();

                        //DataRow drAccountHolderType = dtAccountHolderType.NewRow();

                        //drAccountHolderType = dtAccountHolderType.Select(s).FirstOrDefault();
                        //drAccountHolderType[8] = objAccountHolderInfo.AccountNo.ToString().Substring(3).ToString();
                        ClearFields();
                        this._isNew = true;
                    }

                }
                
                this._SelctedAccHolderInfoId = 0;
            }
        }

        private void cmbType_SelectedIndexChanged(object sender, EventArgs e)
        {
           //SetAccountNumber();   
            if (cmbType.Text == "Customer")
            {
                lbl_customer_type.Visible = true;
                cmb_customer_type.Visible = true;
            }
            else 
            {
                lbl_customer_type.Visible = false;
                cmb_customer_type.Visible = false;
            }
                        
        }
        private void SetAccountNumber()
        {
            //string s = "AccountHolderTypeID = " + this.cmbType.SelectedValue.ToString();

            //DataRow drAccountHolderType = dtAccountHolderType.NewRow();

            //drAccountHolderType = dtAccountHolderType.Select(s).FirstOrDefault();
            //maxAcctTypeValue = Convert.ToInt64(drAccountHolderType[8]) + 1;
            //string AccountNum = drAccountHolderType[2] + (Convert.ToInt64(drAccountHolderType[8]) + 1).ToString().PadLeft(7, '0');

            //this.txtAccountNumber.Text = AccountNum;
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            this._isNew = true;
            this._SelctedAccHolderInfoId = 0;
            ClearFields();
            this.txtAccountHolderName.Focus();
            //SetAccountNumber();  

        }

        private void dgvAccountHolderList_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (Convert.ToInt32(e.RowIndex) == -1)
            {

            }
            else
            {
                DataGridViewRow dr = ((DataGridView)sender).Rows[e.RowIndex];

                this._isNew = false;
                try
                {
                    //bool chk = true;
                    long AccHolderInfoId = 0;
                    AccHolderInfoId = Convert.ToInt64(dr.Cells[0].Value);

                    //Load the selected row data fro edit mode

                    this._SelctedAccHolderInfoId = AccHolderInfoId;
                    LoadAccountHolderInfoByID(_SelctedAccHolderInfoId);
                }
                catch { }
            }
        }

        private void btnSearchUser_Click(object sender, EventArgs e)
        {
            DataTable dt = bllReportUtility.ReportData("dbo.search_account_holder_info "+ cmbAccountTypeSearch.SelectedValue + ", '"+ txtAccountNameSearch.Text.Trim()  +"'");
            if (dt.Rows.Count > 0)
            {
                dgvAccountHolderList.DataSource = dt;
            }
            else
            {
                dgvAccountHolderList.DataSource = null;
                bllUtility.MyMessage("No data found");
                txtAccountNameSearch.Focus();
            }
        }

        

    }
}
