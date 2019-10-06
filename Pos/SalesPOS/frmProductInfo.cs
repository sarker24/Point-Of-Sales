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
    public partial class frmProductInfo : Form
    {
        private DataTable dtProductInfo = new DataTable();
        private string _SelctedProductID = "";
        ProductInfo objProductInfo = new ProductInfo();
        AutoCompleteStringCollection namesCollection = new AutoCompleteStringCollection();
        AutoCompleteStringCollection namesCollection1 = new AutoCompleteStringCollection();

        public frmProductInfo()
        {
            InitializeComponent();
        }

        private void frmProductInfo_Load(object sender, EventArgs e)
        {
            this.ActiveControl = txtSearch;
            ClearFields();
            LoadGrid();
            bllUtility.ResetGridColor(dgvProductInfo);
            bllUtility.ResetGridColor(dgvSize);
            InitializeModel();
        }

        private void InitializeModel()
        {
            DataTable dt = new DataTable();
            dt = bllReportUtility.ReportData("SELECT DISTINCT VariationName FROM ProductSizeLookup ORDER BY VariationName");
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                namesCollection.Add(dt.Rows[i][0].ToString());
            }

            txtVariation.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtVariation.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txtVariation.AutoCompleteCustomSource = namesCollection;
        }
        
        private void LoadGrid()
        {
            dtProductInfo = bllProductInfo.getAll1();
            this.dgvProductInfo.AutoGenerateColumns = false;
            this.dgvProductInfo.DataSource = dtProductInfo;

        }

        private void LoadSizeGrid( string _PID)
        {
            DataTable dt;
            dt = bllReportUtility.ReportData(@"SELECT     ProductSizeID, VariationName FROM     ProductSizeLookup
                                    WHERE  ProductSizeLookup.PID='" + _PID + "' order by VariationName");
            dgvSize.DataSource = dt;
            this.dgvSize.AutoGenerateColumns = false;
            this.dgvSize.DataSource = dt;           
        }
        
        private void LoadProductSizeInfoByID(string selectedID)
        {
            DataTable dt = new DataTable();
            dt = bllReportUtility.ReportData(@"SELECT  ProductSizeID, PID, VariationName FROM  ProductSizeLookup 
                                                Where ProductSizeID=" + selectedID);
            this.txtCode.Text = dt.Rows[0]["ProductSizeID"].ToString();
            this.txtVariation.Text = dt.Rows[0]["VariationName"].ToString();
        }
               
        private void ClearFields()
        {
                      
            txtCode.Text = "";
            txtVariation.Text = "";
            txtVariation.Focus();

        }            

        private void dgvProductInfo_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (Convert.ToInt32(e.RowIndex) == -1) { }
            else
            {
                DataGridViewRow dr = ((DataGridView)sender).Rows[e.RowIndex];
                try
                {
                    tabControl.SelectedTab = tabControl.TabPages[1];
                    this._SelctedProductID = Convert.ToString(dr.Cells[0].Value).Trim();
                    ClearFields();
                    LoadSizeGrid(_SelctedProductID);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }


        private void btnReset2_Click(object sender, EventArgs e)
        {
            txtVariation.Text = "";
            txtCode.Text = "";
            LoadSizeGrid(this._SelctedProductID);
            txtVariation.Focus();           
        }

        private void btnSave2_Click(object sender, EventArgs e)
        {
            DataTable dt1;


            string sql = "";
            DataTable dt;
            if (_SelctedProductID == "")
            {
                MessageBox.Show("Please select the product.");                
            }
            else if (txtVariation.Text == "")
            {
                MessageBox.Show("Please enter the model.");
                txtVariation.Focus();
            }
            else
            {
                try
                {
                    if (txtCode.Text == "")
                    {
                        //insert
                        //check duplicate
                        if (bllReportUtility.ReportData("[dbo].[USP_IsDuplicateProductSize] 0,'" + _SelctedProductID + "','" + txtVariation.Text.ToUpper().Trim() + "','Insert'").Rows.Count > 0)
                        {
                            MessageBox.Show("Duplicate Model Name.");
                            txtVariation.Focus();
                        }
                        else
                        {
                            sql = "[USP_ProductSize_InsertUpdate] 0,'" + _SelctedProductID + "','" + txtVariation.Text.ToUpper().Trim() + "'";
                            dt = bllReportUtility.ReportData(sql);
                            txtCode.Text = dt.Rows[0]["ProductSizeID"].ToString();
                            MessageBox.Show("You have successfully Inserted the record.");
                            btnReset2.Focus();
                        }
                    }
                    else
                    {
                        //update
                        //check duplicate
                        if (bllReportUtility.ReportData("[dbo].[USP_IsDuplicateProductSize] " + txtCode.Text.Trim() + ",'" + _SelctedProductID + "','" + txtVariation.Text.ToUpper().Trim() + "','Update'").Rows.Count > 0)
                        {
                            MessageBox.Show("Duplicate Model Name.");
                            txtVariation.Focus();
                        }
                        else
                        {
                            sql = "[USP_ProductSize_InsertUpdate] " + txtCode.Text.Trim() + ",'" + _SelctedProductID + "','" + txtVariation.Text.ToUpper().Trim() + "'";
                            dt = bllReportUtility.ReportData(sql);
                            txtCode.Text = dt.Rows[0]["ProductSizeID"].ToString();
                            MessageBox.Show("You have successfully Updated the record.");
                        }
                    }
                    LoadSizeGrid(_SelctedProductID);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void dgvSize_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (Convert.ToInt32(e.RowIndex) == -1) { }
            else
            {
                DataGridViewRow dr = ((DataGridView)sender).Rows[e.RowIndex];
                try
                {
                    string _ID = Convert.ToString(dr.Cells[0].Value);
                    LoadProductSizeInfoByID(_ID);                   
                    txtVariation.Focus();
                    txtVariation.SelectAll();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void txtVariation_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                btnSave2.Focus();
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            dtProductInfo.DefaultView.RowFilter = "PID like'%" + txtSearch.Text + "%' OR ProductName like'%" + txtSearch.Text + "%'";
            dgvProductInfo.DataSource = dtProductInfo;
        }

        private void txtVariation_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSave2_Click(sender, e);
            }
        }

    }
}
