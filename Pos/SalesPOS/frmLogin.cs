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
using System.Data.OleDb;
using System.Security.Cryptography;
using System.Data.SqlClient;
using System.IO;


namespace AssetInventory
{
    public partial class frmLogin : Form
    {

        public frmLogin()
        {
            InitializeComponent();
        }

        #region private methods

        private void StoreLoggedInSystemInformation()
        {
            bllUtility.LoggedInSystemInformation.LoggedUserName = this.txtUserName.Text.Trim();
        }

        private void ReadTextFile()
        {
            int counter = 0;
            string line;
            string remember_me = "";

            // Read the file and display it line by line.
            System.IO.StreamReader file = new System.IO.StreamReader(@".\login.dll");
            while ((line = file.ReadLine()) != null)
            {
                string[] abc;
                abc = line.Split(':');
                switch (counter)
                {
                    case 0:// ip address
                        txtIP.Text = DecryptString(abc[1], "X");
                        break;
                    case 1:// db user
                        txtDBUser.Text = DecryptString(abc[1], "X");
                        break;
                    case 2:// db password
                        txtDBPass.Text = DecryptString(abc[1], "X");
                        break;
                    case 3:// db name
                        cmbDBName.Text = DecryptString(abc[1], "X");
                        break;                    
                    case 4:// dll terminal
                        txtDll_HDDNo.Text = DecryptString(abc[1], "X");
                        break;
                    case 5:// remember me                        
                        if ((DecryptString(abc[1], "X") == "True") && (txtDll_HDDNo.Text.Trim() == bllUtility.GetHDDSerialNumber("C")))
                        {
                            chkRemember.Checked = true;
                            remember_me = "True";
                        }
                        else
                        {
                            chkRemember.Checked = false;
                            remember_me = "False";
                        }
                        break;
                    case 6:// login user id
                        if ((remember_me == "True") && (txtDll_HDDNo.Text.Trim() == bllUtility.GetHDDSerialNumber("C")))
                        {
                            txtUserName.Text = DecryptString(abc[1], "X");
                        }
                        else
                        {
                            txtUserName.Text = "";
                        }
                        break;
                    case 7:// login user pass
                        if ((remember_me == "True") && (txtDll_HDDNo.Text.Trim() == bllUtility.GetHDDSerialNumber("C")))
                        {
                            txtPassword.Text = DecryptString(abc[1], "X");
                        }
                        else
                        {
                            txtPassword.Text = "";
                        }
                        break;
                }
                counter++;
            }
            file.Close();
        }

        private void WriteTextFile()
        {
            string a = "";
            a = "IP:" + EncryptString(txtIP.Text, "X");
            a = a + "\r\n" + "DBUser:" + EncryptString(txtDBUser.Text, "X");
            a = a + "\r\n" + "DBPass:" + EncryptString(txtDBPass.Text, "X");
            a = a + "\r\n" + "DBName:" + EncryptString(cmbDBName.Text, "X");
            a = a + "\r\n" + "Terminal:" + EncryptString(bllUtility.GetHDDSerialNumber("C"), "X");
            a = a + "\r\n" + "Remember me:" + EncryptString(chkRemember.Checked.ToString(), "X");
            a = a + "\r\n" + "UserName:" + EncryptString(txtUserName.Text, "X");
            a = a + "\r\n" + "UserPass:" + EncryptString(txtPassword.Text, "X");
            System.IO.File.WriteAllText(@".\login.dll", a);
        }

        public static string EncryptString(string Message, string Passphrase)
        {
            byte[] Results;
            System.Text.UTF8Encoding UTF8 = new System.Text.UTF8Encoding();

            // Step 1. We hash the passphrase using MD5
            // We use the MD5 hash generator as the result is a 128 bit byte array
            // which is a valid length for the TripleDES encoder we use below

            MD5CryptoServiceProvider HashProvider = new MD5CryptoServiceProvider();
            byte[] TDESKey = HashProvider.ComputeHash(UTF8.GetBytes(Passphrase));

            // Step 2. Create a new TripleDESCryptoServiceProvider object
            TripleDESCryptoServiceProvider TDESAlgorithm = new TripleDESCryptoServiceProvider();

            // Step 3. Setup the encoder
            TDESAlgorithm.Key = TDESKey;
            TDESAlgorithm.Mode = CipherMode.ECB;
            TDESAlgorithm.Padding = PaddingMode.PKCS7;

            // Step 4. Convert the input string to a byte[]
            byte[] DataToEncrypt = UTF8.GetBytes(Message);

            // Step 5. Attempt to encrypt the string
            try
            {
                ICryptoTransform Encryptor = TDESAlgorithm.CreateEncryptor();
                Results = Encryptor.TransformFinalBlock(DataToEncrypt, 0, DataToEncrypt.Length);
            }
            finally
            {
                // Clear the TripleDes and Hashprovider services of any sensitive information
                TDESAlgorithm.Clear();
                HashProvider.Clear();
            }

            // Step 6. Return the encrypted string as a base64 encoded string
            return Convert.ToBase64String(Results);
        }

