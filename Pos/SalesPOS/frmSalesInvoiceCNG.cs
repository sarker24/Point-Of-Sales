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
    public partial class frmSalesInvoiceCNG : Form
    {
        AutoCompleteStringCollection namesCollection = new AutoCompleteStringCollection();
        AutoCompleteStringCollection namesCollection1 = new AutoCompleteStringCollection();

        TreeNode parentnode = null;
        SaleMaster objSaleMaster = new SaleMaster();
        SalesChild objSalesChild = new SalesChild();
        SalesPaymentInfo objSalesPaymentInfo = new SalesPaymentInfo();
        bool IsPrint = false;
        bllReportUtility iReportUtility = new bllReportUtility();

        string SalesMasterID = "";
        string _ItemID = "";
        double _ActualPayment = 0;

        public frmSalesInvoiceCNG()
        {
            InitializeComponent();
        }

        private void frmSalesInvoiceCNG_Load(object sender, EventArgs e)
        {
            ClearAll();
            treemanipulate();
        }
        private void InitializeProductName()
        {
            DataTable dt = new DataTable();
            dt = bllProductInfo.getProductNameList();//0 = without fixed asset 
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                namesCollection.Add(dt.Rows[i][0].ToString());
            }

            txtItemName.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtItemName.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txtItemName.AutoCompleteCustomSource = namesCollection;
        }

        private void InitializeProductCode()
        {
            DataTable dt = new DataTable();
            dt = bllProductInfo.getProductNameList();//0 = without fixed asset 
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                namesCollection1.Add(dt.Rows[i][1].ToString());
            }

            txtItemCode.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtItemCode.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txtItemCode.AutoCompleteCustomSource = namesCollection1;
        }
        private void LoadCustomer()
        {
            try
            {
                DataTable dt = new DataTable();
                dt = bllReportUtility.ReportData(@"SELECT     AccHolderName+' ( '+ AccountNo +' )' as [AccHolderName], AccHolderInfoId, AccountHolderTypeID
FROM         AccountHolderInfo
WHERE     (AccountHolderTypeID = 2)
ORDER BY AccHolderName");
                DataRow dr = dt.NewRow();
                dr["AccHolderInfoId"] = "0";
                dr["AccHolderName"] = "Select";
                dt.Rows.InsertAt(dr, 0);
                cmb_customer.DisplayMember = "AccHolderName";
                cmb_customer.ValueMember = "AccHolderInfoId";
                cmb_customer.DataSource = dt;
            }
            catch
            { }
        }
        private void LoadSalesman()
        {
            try
            {
                DataTable dt = new DataTable();
                dt = bllReportUtility.ReportData(@"SELECT     AccHolderName+' ( '+ AccountNo +' )' as [AccHolderName], AccHolderInfoId, AccountHolderTypeID
FROM         AccountHolderInfo
WHERE     (AccountHolderTypeID = 3)
ORDER BY AccHolderName");
                cmb_salesman.DisplayMember = "AccHolderName";
                cmb_salesman.ValueMember = "AccHolderInfoId";
                cmb_salesman.DataSource = dt;
            }
            catch
            { }
        }
        private void treemanipulate()
        {
            TreeNode root = null;
            try
            {
                root = new TreeNode("Product Tree");
                treeView.Nodes.Add(root);
                DataTable DTab_Category = bllReportUtility.ReportData("SELECT     ProductName, PID FROM ProductInfo order by ProductName");
                foreach (DataRow dr0 in DTab_Category.Rows)
                {
                    parentnode = new TreeNode(dr0[0].ToString().Trim());
                    DataTable DTab_SubCategory = bllReportUtility.ReportData("SELECT  VariationName, ProductSizeID FROM ProductSizeLookup WHERE(PID = '" + dr0[1].ToString().Trim() + "')");
                    foreach (DataRow dr1 in DTab_SubCategory.Rows)
                    {
                        TreeNode child1 = new TreeNode(dr1[0].ToString().Trim());
                        DataTable DTab_item = bllReportUtility.ReportData("populate_product_tree_for_sale " + dr1[1].ToString().Trim());
                        foreach (DataRow dr2 in DTab_item.Rows)
                        {
                            TreeNode child2 = new TreeNode();
                            child2.Text = dr2[0].ToString().Trim() + " (" + dr2[2].ToString().Trim() + ")";
                            child2.Name = dr2[1].ToString().Trim();
                            child1.Nodes.Add(child2);
                        }
                        parentnode.Nodes.Add(child1);
                    }
                    root.Nodes.Add(parentnode);
                    root.Expand();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void treeView_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            // txtItemCode.Text = e.Node.Name.ToString().Trim();           
        }

        private void txtItemCode_TextChanged(object sender, EventArgs e)
        {
            //if (txtItemCode.TextLength == 10)
            //{
            //    if(IsAssetExistInGrid(txtItemCode.Text.Trim()))
            //    {
            //        //MessageBox.Show("Already Exist in the grid");
            //    }
            //    else
            //    {
            //        AddToGrid();                    
            //    }
            //    txtItemCode.Text = "";
            //    txtItemCode.Focus();
            //    Calculate();
            //}
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

        private void AddToGrid(string _ItemID1)
        {
            DataTable dt;
            dt = bllReportUtility.ReportData("[PopulateSalesData] '" + _ItemID1 + "', 'R'");
            if (dt.Rows.Count > 0)
            {
                dgvSalesGrid.Rows.Add();
                dgvSalesGrid.Rows[dgvSalesGrid.Rows.Count - 1].Cells["Sl"].Value = dgvSalesGrid.Rows.Count.ToString();
                dgvSalesGrid.Rows[dgvSalesGrid.Rows.Count - 1].Cells["ItemCode"].Value = dt.Rows[0]["ItemCode"].ToString();
                dgvSalesGrid.Rows[dgvSalesGrid.Rows.Count - 1].Cells["ItemDescription"].Value = dt.Rows[0]["ItemDescription"].ToString();
                dgvSalesGrid.Rows[dgvSalesGrid.Rows.Count - 1].Cells["SaleQty"].Value = dt.Rows[0]["SaleQty"].ToString();
                dgvSalesGrid.Rows[dgvSalesGrid.Rows.Count - 1].Cells["UnitName"].Value = dt.Rows[0]["UnitName"].ToString();
                dgvSalesGrid.Rows[dgvSalesGrid.Rows.Count - 1].Cells["SalesPrice"].Value = dt.Rows[0]["SalesPrice"].ToString();
                dgvSalesGrid.Rows[dgvSalesGrid.Rows.Count - 1].Cells["DaysCount"].Value = dt.Rows[0]["DaysCount"].ToString();
                dgvSalesGrid.Rows[dgvSalesGrid.Rows.Count - 1].Cells["WarrentyName"].Value = dt.Rows[0]["WarrentyName"].ToString();
                dgvSalesGrid.Rows[dgvSalesGrid.Rows.Count - 1].Cells["SerialNo"].Value = dt.Rows[0]["SerialNo"].ToString();
                dgvSalesGrid.Rows[dgvSalesGrid.Rows.Count - 1].Cells["WarrentyID"].Value = dt.Rows[0]["WarrentyID"].ToString();
                dgvSalesGrid.Rows[dgvSalesGrid.Rows.Count - 1].Cells["StockQty"].Value = dt.Rows[0]["StockQty"].ToString();
                dgvSalesGrid.Rows[dgvSalesGrid.Rows.Count - 1].Cells["Vat"].Value = dt.Rows[0]["Vat"].ToString();
                dgvSalesGrid.Rows[dgvSalesGrid.Rows.Count - 1].Cells["TotalVat"].Value = Convert.ToString(Math.Round(Convert.ToDecimal(dt.Rows[0]["TotalVat"].ToString()), 3));
                dgvSalesGrid.Rows[dgvSalesGrid.Rows.Count - 1].Cells["TotalPrice"].Value = Convert.ToString(Math.Round(Convert.ToDecimal(dt.Rows[0]["TotalPrice"].ToString()), 3));
                dgvSalesGrid.Rows[dgvSalesGrid.Rows.Count - 1].Cells["ItemID"].Value = _ItemID1;
                txtPaid.Text = "0.00";
                txtDues.Text = "0.00";
            }
            else
            {
                MessageBox.Show("Not Have Enough Stock", "Warning..");
            }
            Calculate();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (dgvSalesGrid.Rows.Count < 1)
            {
                MessageBox.Show("Please Item First.", "Information");
                txtItemCode.Focus();
            }
            else if (cmb_salesman.SelectedValue.ToString() == "0")
            {
                MessageBox.Show("Please Select Salesman.", "Information");
                cmb_salesman.Focus();
            }
            else if (cmb_customer.SelectedValue.ToString() == "0")
            {
                MessageBox.Show("Please Select Customer.", "Information");
                cmb_customer.Focus();
            }
            else
            {
                if (txtPaid.Text == "") txtPaid.Text = "0";
                if (Convert.ToDouble(txtPaid.Text.Trim()) < Convert.ToDouble(lblTotalItemAmount.Text.Trim()))
                {
                    if (MessageBox.Show("Do you want to save this credit sales information?\nSales Amount : " + lblTotalItemAmount.Text + "\nCash Paid :" + txtPaid.Text, "Confirm Save", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        _ActualPayment = Convert.ToDouble(txtPaid.Text.Trim());
                        SaveData();
                        btnPrint.Enabled = true;
                        btnSave.Enabled = false;
                    }
                }
                else
                {
                    _ActualPayment = Convert.ToDouble(lblTotalItemAmount.Text.Trim());
                    SaveData();
                    btnPrint.Enabled = true;
                    btnSave.Enabled = false;
                }
            }
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
        private void InitializeSalesPaymentInfo()
        {
            objSalesPaymentInfo.InvoiceNo = lblInvoiceNo.Text;
            objSalesPaymentInfo.PaidAmount = _ActualPayment.ToString();
            objSalesPaymentInfo.TerminalID = "0";
            objSalesPaymentInfo.CreatedBy = bllUtility.LoggedInSystemInformation.LoggedUserId.ToString();
            objSalesPaymentInfo.CustomerID = cmb_customer.SelectedValue.ToString();
        }

        private void Initialize_Sales_Master()
        {
            objSaleMaster.SalesType = "R";
            objSaleMaster.CustomerID = cmb_customer.SelectedValue.ToString();
            objSaleMaster.SalemanID = cmb_salesman.SelectedValue.ToString();
            objSaleMaster.SalesAmount = lblTotalItemAmount.Text.Trim();
            objSaleMaster.TerminalID = "0";
            objSaleMaster.CreatedBy = bllUtility.LoggedInSystemInformation.LoggedUserId.ToString();
            objSaleMaster.CashPaid = _ActualPayment.ToString();
            objSaleMaster.CustomerName = txtCustomerName.Text;
            objSaleMaster.CustomerPhone = txtCustomerPhone.Text;
            objSaleMaster.CustomerAddress = txtCustomerAddress.Text;
        }

        private void Initialize_Sales_Child(int j)
        {
            objSalesChild.SalesMasterID = SalesMasterID;
            objSalesChild.ProductSizeID = dgvSalesGrid.Rows[j].Cells["ItemID"].Value.ToString().Trim();
            objSalesChild.SalesQuantity = dgvSalesGrid.Rows[j].Cells["SaleQty"].Value.ToString().Trim();
            objSalesChild.UnitSalesPrice = dgvSalesGrid.Rows[j].Cells["SalesPrice"].Value.ToString().Trim();
            objSalesChild.UnitCostPrice = dgvSalesGrid.Rows[j].Cells["SalesPrice"].Value.ToString().Trim();
            objSalesChild.VatRate = dgvSalesGrid.Rows[j].Cells["Vat"].Value.ToString().Trim();
            objSalesChild.WarrentyID = dgvSalesGrid.Rows[j].Cells["WarrentyID"].Value.ToString().Trim();
            objSalesChild.SerialNo = dgvSalesGrid.Rows[j].Cells["SerialNo"].Value.ToString().Trim();
            objSalesChild.StoreID = "1";
        }

        private void treeView_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            //txtItemCode.Text = e.Node.Name.ToString().Trim();   
            if (btnSave.Enabled == true)
            {
                _ItemID = e.Node.Name.ToString().Trim();
                if (_ItemID != "")
                {
                    AddToGrid(_ItemID);
                }
            }
        }

        private void splitContainer_DoubleClick(object sender, EventArgs e)
        {
            if (splitContainer.SplitterDistance == 200)
            {
                splitContainer.SplitterDistance = 0;
            }
            else
            {
                splitContainer.SplitterDistance = 200;
            }
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
            ClearAll();
        }

        private void ClearAll()
        {
            _ActualPayment = 0;
            txtItemCode.Text = "";
            txtItemName.Text = "";
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
            LoadCustomer();
            LoadSalesman();
            cmb_customer.SelectedIndex = 0;
            InitializeProductName();
            InitializeProductCode();
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

                //string invoiceID = "PUR00000000038";
                sql = "print_sales_invoice '" + lblInvoiceNo.Text.Trim() + "'";
                rptSalesInvoice_Large irptrptSalesInvoice_Large = new rptSalesInvoice_Large();
                iReportUtility.PrintPreview(irptrptSalesInvoice_Large, sql, ht, IsPrint);
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
            }
            this.txtDues.Text = Convert.ToString(Convert.ToDecimal(this.lblTotalItemAmount.Text) - Convert.ToDecimal(this.txtPaid.Text));
        }

        private void dgvSalesGrid_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            double _TotalPrice, _Vat;
            if (e.ColumnIndex > -1 && e.RowIndex > -1)
            {
                if ((dgvSalesGrid.Columns[e.ColumnIndex].Name == "SaleQty") || (dgvSalesGrid.Columns[e.ColumnIndex].Name == "SalesPrice"))
                {
                    int rowIdex = Convert.ToInt16(e.RowIndex);
                    if ((dgvSalesGrid.Rows[rowIdex].Cells["SaleQty"].Value != null) && (dgvSalesGrid.Rows[rowIdex].Cells["SalesPrice"].Value != null))
                    {
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
                this.dgvSalesGrid.Rows.RemoveAt(dgvSalesGrid.CurrentCell.RowIndex);
                Calculate();
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

        private void cmb_customer_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt;
            dt = bllReportUtility.ReportData("SELECT  AccountNo,AccHolderName,Address, ContactNo FROM   AccountHolderInfo WHERE   (AccHolderInfoId = " + cmb_customer.SelectedValue.ToString() + ") ");
            if (dt.Rows.Count > 0)
            {
                txtCustomerAddress.Text = dt.Rows[0]["Address"].ToString();
                txtCustomerPhone.Text = dt.Rows[0]["ContactNo"].ToString();
                txtCustomerName.Text = dt.Rows[0]["AccHolderName"].ToString();
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

                    txtCustomerAddress.BackColor = Color.LemonChiffon;
                    txtCustomerPhone.BackColor = Color.LemonChiffon;
                    txtCustomerName.BackColor = Color.LemonChiffon;

                    txtCustomerAddress.ForeColor = Color.Brown;
                    txtCustomerPhone.ForeColor = Color.Brown;
                    txtCustomerName.ForeColor = Color.Brown;
                }
            }
            else
            {
                txtCustomerAddress.Text = "";
                txtCustomerPhone.Text = "";
                txtCustomerName.Text = "";
            }
        }

        private void txtItemCode_KeyUp(object sender, KeyEventArgs e)
        {
            if (Convert.ToInt16(e.KeyCode) == 13)
            {
                btnAddtoGrid_byItemCode_Click(sender, e);
            }
        }

        private void btnAddtoGrid_Click(object sender, EventArgs e)
        {
            DataTable dt;
            dt = bllReportUtility.ReportData("Select ItemID from Product_Price_Info where Item_Description='" + txtItemName.Text.Trim() + "'");
            if (dt.Rows.Count > 0)
            {
                _ItemID = dt.Rows[0][0].ToString();
                if (_ItemID != "")
                {
                    AddToGrid(_ItemID);
                }
            }
            else
            {
                MessageBox.Show("No Product Found..");
            }
            txtItemName.Text = "";
            txtItemName.Focus();
        }

        private void btnAddtoGrid_byItemCode_Click(object sender, EventArgs e)
        {
            DataTable dt;
            dt = bllReportUtility.ReportData("Select ItemID from Product_Price_Info where ItemCode='" + txtItemCode.Text.Trim() + "'");
            if (dt.Rows.Count > 0)
            {
                _ItemID = dt.Rows[0][0].ToString();
                if (_ItemID != "")
                {
                    AddToGrid(_ItemID);
                }
            }
            else
            {
                MessageBox.Show("No Product Found..");
            }
            txtItemCode.Text = "";
            txtItemCode.Focus();
        }

        private void txtItemName_KeyUp(object sender, KeyEventArgs e)
        {
            if (Convert.ToInt16(e.KeyCode) == 13)
            {
                btnAddtoGrid_Click(sender, e);
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

        private void btnSeachProduct_Click(object sender, EventArgs e)
        {
            frmProductSearch obj = new frmProductSearch(0);
            obj.ShowDialog();
            //txtProductName.Text = bllUtility.ReturnSearchedProduct.returnSearchedProductInfo.ProductName; //test code rasel
            txtItemCode1.Text = bllUtility.ReturnSearchedProduct.returnSearchedProductInfo.PID;

            //clearing global search object.
            bllUtility.ReturnSearchedProduct.returnSearchedProductInfo = null;
        }

        private void treeView_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void splitContainer_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void txtDues_TextChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void txtCustomerName_TextChanged(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void cmb_salesman_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void txtCustomerAddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtCustomerPhone_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtItemName_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dgvSalesGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void dtpPurchaseDate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void lblInword_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void lblTotalItemAmount_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtItemCode1_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblInvoiceNo_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
