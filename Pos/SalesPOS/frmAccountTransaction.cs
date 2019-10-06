using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using AssetInventory.BLL;
using AssetInventory.BOL;
using System.Web;

namespace AssetInventory
{
    public partial class frmAccountTransaction : Form
    {
        DataTable dtAccTrans = new DataTable();
        AccountTransaction objAccountTransaction = new AccountTransaction();
        private long _ATID = 0;
        
        public frmAccountTransaction()
        {
            InitializeComponent();
        }
        
        private void frmAccountTransaction_Load(object sender, EventArgs e)
        {
            this.ActiveControl = cmb_supplier;
            LoadSupplierFor_Search();
            ClearAll();
            LoadGrid();            
            LoadTransactionType();
            LoadSupplier();
            
            this.dgvAccountTransaction.DefaultCellStyle.ForeColor = Color.Black;
        }

        private void LoadSupplier()
        {
            try
            {
                DataTable dt = new DataTable();
                dt = bllReportUtility.ReportData(@"SELECT AccountNo, AccHolderName +' ( '+ AccountNo +' )' AS [AccHolderName] FROM AccountHolderInfo ORDER BY AccHolderName");
                DataRow dr = dt.NewRow();
                dr["AccountNo"] = "0";
                dr["AccHolderName"] = "Select";
                dt.Rows.InsertAt(dr, 0);
                cmb_supplier.DisplayMember = "AccHolderName";
                cmb_supplier.ValueMember = "AccountNo";
                cmb_supplier.DataSource = dt;
            }
            catch
            { }
        }

        private void LoadSupplierFor_Search()
        {
            try
            {
                DataTable dt = new DataTable();
                dt = bllReportUtility.ReportData(@"SELECT AccountNo, AccHolderName +' ( '+ AccountNo +' )' AS [AccHolderName] FROM AccountHolderInfo WHERE  (AccountHolderTypeID = 1) ORDER BY AccHolderName");
                DataRow dr = dt.NewRow();
                dr["AccountNo"] = "0";
                dr["AccHolderName"] = "Select";
                dt.Rows.InsertAt(dr, 0);
                cmb_supplier_search.DisplayMember = "AccHolderName";
                cmb_supplier_search.ValueMember = "AccountNo";
                cmb_supplier_search.DataSource = dt;
                cmb_supplier_search.SelectedIndex = 0;
            }
            catch
            { }
        }

        private void LoadTransactionType()
        { 
            DataTable dt = new DataTable();
            dt = bllAccountTransactionType.GetAccountTransInfoForMiniAcc();
            this.cmbAccTransType.DisplayMember = "TransactionType";
            this.cmbAccTransType.ValueMember = "AccTypeID";
            this.cmbAccTransType.DataSource = dt;
        }

        private void LoadData(long selectedID)
        {
            DataTable dt = new DataTable();
            dt = bllAccountTransaction.getById(selectedID);
            this.txtAtid.Text = dt.Rows[0]["ATID"].ToString();
            this.cmb_supplier.SelectedValue= dt.Rows[0]["AccountNo"].ToString();
            //this.txtAccountHolder.Text = dt.Rows[0]["AccHolderName"].ToString();
            this.cmbAccTransType.SelectedValue = Convert.ToInt64(dt.Rows[0]["ATTID"].ToString());

            DataTable dt1 = bllAccountTransaction.GetTransactionType(Convert.ToInt64(dt.Rows[0]["ATTID"].ToString()));
            if (dt1.Rows[0]["DrCr"].ToString() == "Debit")
            {
                this.txtAmount.Text = dt.Rows[0]["Debit"].ToString();
            }
            else
            {
                this.txtAmount.Text = dt.Rows[0]["Credit"].ToString();
            }      

            this.txtDescription.Text = dt.Rows[0]["Description"].ToString();
            this.dtpTransactionDate.Value = Convert.ToDateTime(dt.Rows[0]["TransactionDate"]);
        }

        private void ClearAll()
        {            
                        
            //txtSearchAccNo.Text = "";            
            cmbAccTransTypeSearch.DataSource = null;
            cmbRecordType.Text = "Both";
            chkTransactionType.Checked = false;
            dtpFrom.Value = DateTime.Now;
            dtpTo.Value = DateTime.Now;
            dgvAccountTransaction.DataSource = null;
        }