        public static string DecryptString(string Message, string Passphrase)
        {
            byte[] Results;
            System.Text.UTF8Encoding UTF8 = new System.Text.UTF8Encoding();

            // Step 1. We hash the passphrase using MD5
            // We use the MD5 hash generator as the result is a 128 bit byte array
            // which is a valid length for the TripleDES encoder we use below

            MD5CryptoServiceProvider HashProvider = new MD5CryptoServiceProvider();
            byte[] TDESKey = HashProvider.ComputeHash(UTF8.GetBytes(Passphrase));

            // Step 2. Create a new TripleDESCryptoServiceProvider object
            TripleDESCryptoServiceProvider TDESAlgorithm = new TripleDESCryptoServiceProvider();

            // Step 3. Setup the decoder
            TDESAlgorithm.Key = TDESKey;
            TDESAlgorithm.Mode = CipherMode.ECB;
            TDESAlgorithm.Padding = PaddingMode.PKCS7;

            // Step 4. Convert the input string to a byte[]
            byte[] DataToDecrypt = Convert.FromBase64String(Message);

            // Step 5. Attempt to decrypt the string
            try
            {
                ICryptoTransform Decryptor = TDESAlgorithm.CreateDecryptor();
                Results = Decryptor.TransformFinalBlock(DataToDecrypt, 0, DataToDecrypt.Length);
            }
            finally
            {
                // Clear the TripleDes and Hashprovider services of any sensitive information
                TDESAlgorithm.Clear();
                HashProvider.Clear();
            }

            // Step 6. Return the decrypted string in UTF8 format
            return UTF8.GetString(Results);
        }

        private void GetDbList()
        {
            cmbDBName.Items.Clear();
            string connetionString = "Provider=sqloledb;Data Source=" + txtIP.Text + ";Initial Catalog='master';User Id='" + txtDBUser.Text.Trim() + "';  password='" + txtDBPass.Text + "';";
            OleDbConnection conn = new OleDbConnection();
            conn.ConnectionString = connetionString;

            try
            {
                conn.Open();
                OleDbCommand command = new OleDbCommand("SELECT name FROM master..sysdatabases WHERE dbid>6 ORDER BY [name] ASC", conn);
                //SELECT name FROM sys.databases WHERE database_id>6
                //SELECT name FROM sys.sysdatabases WHERE dbid>6
                //SELECT name FROM master..sysdatabases WHERE dbid>6

                OleDbDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    string dbName = reader.GetString(0);
                    cmbDBName.Items.Add(dbName);
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                bllUtility.MyMessage("Can not open connection ! ");
            }
        }

        private bool CheckingSoftLicence()
        {
            bool isValid = false;
            if (bllSecurityInfo.IsLicenseActive())
            {
                string iHddNo = bllUtility.GetHDDSerialNumber("C");
                if (bllSecurityInfo.TerminalAuthontication(iHddNo) == true)
                {
                    isValid = true;
                    txtUserName.Focus();
                    //lblSoftName.Text = bllUtility.LoggedInSystemInformation.SoftwareName.Trim();                    
                }
                else
                {
                    DialogResult result;
                    result = MessageBox.Show("Unauthorized Terminal.\r\nDo you want to register your terminal?", bllUtility.LoggedInSystemInformation.SoftwareName, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        frmTerminalRegistration obj = new frmTerminalRegistration();
                        obj.ShowDialog();
                        this.Dispose(true);
                        this.Close();
                    }
                    else
                    {
                        this.Dispose(true);
                        this.Close();
                    }
                }
            }
            else
            {
                string strMessage = @"Your Software License Has Expired. Please Contact With the Vendor.";
                bllUtility.MyMessage(strMessage);
                this.Dispose(true);
                this.Close();
            }
            return isValid;
        }

        #endregion

