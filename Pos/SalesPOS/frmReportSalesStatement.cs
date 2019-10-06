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
    public partial class frmReportSalesStatement : Form
    {
        bool IsPrint = false;
        bllReportUtility iReportUtility = new bllReportUtility();

        public frmReportSalesStatement()
        {
            InitializeComponent();
        }

        private void frmReportSalesStatement_Load(object sender, EventArgs e)
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
            string strDateFrom = bllUtility.FormatDate(dtpFrom);
            string strDateTo = bllUtility.FormatDate(dtpTo);
            string sql = "";
            string ReportType = "";
            if (rptDetails.Checked == true)
            { ReportType = "Details"; }
            else
            { ReportType = "Summary"; }

            Hashtable ht = new Hashtable();


            ht.Add("paramCompany", bllUtility.LoggedInSystemInformation.CompanyName);
            ht.Add("paramComAddress", bllUtility.LoggedInSystemInformation.CompanyAddress);
            ht.Add("paramComContact", bllUtility.LoggedInSystemInformation.CompanyContactNo);
            ht.Add("paramRptTitle", "Sales Statement");
            ht.Add("paramDateFrom", strDateFrom);
            ht.Add("paramDateTo", strDateTo);

            sql = "[dbo].[USP_RptProductSalesStatement]  '" + strDateFrom.Trim() + "','" + strDateTo.Trim() + "','" + ReportType + "'";

            if (rptDetails.Checked == true)
            {
                rptSalesStatement irptSalesStatement = new rptSalesStatement();
                iReportUtility.PrintPreview(irptSalesStatement, sql, ht, IsPrint);
            }
            else
            {
                rptSalesStatementSummary irptSalesStatementSummary = new rptSalesStatementSummary();
                iReportUtility.PrintPreview(irptSalesStatementSummary, sql, ht, IsPrint);
            }


        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
