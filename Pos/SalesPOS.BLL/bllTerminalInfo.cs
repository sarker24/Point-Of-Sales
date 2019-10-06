using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using AssetInventory.DataAccessLayer;
using AssetInventory.BOL;

namespace AssetInventory.BLL
{
    public static class bllTerminalInfo
    {
        public static DataTable getAll()
        {
            ISalesPOSDBManager dbManager = new SalesPOSDBManager();
            DataTable dt = new DataTable();
            try
            {
                dbManager.Open();
                IDbDataParameter[] param = null;


                IDbCommand cmd = dbManager.getCommand(CommandType.Text, @"SELECT *
from dbo.TerminalInfo ti left outer join dbo.ActivityInfo ai
on ai.ActivityID = ti.ActivityID order by ti.TerminalName", param);
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

        public static DataTable getById(long TerminalInfoId)
        {
            ISalesPOSDBManager dbManager = new SalesPOSDBManager();
            DataTable dt = new DataTable();
            try
            {
                dbManager.Open();
                IDbDataParameter[] param = SalesPOSDBManagerFactory.GetParameters(dbManager.ProviderType, 1);

                param[0] = dbManager.getparam("@TerminalInfoId", TerminalInfoId);

                IDbCommand cmd = dbManager.getCommand(CommandType.StoredProcedure, "dbo.usp_terminalinfo_getbyId", param);
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

        public static bool Insert(TerminalInfo objTerminalInfo)
        {
            ISalesPOSDBManager dbManager = new SalesPOSDBManager();
            Boolean chk = false;
            try
            {
                dbManager.Open();
                IDbDataParameter[] param = SalesPOSDBManagerFactory.GetParameters(dbManager.ProviderType, 8);

                param[0] = dbManager.getparam("@TerminalName", objTerminalInfo.TerminalName.ToString());
                param[1] = dbManager.getparam("@Attribute", objTerminalInfo.Attribute.ToString());
                param[2] = dbManager.getparam("@ValueOfAttribute", objTerminalInfo.ValueOfAttribute.ToString());
                param[3] = dbManager.getparam("@ActivationDate", objTerminalInfo.ActivationDate);
                param[4] = dbManager.getparam("@ActivityID", objTerminalInfo.ActivityID.ToString());
                param[5] = dbManager.getparam("@ExpireDate", objTerminalInfo.ExpireDate);
                param[6] = dbManager.getparam("@CreatedBy", objTerminalInfo.CreatedBy.ToString());
                param[7] = dbManager.getparam("@IPAddress", objTerminalInfo.IPAddress.Trim());
                IDbCommand cmd = dbManager.getCommand(CommandType.StoredProcedure, "usp_terminal_info_insert", param);

                chk = dbManager.ExecuteQuery(cmd);
            }
            catch (Exception ex)
            {
                return false;
            }
            finally
            {
                dbManager.Dispose();

            }
            return chk;
        }

        public static bool Update(TerminalInfo objTerminalInfo)
        {
            ISalesPOSDBManager dbManager = new SalesPOSDBManager();
            Boolean chk = false;
            try
            {
                dbManager.Open();
                IDbDataParameter[] param = SalesPOSDBManagerFactory.GetParameters(dbManager.ProviderType, 9);

                param[0] = dbManager.getparam("@TerminalID", objTerminalInfo.TerminalID.ToString());
                param[1] = dbManager.getparam("@TerminalName", objTerminalInfo.TerminalName.ToString());
                param[2] = dbManager.getparam("@Attribute", objTerminalInfo.Attribute.ToString());
                param[3] = dbManager.getparam("@ValueOfAttribute", objTerminalInfo.ValueOfAttribute.ToString());
                param[4] = dbManager.getparam("@ActivationDate", objTerminalInfo.ActivationDate);
                param[5] = dbManager.getparam("@ActivityID", objTerminalInfo.ActivityID.ToString());
                param[6] = dbManager.getparam("@ExpireDate", objTerminalInfo.ExpireDate);
                param[7] = dbManager.getparam("@UpdatedBy", objTerminalInfo.UpdatedBy.ToString());
                param[8] = dbManager.getparam("@IPAddress", objTerminalInfo.IPAddress.Trim());

                IDbCommand cmd = dbManager.getCommand(CommandType.StoredProcedure, "usp_terminal_info_update", param);

                chk = dbManager.ExecuteQuery(cmd);
            }
            catch (Exception ex)
            {
                return false;
            }
            finally
            {
                dbManager.Dispose();

            }
            return chk;
        }

        public static bool TerminalRegistration(string _RegtIP, string _RegValue, string _RegtHostName, string _RegComments)
        {
            ISalesPOSDBManager dbManager = new SalesPOSDBManager();
            Boolean chk = false;
            try
            {
                dbManager.Open();
                IDbDataParameter[] param = SalesPOSDBManagerFactory.GetParameters(dbManager.ProviderType, 4);

                param[0] = dbManager.getparam("@RegtIP", _RegtIP);
                param[1] = dbManager.getparam("@RegValue", _RegValue);
                param[2] = dbManager.getparam("@RegtHostName", _RegtHostName);
                param[3] = dbManager.getparam("@RegComments", _RegComments);
                IDbCommand cmd = dbManager.getCommand(CommandType.StoredProcedure, "usp_terminal_registration_insert", param);

                chk = dbManager.ExecuteQuery(cmd);
            }
            catch (Exception ex)
            {
                return false;
            }
            finally
            {
                dbManager.Dispose();

            }
            return chk;
        }
    }
}