        private void ClearFields()
        {
            //txtAccountHolder.Text = "";
            cmb_supplier.SelectedIndex = 0;
            txtAmount.Text = "";
            txtAtid.Text = "";
            txtDescription.Text = "";
            lblDrCr.Text = "Amount :";
            dtpTransactionDate.Value = DateTime.Now;
            LoadTransactionType();
        }
        private void LoadGrid()
        {
            InitializeSearchValue();            
            dtAccTrans = bllAccountTransaction.GetAccTransDetails(objAccountTransaction);
            this.dgvAccountTransaction.AutoGenerateColumns = false;
            this.dgvAccountTransaction.DataSource = dtAccTrans;
            lblRecordCount.Text = dtAccTrans.Rows.Count.ToString();
        }

        private void chkTransactionType_CheckedChanged(object sender, EventArgs e)
        {
            if (chkTransactionType.Checked == true)
            {
                DataTable dt = new DataTable();
                dt = bllAccountTransactionType.GetAccountTransInfoForMiniAcc();
                this.cmbAccTransTypeSearch.DisplayMember = "TransactionType";
                this.cmbAccTransTypeSearch.ValueMember = "AccTypeID";
                this.cmbAccTransTypeSearch.DataSource = dt;
            }
            else
            {
                this.cmbAccTransTypeSearch.DataSource = null;
            }
            
        }

