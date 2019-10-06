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
using System.Globalization;

namespace AssetInventory
{
    public partial class frmMain : Form
    {
        DataTable MenuList = new DataTable();
        long UserID;

        public frmMain(DataTable DTab, long _UserID)
        {
            MenuList = DTab;
            UserID = _UserID;
            InitializeComponent();
            
        }

        #region private methods

        public void form_load(string form_name)
        {
            Type type = this.GetType();
            string str = type.Namespace + "." + form_name;
            Type tpfrm = Type.GetType(str);
            if (tpfrm != null)
            {
                Form obj = (Form)Activator.CreateInstance(tpfrm);
                obj.ShowDialog();
            }
        }        

        public void LoadSubMenuList(DataTable DTabList)
        {
            #region Add Menu
            foreach (DataRow dr in DTabList.Rows)
            {

                ToolStripMenuItem tpMenu = new ToolStripMenuItem();
                tpMenu.Text = dr[2].ToString().Trim();
                tpMenu.Name = dr[1].ToString().Trim();
                //tpMenu.Image = Image.FromFile(".\\icon\\1.gif");
                long MenuCode = Convert.ToInt64(dr[0].ToString().Trim());
                DataTable DTab_SubMenu = (DataTable)bllScreenInfo.getUserSubMenuList(MenuCode, UserID);
                #region Add SubMenu
                foreach (DataRow drSub in DTab_SubMenu.Rows)
                {
                    //Sub Menu Load
                    ToolStripMenuItem tpSubMenu = new ToolStripMenuItem();
                    tpSubMenu.Text = drSub[1].ToString().Trim();
                    tpSubMenu.Name = drSub[2].ToString().Trim();
                    //tpSubMenu.Image = global::SalesPOS.Properties.Resources.exit1;
                    tpSubMenu.Image = Image.FromFile(".\\icon\\" + drSub[3].ToString().Trim() + "");
                    tpSubMenu.Click += new System.EventHandler(this.MenuandSubmenu_Click);
                    //mnuSetup.DropDownItems.Add(tpSubMenu1UserID);             
                    tpMenu.DropDownItems.Add(tpSubMenu);

                    //ToolStrip Load
                    ToolStripButton btn = new ToolStripButton();
                    btn.Name = drSub[2].ToString().Trim();
                    btn.Image = Image.FromFile(".\\icon\\" + drSub[3].ToString().Trim() + "");
                    btn.ToolTipText = drSub[1].ToString().Trim();       
                    
                }
                #endregion
                //mnuSetup.DropDownItems.Add(tpSubMenu1UserID);             
                menuStrip.Items.Add(tpMenu);
            }
            #endregion

            #region Add FixedMenu

            ToolStripMenuItem tpMenuExit = new ToolStripMenuItem();
            tpMenuExit.Text = "Exit";
            tpMenuExit.Name = "mnuExit";
            tpMenuExit.Click += new System.EventHandler(this.MenuandSubmenu_Click);
            menuStrip.Items.Add(tpMenuExit);

            #endregion
        }

        #endregion

        #region events

        private void frmMain_Load(object sender, EventArgs e)
        {
            LoadSubMenuList(MenuList);
            this.Text = bllUtility.LoggedInSystemInformation.SoftwareName + " - " + bllUtility.LoggedInSystemInformation.LicenseTo;
            this.BackgroundImage = Image.FromFile(".\\icon\\banner.jpg");
            this.BackgroundImageLayout = ImageLayout.Stretch;
            lblSoftName.Text = bllUtility.LoggedInSystemInformation.SoftwareName;
            lblVersion.Text = "Version : " + bllUtility.LoggedInSystemInformation.Version;

            //status bar data load 
            toolStripStatus_lblUserID.Text = bllUtility.LoggedInSystemInformation.LoggedUserName;
            toolStripStatus_lblTerminalNo.Text = bllUtility.LoggedInSystemInformation.TerminalID;
            toolStripStatus_lblTodaysDate.Text = DateTime.Now.ToString("d", CultureInfo.CreateSpecificCulture("en-NZ"));
        }

        private void MenuandSubmenu_Click(object sender, EventArgs e)
        {
            #region Click Event for Menu & SubMenu

            ToolStripMenuItem SubmenuName = (ToolStripMenuItem)sender;
            string FormName = SubmenuName.Name.ToString().Trim();
            if (FormName == "mnuExit")
            {
                bllReportUtility.Exec_Store_Procedure("exec usp_insert_user_log 'Exit'," + bllUtility.LoggedInSystemInformation.LoggedUserId);
                Application.Exit();
            }
            else
            {
                form_load(FormName);
                bllReportUtility.Exec_Store_Procedure("exec usp_insert_user_log '" + FormName + "'," + bllUtility.LoggedInSystemInformation.LoggedUserId);
            }

            #endregion
        }
        #endregion

    }
}
