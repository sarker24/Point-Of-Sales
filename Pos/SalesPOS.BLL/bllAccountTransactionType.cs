using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AssetInventory.DataAccessLayer;
using AssetInventory.BOL;
using System.Data;

namespace AssetInventory.BLL
{
    public class bllAccountTransactionType
    {
        public static DataTable GetAccountTransInfoForMiniAcc()
        {
            ISalesPOSDBManager dbManager = new SalesPOSDBManager();
            DataTable dt = new DataTable();
            try
            {
                dbManager.Open();
                IDbDataParameter[] param = null;

                IDbCommand cmd = dbManager.getCommand(CommandType.StoredProcedure, "[dbo].[USP_AccountTransInfoForMiniAcc ]", param);
                dt = dbManager.GetDataTable(cmd);
            }
            catch (Exception ex)
            {
                //return false;
            }
            finally
            {
                dbManager.Dispose();
            }
            return dt;
        }
    }
}
