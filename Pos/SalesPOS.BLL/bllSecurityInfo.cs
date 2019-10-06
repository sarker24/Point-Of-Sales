using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using AssetInventory.BOL;
using AssetInventory.DataAccessLayer;


namespace AssetInventory.BLL
{
    public static class bllSecurityInfo
    {
        public static bool Authontication(string iUserName, string iPassword)
        {
            bool IsAuthentic = false;
            DataTable dt = new DataTable();
            ISalesPOSDBManager dbManager = new SalesPOSDBManager();
            UserInfo iUserInfo = new UserInfo();

            try
            {
                dbManager.Open();
                IDbDataParameter[] param = SalesPOSDBManagerFactory.GetParameters(dbManager.ProviderType, 2);

                param[0] = dbManager.getparam("@user_id", iUserName);
                param[1] = dbManager.getparam("@user_password", iPassword);

                IDbCommand cmd = dbManager.getCommand(CommandType.StoredProcedure, "usp_authontication_check", param);

                dt = dbManager.GetDataTable(cmd);
                if (dt.Rows.Count > 0)
                {
                    bllUtility.LoggedInSystemInformation.LoggedUserId = Convert.ToInt64(dt.Rows[0]["UserInfoId"].ToString());
                    bllUtility.LoggedInSystemInformation.UserName = dt.Rows[0]["UserName"].ToString();                    
                    IsAuthentic = true;                    
                }
                else
                {
                    IsAuthentic = false;
                }

            }
            catch (Exception ex)
            {
                throw (ex);
            }
            finally
            {
                dt.Dispose();
                dbManager.Dispose();
            }
            return IsAuthentic;
        }

        public static bool MenuAuthontication(long iUserInfoId, int iMenuId)
        {
            bool IsAuthentic = false;
            DataTable dt = new DataTable();
            ISalesPOSDBManager  dbManager = new SalesPOSDBManager();
            try
            {
                dbManager.Open();
                IDbDataParameter[] param = SalesPOSDBManagerFactory.GetParameters(dbManager.ProviderType, 2);

                param[0] = dbManager.getparam("@UserInfoId", iUserInfoId);
                param[1] = dbManager.getparam("@MenuId", iMenuId);

                IDbCommand cmd = dbManager.getCommand(CommandType.StoredProcedure, "USP_UserMenuAuthonticationCheck", param);
                dt = dbManager.GetDataTable(cmd);
                if (dt.Rows.Count > 0)
                {
                    IsAuthentic = true;
                }
                else
                {
                    IsAuthentic = false;
                }

            }
            catch (Exception ex)
            {
                throw (ex);
            }
            finally
            {
                dt.Dispose();
                dbManager.Dispose();
            }
            return IsAuthentic;
        }

        public static bool TerminalAuthontication(string iHddMacNo)
        {
            bool IsAuthentic = false;
            DataTable dt = new DataTable();
            ISalesPOSDBManager dbManager = new SalesPOSDBManager();
            try
            {
                dbManager.Open();
                IDbDataParameter[] param = SalesPOSDBManagerFactory.GetParameters(dbManager.ProviderType, 1);

                param[0] = dbManager.getparam("@ValueOfAttribute", iHddMacNo);
                IDbCommand cmd = dbManager.getCommand(CommandType.StoredProcedure, "usp_terminal_authontication_check", param);
                dt = dbManager.GetDataTable(cmd);
                if (dt.Rows.Count > 0)
                {
                    IsAuthentic = true;
                    bllUtility.LoggedInSystemInformation.TerminalID = dt.Rows[0]["TerminalID"].ToString();                    
                }
                else
                {
                    IsAuthentic = false;
                }
            }
            catch (Exception ex)
            {
                throw (ex);
            }
            finally
            {
                dt.Dispose();
                dbManager.Dispose();
            }
            return IsAuthentic;
        }

        public static bool IsLicenseActive()
        {
            bool IsAuthentic = false;
            DataTable dt = new DataTable();
            ISalesPOSDBManager dbManager = new SalesPOSDBManager();
            try
            {
                dbManager.Open();
                IDbDataParameter[] param = null;

                IDbCommand cmd = dbManager.getCommand(CommandType.StoredProcedure, "usp_check_license", param);
                dt = dbManager.GetDataTable(cmd);
                if (dt.Rows.Count > 0)
                {
                    IsAuthentic = true;
                    bllUtility.LoggedInSystemInformation.SoftwareName = dt.Rows[0]["SoftwareName"].ToString();
                    bllUtility.LoggedInSystemInformation.LicenseTo = dt.Rows[0]["LicenseTo"].ToString();
                    bllUtility.LoggedInSystemInformation.Version = dt.Rows[0]["Version"].ToString();
                    bllUtility.LoggedInSystemInformation.ActivationDate = dt.Rows[0]["ActivationDate"].ToString();
                    bllUtility.LoggedInSystemInformation.ExpireDate = Convert.ToDateTime(dt.Rows[0]["ExpireDate"].ToString());
                }
                else
                {
                    IsAuthentic = false;
                }

            }
            catch (Exception ex)
            {
                throw (ex);
            }
            finally
            {
                dt.Dispose();
                dbManager.Dispose();
            }
            return IsAuthentic;
        }

