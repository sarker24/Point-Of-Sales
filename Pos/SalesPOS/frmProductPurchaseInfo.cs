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
using AssetInventory.DataAccessLayer;

namespace AssetInventory
{
    public partial class frmProductPurchaseInfo : Form
    {
        ProductPurchaseInfo objProductPurchaseInfo = new ProductPurchaseInfo();
        PurchasePaymentInfo objPurchasePaymentInfo = new PurchasePaymentInfo();
        AutoCompleteStringCollection namesCollection = new AutoCompleteStringCollection();
        ContextMenuStrip contextMenuStrip = new ContextMenuStrip();

        int _currentRowIndex;
        string _ItemID="";
        string _ItemName="";

        public frmProductPurchaseInfo()
        {
            InitializeComponent();
            contextMenuStrip = new System.Windows.Forms.ContextMenuStrip();
            System.Windows.Forms.ToolStripMenuItem MenuItemDelete = new System.Windows.Forms.ToolStripMenuItem();
            MenuItemDelete.Text = "Delete";
            MenuItemDelete.Click += new EventHandler(deleteToolStripMenuItem_Click); //Add Click Handler
            contextMenuStrip.Items.Add(MenuItemDelete);
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
                    cmb_model.Focus();
                    bllUtility.GlobalSearchValue.Code = null;
                    bllUtility.GlobalSearchValue.Description = null;
                }   
                return true;
            }
            else if ((keyData & Keys.KeyCode) == Keys.F2)
            {
                //F2=Supplier List View
                PopulateSearchGrid("dbo.load_supplier_list ", "Supplier List");
                if (bllUtility.GlobalSearchValue.Code != null)
                {
                    txtSupplierCode.Text = bllUtility.GlobalSearchValue.Code;
                    txtSupplierName.Text = bllUtility.GlobalSearchValue.Description;
                    txtMemoNo.Focus();
                    bllUtility.GlobalSearchValue.Code = null;
                    bllUtility.GlobalSearchValue.Description = null;
                }
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
                if (dgvPurchaseGrid.Rows.Count > 0)
                {
                    //select 1st row qty cell
                    dgvPurchaseGrid.Rows[0].Cells["qty"].Selected = true;
                    dgvPurchaseGrid.CurrentCell = dgvPurchaseGrid.Rows[0].Cells["qty"];
                    dgvPurchaseGrid.BeginEdit(true);
                }
                return true;
            }
            else if ((keyData & Keys.KeyCode) == Keys.F5)
            {
                ClearProductPurchaseInfo();
                ClearProductInfo();
                InitializeModel();
                return true;
            }
            else
                return base.ProcessCmdKey(ref msg, keyData);
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (DataGridViewRow dr in dgvPurchaseGrid.SelectedRows)
                {
                    Int32 rowToDelete = dgvPurchaseGrid.Rows.GetFirstRow(DataGridViewElementStates.Selected);
                    if (rowToDelete > -1)
                    {
                        dgvPurchaseGrid.Rows.RemoveAt(rowToDelete);
                    }
                }
                Calculate();
            }
            catch (Exception ex) { }
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

        private void txtTotalPrice_KeyPress(object sender, KeyPressEventArgs e)
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

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (dgvPurchaseGrid.Rows.Count > 0)
            {
                if (txtSupplierCode.Text == "")
                {
                    bllUtility.MyMessage("Please select supplier information");
                    btnSearchSupplier_Click(sender,e);                    
                }
                else if (IsValid())
                {
                    if (txtPaid.Text == "") txtPaid.Text = "0";
                    if (MessageBox.Show("Do you want to save this purchase information?\nPurchase Amount : " + lblTotalItemAmount.Text + "\nCash Payment :" + txtPaid.Text, "Confirm Save", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        SaveDate();
                    }
                }
                else
                {
                    bllUtility.MyMessage("Please fill up the data correctly which are orange color.");
                }
            }
            else
            {
                bllUtility.MyMessage("No information found for insert. Select the product first.");
                //txtProductName.Focus();
            }
        }

        private void SaveDate()
        {
            //initialize the purchase master
            Initialize_Purchase_Master();

            //execute the master purchase information & get the purchase no
            DataTable dt = bllProductPurchase.InsertPurchaseMaster(objProductPurchaseInfo);

            string purchaseID = dt.Rows[0][0].ToString();
            string purchaseRef = dt.Rows[0][1].ToString();

            DataTable dt1;
            for (int i = 0; i < dgvPurchaseGrid.Rows.Count; i++)
            {
                dt1 = bllProductPurchase.InsertPurchaseMasterDetails(
                                            purchaseID, 
                                            dgvPurchaseGrid.Rows[i].Cells["ProductSizeID"].Value.ToString().Trim(), 
                                            dgvPurchaseGrid.Rows[i].Cells["Manufacturer"].Value.ToString().Trim(), 
                                            dgvPurchaseGrid.Rows[i].Cells["unit_price"].Value.ToString().Trim(), 
                                            dgvPurchaseGrid.Rows[i].Cells["qty"].Value.ToString()
                                        );
            }

            txtPurchaseNo.Text = purchaseRef;

            /********************************************************
            * Save Purchase Payment
            * *******************************************************/
            InitializePurchasePaymentInfo();
            bllProductPurchase.InsertPurchasePayment(objPurchasePaymentInfo);

            //disable save button
            this.btnSave.Enabled = false;
            bllUtility.MyMessage("Successfully Inserted the purchase information");
        }

        private void InitializePurchasePaymentInfo()
        {
            objPurchasePaymentInfo.PurchaseID = txtPurchaseNo.Text;
            objPurchasePaymentInfo.PaidAmount = txtPaid.Text;
            objPurchasePaymentInfo.SupplierID = txtSupplierCode.Text.Trim();
            objPurchasePaymentInfo.TerminalID = "0";
            objPurchasePaymentInfo.CreatedBy = bllUtility.LoggedInSystemInformation.LoggedUserId.ToString();
        }

        private void Initialize_Purchase_Master()
        {
            objProductPurchaseInfo.TransactionDate = dtpPurchaseDate.Value;
            objProductPurchaseInfo.MemoNo = txtMemoNo.Text.Trim();
            objProductPurchaseInfo.SupplierID = txtSupplierCode.Text.Trim();
            objProductPurchaseInfo.CreatedBy = bllUtility.LoggedInSystemInformation.LoggedUserId;
            objProductPurchaseInfo.TotalPrice = lblTotalItemAmount.Text.ToString();
        }

        private void btnResetForm_Click(object sender, EventArgs e)
        {
            ClearProductPurchaseInfo();
            ClearProductInfo();
            InitializeModel();
        }

        private void ClearProductPurchaseInfo()
        {
            this.dgvPurchaseGrid.Rows.Clear();
            this.txtMemoNo.Text = string.Empty;
            this.lblTotalItemAmount.Text = "0.00";
            this.lblInword.Text = "";
            this.txtPurchaseNo.Text = "";
            this.txtPaid.Text = "";
            this.btnSave.Enabled = true;
            this.txtSupplierCode.Text = "";
            this.txtSupplierName.Text = "";
        }

        private void ClearProductInfo()
        {
            this.txtItemCode.Text = "";
            dtpPurchaseDate.Value = DateTime.Now;
            cmb_model.DataSource = null;
            txtManufacture.Text = "";
            txtQty.Text = "";
            txtUnitPrice.Text = "";
            btnSearchProduct.Focus();
            _ItemID = "";
            _ItemName = "";
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmProductPurchaseInfo_Load(object sender, EventArgs e)
        {
            ClearProductPurchaseInfo();
            ClearProductInfo();
            bllUtility.ResetGridColor(dgvPurchaseGrid);
            InitializeModel();
        }

        private void InitializeModel()
        {
            DataTable dt = new DataTable();
            dt = bllReportUtility.ReportData("SELECT DISTINCT Manufacturer FROM PurchaseChild ORDER BY Manufacturer");
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                namesCollection.Add(dt.Rows[i][0].ToString());
            }

            txtManufacture.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtManufacture.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txtManufacture.AutoCompleteCustomSource = namesCollection;
        }

        private void VariationLoad(string PID, int row_no, int col_no)
        {
            DataGridViewComboBoxCell cmbClassItem = new DataGridViewComboBoxCell();
            cmbClassItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            dgvPurchaseGrid.Rows[row_no].Cells[col_no] = cmbClassItem;
            cmbClassItem.DataSource = bllReportUtility.ReportData("[dbo].[USP_LoadVariation] '" + PID + "'");
            cmbClassItem.ValueMember = "ProductSizeID";
            cmbClassItem.DisplayMember = "VariationName";            
        }

        private void dgvPurchaseGrid_KeyDown(object sender, KeyEventArgs e)
        {
            string ColumnName = dgvPurchaseGrid.Columns[dgvPurchaseGrid.CurrentCell.ColumnIndex].Name;

            //remove the selected row
            if (e.KeyCode == Keys.Delete)
            {
                if (dgvPurchaseGrid.SelectionMode == DataGridViewSelectionMode.FullRowSelect)
                {
                    this.dgvPurchaseGrid.Rows.RemoveAt(dgvPurchaseGrid.CurrentCell.RowIndex);
                    Calculate();
                }
            }
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

        private double _Convert(string value)
        {
            double Cvalue = 0.00;
            if (value != "")
            {
                Cvalue = Convert.ToDouble(value);
            }
            return Cvalue;
        }

        private void dgvPurchaseGrid_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        private bool IsValid()
        {
            Boolean Valid;
            int err_count = 0;
            for (int i = 0; i < dgvPurchaseGrid.Rows.Count; i++)
            {
                dgvPurchaseGrid.Rows[i].Cells["qty"].Style.BackColor = Color.White;
                dgvPurchaseGrid.Rows[i].Cells["unit_price"].Style.BackColor = Color.White;
                
                if (dgvPurchaseGrid.Rows[i].Cells["qty"].Value == null || dgvPurchaseGrid.Rows[i].Cells["qty"].Value.ToString().Trim() == "" || dgvPurchaseGrid.Rows[i].Cells["qty"].Value.ToString().Trim() == "0")
                {
                    dgvPurchaseGrid.Rows[i].Cells["qty"].Style.BackColor = Color.Orange;
                    err_count = err_count + 1;
                }
                if (dgvPurchaseGrid.Rows[i].Cells["unit_price"].Value == null || dgvPurchaseGrid.Rows[i].Cells["unit_price"].Value.ToString().Trim() == "" || dgvPurchaseGrid.Rows[i].Cells["unit_price"].Value.ToString().Trim() == "0")
                {
                    dgvPurchaseGrid.Rows[i].Cells["unit_price"].Style.BackColor = Color.Orange;
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

        private void Calculate()
        {
            this.lblTotalItemAmount.Text = Convert.ToString(Math.Round(dgvColumnSum(dgvPurchaseGrid, "total_price")));
            this.lblInword.Text = bllUtility.changeCurrencyToWords(Math.Round(dgvColumnSum(dgvPurchaseGrid, "total_price")));
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
        
        private void AddToGrid()
        {
            dgvPurchaseGrid.Rows.Add();
            string _Unit = "";
            _Unit=bllReportUtility.ReportData(@"SELECT dbo.UnitInfo.UnitName FROM dbo.ProductInfo INNER JOIN
                                        dbo.UnitInfo ON dbo.ProductInfo.UnitId = dbo.UnitInfo.UnitId
                                        WHERE (dbo.ProductInfo.PID = '" + _ItemID + "')").Rows[0]["UnitName"].ToString();
            
            dgvPurchaseGrid.Rows[dgvPurchaseGrid.Rows.Count - 1].Cells["sl"].Value = dgvPurchaseGrid.Rows.Count.ToString();
            dgvPurchaseGrid.Rows[dgvPurchaseGrid.Rows.Count - 1].Cells["ItemCode"].Value = _ItemID;
            dgvPurchaseGrid.Rows[dgvPurchaseGrid.Rows.Count - 1].Cells["ItemDescription"].Value = _ItemName;
            dgvPurchaseGrid.Rows[dgvPurchaseGrid.Rows.Count - 1].Cells["Model"].Value = cmb_model.Text;
            dgvPurchaseGrid.Rows[dgvPurchaseGrid.Rows.Count - 1].Cells["Manufacturer"].Value = txtManufacture.Text.ToUpper();
            dgvPurchaseGrid.Rows[dgvPurchaseGrid.Rows.Count - 1].Cells["qty"].Value = txtQty.Text;
            dgvPurchaseGrid.Rows[dgvPurchaseGrid.Rows.Count - 1].Cells["unit"].Value = _Unit;
            dgvPurchaseGrid.Rows[dgvPurchaseGrid.Rows.Count - 1].Cells["unit_price"].Value = txtUnitPrice.Text;
            dgvPurchaseGrid.Rows[dgvPurchaseGrid.Rows.Count - 1].Cells["total_price"].Value = _Convert(txtQty.Text.Trim()) * _Convert(txtUnitPrice.Text.Trim());
            dgvPurchaseGrid.Rows[dgvPurchaseGrid.Rows.Count - 1].Cells["ProductSizeID"].Value = cmb_model.SelectedValue.ToString().Trim();
            Calculate();
        }

        private void dgvPurchaseGrid_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            e.Control.KeyPress += new KeyPressEventHandler(dgvPurchaseGrid_KeyPress);
        }

        private void dgvPurchaseGrid_KeyPress(object sender, KeyPressEventArgs e)
        {
            string ColumnName = dgvPurchaseGrid.Columns[dgvPurchaseGrid.CurrentCell.ColumnIndex].Name;
            if (ColumnName == "qty")
            {
                if (char.IsNumber(e.KeyChar) || e.KeyChar == 8)
                {
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                }
            }
            else if (ColumnName == "unit_price")
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

        private void dgvPurchaseGrid_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex > -1 && e.RowIndex > -1)
            {
                if ((dgvPurchaseGrid.Columns[e.ColumnIndex].Name == "unit_price") || (dgvPurchaseGrid.Columns[e.ColumnIndex].Name == "qty"))
                {
                    int rowIdex = Convert.ToInt16(e.RowIndex);
                    if ((dgvPurchaseGrid.Rows[rowIdex].Cells["unit_price"].Value != null) && (dgvPurchaseGrid.Rows[rowIdex].Cells["qty"].Value != null))
                    {
                        dgvPurchaseGrid.Rows[rowIdex].Cells["total_price"].Value = _Convert(dgvPurchaseGrid.Rows[rowIdex].Cells["unit_price"].Value.ToString()) * _Convert(dgvPurchaseGrid.Rows[rowIdex].Cells["qty"].Value.ToString());
                    }
                    else if ((dgvPurchaseGrid.Rows[rowIdex].Cells["unit_price"].Value == null) && (dgvPurchaseGrid.Rows[rowIdex].Cells["qty"].Value != null))
                    {
                        dgvPurchaseGrid.Rows[rowIdex].Cells["unit_price"].Value = 0;
                        dgvPurchaseGrid.Rows[rowIdex].Cells["total_price"].Value = 0 * _Convert(dgvPurchaseGrid.Rows[rowIdex].Cells["qty"].Value.ToString());
                    }
                    else if ((dgvPurchaseGrid.Rows[rowIdex].Cells["unit_price"].Value != null) && (dgvPurchaseGrid.Rows[rowIdex].Cells["qty"].Value == null))
                    {
                        dgvPurchaseGrid.Rows[rowIdex].Cells["qty"].Value = 0;
                        dgvPurchaseGrid.Rows[rowIdex].Cells["total_price"].Value = _Convert(dgvPurchaseGrid.Rows[rowIdex].Cells["unit_price"].Value.ToString()) * 0;
                    }
                }
            }
            Calculate();
        }

        private void dgvPurchaseGrid_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            _currentRowIndex = e.RowIndex;
        }

        private void dgvPurchaseGrid_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                System.Drawing.Point pt = this.PointToClient(System.Windows.Forms.Cursor.Position);
                if (e.Button == MouseButtons.Right)
                {
                    if (dgvPurchaseGrid.SelectedRows.Count > 0)
                    {
                        contextMenuStrip.Show(this, pt.X, pt.Y);
                    }
                }
            }
            catch (Exception ex) { }
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
                bllUtility.GlobalSearchValue.Code = null;
                bllUtility.GlobalSearchValue.Description = null;
                cmb_model.Text = "";
                cmb_model.Focus();
            }           
        }

        private void PopulateSearchGrid(string SP, string FormTitle)
        {
            frmGlobalSearch obj = new frmGlobalSearch(SP, FormTitle);
            obj.ShowDialog();            
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

                //comboBox1.Focus();
            }
            catch
            { }
        }

        private void btnSearchSupplier_Click(object sender, EventArgs e)
        {
            PopulateSearchGrid("dbo.load_supplier_list ", "Supplier List");
            if (bllUtility.GlobalSearchValue.Code != null)
            {
                txtSupplierCode.Text= bllUtility.GlobalSearchValue.Code;
                txtSupplierName.Text = bllUtility.GlobalSearchValue.Description;
                txtMemoNo.Focus();
                bllUtility.GlobalSearchValue.Code = null;
                bllUtility.GlobalSearchValue.Description = null;
            }
        }
       
        private void btnaddToList_Click(object sender, EventArgs e)
        {
            if (_ItemID == "")
            {
                bllUtility.MyMessage("Please select product from the list");
                btnSearchProduct_Click(sender,e);
            }
            else if (cmb_model.SelectedValue == null || cmb_model.SelectedValue.ToString() == "0" || cmb_model.Text == "")
            {
                bllUtility.MyMessage("Please select product model");
                cmb_model.Focus();
            }
            else if (txtManufacture.Text == "")
            {
                bllUtility.MyMessage("Please input the product manufacture");
                txtManufacture.Focus();
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
                AddToGrid();
                txtManufacture.Text = "";
                txtQty.Text = "";
                txtUnitPrice.Text = "";
                cmb_model.Focus();
                //ClearProductInfo();
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ClearProductInfo();
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

        private void dtpPurchaseDate_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSearchProduct.Focus();
            }
        }

        private void txtItemCode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                cmb_model.Focus();
            }
        }

        private void cmb_model_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtManufacture.Focus();
            }
        }

        private void txtManufacture_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtQty.Focus();
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

        private void txtMemoNo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtPaid.Focus();
                txtPaid.SelectAll();
            }
        }

        private void txtPaid_KeyDown(object sender, KeyEventArgs e)
        {
            if (Convert.ToInt16(e.KeyCode) == 13)
            {
                btnSave.Focus();
            }
        }


    }

}
