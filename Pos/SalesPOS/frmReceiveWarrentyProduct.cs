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
using AssetInventory.Report;
using System.Collections;

namespace AssetInventory
{
    public partial class frmReceiveWarrentyProduct : frmTemplate
    {
        DataTable dt = new DataTable();
        WarrentyService obj = new WarrentyService();
        bllReportUtility iReportUtility = new bllReportUtility();
        string SearchParam = "";
        bool IsPrint = false;

        public frmReceiveWarrentyProduct()
        {
            InitializeComponent();
        }

        public frmReceiveWarrentyProduct(string strSearchParam)
        {
            InitializeComponent();
            SearchParam = strSearchParam;
        }

        private void frmReceiveWarrentyProduct_Load(object sender, EventArgs e)
        {
            bllUtility.ResetGridColor(dgvItem);
            ClearAll();
            txtSearch.Focus();
            GridLoad();
            if (SearchParam != "")
            {
                SetData(SearchParam);
            }
        }

        private void GridLoad()
        {            
            dt = bllReportUtility.ReportData("dbo.populate_service_list_for_payment");
            if (dt.Rows.Count > 0)
            {
                dgvItem.AutoGenerateColumns = false;
                dgvItem.DataSource = dt;
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            dt.DefaultView.RowFilter = "ServiceNumber like'%" + txtSearch.Text.Trim() + "%' OR Description like'%" + txtSearch.Text.Trim() + "%'";
            dgvItem.DataSource = dt;
        }

        private void ClearAll()
        {
            txtInvoiceNo.Text = "";
            txtDescription.Text = "";
            txtPaid.Text = "";
            lblVehicle.Visible = false ;
            lblVehicle1.Visible = false;
            lblVehicle.Text = "";
            cmb_status.SelectedIndex = 1;
            txtCustomerAddress.Text = "";
            txtCustomerName.Text = "";
            chk_new_fare.Checked = false;
            chk_new_fare.Visible = false;
            lblCustomerID.Text = "";
            btnPayment.Enabled = true;
            btnReceivePrint.Enabled = false;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            GridLoad();
            ClearAll();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SetData(string strSearch)
        {
            DataTable dt1 = new DataTable();
            dt1 = bllReportUtility.ReportData("populate_service_list_for_payment_by_id " + strSearch);
            if (dt.Rows.Count > 0)
            {
                txtInvoiceNo.Text = dt1.Rows[0]["ServiceNumber"].ToString();
                txtDescription.Text = dt1.Rows[0]["Description"].ToString();
                txtCustomerName.Text = dt1.Rows[0]["CustomerName"].ToString();
                txtCustomerAddress.Text = dt1.Rows[0]["Address"].ToString();
                if (dt1.Rows[0]["VehicleNo"].ToString() != "")
                {
                    lblVehicle.Text = dt1.Rows[0]["VehicleNo"].ToString();
                    lblVehicle.Visible = true;
                    lblVehicle1.Visible = true;
                    chk_new_fare.Visible = true;
                    chk_new_fare.Checked = Convert.ToBoolean(dt1.Rows[0]["IsNewFareAdded"]);
                }
                else
                {
                    lblVehicle.Visible = false;
                    lblVehicle1.Visible = false;
                    chk_new_fare.Visible = false;
                }
                txtPaid.Text = "";
                lblCustomerID.Text = dt1.Rows[0]["CustomerID"].ToString();
                txtPaid.Focus();
            }
        }

        private void dgvItem_CellClick(object sender, DataGridViewCellEventArgs e)
        {            
            if (e.ColumnIndex > -1 && e.RowIndex > -1)
            {
                ClearAll();
                SearchParam = dgvItem.Rows[e.RowIndex].Cells[0].Value.ToString().Trim();
                SetData(SearchParam);                
            }
        }

        private void btnPayment_Click(object sender, EventArgs e)
        {
            if (txtInvoiceNo.Text=="")
            {
                bllUtility.MyMessage("You have not select any service item for payment slip");
                //txtPaid.Focus();
            }
            else if (txtPaid.Text == "")
            {
                bllUtility.MyMessage("Please input amount");
                txtPaid.Focus();
            }
            else
            {
                obj.ServiceNumber = txtInvoiceNo.Text;
                obj.PaidAmount = Convert.ToDouble(txtPaid.Text);
                obj.Status = cmb_status.Text;
                obj.CustomerID = Convert.ToInt32(lblCustomerID.Text);

                bllWarrentyService.Receive_Payment(obj);
                btnPayment.Enabled = false;
                btnReceivePrint.Enabled = true;
                bllUtility.MyMessage("You have successfully received amount");
                GridLoad();
            }
        }

        private void txtPaid_KeyPress(object sender, KeyPressEventArgs e)
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

        private void btnReceivePrint_Click(object sender, EventArgs e)
        {
            IsPrint = false;
            PrintPreview(IsPrint);
            btnReceivePrint.Enabled = false;
        }

        private void PrintPreview(bool IsPrint)
        {
            if (txtInvoiceNo.Text == "")
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
                ht.Add("paramRptTitle", "Service Payment Receipt");

                sql = "[print_service_invoice] '" + txtInvoiceNo.Text.Trim() + "'";
                rptServiceInvoice obj_rpt = new rptServiceInvoice();
                iReportUtility.PrintPreview(obj_rpt, sql, ht, IsPrint);
            }
        }
    }
}