        public static bool InsertUpdateDefaultSetting(string iID, string iDefaultSaleType, string iSalesPriceIsEditable, string iDiscountAllow, string iMiniAccAllow, string iCreditSaleAllow, string iSalesInvoicePrintType)
        {
            bool IsSave = false;
            DataTable dt = new DataTable();
            ISalesPOSDBManager dbManager = new SalesPOSDBManager();

            try
            {
                dbManager.Open();
                IDbDataParameter[] param = SalesPOSDBManagerFactory.GetParameters(dbManager.ProviderType, 7);

                param[0] = dbManager.getparam("@ID", iID);
                param[1] = dbManager.getparam("@DefaultSaleType", iDefaultSaleType);
                param[2] = dbManager.getparam("@SalesPriceIsEditable", iSalesPriceIsEditable);
                param[3] = dbManager.getparam("@DiscountAllow", iDiscountAllow);
                param[4] = dbManager.getparam("@MiniAccAllow", iMiniAccAllow);
                param[5] = dbManager.getparam("@CreditSaleAllow", iCreditSaleAllow);
                param[6] = dbManager.getparam("@SalesInvoicePrintType", iSalesInvoicePrintType);

                IDbCommand cmd = dbManager.getCommand(CommandType.StoredProcedure, "dbo.USP_SofDefaultSettingsInsertUpdate", param);

                IsSave = dbManager.ExecuteQuery(cmd);

            }
            catch (Exception ex)
            {
                throw (ex);
            }
            finally
            {
                dt.Dispose();
                dbManager.Dispose();
            }
            return IsSave;
        }

        public static DataTable getUAgentAccessInformation(long UserInfoID)
        {
            ISalesPOSDBManager dbManager = new SalesPOSDBManager();
            DataTable dt = new DataTable();
            try
            {
                dbManager.Open();
                IDbDataParameter[] param = SalesPOSDBManagerFactory.GetParameters(dbManager.ProviderType, 1);

                param[0] = dbManager.getparam("@UserID", UserInfoID);

                IDbCommand cmd = dbManager.getCommand(CommandType.StoredProcedure, "[usp_agent_service_type_permitted_list]", param);
                dt = dbManager.GetDataTable(cmd);


            }
            catch (Exception ex)
            {
                throw (ex);
            }
            finally
            {
                dt.Dispose();
                dbManager.Dispose();
            }
            return dt;
        }

        public static bool InitialSetup(string _ComAddress, DateTime _ActivationDate, DateTime _ExpireDate, string _CompanyName, string _SoftPassword, string _HDDNo)
        {
            bool chk = false;
            DataTable dt = new DataTable();
            ISalesPOSDBManager dbManager = new SalesPOSDBManager();
            try
            {
                dbManager.Open();
                IDbDataParameter[] param = SalesPOSDBManagerFactory.GetParameters(dbManager.ProviderType, 6);

                param[0] = dbManager.getparam("@ComAddress", _ComAddress);
                param[1] = dbManager.getparam("@ActivationDate", _ActivationDate);
                param[2] = dbManager.getparam("@ExpireDate", _ExpireDate);
                param[3] = dbManager.getparam("@CompanyName", _CompanyName);
                param[4] = dbManager.getparam("@SoftPassword", bllUtility.EncryptPassword(_SoftPassword));
                param[5] = dbManager.getparam("@HDDNo", _HDDNo);
                IDbCommand cmd = dbManager.getCommand(CommandType.StoredProcedure, "[usp_initial_setup]", param);
                chk = dbManager.ExecuteQuery(cmd);
            }
            catch (Exception ex)
            {
                throw (ex);
            }
            finally
            {
                dt.Dispose();
                dbManager.Dispose();
                chk = true;
            }
            return chk;
        }


        public static bool SoftDefaultSetting()
        {
            bool IsValid = false;
            DataTable dt = new DataTable();
            ISalesPOSDBManager dbManager = new SalesPOSDBManager();
            try
            {
                dbManager.Open();
                IDbDataParameter[] param = null;

                IDbCommand cmd = dbManager.getCommand(CommandType.StoredProcedure, "[dbo].[USP_SofDefaultSettings]", param);
                dt = dbManager.GetDataTable(cmd);
                if (dt.Rows.Count > 0)
                {
                    IsValid = true;
                    bllUtility.DefaultSettings.ID = dt.Rows[0]["ID"].ToString();
                    bllUtility.DefaultSettings.DefaultSaleType = dt.Rows[0]["DefaultSaleType"].ToString();
                    bllUtility.DefaultSettings.IsEditableSalePrice = dt.Rows[0]["SalesPriceIsEditable"].ToString();
                    bllUtility.DefaultSettings.DiscountAllow = dt.Rows[0]["DiscountAllow"].ToString();
                    bllUtility.DefaultSettings.MiniAccAllow = dt.Rows[0]["MiniAccAllow"].ToString();
                    bllUtility.DefaultSettings.CreditSaleAllow = dt.Rows[0]["CreditSalesAllow"].ToString();
                    bllUtility.DefaultSettings.SalePrintType = dt.Rows[0]["SalesInvoicePrintType"].ToString();
                }
                else
                {
                    IsValid = false;
                }

            }
            catch (Exception ex)
            {
                throw (ex);
            }
            finally
            {
                dt.Dispose();
                dbManager.Dispose();
            }
            return IsValid;
        }


    }
}
