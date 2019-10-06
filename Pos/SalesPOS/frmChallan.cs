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
using System.Collections;
using AssetInventory.Report;

namespace AssetInventory
{
    public partial class frmChallan : frmTemplate
    {
        bool IsPrint = false;
        bllReportUtility iReportUtility = new bllReportUtility();
        DataTable dt_main = new DataTable();
        public frmChallan()
        {
            InitializeComponent();
        }

        private void frmChallan_Load(object sender, EventArgs e)
        {            
            bllUtility.ResetGridColor(dgvChallan);
            bllUtility.ResetGridColor(dgvProductList);            
            ClearAll();
            LoadGrid();
        }

        private void LoadGrid()
        {
            dgvChallan.AutoGenerateColumns = false;
            dt_main = bllReportUtility.ReportData("dbo.populate_pending_challan");
                            
                dgvChallan.DataSource = dt_main;
            
        }

        private void ClearAll()
        {
            lblSalesMasteID.Text = "";
            btnPrint.Enabled = true;
            btnSave.Enabled = true;
            dtpChallanDate.Text = DateTime.Now.ToString();
            txtCustomerAddress.Text = "";
            txtCustomerName.Text = "";
            txtCustomerPhone.Text = "";
            txtRemarks.Text = "";
            txtChallanNo.Text = "";
            txt_po_no.Text = "";
            //dgvChallan.DataSource = null;
        }

        private void btnResetForm_Click(object sender, EventArgs e)
        {
            dgvChallan.DataSource = null;
            ClearAll();
            LoadGrid();
            dgvProductList.DataSource = null;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            btnSave.Enabled = false;
            if (lblSalesMasteID.Text == "")
            {
                bllUtility.MyMessage("You have not select any data for challan.");
            }
            else
            {
                try
                {
                    DataTable dt = bllReportUtility.ReportData("[insert_challan_master] " + lblSalesMasteID.Text + "," + bllUtility.LoggedInSystemInformation.LoggedUserId + ",'" + txtRemarks.Text.Trim() + "'");
                    if (dt.Rows.Count > 0)
                    {
                        txtChallanNo.Text=dt.Rows[0][0].ToString();
                        bllUtility.MyMessage("Challan created successfully..");
                        LoadGrid();
                    }
                }
                catch (Exception ex) { throw (ex); }
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            IsPrint = false;
            PrintPreview(IsPrint);
            btnPrint.Enabled = false;
        }

        private void PrintPreview(bool IsPrint)
        {
            if (txtChallanNo.Text == "")
            {
                MessageBox.Show("You have not created any Invoice. Please create an Invoice.", "Information");
            }
            else
            {
                string sql = "";
                Hashtable ht = new Hashtable();

                ht.Add("paramCompany", bllUtility.LoggedInSystemInformation.CompanyName);
                ht.Add("paramComAddress", bllUtility.LoggedInSystemInformation.CompanyAddress);
                ht.Add("paramComContact", bllUtility.LoggedInSystemInformation.CompanyContactNo);
                ht.Add("paramRptTitle", "Challan");

                sql = "print_challan '" + txtChallanNo.Text.Trim() + "'";
                rptSalesInvoice_Large obj_rpt = new rptSalesInvoice_Large();
                iReportUtility.PrintPreview(obj_rpt, sql, ht, IsPrint);
            }
        }

        private void dgvChallan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1 && e.ColumnIndex > -1)
            {
                ClearAll();
                SetData(dgvChallan.Rows[e.RowIndex].Cells["SalesMasterID"].Value.ToString());
            }
        }

        private void SetData(string _SearchID)
        {
            DataTable dt = new DataTable();
            DataTable dt1 = new DataTable();
            dt = bllReportUtility.ReportData(@"SELECT  SalesMasterInfo.SalesMasterID, SalesMasterInfo.CustomerName, AccountHolderInfo.Address as CustomerAddress, 
            AccountHolderInfo.ContactNo as CustomerPhone, SalesMasterInfo.VehicleNo, SalesMasterInfo.PO_Number
            FROM SalesMasterInfo inner join AccountHolderInfo on AccountHolderInfo.AccHolderInfoId=SalesMasterInfo.CustomerID
            WHERE (SalesMasterID = " + _SearchID + ")");
            if (dt.Rows.Count > 0)
            {
                txtCustomerAddress.Text = dt.Rows[0]["CustomerAddress"].ToString();
                txtCustomerPhone.Text = dt.Rows[0]["CustomerPhone"].ToString();
                txtCustomerName.Text = dt.Rows[0]["CustomerName"].ToString();
                lblSalesMasteID.Text = dt.Rows[0]["SalesMasterID"].ToString();
                txt_po_no.Text = dt.Rows[0]["PO_Number"].ToString();
            }


            dt1 = bllReportUtility.ReportData(@"SELECT     ProductInfo.ProductName, ProductSizeLookup.VariationName, SalesChildInfo.Manufacturer, SalesChildInfo.SalesQuantity, SalesChildInfo.SerialNo, 
                        UnitInfo.UnitName, SalesChildInfo.SalesMasterID
                        FROM ProductSizeLookup INNER JOIN
                        ProductInfo ON ProductSizeLookup.PID = ProductInfo.PID INNER JOIN
                        SalesChildInfo ON ProductSizeLookup.ProductSizeID = SalesChildInfo.ProductSizeID INNER JOIN
                        UnitInfo ON ProductInfo.UnitId = UnitInfo.UnitId
                        WHERE(SalesChildInfo.SalesMasterID = " + _SearchID + ")");

            if (dt1.Rows.Count > 0)
            {
                dgvProductList.AutoGenerateColumns = false;
                dgvProductList.DataSource = dt1;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            dt_main.DefaultView.RowFilter = "PO_Number like'%" + txtSearch.Text.Trim() + "%' OR SalesInvoiceNo like'%" + txtSearch.Text.Trim() + "%'";
            dgvChallan.DataSource = dt_main;
        }
    }
}
