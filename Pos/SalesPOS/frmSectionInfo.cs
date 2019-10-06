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
    public partial class frmSectionInfo : Form
    {
        private long _SelctedSectionInfoId = 0;
        //private Int32 _GridRowSelectedIndex = 0;
        private bool _isNew = true;
        
        public frmSectionInfo()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmSectionInfo_Load(object sender, EventArgs e)
        {
            this.ActiveControl = this.txtSectionName;
            bllUtility.LoadAcitivityCombo(this.cmbActivity);
            LoadGrid();
            if (this.dgvSectionList.Rows.Count > 0)
                this.dgvSectionList.Rows[0].Selected = false;
            this.dgvSectionList.DefaultCellStyle.ForeColor = Color.Black;
        }

        private void LoadGrid()
        {
            DataTable dt = new DataTable();
            dt = bllSectionInfo.getAll();
            this.dgvSectionList.AutoGenerateColumns = false;
            this.dgvSectionList.DataSource = dt;            
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ClearFields();
            this._isNew = true;
            this.txtSectionName.Focus();
        }

        private void ClearFields()
        {
            try
            {
                this.txtSectionName.Text = string.Empty;
                this.txtVat.Text = string.Empty;
                this.cmbActivity.SelectedIndex = 0;
                this.err_SectionInfo.Clear();
                if (this.dgvSectionList.Rows.Count > 0)
                    this.dgvSectionList.Rows[0].Selected = false;
                this.txtSectionName.Focus();
            }
            catch
            { }
        }

        private bool isValid()
        {
            bool chk = true;
            if (string.IsNullOrEmpty(this.txtSectionName.Text))
            {
                this.err_SectionInfo.SetError(txtSectionName, "Section name is mandatory");
                chk = false;
            }
            return chk;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (isValid())
            {
                if (this.txtVat.Text == "") { this.txtVat.Text = "0"; }
                if (!this._isNew) 
                {
                    if (_SelctedSectionInfoId > 0)
                    {
                        //update here
                        bool chk = true;

                        SectionInfo objSectionInfo = new SectionInfo();
                        objSectionInfo.SectionID = this._SelctedSectionInfoId;
                        objSectionInfo.SectionName = this.txtSectionName.Text.Trim();
                        objSectionInfo.Vat = this.txtVat.Text.Trim();
                        objSectionInfo.ActivityID = Convert.ToInt64(this.cmbActivity.SelectedValue);

                        objSectionInfo.UpdatedBy = 1;
                        objSectionInfo.UpdatedDate = DateTime.Now;

                        DataTable dt1 = bllSectionInfo.IsDuplicateCategoryName(this._SelctedSectionInfoId, this.txtSectionName.Text.ToString(), "Update");
                        if (dt1.Rows.Count > 0)
                        {
                            MessageBox.Show("Duplicate Product Category Found. Please change the Product Category.");
                            this.txtSectionName.Focus();
                            this.txtSectionName.SelectAll();                           
                        }
                        else
                        {
                            chk = bllSectionInfo.Update(objSectionInfo);
                            if (chk)
                            {
                                LoadGrid();
                                //show success message here
                                MessageBox.Show("Successfully updated the record");
                                ClearFields();
                                this._isNew = true;
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("No data found for update.");
                    }
                }
                else
                {
                    bool chk = true;                   

                    //insert here
                    SectionInfo objSectionInfo = new SectionInfo();
                    objSectionInfo.SectionName = this.txtSectionName.Text.Trim();
                    objSectionInfo.Vat = this.txtVat.Text.Trim();
                    objSectionInfo.ActivityID = Convert.ToInt64(this.cmbActivity.SelectedValue);

                    objSectionInfo.CreatedBy = 1;
                    objSectionInfo.CreatedDate = DateTime.Now;

                    DataTable dt1 = bllSectionInfo.IsDuplicateCategoryName(0, this.txtSectionName.Text.ToString(), "Update");
                    if (dt1.Rows.Count > 0)
                    {
                        MessageBox.Show("Duplicate Product Category Found. Please change the Product Category.");
                        this.txtSectionName.Focus();
                        txtSectionName.SelectAll();                        
                    }
                    else
                    {
                        chk = bllSectionInfo.Insert(objSectionInfo);
                        if (chk)
                        {
                            LoadGrid();                            
                            ClearFields();
                            this._isNew = true;
                        }
                    }
                }
                //if (this.dgvSectionList.Rows.Count > 0)
                //    this.dgvSectionList.Rows[0].Selected = false;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            this._isNew = true;
            bool chk = true;
            long SectionInfoId = 0;
            
            if (this.dgvSectionList.SelectedRows.Count > 0)
            {
                SectionInfoId = Convert.ToInt64(this.dgvSectionList.SelectedRows[0].Cells[0].Value);
                if (MessageBox.Show("Do you really want to delete the data ?", "Confirm Delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    chk = bllSectionInfo.Delete(SectionInfoId);
                    if (chk)
                    {
                        LoadGrid();
                        ClearFields();
                        if (this.dgvSectionList.Rows.Count > 0)
                            this.dgvSectionList.Rows[0].Selected = false;                
                    }
                }                
            }
            else
            {
                MessageBox.Show("Select a row first.");
            }
        }

        private void dgvSectionList_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (Convert.ToInt32(e.RowIndex) == -1)
            {

            }
            else
            {
                DataGridViewRow dr = ((DataGridView)sender).Rows[e.RowIndex];

                this._isNew = false;
                try
                {
                    //bool chk = true;
                    long SectionInfoId = 0;
                    SectionInfoId = Convert.ToInt64(dr.Cells[0].Value);

                    //Load the selected row data fro edit mode

                    this._SelctedSectionInfoId = SectionInfoId;
                    LoadSectionInfoByID(_SelctedSectionInfoId);
                }
                catch { }
            }
        }

        private void LoadSectionInfoByID(long selectedID)
        {
            DataTable dt = new DataTable();
            dt = bllSectionInfo.getById(selectedID);
            this.txtSectionName.Text = dt.Rows[0]["SectionName"].ToString();
            this.txtVat.Text = dt.Rows[0]["Vat"].ToString();
            this.cmbActivity.SelectedValue = Convert.ToInt64(dt.Rows[0]["ActivityID"].ToString());

        }

        private void txtVat_KeyPress(object sender, KeyPressEventArgs e)
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
}
