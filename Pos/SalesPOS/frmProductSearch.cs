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

namespace AssetInventory
{
    public partial class frmProductSearch : Form
    {
        AutoCompleteStringCollection namesCollection = new AutoCompleteStringCollection();
        AutoCompleteStringCollection codesCollection = new AutoCompleteStringCollection();
        DataTable dt = new DataTable();
        DataTable gridData;
        int isFixedAsset ;
        public frmProductSearch(int _isFixedAsset)
        {
            InitializeComponent();
            isFixedAsset = _isFixedAsset;
        }
        //private void setAutoCompletelist()
        //{

        //    for (int i = 0; i < dt.Rows.Count; i++)
        //    {
        //        namesCollection.Add(dt.Rows[i][1].ToString());
        //        codesCollection.Add(dt.Rows[i][0].ToString());
        //    }

        //    txtAssetType.AutoCompleteMode = AutoCompleteMode.Suggest;
        //    txtAssetType.AutoCompleteSource = AutoCompleteSource.CustomSource;
        //    txtAssetType.AutoCompleteCustomSource = namesCollection;

        //    txtProductName.AutoCompleteMode = AutoCompleteMode.Suggest;
        //    txtProductName.AutoCompleteSource = AutoCompleteSource.CustomSource;
        //    txtProductName.AutoCompleteCustomSource = codesCollection;


        //}
        //private void FilterSearchGrid()
        //{
        //    try
        //    {
        //        DataTable dtFiltered = dt.Copy();// Clone();
        //        DataView dv = new DataView();
        //        dv = dtFiltered.DefaultView;

        //        string s = " ID is not null";
        //        if (!string.IsNullOrEmpty(this.txtProductName.Text.Trim()))
        //        {
        //            s = s + " AND ProductName Like '" + this.txtProductName.Text.Trim() + "%'";
        //        }
        //        if (!string.IsNullOrEmpty(this.txtAssetType.Text))
        //        {
        //            s = s + " AND SectionName Like '" + this.txtAssetType.Text.Trim() + "%'";
        //        }
        //        if (chkFixedAsset.Checked==true)
        //        {
        //            s = s + " AND FixedAsset = 1";
        //        }
        //        if (chkIssuable.Checked == true)
        //        {
        //            s = s + " AND Issuable = 1";
        //        }
        //        dv.RowFilter = s;
               

        //        this.dgvProductInfoList.DataSource = null;
        //        this.dgvProductInfoList.DataSource = dv;
        //    }
        //    catch { }
        //}
        private void frmProductSearch_Load(object sender, EventArgs e)
        {
            LoadProduct();
            
        }
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
                //this.cmbProduct.SelectedIndex = 0;
            }
            catch
            { }
        }
        //private void txtProductCode_TextChanged(object sender, EventArgs e)
        //{
        //    FilterSearchGrid();
        //}

        //private void txtProductName_TextChanged(object sender, EventArgs e)
        //{
        //    FilterSearchGrid();
        //}

        private void dgvProductInfoList_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (Convert.ToInt32(e.RowIndex) == -1)
            {

            }
            else
            {
                DataGridView dgv = (DataGridView)sender;

                ProductInfo objProductInfo = new ProductInfo();
                //objProductInfo.SerialNo = Convert.ToInt64(dgv.Rows[e.RowIndex].Cells[0].Value.ToString());
                objProductInfo.PID = dgv.Rows[e.RowIndex].Cells[0].Value.ToString();
                //objProductInfo.ProductName = dgv.Rows[e.RowIndex].Cells[1].Value.ToString();
                //objProductInfo.Warrenty = dgv.Rows[e.RowIndex].Cells[2].Value.ToString();
                //objProductInfo.AssetCode = dgv.Rows[e.RowIndex].Cells[3].Value.ToString();
                //objProductInfo.ProductName = dgv.Rows[e.RowIndex].Cells[1].Value.ToString();
                //objProductInfo.UnitName = dgv.Rows[e.RowIndex].Cells[4].Value.ToString();

                bllUtility.ReturnSearchedProduct.returnSearchedProductInfo = objProductInfo;

                this.Close();
            }
            
        }

        private void dgvProductInfoList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmProductSearch_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (bllUtility.ReturnSearchedProduct.returnSearchedProductInfo == null)
            {

                ProductInfo objProductInfo = new ProductInfo();
                //objProductInfo.SerialNo = 0;
                objProductInfo.PID = "";
                //objProductInfo.ProductName = "";

                bllUtility.ReturnSearchedProduct.returnSearchedProductInfo = objProductInfo;
            }
        }

        //private void chkFixedAsset_CheckedChanged(object sender, EventArgs e)
        //{
        //    FilterSearchGrid();
        //}

        //private void chkIssuable_CheckedChanged(object sender, EventArgs e)
        //{
        //    FilterSearchGrid();
        //}

        private void btnSearchProduct_Click(object sender, EventArgs e)
        {
            string strPID = this.cmbProduct.SelectedValue.ToString();
            gridData = bllProductInfo.getStockData(strPID, "");
            dgvProductInfoList.AutoGenerateColumns = false;
            dgvProductInfoList.DataSource = gridData;
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        
    }
}
