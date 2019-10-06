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

namespace AssetInventory
{
    public partial class frmWarrantyCheck : Form
    {
        WarrentyService obj = new WarrentyService();
        string dt_time;
        public frmWarrantyCheck()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            load_data();
            load_grid();
        }

        private void load_data()
        {
            DataTable dt;
            dt = bllReportUtility.ReportData("[dbo].[Load_Warranty_Info] '"+txtSerialNo.Text.Trim()+"','"+ cmbVariation.SelectedValue.ToString() +"'");
            if (dt.Rows.Count > 0)
            { 
                txtInvoiceNo.Text="";
                txtItem.Text=dt.Rows[0]["ProductName"].ToString();
                txt_model.Text = dt.Rows[0]["VariationName"].ToString();
                txt_manufacturer.Text = dt.Rows[0]["Manufacturer"].ToString();
                txtSerial.Text = dt.Rows[0]["SerialNo"].ToString();
                lblCustomerID.Text = dt.Rows[0]["CustomerID"].ToString();
                txtCustomerCode.Text = dt.Rows[0]["AccountNo"].ToString();
                txtCustomerName.Text = dt.Rows[0]["CustomerName"].ToString();
                txtCustomerAddress.Text = dt.Rows[0]["CustomerAddress"].ToString();
                txtCustomerPhone.Text = dt.Rows[0]["CustomerPhone"].ToString();
                dtpExpDate.Text = dt.Rows[0]["Warenty_Exp_date"].ToString();
                dt_time = dt.Rows[0]["Warenty_Exp_date"].ToString();
                lblMsg.Text = dt.Rows[0]["Warrenty_Applicable"].ToString();
                cmb_status.SelectedIndex = 0;
                if (lblMsg.Text == "Yes")
                {
                    lblMsg.Text = "This Product is Under Warranty Period.";
                    lblMsg.ForeColor = Color.Green;
                    chk_free_service.Checked = true;
                }
                else
                {
                    lblMsg.Text = "Warranty Period of this product has Expired.";
                    lblMsg.ForeColor = Color.Red;
                    chk_free_service.Checked = false;
                }
                if (dt.Rows[0]["VehicleNo"].ToString() != "")
                {
                    chk_new_fare.Visible = true;
                    chk_new_fare.Checked = false;
                    lblVehicle.Visible = true;
                    lblVehicle1.Visible = true;
                    lblVehicle.Text = dt.Rows[0]["VehicleNo"].ToString();
                }
                cmbProduct.Enabled = false;
                cmbVariation.Enabled = false;
                txtSerialNo.Enabled = false;
                cmb_status.Focus();
            }
            else
            {
                MessageBox.Show("No Record Found");
                //txtInvoiceNo.Text="";
                //txtSalesDate.Text="";
                //txtCustomerName.Text ="";
                //txtCustomerAddress.Text ="";
                //txtCustomerPhone.Text ="";
                //txtItemDescription.Text ="";
                //txtWarrantyType.Text ="";
                //txtWarrantyExpDate.Text = "";
                //lblMsg.Text = "";
                //lblMsg.ForeColor = Color.Black;
            }
        }

        private void load_grid()
        {
            DataTable dt = new DataTable();
            dt = bllReportUtility.ReportData("[dbo].[populate_service_list] '" + txtSerialNo.Text.Trim() + "'," + cmbVariation.SelectedValue.ToString() + "");
            if (dt.Rows.Count > 0)
            {
                dgvAccountHolderList.AutoGenerateColumns = false;
                dgvAccountHolderList.DataSource = dt;
            }
        }

        private void frmWarrantyCheck_Load(object sender, EventArgs e)
        {
            ClearAll();
            bllUtility.ResetGridColor(dgvAccountHolderList);
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if ((keyData & Keys.KeyCode) == Keys.F5)
            {
                ClearAll();
                return true;
            }
            else
                return base.ProcessCmdKey(ref msg, keyData);
        }

        private void ClearAll()
        {
            LoadProduct();
            txtInvoiceNo.Text = "";
            txtItem.Text = "";
            txt_model.Text = "";
            txt_manufacturer.Text = "";
            txtSerial.Text="";
            txt_exp_extend.Text = "60";
            txt_exp_extend.Visible = false;
            lbl_exp_extend.Visible = false;
            chk_new_fare.Visible = false;
            lblVehicle.Visible = false;
            lblVehicle1.Visible = false;
            btnReceive.Enabled = true;
            txtCustomerCode.Text = "";
            txtCustomerName.Text = "";
            txtCustomerPhone.Text = "";
            txtCustomerAddress.Text = "";
            chk_free_service.Checked = false;
            dtpExpDate.Text = DateTime.Now.ToString();
            lblMsg.Text = "";
            cmbProduct.Enabled = true;
            cmbVariation.Enabled = true;
            txtSerialNo.Enabled = true;
            cmbProduct.Focus();
            lblCustomerID.Text = "";
            dgvAccountHolderList.DataSource = null;
            lblVehicle.Text = "";
        }

