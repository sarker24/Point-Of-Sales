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
    public partial class frmSalesInvoiceList : Form
    {
        bool IsPrint = false;
        bllReportUtility iReportUtility = new bllReportUtility();
        private string _SelctedInvoice = "";

        public frmSalesInvoiceList()
        {
            InitializeComponent();
        }

        private void SalesInvoiceList_Load(object sender, EventArgs e)
        {
            bllUtility.ResetGridColor(dgvSalesList);
            LoadGrid();
        }

        private void LoadGrid()
        {
            try
            {
                string strDateFrom = this.dtpFromDate.Value.ToString("dd/MM/yyyy");
                string strDateTo = this.dtpToDate.Value.ToString("dd/MM/yyyy");
                DataTable dt = new DataTable();
                dt = bllInvoiceList.LoadSalesInvoice(strDateFrom, strDateTo);
                dgvSalesList.DataSource = dt;
                this.dgvSalesList.DefaultCellStyle.ForeColor = Color.Black;
                if (this.dgvSalesList.Rows.Count > 0)
                    this.dgvSalesList.Rows[0].Selected = false;
                //lblRecordCount.Text = dt.Rows.Count.ToString();
            }
            catch (Exception ex)
            {
                throw (ex);
            }
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
                MessageBox.Show("You have not selected any Invoice. Please select an Invoice.", "Information");
            }
            else
            {
                string sql = "";
                Hashtable ht = new Hashtable();

                ht.Add("paramCompany", bllUtility.LoggedInSystemInformation.CompanyName);
                ht.Add("paramComAddress", bllUtility.LoggedInSystemInformation.CompanyAddress);
                ht.Add("paramComContact", bllUtility.LoggedInSystemInformation.CompanyContactNo);
                ht.Add("paramRptTitle", "Sales Invoice");

                sql = "print_sales_invoice '" + _SelctedInvoice.Trim() + "'";
                rptSalesInvoice_Small irptSalesInvoice_Large = new rptSalesInvoice_Small();
                iReportUtility.PrintPreview(irptSalesInvoice_Large, sql, ht, IsPrint);
            }
        }

        private void dgvSalesList_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (Convert.ToInt32(e.RowIndex) == -1)
            {

            }
            else
            {
                DataGridViewRow dr = ((DataGridView)sender).Rows[e.RowIndex];
                try
                {
                    this._SelctedInvoice = dr.Cells[1].Value.ToString();
                }
                catch { }
            }
        }

        private void btnSearchUser_Click(object sender, EventArgs e)
        {
            LoadGrid();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
