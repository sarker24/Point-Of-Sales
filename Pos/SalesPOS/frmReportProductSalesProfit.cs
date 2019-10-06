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
    public partial class frmReportProductSalesProfit : Form
    {
        bool IsPrint = false;
        bllReportUtility iReportUtility = new bllReportUtility();

        public frmReportProductSalesProfit()
        {
            InitializeComponent();
        }

        private void frmReportProductSalesProfit_Load(object sender, EventArgs e)
        {
            LoadProduct();
            this.dtpFrom.Value = DateTime.Now;
            this.dtpTo.Value = DateTime.Now;
        }

        //private void LoadSection()
        //{
        //    try
        //    {
        //        DataTable dt = new DataTable();
        //        dt = bllSectionInfo.getAll();
        //        DataRow dr = dt.NewRow();
        //        dr["SectionID"] = "0";
        //        dr["SectionName"] = "----Select All----";
        //        dt.Rows.InsertAt(dr, 0);
        //        cmbProduct.DisplayMember = "SectionName";
        //        cmbProduct.ValueMember = "SectionID";
        //        cmbProduct.DataSource = dt;
        //    }
        //    catch
        //    { }
        //}
        private void LoadProduct()
        {
            try
            {
                DataTable dt = new DataTable();
                dt = bllProductInfo.getAll1();
                DataRow dr = dt.NewRow();
                dr["PID"] = "0";
                dr["ProductName"] = "Select All Product";
                dt.Rows.InsertAt(dr, 0);
                cmbProduct.DisplayMember = "ProductName";
                cmbProduct.ValueMember = "PID";
                cmbProduct.DataSource = dt;
                this.cmbProduct.SelectedIndex = 0;
            }
            catch
            { }
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
            string strSectionID = this.cmbProduct.SelectedValue.ToString();


            string sql = "";
            Hashtable ht = new Hashtable();            
            ht.Add("paramRptTitle", "Profit & Loss Analysis Report");            
            ht.Add("paramDateFrom", strDateFrom);
            ht.Add("paramDateTo", strDateTo);

            if (rptDetails.Checked == true)
            {
                ht.Add("paramReportType", "(Details)");
                sql = "[dbo].[USP_RptProductSalesProfit] '" + strDateFrom.Trim() + "','" + strDateTo.Trim() + "','" + cmbProduct.SelectedValue.ToString().Trim() + "', 'Details' ";
                rptProfitLoss_Details irptProfitLoss_Details = new rptProfitLoss_Details();
                iReportUtility.PrintPreview(irptProfitLoss_Details, sql, ht, IsPrint);
            }
            else
            {
                ht.Add("paramReportType", "(Summary)");
                sql = "[dbo].[USP_RptProductSalesProfit] '" + strDateFrom.Trim() + "','" + strDateTo.Trim() + "','" + cmbProduct.SelectedValue.ToString().Trim() + "', 'Summary' ";
                rptProfitLoss_Summary irptProfitLoss_Summary = new rptProfitLoss_Summary();
                iReportUtility.PrintPreview(irptProfitLoss_Summary, sql, ht, IsPrint);
            }

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
