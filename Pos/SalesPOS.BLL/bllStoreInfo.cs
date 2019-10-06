using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using AssetInventory.DataAccessLayer;
using AssetInventory.BOL;

namespace AssetInventory.BLL
{
    public static class bllStoreInfo
    {
        public static DataTable getAll()
        {
            ISalesPOSDBManager dbManager = new SalesPOSDBManager();
            DataTable dt = new DataTable();
            try
            {
                dbManager.Open();
                IDbDataParameter[] param = null;


                IDbCommand cmd = dbManager.getCommand(CommandType.Text, @"select * from StoreInfo where ActivityID=1 ", param);
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
    }
}