        private void dgvAccountTransaction_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (Convert.ToInt32(e.RowIndex) == -1)
            { }
            else
            {
                DataGridViewRow dr = ((DataGridView)sender).Rows[e.RowIndex];
                try
                {
                    long ATID = 0;
                    long ATTID = 0;
                    ATID = Convert.ToInt64(dr.Cells[0].Value);
                    ATTID = Convert.ToInt64(dr.Cells["ATTID"].Value);
                    this._ATID = ATID;
                    if ( Convert.ToBoolean(dr.Cells["IsEditable"].Value) == true)
                    {
                        LoadData(_ATID);
                        cmb_supplier.Focus();

                        //ATTID = Convert.ToInt64(cmbAccTransType.SelectedValue);
                        DataTable dt = bllAccountTransaction.GetTransactionType(ATTID);
                        SetTextLabeColor(dt);
                    }
                    else
                    {
                        ClearFields();
                        txtAmount.BackColor = Color.White;
                        txtAmount.ForeColor = Color.Black;
                        MessageBox.Show("You can not modify this record.","Warning Message.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void SetTextLabeColor(DataTable dt)
        {
            lblDrCr.Text = dt.Rows[0]["DrCr"].ToString();
            if (dt.Rows[0]["CashFlow"].ToString() == "Inlay")
            {
                txtAmount.BackColor = Color.Green;
                txtAmount.ForeColor = Color.White;
            }
            else if (dt.Rows[0]["CashFlow"].ToString() == "Outlay")
            {
                txtAmount.BackColor = Color.Red;
                txtAmount.ForeColor = Color.White;
            }
            else if (dt.Rows[0]["CashFlow"].ToString() == "Impartial")
            {
                txtAmount.BackColor = Color.White;
                txtAmount.ForeColor = Color.Black;
            }
        }

        private void btnResetForm_Click(object sender, EventArgs e)
        {
            ClearFields();         
            cmb_supplier.Focus();
        }

        private void btnSearchUser_Click(object sender, EventArgs e)
        {
            LoadGrid();            
        }

        private void InitializeSearchValue()
        {
            objAccountTransaction.SearchAccountNo = cmb_supplier_search.SelectedValue.ToString();

            if (chkTransactionType.Checked == true)
            {
                objAccountTransaction.SearchATTID = cmbAccTransTypeSearch.SelectedValue.ToString();
            }
            else
            {
                objAccountTransaction.SearchATTID = string.Empty;
            }
            objAccountTransaction.SearchDateFrom = dtpFrom.Value.ToString("dd/MM/yyyy");
            objAccountTransaction.SearchDateTo = dtpTo.Value.ToString("dd/MM/yyyy");
            objAccountTransaction.SearchIsEditable = cmbRecordType.Text;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || e.KeyChar == 8 || e.KeyChar == 46)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void cmbAccTransType_SelectedIndexChanged(object sender, EventArgs e)
        {
            long ATTID = 0;
            ATTID = Convert.ToInt64(cmbAccTransType.SelectedValue);
            DataTable dt = bllAccountTransaction.GetTransactionType(ATTID);
            SetTextLabeColor(dt);
            //txtAmount.Focus();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (IsValidData())
            {
                InitializeDataForSave();
                SaveData();
                LoadGrid();
            }
        }
        
        private void InitializeDataForSave()
        {
            objAccountTransaction.AccountHolderID = cmb_supplier.SelectedValue.ToString();
            objAccountTransaction.ATID=txtAtid.Text;
            objAccountTransaction.ATTID=cmbAccTransType.SelectedValue.ToString();
            objAccountTransaction.CreatedBy=bllUtility.LoggedInSystemInformation.LoggedUserId.ToString();
            if (lblDrCr.Text == "Debit")
            {
                objAccountTransaction.Debit = txtAmount.Text;
                objAccountTransaction.Credit = "0.00";
            }
            else 
            {
                objAccountTransaction.Credit = txtAmount.Text;
                objAccountTransaction.Debit = "0.00";
            }            
            
            objAccountTransaction.Description=txtDescription.Text;
            objAccountTransaction.TransactionDate=dtpTransactionDate.Value.ToString();
            objAccountTransaction.TerminalID = "0"; 
        }
        
        private void SaveData()
        {
            if (txtAtid.Text == "")
            {
                //Insert Data
                DataTable dt = new DataTable();
                dt= bllAccountTransaction.InsertData(objAccountTransaction);
                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("Data Saved Successfully..", "Successfull Message");
                    txtAtid.Text = dt.Rows[0]["ATID"].ToString();
                }
                else 
                {
                    MessageBox.Show("Error found", "Error Message");
                }
            }
            else
            { 
                //Update Data
                bool chk = bllAccountTransaction.UpdateData(objAccountTransaction);
                if (chk == true)
                {
                    MessageBox.Show("Data Edited Successfully..", "Successfull Message");
                }
                else
                {
                    MessageBox.Show("Error found","Error Message");
                }
            }
        }

        private bool IsValidData()
        {
            bool isValid = true;
            if ((this.cmb_supplier.Text == "") || (this.cmb_supplier.Text == "Select"))
            {
                isValid = false;
                MessageBox.Show("Please Select Account Holder","Warning");
                this.cmb_supplier.Focus();                
            }
            else if (this.txtAmount.Text == "")
            {
                isValid = false;
                MessageBox.Show("Please Enter Amount", "Warning");
                this.txtAmount.Focus();
            }
            else if (this.txtDescription.Text == "")
            {
                this.txtDescription.Text = "N/A";
            }
            return isValid;
        }

        //private void txtAccountNo_TextChanged(object sender, EventArgs e)
        //{
        //    if (this.txtAccountNo.TextLength == 14)
        //    {
        //        string strAccountNo = txtAccountNo.Text.ToUpper();
        //        DataTable dt = new DataTable();
        //        dt = bllAccountHolderInfo.GetAccountHolderInfo(strAccountNo,"");
        //        if (dt.Rows.Count > 0)
        //        {
        //            txtAccountHolder.Text = dt.Rows[0]["AccHolderName"].ToString();
        //        }
        //        else 
        //        {
        //            MessageBox.Show("Invalid Account Holder.","Warning");
        //            txtAccountHolder.Text = "";
        //            txtAccountNo.Focus();
        //            txtAccountNo.SelectAll();
        //        }
        //    }
        //}

        //private void txtAccountNoSearch_TextChanged(object sender, EventArgs e)
        //{
        //    if (this.txtAccountNoSearch.TextLength == 14)
        //    {
        //        string strAccountNoSearch = txtAccountNoSearch.Text.ToUpper();
        //        //txtAccountNoSearch.Text = txtAccountNoSearch.Text.ToUpper();
        //        DataTable dt = new DataTable();
        //        dt = bllAccountHolderInfo.GetAccountHolderInfo(strAccountNoSearch,"");
        //        if (dt.Rows.Count > 0)
        //        {
        //            txtAccountHolderSearch.Text = dt.Rows[0]["AccHolderName"].ToString();
        //        }
        //        else
        //        {
        //            MessageBox.Show("Invalid Account Holder.", "Warning");
        //            txtAccountHolderSearch.Text = "";
        //            txtAccountNoSearch.Focus();
        //            txtAccountNoSearch.SelectAll();
        //        }
        //    }
        //}

        //private void label1_Click(object sender, EventArgs e)
        //{

        //}

        //private void txtSearchAccNo_Click(object sender, EventArgs e)
        //{
        //    frmCustomerSearch obj = new frmCustomerSearch(0);
        //    obj.ShowDialog();
        //    this.txtAccountHolder.Text = bllUtility.ReturnSearchedAccountHolderInfo.returnSearchedAccountHolderInfo.AccHolderName; //test code rasel
        //    this.txtAccountNo.Text = bllUtility.ReturnSearchedAccountHolderInfo.returnSearchedAccountHolderInfo.AccountNo;

        //    //clearing global search object.
        //    bllUtility.ReturnSearchedAccountHolderInfo.returnSearchedAccountHolderInfo = null;

        //}

        private void dgvAccountTransaction_SelectionChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void btnPrint_Click(object sender, EventArgs e)
        {

        }
       
    }
}
