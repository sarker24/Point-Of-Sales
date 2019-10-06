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
    public partial class frmSalesInvice : Form
    {
        string _ItemID = "";
        string _ItemName = "";

        SaleMaster objSaleMaster = new SaleMaster();
        SalesChild objSalesChild = new SalesChild();
        SalesPaymentInfo objSalesPaymentInfo = new SalesPaymentInfo();
        bool IsPrint = false;
        bllReportUtility iReportUtility = new bllReportUtility();

        ContextMenuStrip contextMenuStrip = new ContextMenuStrip();
        int _currentRowIndex;

        string SalesMasterID = "";
        double _ActualPayment = 0;

        public frmSalesInvice()
        {
            InitializeComponent();

            contextMenuStrip = new System.Windows.Forms.ContextMenuStrip();
            System.Windows.Forms.ToolStripMenuItem MenuItemDelete = new System.Windows.Forms.ToolStripMenuItem();
            MenuItemDelete.Text = "Delete";
            MenuItemDelete.Click += new EventHandler(deleteToolStripMenuItem_Click); //Add Click Handler
            contextMenuStrip.Items.Add(MenuItemDelete);
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (DataGridViewRow dr in dgvSalesGrid.SelectedRows)
                {
                    Int32 rowToDelete = dgvSalesGrid.Rows.GetFirstRow(DataGridViewElementStates.Selected);
                    if (rowToDelete > -1)
                    {
                        dgvSalesGrid.Rows.RemoveAt(rowToDelete);
                    }
                }
                Calculate();
            }
            catch (Exception ex) { }
        }

        private void dgvSalesGrid_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            _currentRowIndex = e.RowIndex;
        }

        private void dgvSalesGrid_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                System.Drawing.Point pt = this.PointToClient(System.Windows.Forms.Cursor.Position);
                if (e.Button == MouseButtons.Right)
                {
                    if (dgvSalesGrid.SelectedRows.Count > 0)
                    {
                        contextMenuStrip.Show(this, pt.X, pt.Y);
                    }
                }
            }
            catch (Exception ex) { }
        }

        private void frmSalesInvice_Load(object sender, EventArgs e)
        {
            this.ActiveControl = txtItemCode;
            ClearProductInfo_All();
            bllUtility.ResetGridColor(dgvSalesGrid);            
        }

        private Boolean IsAssetExistInGrid(string _ItemCode)
        {
            bool ExistInGrid = false;
            double _TotalPrice, _Vat, _Qty;
            for (int i = 0; i < dgvSalesGrid.Rows.Count; i++)
            {
                if (dgvSalesGrid.Rows[i].Cells["ItemCode"].Value.ToString() == _ItemCode)
                {
                    ExistInGrid = true;
                    _Qty = _Convert(dgvSalesGrid.Rows[i].Cells["SaleQty"].Value.ToString()) + 1;
                    _TotalPrice = _Qty * _Convert(dgvSalesGrid.Rows[i].Cells["SalesPrice"].Value.ToString());
                    _Vat = _TotalPrice * _Convert(dgvSalesGrid.Rows[i].Cells["Vat"].Value.ToString()) / 100;

                    dgvSalesGrid.Rows[i].Cells["SaleQty"].Value = _Qty;
                    dgvSalesGrid.Rows[i].Cells["TotalVat"].Value = _Vat;
                    dgvSalesGrid.Rows[i].Cells["TotalPrice"].Value = _TotalPrice + _Vat;
                }
            }
            return ExistInGrid;

        }

        private void AddToGrid()
        {
            DataTable dt;
            dt = bllReportUtility.ReportData("[PopulateSalesData] " + Convert.ToInt32(cmb_model.SelectedValue) + ", '"+cmb_manufacturer.SelectedValue.ToString().Trim()+"'");
            if (dt.Rows.Count > 0)
            {
                if(Convert.ToInt32(dt.Rows[0]["OnhandQty"].ToString().Trim())<Convert.ToInt32(txtQty.Text.Trim()))
                {
                    bllUtility.MyMessage("Not sufficient stock to meet your requirement."+"Your current stock is "+dt.Rows[0]["OnhandQty"].ToString());
                    txtQty.Focus();
                    txtQty.SelectAll();
                }
                else
                {
                    dgvSalesGrid.Rows.Add();
                    dgvSalesGrid.Rows[dgvSalesGrid.Rows.Count - 1].Cells["Sl"].Value = dgvSalesGrid.Rows.Count.ToString();
                    dgvSalesGrid.Rows[dgvSalesGrid.Rows.Count - 1].Cells["ItemCode"].Value = dt.Rows[0]["PID"].ToString();
                    dgvSalesGrid.Rows[dgvSalesGrid.Rows.Count - 1].Cells["ItemDescription"].Value = dt.Rows[0]["ProductName"].ToString();
                    dgvSalesGrid.Rows[dgvSalesGrid.Rows.Count - 1].Cells["Model"].Value = dt.Rows[0]["VariationName"].ToString();
                    dgvSalesGrid.Rows[dgvSalesGrid.Rows.Count - 1].Cells["Manufacturer"].Value = dt.Rows[0]["Manufacturer"].ToString().ToUpper().Trim();
                    dgvSalesGrid.Rows[dgvSalesGrid.Rows.Count - 1].Cells["SaleQty"].Value = Convert.ToInt32(txtQty.Text.Trim());
                    dgvSalesGrid.Rows[dgvSalesGrid.Rows.Count - 1].Cells["UnitName"].Value = dt.Rows[0]["UnitName"].ToString();
                    dgvSalesGrid.Rows[dgvSalesGrid.Rows.Count - 1].Cells["Vat"].Value = dt.Rows[0]["Vat"].ToString();
                    dgvSalesGrid.Rows[dgvSalesGrid.Rows.Count - 1].Cells["WarrentyName"].Value = dt.Rows[0]["WarrentyName"].ToString();
                    dgvSalesGrid.Rows[dgvSalesGrid.Rows.Count - 1].Cells["SerialNo"].Value = "";
                    dgvSalesGrid.Rows[dgvSalesGrid.Rows.Count - 1].Cells["SalesPrice"].Value = Math.Round(Convert.ToDecimal(txtUnitPrice.Text.Trim()), 2);
                    double TotalVat = Convert.ToDouble(txtQty.Text.Trim()) * Convert.ToDouble(txtUnitPrice.Text.Trim()) * Convert.ToDouble(dt.Rows[0]["Vat"].ToString()) / 100;
                    double TotalPrice = Convert.ToDouble(txtQty.Text.Trim()) * Convert.ToDouble(txtUnitPrice.Text.Trim());
                    dgvSalesGrid.Rows[dgvSalesGrid.Rows.Count - 1].Cells["TotalVat"].Value = TotalVat;
                    dgvSalesGrid.Rows[dgvSalesGrid.Rows.Count - 1].Cells["TotalPrice"].Value = TotalPrice + TotalVat;// Convert.ToString(Math.Round(Convert.ToDecimal(dt.Rows[0]["TotalPrice"].ToString()), 3));
                    dgvSalesGrid.Rows[dgvSalesGrid.Rows.Count - 1].Cells["DaysCount"].Value = dt.Rows[0]["DaysCount"].ToString(); 
                    dgvSalesGrid.Rows[dgvSalesGrid.Rows.Count - 1].Cells["WarrentyID"].Value = dt.Rows[0]["WarrentyID"].ToString();
                    dgvSalesGrid.Rows[dgvSalesGrid.Rows.Count - 1].Cells["StockQty"].Value = dt.Rows[0]["OnhandQty"].ToString();
                    dgvSalesGrid.Rows[dgvSalesGrid.Rows.Count - 1].Cells["ProductSizeID"].Value = dt.Rows[0]["ProductSizeID"].ToString();        
                    Calculate();            
                }
            }
            else
            {
                bllUtility.MyMessage("This Product is not available now. Please purchase this product first.");
            }
            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (dgvSalesGrid.Rows.Count < 1)
            {
                MessageBox.Show("Please select item first.", "Information");
                txtItemCode.Focus();
            }
            else
            {
                if (IsValid())
                {
                    if (txtCustomerCode.Text.Trim() == "")
                    {
                        MessageBox.Show("Please Select Customer.", "Information");
                        Load_Customer_Information();
                    }
                    else
                    {
                        if (txtPaid.Text == "") txtPaid.Text = "0";
                        if (Convert.ToDouble(txtPaid.Text.Trim()) < Convert.ToDouble(lblTotalItemAmount.Text.Trim()))
                        {
                            if (MessageBox.Show("Do you want to save this credit sales information?\nSales Amount : " + lblTotalItemAmount.Text + "\nCash Paid :" + txtPaid.Text, "Confirm Save", MessageBoxButtons.YesNo) == DialogResult.Yes)
                            {
                                _ActualPayment = Convert.ToDouble(txtPaid.Text.Trim());
                                
                                //
                                SaveData();
                                //

                                btnPrint.Enabled = true;
                                btnSave.Enabled = false;
                            }
                        }
                        else
                        {
                            _ActualPayment = Convert.ToDouble(lblTotalItemAmount.Text.Trim());
                            
                            //-----------------------
                            //Save
                            //-----------------------
                            SaveData();
                            
                            btnPrint.Enabled = true;
                            btnSave.Enabled = false;
                        }
                    }
                }
                else
                {
                    bllUtility.MyMessage("Please fill up the data correctly which are orange color.");
                }
            }
        }

        private bool IsValid()
        {
            Boolean Valid;
            int err_count = 0;
            for (int i = 0; i < dgvSalesGrid.Rows.Count; i++)
            {
                dgvSalesGrid.Rows[i].Cells["SaleQty"].Style.BackColor = Color.White;
                dgvSalesGrid.Rows[i].Cells["SalesPrice"].Style.BackColor = Color.White;
                dgvSalesGrid.Rows[i].Cells["SerialNo"].Style.BackColor = Color.White;

                if (dgvSalesGrid.Rows[i].Cells["SaleQty"].Value == null || dgvSalesGrid.Rows[i].Cells["SaleQty"].Value.ToString().Trim() == "" || dgvSalesGrid.Rows[i].Cells["SaleQty"].Value.ToString().Trim() == "0")
                {
                    dgvSalesGrid.Rows[i].Cells["SaleQty"].Style.BackColor = Color.Orange;
                    err_count = err_count + 1;
                }
                if (dgvSalesGrid.Rows[i].Cells["SalesPrice"].Value == null || dgvSalesGrid.Rows[i].Cells["SalesPrice"].Value.ToString().Trim() == "" || dgvSalesGrid.Rows[i].Cells["SalesPrice"].Value.ToString().Trim() == "0" || dgvSalesGrid.Rows[i].Cells["SalesPrice"].Value.ToString().Trim() == "0.00")
                {
                    dgvSalesGrid.Rows[i].Cells["SalesPrice"].Style.BackColor = Color.Orange;
                    err_count = err_count + 1;
                }
                if (Convert.ToDouble(dgvSalesGrid.Rows[i].Cells["WarrentyID"].Value) > 1 && dgvSalesGrid.Rows[i].Cells["SerialNo"].Value == "")
                {
                    dgvSalesGrid.Rows[i].Cells["SerialNo"].Style.BackColor = Color.Orange;
                    err_count = err_count + 1;
                }
            }

            if (err_count > 0)
            {
                Valid = false;
            }
            else
            {
                Valid = true;
            }

            return Valid;
        }

        private bool SaveData()
        {
            /********************************************************
            * Author    : Shah Md. Faysal
            * Date      : 04/12/2010
            * *******************************************************/
            bool isValid = false;
            try
            {
                //Start saving process....
                /********************************************************
                * Save Sales Parent & Get Invoice no
                * *******************************************************/
                Initialize_Sales_Master();
                DataTable dt = bllProductSales.InsertSalesParent(objSaleMaster);
                lblInvoiceNo.Text = dt.Rows[0]["InvoiceNo"].ToString();
                SalesMasterID = dt.Rows[0]["SalesMasterID"].ToString();
                /********************************************************
                * Save Sales Payment
                * *******************************************************/
                InitializeSalesPaymentInfo();
                bllProductSales.InsertSalesPayment(objSalesPaymentInfo);

                /********************************************************
                * Save Sales Details Info
                * This Process will also update the stock information
                * *******************************************************/
                for (int i = 0; i < dgvSalesGrid.Rows.Count; i++)
                {
                    Initialize_Sales_Child(i);
                    bllProductSales.InsertSalesDetails(objSalesChild);
                }

                isValid = true;
            }
            catch (Exception ex)
            {
                isValid = false;
                MessageBox.Show(ex.ToString());
            }
            return isValid;
        }

        private void LoadProduct_Model(string _PID)
        {
            try
            {
                DataTable dt;
                dt = bllReportUtility.ReportData(@"SELECT     ProductSizeID, VariationName FROM     ProductSizeLookup
                                    WHERE  ProductSizeLookup.PID='" + _PID + "' order by VariationName");
                /*DataRow dr = dt.NewRow();
                dr["ProductSizeID"] = "0";
                dr["VariationName"] = "Select";
                dt.Rows.InsertAt(dr, 0);*/
                cmb_model.DisplayMember = "VariationName";
                cmb_model.ValueMember = "ProductSizeID";
                cmb_model.DataSource = dt;
                cmb_model.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                cmb_model.AutoCompleteSource = AutoCompleteSource.ListItems;

            }
            catch
            { }
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if ((keyData & Keys.KeyCode) == Keys.F1)
            {
                //F1=Product List View
                PopulateSearchGrid("dbo.load_product_basic_info", "Product List");
                if (bllUtility.GlobalSearchValue.Code != null)
                {
                    txtItemCode.Text = bllUtility.GlobalSearchValue.Description + " (" + bllUtility.GlobalSearchValue.Code + ")";
                    LoadProduct_Model(bllUtility.GlobalSearchValue.Code);

                    _ItemID = bllUtility.GlobalSearchValue.Code;
                    _ItemName = bllUtility.GlobalSearchValue.Description;
                    cmb_model.Text = "";
                    cmb_model.Focus();
                    bllUtility.GlobalSearchValue.Code = null;
                    bllUtility.GlobalSearchValue.Description = null;
                }
                return true;
            }
            else if ((keyData & Keys.KeyCode) == Keys.F2)
            {
                //F2=Customer List View
                Load_Customer_Information();
                bllUtility.GlobalSearchValue.Code = null;
                bllUtility.GlobalSearchValue.Description = null;
                return true;
            }
            else if ((keyData & Keys.KeyCode) == Keys.F3)
            {
                //F3=Select Paid Amount
                txtPaid.Focus();
                return true;
            }
            else if ((keyData & Keys.KeyCode) == Keys.Q)
            {
                if (dgvSalesGrid.Rows.Count > 0)
                {
                    //select 1st row qty cell
                    dgvSalesGrid.Rows[0].Cells["SaleQty"].Selected = true;
                    dgvSalesGrid.CurrentCell = dgvSalesGrid.Rows[0].Cells["SaleQty"];
                    dgvSalesGrid.BeginEdit(true);
                }
                return true;
            }
            else if ((keyData & Keys.KeyCode) == Keys.F5)
            {
                ClearProductInfo_All();
                return true;
            }
            else
                return base.ProcessCmdKey(ref msg, keyData);
        }

        private void ClearProductInfo_Top()
        {
            txtItemCode.Text = "";
            _ItemID = "";
            _ItemName = "";
            dtpPurchaseDate.Value = DateTime.Now;
            cmb_model.DataSource = null;
            cmb_manufacturer.DataSource = null;
            txtQty.Text = "";
            txtUnitPrice.Text = "";
            lblStock.Text = "";
            btnSearchProduct.Focus();
        }

        private void ClearProductInfo_All()
        {
            txtPO_Number.Text = "";
            _ActualPayment = 0;
            lblInvoiceNo.Text = "";
            dgvSalesGrid.Rows.Clear();
            lblTotalItemAmount.Text = "0.00";
            lblInword.Text = "";
            txtCustomerAddress.Text = "";
            txtCustomerName.Text = "";
            txtCustomerPhone.Text = "";
            txtPaid.Text = "0.00";
            txtDues.Text = "0.00";
            btnPrint.Enabled = false;
            btnSave.Enabled = true;
            txtCustomerCode.Text = "";
            chkVehicle.Checked = false;
            cmb_customer_type.Text = "ALL";
            ClearProductInfo_Top();
        }

        private void InitializeSalesPaymentInfo()
        {
            objSalesPaymentInfo.InvoiceNo = lblInvoiceNo.Text;
            objSalesPaymentInfo.PaidAmount = _ActualPayment.ToString();
            objSalesPaymentInfo.TerminalID = "0";
            objSalesPaymentInfo.CreatedBy = bllUtility.LoggedInSystemInformation.LoggedUserId.ToString();
            objSalesPaymentInfo.CustomerID = txtCustomerCode.Text.Trim();
        }

        private void Initialize_Sales_Master()
        {
            objSaleMaster.SalesType = "R";
            objSaleMaster.CustomerID = txtCustomerCode.Text.Trim();
            objSaleMaster.SalemanID = "0";
            objSaleMaster.SalesAmount = lblTotalItemAmount.Text.Trim();
            objSaleMaster.TerminalID = "0";
            objSaleMaster.CreatedBy = bllUtility.LoggedInSystemInformation.LoggedUserId.ToString();
            objSaleMaster.CashPaid = _ActualPayment.ToString();
            objSaleMaster.CustomerName = txtCustomerName.Text;
            objSaleMaster.CustomerPhone = txtCustomerPhone.Text;
            objSaleMaster.CustomerAddress = txtCustomerAddress.Text;
            objSaleMaster.VehicleNo = txtVehicle.Text;
            objSaleMaster.PO_Number = txtPO_Number.Text;
        }

        private void Initialize_Sales_Child(int j)
        {
            objSalesChild.SalesMasterID = SalesMasterID;
            objSalesChild.ProductSizeID = dgvSalesGrid.Rows[j].Cells["ProductSizeID"].Value.ToString().Trim();
            objSalesChild.Manufacturer = dgvSalesGrid.Rows[j].Cells["Manufacturer"].Value.ToString().Trim();
            objSalesChild.SalesQuantity = dgvSalesGrid.Rows[j].Cells["SaleQty"].Value.ToString().Trim();
            objSalesChild.UnitSalesPrice = dgvSalesGrid.Rows[j].Cells["SalesPrice"].Value.ToString().Trim();            
            objSalesChild.VatRate = dgvSalesGrid.Rows[j].Cells["Vat"].Value.ToString().Trim();
            objSalesChild.WarrentyID = dgvSalesGrid.Rows[j].Cells["WarrentyID"].Value.ToString().Trim();
            objSalesChild.SerialNo = dgvSalesGrid.Rows[j].Cells["SerialNo"].Value.ToString().Trim();
        }

        private void PopulateSearchGrid(string SP, string FormTitle)
        {
            frmGlobalSearch obj = new frmGlobalSearch(SP, FormTitle);
            obj.ShowDialog();
        }

        private void Calculate()
        {
            this.lblTotalItemAmount.Text = Convert.ToString(Math.Round(dgvColumnSum(dgvSalesGrid, "TotalPrice")));
            this.lblInword.Text = bllUtility.changeCurrencyToWords(Math.Round(Convert.ToDouble(lblTotalItemAmount.Text.Trim())));
        }

        private static double dgvColumnSum(DataGridView dgv, string cellName)
        {
            double sumValue = 0;
            for (int i = 0; i < dgv.RowCount; i++)
            {
                if (dgv.Rows[i].Cells[cellName].Value != null)
                {
                    string aa = dgv.Rows[i].Cells[cellName].Value.ToString();
                    sumValue += Convert.ToDouble(aa);
                }
            }
            return sumValue;
        }

        private void btnResetForm_Click(object sender, EventArgs e)
        {
            ClearProductInfo_All();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            IsPrint = false;
            PrintPreview(IsPrint);
            btnPrint.Enabled = false;
        }

        private void PrintPreview(bool IsPrint)
        {
            if (lblInvoiceNo.Text == "")
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
                ht.Add("paramRptTitle", "Sales Invoice");

                sql = "print_sales_invoice '" + lblInvoiceNo.Text.Trim() + "'";
                rptSalesInvoice_Small obj_rpt = new rptSalesInvoice_Small();
                iReportUtility.PrintPreview(obj_rpt, sql, ht, IsPrint);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtPaid_TextChanged(object sender, EventArgs e)
        {
            if (txtPaid.Text == "")
            {
                this.txtPaid.Text = "0";
                this.txtPaid.Focus();
                this.txtPaid.SelectAll();
            }
            this.txtDues.Text = Convert.ToString(Convert.ToDecimal(this.lblTotalItemAmount.Text) - Convert.ToDecimal(this.txtPaid.Text));
        }

        private void dgvSalesGrid_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            double _TotalPrice, _Vat;
            int rowIdex = Convert.ToInt16(e.RowIndex);
            if (e.ColumnIndex > -1 && e.RowIndex > -1)
            {
                if (dgvSalesGrid.Columns[e.ColumnIndex].Name == "SaleQty")
                {
                    if (_Convert(dgvSalesGrid.Rows[rowIdex].Cells["StockQty"].Value.ToString().Trim()) < _Convert(dgvSalesGrid.Rows[rowIdex].Cells["SaleQty"].Value.ToString().Trim()))
                    {
                        dgvSalesGrid.Rows[rowIdex].Cells["SaleQty"].Value = "0";
                        bllUtility.MyMessage("Stock not available. Please purchase this product.");
                        return;
                    }
                }
                if ((dgvSalesGrid.Columns[e.ColumnIndex].Name == "SaleQty") || (dgvSalesGrid.Columns[e.ColumnIndex].Name == "SalesPrice"))
                {
                    
                    if ((dgvSalesGrid.Rows[rowIdex].Cells["SaleQty"].Value != null) && (dgvSalesGrid.Rows[rowIdex].Cells["SalesPrice"].Value != null))
                    {
                        _TotalPrice = _Convert(dgvSalesGrid.Rows[rowIdex].Cells["SalesPrice"].Value.ToString()) * _Convert(dgvSalesGrid.Rows[rowIdex].Cells["SaleQty"].Value.ToString());
                        _Vat = (_Convert(dgvSalesGrid.Rows[rowIdex].Cells["SalesPrice"].Value.ToString()) * _Convert(dgvSalesGrid.Rows[rowIdex].Cells["SaleQty"].Value.ToString())) * _Convert(dgvSalesGrid.Rows[rowIdex].Cells["Vat"].Value.ToString()) / 100;
                        dgvSalesGrid.Rows[rowIdex].Cells["TotalPrice"].Value = _TotalPrice + _Vat;
                        dgvSalesGrid.Rows[rowIdex].Cells["TotalVat"].Value = _Vat;
                    }
                    else if ((dgvSalesGrid.Rows[rowIdex].Cells["SaleQty"].Value == null) && (dgvSalesGrid.Rows[rowIdex].Cells["SalesPrice"].Value != null))
                    {
                        dgvSalesGrid.Rows[rowIdex].Cells["SaleQty"].Value = 0;
                        _TotalPrice = _Convert(dgvSalesGrid.Rows[rowIdex].Cells["SalesPrice"].Value.ToString()) * 0;
                        _Vat = (_Convert(dgvSalesGrid.Rows[rowIdex].Cells["SalesPrice"].Value.ToString()) * 0) * _Convert(dgvSalesGrid.Rows[rowIdex].Cells["Vat"].Value.ToString()) / 100;
                        dgvSalesGrid.Rows[rowIdex].Cells["TotalPrice"].Value = _TotalPrice + _Vat;
                        dgvSalesGrid.Rows[rowIdex].Cells["TotalVat"].Value = _Vat;
                    }
                    else if ((dgvSalesGrid.Rows[rowIdex].Cells["SaleQty"].Value != null) && (dgvSalesGrid.Rows[rowIdex].Cells["SalesPrice"].Value == null))
                    {
                        dgvSalesGrid.Rows[rowIdex].Cells["SalesPrice"].Value = 0;
                        _TotalPrice = _Convert(dgvSalesGrid.Rows[rowIdex].Cells["SalesPrice"].Value.ToString()) * _Convert(dgvSalesGrid.Rows[rowIdex].Cells["SaleQty"].Value.ToString());
                        _Vat = (_Convert(dgvSalesGrid.Rows[rowIdex].Cells["SalesPrice"].Value.ToString()) * _Convert(dgvSalesGrid.Rows[rowIdex].Cells["SaleQty"].Value.ToString())) * _Convert(dgvSalesGrid.Rows[rowIdex].Cells["Vat"].Value.ToString()) / 100;
                        dgvSalesGrid.Rows[rowIdex].Cells["TotalPrice"].Value = _TotalPrice + _Vat;
                        dgvSalesGrid.Rows[rowIdex].Cells["TotalVat"].Value = _Vat;
                    }   
                   
                }
               
            }
            Calculate();
        }

        private double _Convert(string value)
        {
            double Cvalue = 0.000;
            if (value != "")
            {
                Cvalue = Convert.ToDouble(value);
            }
            return Cvalue;

        }

        private void dgvSalesGrid_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                if (dgvSalesGrid.SelectionMode == DataGridViewSelectionMode.FullRowSelect)
                {
                    this.dgvSalesGrid.Rows.RemoveAt(dgvSalesGrid.CurrentCell.RowIndex);
                    Calculate();
                }
            }
        }

        private void dgvSalesGrid_KeyPress(object sender, KeyPressEventArgs e)
        {
            string ColumnName = dgvSalesGrid.Columns[dgvSalesGrid.CurrentCell.ColumnIndex].Name;
            if (ColumnName == "SaleQty")
            {
                if (char.IsNumber(e.KeyChar) || e.KeyChar == 8)//|| e.KeyChar == 46)
                {
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                }
            }
            else if (ColumnName == "SalesPrice")
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
        }

        //private void cmb_customer_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    DataTable dt;
        //    dt = bllReportUtility.ReportData("SELECT  AccountNo,AccHolderName,Address, ContactNo FROM   AccountHolderInfo WHERE   (AccHolderInfoId = " + cmb_customer.SelectedValue.ToString() + ") ");
        //    if (dt.Rows.Count > 0)
        //    {
        //        txtCustomerAddress.Text = dt.Rows[0]["Address"].ToString();
        //        txtCustomerPhone.Text = dt.Rows[0]["ContactNo"].ToString();
        //        txtCustomerName.Text = dt.Rows[0]["AccHolderName"].ToString();
        //        if (dt.Rows[0]["AccountNo"].ToString() == "CUS00000000000")//if general customer
        //        {
        //            txtCustomerAddress.ReadOnly = false;
        //            txtCustomerPhone.ReadOnly = false;
        //            txtCustomerName.ReadOnly = false;
        //            txtCustomerName.Focus();

        //            txtCustomerAddress.Text = "";
        //            txtCustomerPhone.Text = "";
        //            txtCustomerName.Text = "";

        //            txtCustomerAddress.BackColor = Color.White;
        //            txtCustomerPhone.BackColor = Color.White;
        //            txtCustomerName.BackColor = Color.White;

        //            txtCustomerAddress.ForeColor = Color.Black;
        //            txtCustomerPhone.ForeColor = Color.Black;
        //            txtCustomerName.ForeColor = Color.Black;
        //        }
        //        else
        //        {
        //            txtCustomerAddress.ReadOnly = true;
        //            txtCustomerPhone.ReadOnly = true;
        //            txtCustomerName.ReadOnly = true;

        //            txtPaid.Focus();
        //            txtCustomerAddress.BackColor = Color.LemonChiffon;
        //            txtCustomerPhone.BackColor = Color.LemonChiffon;
        //            txtCustomerName.BackColor = Color.LemonChiffon;

        //            txtCustomerAddress.ForeColor = Color.Brown;
        //            txtCustomerPhone.ForeColor = Color.Brown;
        //            txtCustomerName.ForeColor = Color.Brown;
        //        }
        //    }
        //    else
        //    {
        //        txtCustomerAddress.Text = "";
        //        txtCustomerPhone.Text = "";
        //        txtCustomerName.Text = "";
        //    }
        //}

       
        //private void btnAddtoGrid_Click(object sender, EventArgs e)
        //{
        //    DataTable dt;
        //    dt = bllReportUtility.ReportData("Select ItemID from Product_Price_Info where Item_Description='" + txtItemCode.Text.Trim() + "'");
        //    if (dt.Rows.Count > 0)
        //    {
        //        _ItemID = dt.Rows[0][0].ToString();
        //        if (_ItemID != "")
        //        {
        //            AddToGrid(_ItemID);
        //        }
        //    }
        //    else
        //    {
        //        MessageBox.Show("No Product Found..");
        //    }
        //    txtItemCode.Text = "";
        //    txtItemCode.Focus();
        //}

       


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


        private void dgvSalesGrid_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            e.Control.KeyPress += new KeyPressEventHandler(dgvSalesGrid_KeyPress);
        }

        private void txtPaid_KeyUp(object sender, KeyEventArgs e)
        {
            if (Convert.ToInt16(e.KeyCode) == 13)
            {
                btnSave.Focus();
            }
        }

        private void dgvSalesGrid_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        private void btnSearchProduct_Click(object sender, EventArgs e)
        {
            PopulateSearchGrid("dbo.load_product_basic_info", "Product List");
            if (bllUtility.GlobalSearchValue.Code != null)
            {
                txtItemCode.Text = bllUtility.GlobalSearchValue.Description + " (" + bllUtility.GlobalSearchValue.Code + ")";
                LoadProduct_Model(bllUtility.GlobalSearchValue.Code);
                _ItemID = bllUtility.GlobalSearchValue.Code;
                _ItemName = bllUtility.GlobalSearchValue.Description;
                cmb_model.Text = "";
                cmb_model.Focus();
                bllUtility.GlobalSearchValue.Code = null;
                bllUtility.GlobalSearchValue.Description = null;
            }
        }

        private void btnSearchCustomer_Click(object sender, EventArgs e)
        {
            Load_Customer_Information();
            bllUtility.GlobalSearchValue.Code = null;
            bllUtility.GlobalSearchValue.Description = null;
        }

        private void Load_Customer_Information()
        {
            PopulateSearchGrid("dbo.[load_customer_list] '" + cmb_customer_type.Text.Trim() + "'", "Customer List of : " + cmb_customer_type.Text.Trim());
            if (bllUtility.GlobalSearchValue.Code != null)
            {
                DataTable dt;
                dt = bllReportUtility.ReportData("SELECT  AccountNo,AccHolderName,Address, ContactNo FROM   AccountHolderInfo WHERE   (AccountNo = '" + bllUtility.GlobalSearchValue.Code + "') ");
                if (dt.Rows.Count > 0)
                {
                    txtCustomerAddress.Text = dt.Rows[0]["Address"].ToString();
                    txtCustomerPhone.Text = dt.Rows[0]["ContactNo"].ToString();
                    txtCustomerName.Text = dt.Rows[0]["AccHolderName"].ToString();
                    txtCustomerCode.Text = bllUtility.GlobalSearchValue.Code;
                    txtCustomerCode.ReadOnly = true;
                    //txtCustomerCode.BackColor = Color.LemonChiffon;
                    //txtCustomerCode.ForeColor = Color.Brown;

                    if (dt.Rows[0]["AccountNo"].ToString() == "CUS00000000000")//if general customer
                    {
                        txtCustomerAddress.ReadOnly = false;
                        txtCustomerPhone.ReadOnly = false;
                        txtCustomerName.ReadOnly = false;

                        txtCustomerName.Focus();

                        txtCustomerAddress.Text = "";
                        txtCustomerPhone.Text = "";
                        txtCustomerName.Text = "";

                        txtCustomerAddress.BackColor = Color.White;
                        txtCustomerPhone.BackColor = Color.White;
                        txtCustomerName.BackColor = Color.White;

                        txtCustomerAddress.ForeColor = Color.Black;
                        txtCustomerPhone.ForeColor = Color.Black;
                        txtCustomerName.ForeColor = Color.Black;
                    }
                    else
                    {
                        txtCustomerAddress.ReadOnly = true;
                        txtCustomerPhone.ReadOnly = true;
                        txtCustomerName.ReadOnly = true;

                        txtPaid.Focus();
                        txtCustomerAddress.BackColor = Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255))))); 
                        txtCustomerPhone.BackColor = Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255))))); 
                        txtCustomerName.BackColor = Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255))))); 

                        txtCustomerAddress.ForeColor = Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
                        txtCustomerPhone.ForeColor = Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
                        txtCustomerName.ForeColor = Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192))))); 
                    }
                }
                else
                {
                    txtCustomerAddress.Text = "";
                    txtCustomerPhone.Text = "";
                    txtCustomerName.Text = "";
                    txtCustomerCode.Text = "";
                }
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ClearProductInfo_Top();
        }
   
        private void btnaddToList_Click(object sender, EventArgs e)
        {
            if (_ItemID == "")
            {
                bllUtility.MyMessage("Please select product from the list");
                btnSearchProduct_Click(sender, e);
            }
            else if (cmb_model.SelectedValue == null || cmb_model.SelectedValue.ToString() == "0" || cmb_model.Text == "")
            {
                bllUtility.MyMessage("Please select product model");
                cmb_model.Focus();
            }
            else if (cmb_manufacturer.SelectedValue == null || cmb_manufacturer.SelectedValue.ToString() == "0" || cmb_manufacturer.Text == "")
            {
                bllUtility.MyMessage("Please select the product manufacturer");
                cmb_manufacturer.Focus();
            }
            else if (txtQty.Text == "")
            {
                bllUtility.MyMessage("Please input the product quantity");
                txtQty.Focus();
            }
            else if (txtUnitPrice.Text == "")
            {
                bllUtility.MyMessage("Please input product unit price");
                txtUnitPrice.Focus();
            }
            else
            {
                if (IsExist() == false)
                {
                    AddToGrid();
                    //ClearProductInfo_Top();
                    txtQty.Text = "";
                    txtUnitPrice.Text = "";
                    cmb_manufacturer.Text = "";
                    lblStock.Text = "";
                    cmb_manufacturer.Focus();
                }
                else
                {
                    bllUtility.MyMessage("This product you already added in the list.");
                    cmb_model.Focus();
                }
            }
        }

        bool IsExist()
        {

            bool is_valid = false;
            for (int i = 0; i < dgvSalesGrid.Rows.Count; i++)
            {

                if (dgvSalesGrid.Rows[i].Cells["ProductSizeID"].Value.ToString().Trim() == cmb_model.SelectedValue.ToString().Trim() &&
                    dgvSalesGrid.Rows[i].Cells["Manufacturer"].Value.ToString().Trim().ToUpper() == cmb_manufacturer.SelectedValue.ToString().Trim().ToUpper())
                {
                    is_valid = true;
                }

            }
            return is_valid;

        }
        
        private void txtQty_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtUnitPrice_KeyPress(object sender, KeyPressEventArgs e)
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


        private void chkVehicle_CheckedChanged(object sender, EventArgs e)
        {
            txtVehicle.Visible = chkVehicle.Checked;
            if (chkVehicle.Checked)
                txtVehicle.Focus();
        }

        private void cmb_model_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmb_model.SelectedValue == null || cmb_model.SelectedValue.ToString().Trim() == "0")
                {
                    return;
                }
                DataTable DTab_Items = bllManufacturerInfo.GetItemList(cmb_model.SelectedValue.ToString().Trim());

                cmb_manufacturer.DisplayMember = "Manufacturer";
                cmb_manufacturer.ValueMember = "Manufacturer";
                cmb_manufacturer.DataSource = DTab_Items;

                cmb_manufacturer.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                cmb_manufacturer.AutoCompleteSource = AutoCompleteSource.ListItems;

                cmb_manufacturer.Text = "";
                cmb_manufacturer.Focus();
                cmb_manufacturer.Select();
            }
            catch (Exception ex)
            {
                throw (ex);
            }            
        }

        private void chkPO_NO_CheckedChanged(object sender, EventArgs e)
        {
            txtPO_Number.Visible = chkPO_NO.Checked;
            if (chkPO_NO.Checked == true)
                txtPO_Number.Focus();
        }

        private void txtItemCode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSearchProduct_Click(sender, e);
            }
        }

        private void cmb_model_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    if (cmb_model.SelectedValue == null || cmb_model.SelectedValue.ToString().Trim() == "0")
                    {
                        return;
                    }
                    DataTable DTab_Items = bllManufacturerInfo.GetItemList(cmb_model.SelectedValue.ToString().Trim());

                    /*DataRow dr = DTab_Items.NewRow();
                    dr["Manufacturer"] = "0";
                    dr["Manufacturer"] = "Select";
                    DTab_Items.Rows.InsertAt(dr, 0);*/

                    cmb_manufacturer.DisplayMember = "Manufacturer";
                    cmb_manufacturer.ValueMember = "Manufacturer";
                    cmb_manufacturer.DataSource = DTab_Items;

                    cmb_manufacturer.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                    cmb_manufacturer.AutoCompleteSource = AutoCompleteSource.ListItems;

                    cmb_manufacturer.Text = "";
                    cmb_manufacturer.Focus();
                    cmb_manufacturer.Select();
                }
                catch (Exception ex)
                {
                    throw (ex);
                }

                //cmb_manufacturer.Focus();
            }
        }

        private void cmb_manufacturer_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtQty.Focus();
                DisplayStock();
            }
        }

        private void DisplayStock()
        {
            DataTable dt= bllReportUtility.ReportData(@"SELECT     TOP (200) SUM(OnhandQty) AS Stock FROM PurchaseChild
                                        WHERE (ProductSizeID = "+cmb_model.SelectedValue+") AND (Manufacturer = '"+cmb_manufacturer.SelectedValue+"')");
            if (dt.Rows.Count > 0)
            {
                lblStock.Text = dt.Rows[0][0].ToString();
            }
            else
            {
                lblStock.Text = "";
            }
        }

        private void txtQty_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtUnitPrice.Focus();
            }
        }

        private void txtUnitPrice_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnaddToList_Click(sender, e);
            }
        }

        private void cmb_manufacturer_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

       
    }
}
