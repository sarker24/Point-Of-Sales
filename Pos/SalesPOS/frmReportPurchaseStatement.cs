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
    public partial class frmReportPurchaseStatement : Form
    {
        bool IsPrint = false;
        bllReportUtility iReportUtility = new bllReportUtility();

        public frmReportPurchaseStatement()
        {
            InitializeComponent();
        }

        private void frmReportPurchaseStatement_Load(object sender, EventArgs e)
        {
            this.dtpFrom.Value = DateTime.Now;
            this.dtpTo.Value = DateTime.Now;
        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            IsPrint = false;
            PrintPreview(IsPrint);

        }

        private void PrintPreview(bool IsPrint)
        {
            string strDateFrom = this.dtpFrom.Value.ToString("dd/MM/yyyy"); ;
            string strDateTo = this.dtpTo.Value.ToString("dd/MM/yyyy"); ;

            string sql = "";

            Hashtable ht = new Hashtable();


            ht.Add("paramCompany", bllUtility.LoggedInSystemInformation.CompanyName);
            ht.Add("paramComAddress", bllUtility.LoggedInSystemInformation.CompanyAddress);
            ht.Add("paramComContact", bllUtility.LoggedInSystemInformation.CompanyContactNo);
            ht.Add("paramRptTitle", "Purchase Statement Report");
            ht.Add("paramDateFrom", strDateFrom);
            ht.Add("paramDateTo", strDateTo);

            sql = "[dbo].[USP_RptPurchaseStatement] '" + strDateFrom.Trim() + "','" + strDateTo.Trim() + "'";
            rptPurchaseStatement irptPurchaseStatement = new rptPurchaseStatement();
            iReportUtility.PrintPreview(irptPurchaseStatement, sql, ht, IsPrint);


        }
    }
}
