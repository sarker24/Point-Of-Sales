using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using AssetInventory.DataAccessLayer;
using AssetInventory.BOL;

namespace AssetInventory.BLL
{
    public static class bllManufacturerInfo
    {
        public static DataTable GetItemList(string ProductSizeID)
        {
            ISalesPOSDBManager dbManager = new SalesPOSDBManager();
            DataTable dt = new DataTable();
            try
            {
                dbManager.Open();
                IDbDataParameter[] param = SalesPOSDBManagerFactory.GetParameters(dbManager.ProviderType, 1);

                param[0] = dbManager.getparam("@ProductSizeID",Convert.ToInt32( ProductSizeID));

                IDbCommand cmd = dbManager.getCommand(CommandType.StoredProcedure, "load_manufacturer_by_product_variation", param);
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
