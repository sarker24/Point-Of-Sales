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
using System.Net;

namespace AssetInventory
{
    public partial class frmTerminalRegistration : frmTemplate
    {
        public frmTerminalRegistration()
        {
            InitializeComponent();
        }

        #region methods

        private void Save()
        {
            bool chk = true;
            chk = bllTerminalInfo.TerminalRegistration(txtHostIP.Text.Trim(), txtHardwareValue.Text.Trim(), txtHostName.Text.Trim(), txtComments.Text.Trim());
            if (chk)
            {
                bllUtility.MyMessage("Terminal request sent successfully.");
            }
        }

        #endregion

        #region events

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = bllReportUtility.ReportData("Select * from tbl_TerminalRegistrationInfo where Status='Post' And RegValue='" + txtHardwareValue.Text.Trim() + "'");
            if (dt.Rows.Count > 0)
            {
                bllUtility.MyMessage("A request already sent from this PC. \r\nPlese wait for approval");
            }
            else
            {
                Save();
            }
        }

        private void frmTerminalRegistration_Load(object sender, EventArgs e)
        {
            txtHardwareValue.Text = bllUtility.GetHDDSerialNumber("C");
            IPAddress[] localIPs = Dns.GetHostAddresses(Dns.GetHostName());
            txtHostIP.Text = localIPs[0].ToString();
            txtHostName.Text = Dns.GetHostName();
        }

        #endregion


    }
}
