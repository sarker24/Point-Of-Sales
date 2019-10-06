using System;
using System.Collections;
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
using System.IO;


namespace AssetInventory
{
    public partial class frmReportCurrentStock : Form
    {
        bool IsPrint = false;
      //  bllReportUtility iReportUtility = new bllReportUtility();
        DataTable gridData;
        private export2Excel export2XLS;
       // private DataSet _dataSet;

        public frmReportCurrentStock()
        {
            InitializeComponent();
        }

        private void frmReportCurrentStock_Load(object sender, EventArgs e)
        {
            LoadProduct();
            bllUtility.ResetGridColor(dgvStockGrid);
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
                this.cmbProduct.SelectedIndex = 0;
            }
            catch
            { }
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            string strPID = this.cmbProduct.SelectedValue.ToString();
            string strReportType = "Summary";
            if (optDetails.Checked == true)
            {
                strReportType = "Details";
            }
            gridData = bllProductInfo.getStockData(strPID, strReportType);            
            dgvStockGrid.DataSource = gridData;            
        }
  
        private void StartExport(String filepath)
        {
            btn2Excel.Enabled = false;
            //btnUseTemplate.Enabled = false;
            //create a new background worker, to do the exporting
            BackgroundWorker bg = new BackgroundWorker();
            bg.DoWork += new DoWorkEventHandler(bg_DoWork);
            bg.RunWorkerCompleted += new RunWorkerCompletedEventHandler(bg_RunWorkerCompleted);
            bg.RunWorkerAsync(filepath);

            //create a new export2XLS object, providing DataView as a input parameter
            export2XLS = new export2Excel();
            export2XLS.prg += new export2Excel.ProgressHandler(export2XLS_prg);
        }

        private void bg_DoWork(object sender, DoWorkEventArgs e)
        {
            //get the Gridviews DataView
            DataView dv = gridData.DefaultView;
            //Pass the path and the sheet to use
            export2XLS.ExportToExcel(dv, (String)e.Argument, "newSheet1");
        }

        private void bg_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            btn2Excel.Enabled = true;
            //btnUseTemplate.Enabled = true;
            MessageBox.Show("Finished");
        }

        private void btn2Excel_Click(object sender, EventArgs e)
        {
            //show a file save dialog and ensure the user selects
            //correct file to allow the export
            saveFileDialog1.Filter = "Excel (*.xls)|*.xls";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if (!saveFileDialog1.FileName.Equals(String.Empty))
                {
                    FileInfo f = new FileInfo(saveFileDialog1.FileName);
                    if (f.Extension.Equals(".xls"))
                    {
                        StartExport(saveFileDialog1.FileName);
                    }
                    else
                    {
                        MessageBox.Show("Invalid file type");
                    }
                }
                else
                {
                    MessageBox.Show("You did pick a location to save file to");
                }
            }
        }
        private void export2XLS_prg(object sender, ProgressEventArgs e)
        {
           
        }
        


    }
}
