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
    public partial class frmGlobalSearch : frmTemplate
    {
        string Sql = "";
        string FormTitle = "";
        DataTable Dt_Main;
        public frmGlobalSearch(string _sql, string _formTitle)
        {
            InitializeComponent();
            Sql = _sql;
            FormTitle = _formTitle;
        }

        private void frmGlobalSearch_Load(object sender, EventArgs e)
        {
            lblTitle.Text = FormTitle; 
            Dt_Main = bllReportUtility.ReportData(Sql);
            dgvSearchGrid.DataSource = Dt_Main;
            bllUtility.ResetGridColor(dgvSearchGrid);
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            Dt_Main.DefaultView.RowFilter = "Code like'%" + txtSearch.Text + "%' OR Description like'%" + txtSearch.Text + "%' ";
            dgvSearchGrid.DataSource = Dt_Main;
        }

        private void dgvSearchGrid_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex > -1 && e.RowIndex > -1)
            {
                loadGlobal_Data(e.RowIndex);
            }
        }

        private void loadGlobal_Data(int _rowIndex)
        {
            bllUtility.GlobalSearchValue.Code = dgvSearchGrid.Rows[_rowIndex].Cells[0].Value.ToString().Trim();
            bllUtility.GlobalSearchValue.Description = dgvSearchGrid.Rows[_rowIndex].Cells[1].Value.ToString().Trim();
            this.Close();
        }

        private void txtSearch_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                if (dgvSearchGrid.Rows.Count > 0)
                {
                    dgvSearchGrid.Focus();
                }
            }
        }

        private void dgvSearchGrid_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (dgvSearchGrid.Rows.Count > 0)
                {
                    loadGlobal_Data(dgvSearchGrid.CurrentRow.Index);
                }
            }
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if ((keyData & Keys.KeyCode) == Keys.Escape)
            {
                this.Close();
                return true;
            }           
            else
                return base.ProcessCmdKey(ref msg, keyData);
        }
    }
}
