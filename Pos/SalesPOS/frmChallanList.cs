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
    public partial class frmChallanList : frmTemplate
    {
        bool IsPrint = false;
        bllReportUtility iReportUtility = new bllReportUtility();
        private string _SelctedInvoice = "";

        public frmChallanList()
        {
            InitializeComponent();
        }

        private void frmChallanList_Load(object sender, EventArgs e)
        {
            bllUtility.ResetGridColor(dgvPurchaseInvoiceList);
            dgvPurchaseInvoiceList.AutoGenerateColumns = false;
            dtpPurchaseDt.Text = DateTime.Now.ToString();
        }

        private void btnSearchUser_Click(object sender, EventArgs e)
        {
            LoadGrid();
        }

        private void LoadGrid()
        {
            try
            {
                string strDateFrom = this.dtpPurchaseDt.Value.ToString("dd/MM/yyyy");
                DataTable dt = new DataTable();
                dt = bllReportUtility.ReportData("[list_of_challan] '" + strDateFrom+"'");
                dgvPurchaseInvoiceList.DataSource = dt;
                this.dgvPurchaseInvoiceList.DefaultCellStyle.ForeColor = Color.Black;
                if (this.dgvPurchaseInvoiceList.Rows.Count > 0)
                    this.dgvPurchaseInvoiceList.Rows[0].Selected = false;
                lblRecordCount.Text = dt.Rows.Count.ToString();
            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            IsPrint = false;
            PrintPreview(IsPrint);
        }

        private void PrintPreview(bool IsPrint)
        {
            if (_SelctedInvoice == "")
            {
                MessageBox.Show("You have not select any Invoice. Please select an Invoice.", "Information");
            }
            else
            {
                string sql = "";
                Hashtable ht = new Hashtable();

                ht.Add("paramCompany", bllUtility.LoggedInSystemInformation.CompanyName);
                ht.Add("paramComAddress", bllUtility.LoggedInSystemInformation.CompanyAddress);
                ht.Add("paramComContact", bllUtility.LoggedInSystemInformation.CompanyContactNo);
                ht.Add("paramRptTitle", "Challan");

                sql = "print_challan '" + _SelctedInvoice + "'";
                rptSalesInvoice_Large obj_rpt = new rptSalesInvoice_Large();
                iReportUtility.PrintPreview(obj_rpt, sql, ht, IsPrint);
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {           
            IsPrint = true;
            PrintPreview(IsPrint);     
        }

        private void dgvPurchaseInvoiceList_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (Convert.ToInt32(e.RowIndex) == -1)
            {

            }
            else
            {
                DataGridViewRow dr = ((DataGridView)sender).Rows[e.RowIndex];
                try
                {
                    this._SelctedInvoice = dr.Cells[0].Value.ToString();
                }
                catch { }
            }
        }
    }
}
