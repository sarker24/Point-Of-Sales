using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using AssetInventory.DataAccessLayer;
using AssetInventory.BOL;

namespace AssetInventory.BLL
{
    public class bllReports
    {
        public static DataSet GetSalesInvoice(string _InvoiceNo)//, string _Status
        {
            ISalesPOSDBManager dbManager = new SalesPOSDBManager();
            DataSet ds = new DataSet();
            try
            {
                dbManager.Open();
                IDbDataParameter[] param = SalesPOSDBManagerFactory.GetParameters(dbManager.ProviderType,1);//, 2

                param[0] = dbManager.getparam("@InvoiceID", _InvoiceNo);
                //param[1] = dbManager.getparam("@Status", Convert.ToInt64(_Status));

                IDbCommand cmd = dbManager.getCommand(CommandType.StoredProcedure, "dbo.USP_RptSalesInvoice ", param);
                ds = dbManager.GetDataSet(cmd);
            }
            catch (Exception ex)
            {

            }
            finally
            {
                dbManager.Dispose();
            }
            return ds;
        }
    }
}
