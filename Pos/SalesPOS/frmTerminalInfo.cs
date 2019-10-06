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
    public partial class frmTerminalInfo : Form
    {
        //declared global variable
        private long _SelctedTerminalInfoId = 0;

        private long _RegID = 0;

        public frmTerminalInfo()
        {
            InitializeComponent();
        }

        #region private methods

        private void LoadAcitivityCombo()
        {
            DataTable dt = new DataTable();
            dt = bllActivityInfo.getAll();
            this.cmbActivity.DisplayMember = "Activity";
            this.cmbActivity.ValueMember = "ActivityID";
            cmbActivity.DataSource = dt;
        }

        private void ClearFields()
        {
            try
            {
                _RegID = 0;
                this.txtAttribute.Text = "HDD";
                this.txtAttributeValue.Text = string.Empty;
                this.txtTerminalName.Text = string.Empty;
                this.txtIPAddress.Text = string.Empty;

                this.dtpActivationDate.Value = DateTime.Today;
                this.dtpExpiryDate.Value =bllUtility.LoggedInSystemInformation.ExpireDate;
                this.cmbActivity.SelectedIndex = 0;
                if (this.dgvTerminalList.Rows.Count > 0)
                    this.dgvTerminalList.Rows[0].Selected = false;

                this.err_terminalInfo.Clear();
                this.txtTerminalName.Focus();
            }
            catch
            { }
        }

        private bool isValid()
        {
            bool chk = true;
            if (string.IsNullOrEmpty(this.txtTerminalName.Text))
            {
                this.err_terminalInfo.SetError(txtTerminalName, "Terminal name is mandatory");
                chk = false;
            }
            if (this.dtpActivationDate.Value.Date > this.dtpExpiryDate.Value.Date)
            {
                this.err_terminalInfo.SetError(dtpActivationDate, "Expiry date must be greater or equals to activation date.");
                this.err_terminalInfo.SetError(dtpExpiryDate, "Expiry date must be greater or equals to activation date.");
                chk = false;
            }
            if (string.IsNullOrEmpty(this.txtIPAddress.Text))
            {
                this.err_terminalInfo.SetError(txtIPAddress, "IP Address is mandatory");
                chk = false;
            }
            return chk;
        }

        private void LoadTerminalInfoByID(long selectedID)
        {
            DataTable dt = new DataTable();
            dt = bllTerminalInfo.getById(selectedID);
            this.txtTerminalName.Text = dt.Rows[0]["TerminalName"].ToString();
            this.txtAttribute.Text = dt.Rows[0]["Attribute"].ToString();
            this.txtAttributeValue.Text = dt.Rows[0]["ValueOfAttribute"].ToString();
            this.dtpExpiryDate.Value = Convert.ToDateTime(dt.Rows[0]["ExpireDate"].ToString());
            this.dtpActivationDate.Value = Convert.ToDateTime(dt.Rows[0]["ActivationDate"].ToString());
            this.cmbActivity.SelectedValue = Convert.ToInt64(dt.Rows[0]["ActivityID"].ToString());
            this.txtIPAddress.Text = dt.Rows[0]["IPAddress"].ToString();
            btnNew.Text = "&New";
        }

        private void LoadGrid()
        {
            DataTable dt = new DataTable();
            dt = bllTerminalInfo.getAll();
            this.dgvTerminalList.AutoGenerateColumns = false;
            this.dgvTerminalList.DataSource = dt;
            if (this.dgvTerminalList.Rows.Count > 0)
                this.dgvTerminalList.Rows[0].Selected = true;
            else
                this.dgvTerminalList.Rows[0].Selected = false;
        }

        private void LoadPendingGrid()
        {
            DataTable dt = new DataTable();
            dt = bllReportUtility.ReportData("Select * from tbl_TerminalRegistrationInfo where Status='Post'");
            dgvReqList.AutoGenerateColumns = false;
            dgvReqList.DataSource = dt;
        }

        #endregion

        #region events

        private void dtpExpiryDate_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13) { btnSave_Click(true, e); }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.err_terminalInfo.Clear();
            if (isValid())
            {
                if (btnNew.Text == "&New")
                {
                    if (_SelctedTerminalInfoId > 0)
                    {
                        //update statement
                        bool chk = true;

                        TerminalInfo objTerminalInfo = new TerminalInfo();
                        objTerminalInfo.TerminalID = this._SelctedTerminalInfoId;
                        objTerminalInfo.TerminalName = this.txtTerminalName.Text.Trim();
                        objTerminalInfo.ActivationDate = this.dtpActivationDate.Value;
                        objTerminalInfo.Attribute = this.txtAttribute.Text;
                        objTerminalInfo.ExpireDate = this.dtpExpiryDate.Value;
                        objTerminalInfo.ValueOfAttribute = this.txtAttributeValue.Text;
                        objTerminalInfo.ActivityID = Convert.ToInt64(this.cmbActivity.SelectedValue);
                        objTerminalInfo.UpdatedBy = bllUtility.LoggedInSystemInformation.LoggedUserId;
                        objTerminalInfo.IPAddress = txtIPAddress.Text;

                        chk = bllTerminalInfo.Update(objTerminalInfo);
                        if (chk)
                        {
                            bllUtility.MyMessage("You have successfully updated the record.");
                            LoadGrid();
                            btnNew.Text = "&New";
                        }
                    }
                    else
                    {
                        bllUtility.MyMessage("No data found for update.");
                    }
                }
                else
                {
                    bool chk = true;

                    //insert statement
                    TerminalInfo objTerminalInfo = new TerminalInfo();
                    objTerminalInfo.TerminalID = this._SelctedTerminalInfoId;
                    objTerminalInfo.TerminalName = this.txtTerminalName.Text.Trim();
                    objTerminalInfo.ActivationDate = this.dtpActivationDate.Value;
                    objTerminalInfo.Attribute = this.txtAttribute.Text;
                    objTerminalInfo.ExpireDate = this.dtpExpiryDate.Value;
                    objTerminalInfo.ValueOfAttribute = this.txtAttributeValue.Text;
                    objTerminalInfo.ActivityID = Convert.ToInt64(this.cmbActivity.SelectedValue);
                    objTerminalInfo.CreatedBy = bllUtility.LoggedInSystemInformation.LoggedUserId;
                    objTerminalInfo.CreatedDate = DateTime.Now;
                    objTerminalInfo.IPAddress = txtIPAddress.Text;

                    chk = bllTerminalInfo.Insert(objTerminalInfo);
                    if (chk)
                    {
                        //update terminal registration request table
                        if (_RegID > 0)
                        {
                            bllReportUtility.Exec_Store_Procedure("Update dbo.tbl_TerminalRegistrationInfo Set [Status]='Approved' Where RegID=" + _RegID);
                        }
                        DialogResult result;
                        result = MessageBox.Show("You have successfully insert the record.\nDo you want to add another data.?", bllUtility.LoggedInSystemInformation.SoftwareName, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (result == DialogResult.Yes)
                        {
                            btnNew.Text = "&New";
                            LoadGrid();
                            ClearFields();
                            btnNew.Text = "&Cancel";

                        }
                        else
                        {
                            btnNew.Text = "&New";
                            LoadGrid();
                        }
                        CountPending();
                    }
                }
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            if (btnNew.Text == "&New")
            {
                btnNew.Text = "&Cancel";
                ClearFields();
            }
            else
            {
                btnNew.Text = "&New";
                LoadGrid();
            }
        }

        private void frmTerminalInfo_Load(object sender, EventArgs e)
        {
            LoadAcitivityCombo();
            LoadGrid();
            CountPending();
        }

        private void CountPending()
        {
            DataTable dt = new DataTable();
            dt = bllReportUtility.ReportData("Select RegID from tbl_TerminalRegistrationInfo where Status='Post'");
            lblPendingNo.Text = dt.Rows.Count.ToString();

            LoadPendingGrid();
        }

        private void dgvUnitList_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (Convert.ToInt32(e.RowIndex) == -1)
            {

            }
            else
            {
                DataGridViewRow dr = ((DataGridView)sender).Rows[e.RowIndex];
                try
                {
                    long TerminalId = 0;
                    TerminalId = Convert.ToInt64(dr.Cells[0].Value);
                    this._SelctedTerminalInfoId = TerminalId;
                    if (btnNew.Text == "&New")
                    {
                        LoadTerminalInfoByID(TerminalId);
                    }
                    else
                    {
                        DialogResult result;
                        result = MessageBox.Show("Do you want to reload the window.?", bllUtility.LoggedInSystemInformation.SoftwareName, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (result == DialogResult.Yes)
                        {
                            LoadTerminalInfoByID(TerminalId);
                            btnNew.Text = "&New";
                        }
                        else
                        {
                            LoadTerminalInfoByID(TerminalId);
                            btnNew.Text = "&Cancel";
                        }
                    }
                }
                catch { }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvTerminalList_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                DataGridView dgv = (DataGridView)sender;

                long TerminalId = 0;
                TerminalId = Convert.ToInt64(dgv.SelectedCells[0].Value);
                this._SelctedTerminalInfoId = TerminalId;
                if (btnNew.Text == "&New")
                {
                    LoadTerminalInfoByID(TerminalId);
                }
                else
                {
                    DialogResult result;
                    result = MessageBox.Show("Do you want to reload the window.?", bllUtility.LoggedInSystemInformation.SoftwareName, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        LoadTerminalInfoByID(TerminalId);
                        btnNew.Text = "&New";
                    }
                }
            }
            catch { }

        }

        private void lblClose_Click(object sender, EventArgs e)
        {
            pnlRequestList.Visible = false;
            LoadGrid();
        }

        private void lblPendingNo_Click(object sender, EventArgs e)
        {
            pnlRequestList.Visible = true;
            LoadPendingGrid();
        }

        private void dgvReqList_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (Convert.ToInt32(e.RowIndex) == -1)
            {

            }
            else
            {
                ClearFields();
                DataGridViewRow dr = ((DataGridView)sender).Rows[e.RowIndex];
                try
                {
                    txtTerminalName.Text = dr.Cells[4].Value.ToString();
                    txtAttributeValue.Text = dr.Cells[3].Value.ToString();
                    txtIPAddress.Text = dr.Cells[2].Value.ToString();
                    this.txtTerminalName.Focus();
                    _RegID = Convert.ToInt32(dr.Cells[0].Value);
                    pnlRequestList.Visible = false;
                    btnNew.Text = "&Cancel";
                }
                catch { }
            }
        }

        #endregion

    }
}
