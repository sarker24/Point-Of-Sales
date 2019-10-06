using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AssetInventory.DataAccessLayer;
using AssetInventory.BOL;
using System.Data;

namespace AssetInventory.BLL
{
    public static class bllProductPurchase
    {
        public static DataTable InsertPurchaseMaster(ProductPurchaseInfo objProductPurchaseInfo)
        {
            ISalesPOSDBManager dbManager = new SalesPOSDBManager();
            DataTable dt = new DataTable();
            try
            {
                dbManager.Open();
                IDbDataParameter[] param = SalesPOSDBManagerFactory.GetParameters(dbManager.ProviderType, 5);
                                
                param[0] = dbManager.getparam("@TransactionDate", objProductPurchaseInfo.TransactionDate);
                param[1] = dbManager.getparam("@MemoNo", objProductPurchaseInfo.MemoNo);                
                param[2] = dbManager.getparam("@CreatedBy", objProductPurchaseInfo.CreatedBy);
                param[3] = dbManager.getparam("@SupplierCode", objProductPurchaseInfo.SupplierID);
                param[4] = dbManager.getparam("@TotalAmount", Convert.ToDecimal(objProductPurchaseInfo.TotalPrice));
                IDbCommand cmd = dbManager.getCommand(CommandType.StoredProcedure, "dbo.[insert_purchase_master]", param);
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

        public static DataTable InsertPurchaseMasterDetails(string _PurchaseMasterID,
                                                            string _ProductSizeID,
                                                            string _Manufacturer, 
                                                            string _UnitCostPrice,
                                                            string _PurchaseQty)
        {

            ISalesPOSDBManager dbManager = new SalesPOSDBManager();
            DataTable dt = new DataTable();
            try
            {
                dbManager.Open();
                IDbDataParameter[] param = SalesPOSDBManagerFactory.GetParameters(dbManager.ProviderType, 5);

                param[0] = dbManager.getparam("@PurchaseMasterID", Convert.ToInt32(_PurchaseMasterID));
                param[1] = dbManager.getparam("@ProductSizeID", Convert.ToInt32(_ProductSizeID));
                param[2] = dbManager.getparam("@Manufacturer", _Manufacturer.ToUpper());
                param[3] = dbManager.getparam("@UnitCostPrice", Convert.ToDecimal(_UnitCostPrice));
                param[4] = dbManager.getparam("@PurchaseQty", Convert.ToDecimal(_PurchaseQty));

                IDbCommand cmd = dbManager.getCommand(CommandType.StoredProcedure, "dbo.[insert_purchase_child]", param);                
                dt = dbManager.GetDataTable(cmd);
               //chk = true;
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

        public static bool InsertPurchasePayment(PurchasePaymentInfo objPurchasePaymentInfo)
        {
            ISalesPOSDBManager dbManager = new SalesPOSDBManager();
            bool isSave = true;
            try
            {
                dbManager.Open();
                IDbDataParameter[] param = SalesPOSDBManagerFactory.GetParameters(dbManager.ProviderType, 5);

                param[0] = dbManager.getparam("@PurchaseID", objPurchasePaymentInfo.PurchaseID);
                param[1] = dbManager.getparam("@PaidAmount", Convert.ToDouble(objPurchasePaymentInfo.PaidAmount));
                param[2] = dbManager.getparam("@SupplierCode", objPurchasePaymentInfo.SupplierID);
                param[3] = dbManager.getparam("@TerminalID", objPurchasePaymentInfo.TerminalID);
                param[4] = dbManager.getparam("@CreatedBy", Convert.ToInt64(objPurchasePaymentInfo.CreatedBy));

                IDbCommand cmd = dbManager.getCommand(CommandType.StoredProcedure, "[dbo].[USP_PurchasePaymentInfo_Add]", param);
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
