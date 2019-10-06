using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AssetInventory.BOL;
using AssetInventory.DataAccessLayer;
using System.Data;

namespace AssetInventory.BLL
{
    public static class bllProductSales
    {
        public static DataTable InsertSalesParent(SaleMaster objSaleMaster)
        {
            ISalesPOSDBManager dbManager = new SalesPOSDBManager();
            DataTable dt = new DataTable();
            try
            {
                dbManager.Open();
                IDbDataParameter[] param = SalesPOSDBManagerFactory.GetParameters(dbManager.ProviderType, 12);
                param[0] = dbManager.getparam("@SalesType", objSaleMaster.SalesType);
                param[1] = dbManager.getparam("@CustomerCode", objSaleMaster.CustomerID);
                param[2] = dbManager.getparam("@SalesmanID", objSaleMaster.SalemanID);                
                param[3] = dbManager.getparam("@SalesAmount", Convert.ToDouble(objSaleMaster.SalesAmount));
                param[4] = dbManager.getparam("@TerminalID", Convert.ToInt32(objSaleMaster.TerminalID));
                param[5] = dbManager.getparam("@CreatedBy", Convert.ToInt32(objSaleMaster.CreatedBy));
                param[6] = dbManager.getparam("@CashPaid", Convert.ToDouble(objSaleMaster.CashPaid));
                param[7] = dbManager.getparam("@CustomerName", objSaleMaster.CustomerName);
                param[8] = dbManager.getparam("@CustomerAddress", objSaleMaster.CustomerAddress);
                param[9] = dbManager.getparam("@CustomerPhone", objSaleMaster.CustomerPhone);
                param[10] = dbManager.getparam("@VehicleNo", objSaleMaster.VehicleNo);
                param[11] = dbManager.getparam("@PO_Number", objSaleMaster.PO_Number);

                IDbCommand cmd = dbManager.getCommand(CommandType.StoredProcedure, "[dbo].[insert_sales_master]", param);
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

        public static bool InsertSalesPayment(SalesPaymentInfo objSalesPaymentInfo)
        {
            ISalesPOSDBManager dbManager = new SalesPOSDBManager();
            bool isSave = true;
            try
            {
                dbManager.Open();
                IDbDataParameter[] param = SalesPOSDBManagerFactory.GetParameters(dbManager.ProviderType, 5);
                param[0] = dbManager.getparam("@InvoiceNo", objSalesPaymentInfo.InvoiceNo);
                param[1] = dbManager.getparam("@PaidAmount", Convert.ToDouble(objSalesPaymentInfo.PaidAmount));                
                param[2] = dbManager.getparam("@TerminalID", objSalesPaymentInfo.TerminalID);
                param[3] = dbManager.getparam("@CreatedBy", Convert.ToInt64(objSalesPaymentInfo.CreatedBy));
                param[4] = dbManager.getparam("@CustomerCode", objSalesPaymentInfo.CustomerID);
                IDbCommand cmd = dbManager.getCommand(CommandType.StoredProcedure, "[dbo].[USP_SalesPaymentInfo_Add]", param);
                dbManager.GetDataTable(cmd);
            }
            catch (Exception ex)
            {
                isSave = false;
            }
            finally
            {
                dbManager.Dispose();
            }
            return isSave;
        }

        public static bool InsertSalesDetails(SalesChild objSalesChild)
        {
            ISalesPOSDBManager dbManager = new SalesPOSDBManager();
            bool isSave = true;
            try
            {
                dbManager.Open();
                IDbDataParameter[] param = SalesPOSDBManagerFactory.GetParameters(dbManager.ProviderType, 8);

                param[0] = dbManager.getparam("@SalesMasterID", Convert.ToInt32(objSalesChild.SalesMasterID));
                param[1] = dbManager.getparam("@ProductSizeID", Convert.ToInt32(objSalesChild.ProductSizeID));
                param[2] = dbManager.getparam("@Manufacturer", objSalesChild.Manufacturer);
                param[3] = dbManager.getparam("@SalesQuantity", Convert.ToInt32(objSalesChild.SalesQuantity));
                param[4] = dbManager.getparam("@UnitSalesPrice", Convert.ToDouble(objSalesChild.UnitSalesPrice));                
                param[5] = dbManager.getparam("@VatRate", Convert.ToDouble(objSalesChild.VatRate));
                param[6] = dbManager.getparam("@WarrentyID", Convert.ToInt32(objSalesChild.WarrentyID));
                param[7] = dbManager.getparam("@SerialNo", objSalesChild.SerialNo);                

                IDbCommand cmd = dbManager.getCommand(CommandType.StoredProcedure, "[dbo].[insert_sales_child]", param);
                dbManager.GetDataTable(cmd);
            }
            catch (Exception ex)
            {
                isSave = false;
            }
            finally
            {
                dbManager.Dispose();
            }
            return isSave;
        }


    }
}