        private void LoadProduct()
        {
            try
            {
                DataTable dt = new DataTable();
                dt = bllProductInfo.getAll1();
                DataRow dr = dt.NewRow();
                dr["PID"] = "0";
                dr["ProductName"] = "Select";
                dt.Rows.InsertAt(dr, 0);
                cmbProduct.DisplayMember = "ProductName";
                cmbProduct.ValueMember = "PID";
                cmbProduct.DataSource = dt;
                this.cmbProduct.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                bllUtility.MyMessage(ex.ToString());
            }
        }

        private void cmbProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            string _PID;
            DataTable dt;
            _PID = cmbProduct.SelectedValue.ToString();
            dt = bllReportUtility.ReportData(@"SELECT ProductSizeID, VariationName
                                        FROM ProductSizeLookup WHERE (PID = '"+_PID+"')");
            DataRow dr = dt.NewRow();
            dr["ProductSizeID"] = "0";
            dr["VariationName"] = "Select";
            dt.Rows.InsertAt(dr, 0);
            cmbVariation.DisplayMember = "VariationName";
            cmbVariation.ValueMember = "ProductSizeID";
            cmbVariation.DataSource = dt;
            this.cmbVariation.SelectedIndex = 0;
        }

        private void btnReceiveProduct_Click(object sender, EventArgs e)
        {
            //frmReceiveWarrentyProduct obj = new frmReceiveWarrentyProduct();
            //obj.ShowDialog();
            //btnReceive.Enabled = false;
            if (Valid_Update_Data() == true)
            {
                InitializeValue();
                Save();
                load_grid();
            }
        }

        private void InitializeValue()
        {
            obj.ProductSizeID = Convert.ToInt32(this.cmbVariation.SelectedValue);
            obj.Manufacturer = txt_manufacturer.Text;
            obj.SerialNo = txtSerial.Text;
            obj.IsWarrentyApplicable = chk_free_service.Checked;
            obj.IsNewFareAdded = chk_new_fare.Checked;
            obj.Status = cmb_status.Text;
            obj.VehicleNo = lblVehicle.Text;
            obj.CustomerID = Convert.ToInt32(lblCustomerID.Text);
            obj.CustomerName = txtCustomerName.Text;
            obj.Address = txtCustomerAddress.Text;
            obj.WarrentyExpiredDate = dtpExpDate.Value;
            obj.TotalServiceAmount = 0;
            obj.DiscountAmount = 0;
            obj.PaidAmount = 0;
            obj.ReadyForGatePass = "No";
            obj.IsPaid = false;            
        }

        private bool Valid_Update_Data()
        {
            bool isValid = true;
            //check the record is selected or not for update
            if (txtSerial.Text.Trim() == "")
            {
                isValid = false;
                bllUtility.MyMessage("You have not select any data for receive.");
            }            
            else
            {
                isValid = true;
            }
            return isValid;
        }

        private void Save()
        {
            try
            {
                DataTable dt = new DataTable();
                dt = bllWarrentyService.Receive_Warrenty_Product(obj);
                if (dt.Rows.Count > 0)
                {
                    bllUtility.MyMessage("You have successfully received this product");
                    txtInvoiceNo.Text=dt.Rows[0][0].ToString();
                }
            }
            catch(Exception ex)
            {
                throw (ex);
            }
        }

        private void setSearchPanel()
        {
            if (optSerial.Checked == true)
            {
                pnlSerial.Visible = true;
                pnlVehicle.Visible = false;
            }
            else
            {
                pnlSerial.Visible = false;
                pnlVehicle.Visible = true;
            }
        }

        private void optSerial_Click(object sender, EventArgs e)
        {
            setSearchPanel(); 
        }

        private void optVehicle_Click(object sender, EventArgs e)
        {
            setSearchPanel(); 
        }

        private void chk_new_fare_CheckedChanged(object sender, EventArgs e)
        {
            txt_exp_extend.Visible = chk_new_fare.Checked;
            lbl_exp_extend.Visible = chk_new_fare.Checked;
            if (chk_new_fare.Checked == true)
            {
                dtpExpDate.Text = DateTime.Now.AddDays(Convert.ToDouble(txt_exp_extend.Text.Trim())).ToString();
            }
            else
            {
                dtpExpDate.Text = dt_time;
            }
        }

        private void btnResetForm_Click(object sender, EventArgs e)
        {
            ClearAll();
        }

        private void txtSerialNo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            { 
                btnSearch_Click( sender,  e);
            }
        }

        private void btnPayment_Click(object sender, EventArgs e)
        {
            frmReceiveWarrentyProduct obj = new frmReceiveWarrentyProduct(txtInvoiceNo.Text.Trim());
            obj.ShowDialog();
        }        
    }
}