        #region private events

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtIP.Text == "")
            {
                bllUtility.MyMessage("Please enter IP address.");
                txtIP.Focus();
            }
            else if (txtDBUser.Text == "")
            {
                bllUtility.MyMessage("Please enter database user.");
                txtDBUser.Focus();
            }
            else if (txtDBPass.Text == "")
            {
                bllUtility.MyMessage("Please enter database user password.");
                txtDBPass.Focus();
            }
            else if (cmbDBName.Text == "")
            {
                bllUtility.MyMessage("Please enter database name.");
                cmbDBName.Focus();
            }           
            else
            {
                //global variable value assign
                UserInfo.DB_Source = txtIP.Text.Trim();
                UserInfo.DB_Name = cmbDBName.Text.Trim();
                UserInfo.DB_User = txtDBUser.Text.Trim();
                UserInfo.DB_Pass = txtDBPass.Text.Trim();

                //checking for initial setup
                DataTable dt1 = new DataTable();
                dt1 = bllReportUtility.ReportData("Select * from SoftwareInfo");
                if (dt1.Rows.Count > 0)
                {
                    //checking software license...
                    if (CheckingSoftLicence() == true)
                    {
                        //login to software
                        if (txtUserName.Text == "")
                        {
                            bllUtility.MyMessage("Please enter user name.");
                            txtUserName.Focus();
                        }
                        else if (txtPassword.Text == "")
                        {
                            bllUtility.MyMessage("Please enter password.");
                            txtPassword.Focus();
                        }
                        else
                        {
                            
                                string _EncryptPass = bllUtility.EncryptPassword(txtPassword.Text.ToString());
                                if (bllSecurityInfo.Authontication(txtUserName.Text.ToString(), bllUtility.EncryptPassword(txtPassword.Text.ToString())) == true)
                                {
                                    WriteTextFile();
                                    //getting data from option table
                                    DataTable dt = bllReportUtility.ReportData("usp_options_value");
                                    bllUtility.LoggedInSystemInformation.CompanyName = dt.Rows[0]["CompanyName"].ToString();
                                    bllUtility.LoggedInSystemInformation.CompanyAddress = dt.Rows[0]["CompanyAddress"].ToString();
                                    bllUtility.LoggedInSystemInformation.CompanyContactNo = dt.Rows[0]["CompanyContact"].ToString();
                                    

                                    bllUtility.LoggedInSystemInformation.LoginPass = bllUtility.EncryptPassword(txtPassword.Text.ToString());
                                    long _LoggedUserId = bllUtility.LoggedInSystemInformation.LoggedUserId;
                                    StoreLoggedInSystemInformation();
                                    DataTable DTab = (DataTable)bllScreenInfo.getUserMenuList(_LoggedUserId);
                                    this.Hide();
                                    bllReportUtility.Exec_Store_Procedure("exec usp_insert_user_log 'Login'," + bllUtility.LoggedInSystemInformation.LoggedUserId);

                                    
                                    frmMain obj = new frmMain(DTab, _LoggedUserId);
                                    obj.WindowState = System.Windows.Forms.FormWindowState.Maximized;
                                    obj.ShowDialog();
                                    
                                   
                                    this.Dispose(true);
                                    this.Close();
                                }
                                else
                                {
                                    bllUtility.MyMessage("You are not authorized person.");
                                    txtUserName.Text = "";
                                    txtPassword.Text = "";
                                    txtUserName.Focus();
                                }
                            
                        }
                    }
                }
                else
                {
                    //initial setup form
                    frmInitialSetup obj = new frmInitialSetup();
                    obj.ShowDialog();
                    this.Dispose(true);
                    this.Close();
                }
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            if (File.Exists(@".\login.dll") == false)
            {
                FileStream fileStream = new FileStream(@".\login.dll", FileMode.CreateNew);
                fileStream.Close();
            }
            this.Height = 225;
            ReadTextFile();
        }

        private void txtUserName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13) { txtPassword.Focus(); }
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13) { btnLogin_Click(true, e); }
        }

        private void btnDBNameGet_Click(object sender, EventArgs e)
        {
            if (txtIP.Text == "")
            {
                bllUtility.MyMessage("Please enter IP address.");
                txtIP.Focus();
            }
            else if (txtDBUser.Text == "")
            {
                bllUtility.MyMessage("Please enter database user.");
                txtDBUser.Focus();
            }
            else if (txtDBPass.Text == "")
            {
                bllUtility.MyMessage("Please enter database user password.");
                txtDBPass.Focus();
            }
            else
            {
                GetDbList();
            }
        }

        private void btnOption_Click(object sender, EventArgs e)
        {
            InputBoxResult test = InputBox.Show("Please Enter Password..", "Easy Queue", "");
            if (test.ReturnCode == DialogResult.OK)
            {
                if (test.Text == "HG54E-87FDW-12DCF-76WQA-67HGF")
                {
                    if (this.Height == 225)
                    {
                        this.Height = 335;
                        pnl2.Visible = true;
                    }
                    else
                    {
                        this.Height = 225;
                        pnl2.Visible = false;
                    }
                }
                else
                {
                    bllUtility.MyMessage("You are not permitted for this option.");
                }
            }
        }

        #endregion

    }
}
