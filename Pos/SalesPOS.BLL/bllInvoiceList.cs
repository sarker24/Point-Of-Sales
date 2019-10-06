using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using AssetInventory.DataAccessLayer;
using AssetInventory.BOL;

namespace AssetInventory.BLL
{
    public static class bllInvoiceList
    {
        //public static DataTable LoadSalesInvoice(string SalesDate, string TerminalID)
        //{
        //    ISalesPOSDBManager dbManager = new SalesPOSDBManager();
        //    DataTable dt = new DataTable();
        //    try
        //    {
        //        dbManager.Open();
        //        IDbDataParameter[] param = SalesPOSDBManagerFactory.GetParameters(dbManager.ProviderType, 2);

        //        param[0] = dbManager.getparam("@SalesDate", SalesDate);
        //        param[1] = dbManager.getparam("@TerminalId", TerminalID);

        //        IDbCommand cmd = dbManager.getCommand(CommandType.StoredProcedure, "[dbo].[USP_ListOfSalesInvice]", param);
        //        dt = dbManager.GetDataTable(cmd);
        //    }
        //    catch (Exception ex)
        //    {
        //        throw (ex);
        //    }
        //    finally
        //    {
        //        dt.Dispose();
        //        dbManager.Dispose();
        //    }
        //    return dt;
        //}

        public static DataTable LoadPurchaseInvoice(string PurchaseDate)
        {
            ISalesPOSDBManager dbManager = new SalesPOSDBManager();
            DataTable dt = new DataTable();
            try
            {
                dbManager.Open();
                IDbDataParameter[] param = SalesPOSDBManagerFactory.GetParameters(dbManager.ProviderType, 1);

                param[0] = dbManager.getparam("@PurchaseDate", PurchaseDate);

                IDbCommand cmd = dbManager.getCommand(CommandType.StoredProcedure, "[dbo].[USP_ListOfPurchaseInvice]", param);
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

        public static DataTable LoadIssueInvoice(string _FromDate,string _ToDate, string _ProjectID, string _IssueTo)
        {
            ISalesPOSDBManager dbManager = new SalesPOSDBManager();
            DataTable dt = new DataTable();
            try
            {
                dbManager.Open();
                IDbDataParameter[] param = SalesPOSDBManagerFactory.GetParameters(dbManager.ProviderType, 4);

                param[0] = dbManager.getparam("@DateFrom", _FromDate);
                param[1] = dbManager.getparam("@DateTo", _ToDate);
                param[2] = dbManager.getparam("@ProjectID", _ProjectID);
                param[3] = dbManager.getparam("@IssueTo", _IssueTo);

                IDbCommand cmd = dbManager.getCommand(CommandType.StoredProcedure, "[dbo].[list_of_issue_no]", param);
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

        public static DataTable LoadSalesInvoice(string _FromDate, string _ToDate)
        {
            ISalesPOSDBManager dbManager = new SalesPOSDBManager();
            DataTable dt = new DataTable();
            try
            {
                dbManager.Open();
                IDbDataParameter[] param = SalesPOSDBManagerFactory.GetParameters(dbManager.ProviderType, 2);

                param[0] = dbManager.getparam("@DateFrom", _FromDate);
                param[1] = dbManager.getparam("@DateTo", _ToDate);

                IDbCommand cmd = dbManager.getCommand(CommandType.StoredProcedure, "[dbo].[list_of_sales_no]", param);
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
