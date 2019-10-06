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
    public partial class frmProductInfoBasic : frmTemplate
    {
        ProductInfo objProductInfo = new ProductInfo();

        public frmProductInfoBasic()
        {
            InitializeComponent();
        }

        #region Global Variable

        string SearchParam = "";
        DataTable dt_main;
        #endregion

        #region private event

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            if (btnNew.Text == "&New")
            {
                btnNew.Text = "&Cancel";
                ClearAll();
            }
            else
            {
                btnNew.Text = "&New";
                //load grid
                LoadGrid();
                SetFields(SearchParam);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DataTable dt1 = new DataTable();
            if (txtVat.Text=="" ){txtVat.Text="0";}
            if (btnNew.Text == "&New")
            {
                //........update............
                if (Valid_Update_Data() == true)
                {
                    dt1 = bllProductInfo.IsDuplicateProductName(txtPID.Text, txtPName.Text);
                    if (dt1.Rows.Count > 0)
                    {
                        bllUtility.MyMessage("Duplicate Product Name Found");
                        txtPName.Focus();
                    }
                    else
                    {
                        InitializeValue();
                        if (SaveData())
                        {
                            LoadGrid();
                            SetFields(SearchParam);
                            bllUtility.MyMessage("Record updated successfully.");
                        }
                    }
                }
            }
            else
            {
                //........insert............
                if (Valid_Insert_Data() == true)
                {
                    dt1 = bllProductInfo.IsDuplicateProductName(txtPID.Text, txtPName.Text);
                    if (dt1.Rows.Count > 0)
                    {
                        bllUtility.MyMessage("Duplicate Product Name Found");
                        txtPName.Focus();
                    }
                    else
                    {
                        InitializeValue();
                        if (SaveData())
                        {
                            LoadGrid();
                            SetFields(SearchParam);
                            btnNew.Text = "&New";
                            bllUtility.MyMessage("Record inserted successfully.");
                        }
                    }
                }
            }
           
        }

        private void frmProductInfoBasic_Load(object sender, EventArgs e)
        {
            this.ActiveControl = txtPName;
            LoadAcitivityCombo();
            LoadUnit();
            LoadWarrenty();
            LoadGrid();
            bllUtility.ResetGridColor(dgvItem);
            txtPName.Focus();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            dt_main.DefaultView.RowFilter = "PID like'%" + txtSearch.Text + "%' OR ProductName like'%" + txtSearch.Text + "%'";
            dgvItem.DataSource = dt_main;
        }

        private void dgvItem_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex > -1 && e.RowIndex > -1)
            {
                SearchParam = dgvItem.Rows[e.RowIndex].Cells[0].Value.ToString().Trim();
                SetFields(SearchParam);
                if (btnNew.Text == "&Cancel")
                {
                    btnNew.Text = "&New";
                }
            }
        }

        #endregion

        #region private method
        
        private void InitializeValue()
        {
            objProductInfo.PID = this.txtPID.Text.Trim();
            objProductInfo.ProductName = this.txtPName.Text.ToUpper().Trim();
            objProductInfo.SubSectionID = 0;
            objProductInfo.UnitID = Convert.ToInt32(this.cmb_unit.SelectedValue);
            objProductInfo.Warrenty = this.cmbWarrenty.SelectedValue.ToString().Trim();
            objProductInfo.ActivityID = Convert.ToInt32(this.cmb_activity.SelectedValue);
            objProductInfo.CreatedBy = bllUtility.LoggedInSystemInformation.LoggedUserId;
            objProductInfo.Vat = this.txtVat.Text.Trim();
        }

        private bool SaveData()
        {
            bool isSaved = true;
            DataTable dt = bllProductInfo.InsertUpdate(objProductInfo);
            if (dt.Rows.Count > 0)
            {
                isSaved = true;
                SearchParam = dt.Rows[0][0].ToString();
            }
            else
            {
                isSaved = false;
            }

            return isSaved;
        }

        private bool Valid_Insert_Data()
        {
            bool isValid = true;

            //check empty field

            if (txtPName.Text.Trim() == "")
            {
                isValid = false;
                bllUtility.MyMessage("Please input the product name.");
                txtPName.Focus();
            }
            else if (cmb_unit.SelectedValue.ToString() == "0")
            {
                MessageBox.Show("Please select Unit.");
                cmb_unit.Focus();
                isValid = false;
            }
            else if (cmbWarrenty.SelectedValue.ToString() == "0")
            {
                MessageBox.Show("Please select Warrenty Time.");
                cmbWarrenty.Focus();
                isValid = false;
            }
            else if (cmb_activity.SelectedValue.ToString() == "0")
            {
                MessageBox.Show("Please select activity.");
                cmb_activity.Focus();
                isValid = false;
            }
            else
            {
                isValid = true;
            }
            //check duplicate fields

            return isValid;
        }

        private bool Valid_Update_Data()
        {
            bool isValid = true;

            //check the record is selected or not for update
            if (txtPID.Text.Trim() == "")
            {
                isValid = false;
                bllUtility.MyMessage("Please select data from the list for update.");
            }
            //check empty field
            else if (txtPName.Text.Trim() == "")
            {
                isValid = false;
                bllUtility.MyMessage("Please input the product name.");
                txtPName.Focus();
            }
            else if (cmb_unit.SelectedValue.ToString() == "0")
            {
                MessageBox.Show("Please select Unit.");
                cmb_unit.Focus();
                isValid = false;
            }
            else if (cmbWarrenty.SelectedValue.ToString() == "0")
            {
                MessageBox.Show("Please select Warrenty Time.");
                cmbWarrenty.Focus();
                isValid = false;
            }
            else if (cmb_activity.SelectedValue.ToString() == "0")
            {
                MessageBox.Show("Please select activity.");
                cmb_activity.Focus();
                isValid = false;
            }
            else
            {
                isValid = true;
            }
            //check duplicate fields

            return isValid;
        }

        private void LoadGrid()
        {
            dt_main = new DataTable();
            dt_main = bllProductInfo.getAll1();
            dgvItem.AutoGenerateColumns = false;
            dgvItem.DataSource = dt_main;
        }

        private void LoadAcitivityCombo()
        {
            DataTable dt = new DataTable();
            dt = bllActivityInfo.getAll();
            this.cmb_activity.DisplayMember = "Activity";
            this.cmb_activity.ValueMember = "ActivityID";
            cmb_activity.DataSource = dt;
        }

        private void LoadUnit()
        {
            try
            {
                DataTable dt = new DataTable();
                dt = bllUnitInfo.getAll();
                DataRow dr = dt.NewRow();
                dr["UnitId"] = "0";
                dr["UnitName"] = "Select";
                dt.Rows.InsertAt(dr, 0);
                cmb_unit.DisplayMember = "UnitName";
                cmb_unit.ValueMember = "UnitId";
                cmb_unit.DataSource = dt;
            }
            catch (Exception e)
            { }
        }

        private void LoadWarrenty()
        {
            try
            {
                DataTable dt = new DataTable();
                dt = bllReportUtility.ReportData("Select * from Warrenty_Type_t where isActive=1");
                DataRow dr = dt.NewRow();
                dr["WarrentyID"] = "0";
                dr["WarrentyName"] = "Select";
                dt.Rows.InsertAt(dr, 0);
                cmbWarrenty.DisplayMember = "WarrentyName";
                cmbWarrenty.ValueMember = "WarrentyID";
                cmbWarrenty.DataSource = dt;

            }
            catch
            { }
        }

        private void SetFields(string _SearchBy)
        {
            DataTable dt = new DataTable();
            dt = bllProductInfo.getById(_SearchBy);
            if (dt.Rows.Count > 0)
            {
                this.txtPID.Text = dt.Rows[0]["PID"].ToString();
                this.txtPName.Text = dt.Rows[0]["ProductName"].ToString();                
                this.cmb_unit.SelectedValue = Convert.ToInt64(dt.Rows[0]["UnitId"]);
                this.cmbWarrenty.SelectedValue = Convert.ToInt64(dt.Rows[0]["WarrentyID"]);
                this.cmb_activity.SelectedValue = Convert.ToInt64(dt.Rows[0]["ActivityID"]);
                this.txtVat.Text = dt.Rows[0]["Vat"].ToString();  
                txtPName.Focus();
                txtPName.SelectAll();
            }
        }

        public void ClearAll()
        {
            LoadAcitivityCombo();
            LoadUnit();
            LoadWarrenty();

            this.txtPID.Text = string.Empty;
            this.txtPName.Text = string.Empty;
            this.cmb_unit.SelectedIndex = 0;
            this.cmb_activity.SelectedIndex = 0;
            this.cmbWarrenty.SelectedIndex = 0;
            cmbWarrenty.SelectedIndex = 1;
            this.txtVat.Text = "0";
            txtPName.Focus();
        }

        #endregion       

        private void txtPName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                cmb_unit.Focus();
            }
        }

        private void cmb_unit_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                cmb_activity.Focus();
            }
        }

        private void cmb_activity_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                cmbWarrenty.Focus();
            }
        }

        private void cmbWarrenty_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtVat.Focus();
                txtVat.SelectAll();
            }
        }

        private void txtVat_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSave_Click(sender, e);
            }
        }

        
    }
}
