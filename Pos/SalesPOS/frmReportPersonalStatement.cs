using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using AssetInventory.BOL;
using AssetInventory.BLL;
using AssetInventory.Report;

namespace AssetInventory
{
    public partial class frmReportPersonalStatement : Form
    {
        bool IsPrint = false;
        bllReportUtility iReportUtility = new bllReportUtility();
        public frmReportPersonalStatement()
        {
            InitializeComponent();
        }

        private void frmReportPersonalStatement_Load(object sender, EventArgs e)
        {

        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            IsPrint = false;
            PrintPreview(IsPrint);
        }
        private void PrintPreview(bool IsPrint)
        {
            string strDateFrom = this.dtpFrom.Value.ToString("dd/MM/yyyy"); 
            string strDateTo = this.dtpTo.Value.ToString("dd/MM/yyyy"); 

            string sql = "";

            Hashtable ht = new Hashtable();


            ht.Add("paramCompany", bllUtility.LoggedInSystemInformation.CompanyName);
            ht.Add("paramComAddress", bllUtility.LoggedInSystemInformation.CompanyAddress);
            ht.Add("paramComContact", bllUtility.LoggedInSystemInformation.CompanyContactNo);
            ht.Add("paramRptTitle", "Personal Statement");
            ht.Add("paramDateFrom", strDateFrom);
            ht.Add("paramDateTo", strDateTo);

            sql = "[dbo].[USP_RptAccountStatement] '" + txtAccountNo.Text.Trim() + "','" + strDateFrom.Trim() + "','" + strDateTo.Trim() + "'";
            rptPersonalStatement irptPersonalStatement = new rptPersonalStatement();
            iReportUtility.PrintPreview(irptPersonalStatement, sql, ht, IsPrint);


        }

        private void btnAccountNoSearch_Click(object sender, EventArgs e)
        {
            //frmCustomerSearch obj = new frmCustomerSearch((Int64)bllUtility.GlobalEnum.AccountHolderType.Supplier);
            //obj.ShowDialog();
            //this.txtAccountName.Text = bllUtility.ReturnSearchedAccountHolderInfo.returnSearchedAccountHolderInfo.AccHolderName; //test code rasel
            //this.txtAccountNo.Text = bllUtility.ReturnSearchedAccountHolderInfo.returnSearchedAccountHolderInfo.AccountNo;

            ////clearing global search object.
            //bllUtility.ReturnSearchedAccountHolderInfo.returnSearchedAccountHolderInfo = null;
            frmGlobalSearch obj = new frmGlobalSearch("[load_all_acc_list]", "All Account Holder");
            obj.ShowDialog();
            if (bllUtility.GlobalSearchValue.Code != null)
            {
                this.txtAccountNo.Text = bllUtility.GlobalSearchValue.Code;
                this.txtAccountName.Text = bllUtility.GlobalSearchValue.Description;
            }


        }

        private void txtAccountNo_TextChanged(object sender, EventArgs e)
        {
            if (this.txtAccountNo.TextLength == 14)
            {
                string strAccountNo = txtAccountNo.Text.ToUpper();
                DataTable dt = new DataTable();
                dt = bllAccountHolderInfo.GetAccountHolderInfo(strAccountNo, "");
                if (dt.Rows.Count > 0)
                {
                    txtAccountName.Text = dt.Rows[0]["AccHolderName"].ToString();
                }
                else
                {
                    MessageBox.Show("Invalid Account Holder.", "Warning");
                    txtAccountName.Text = "";
                    txtAccountNo.Focus();
                    txtAccountNo.SelectAll();
                }
            }
        }

        
    }
}
