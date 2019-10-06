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
    public partial class frmInitialSetup : Form
    {
        public frmInitialSetup()
        {
            InitializeComponent();
        }

        #region methods
        #endregion

        #region events

        private void frmInitialSetup_Load(object sender, EventArgs e)
        {
            txtHDDValue.Text = bllUtility.GetHDDSerialNumber("C");
            this.ActiveControl = txtCompanyName;
            txtCompanyName.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSetup_Click(object sender, EventArgs e)
        {
            bool chk = true;
            chk = bllSecurityInfo.InitialSetup(txtAddress.Text.Trim(), dtpActivationDate.Value, dtpExpiryDate.Value, txtCompanyName.Text.Trim(), txtPassword.Text.Trim(), txtHDDValue.Text.Trim());
            if (chk == true)
            {
                bllUtility.MyMessage("You have successfully setup the software.\r\nPlease re-login to software.");
                this.Close();
            }
            else
            {
                bllUtility.MyMessage("Setup failed..");
            }
        }

        #endregion

    }
}
