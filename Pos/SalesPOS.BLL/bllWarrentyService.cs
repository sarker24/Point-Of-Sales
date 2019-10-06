using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using AssetInventory.DataAccessLayer;
using AssetInventory.BOL;

namespace AssetInventory.BLL
{
    public class bllWarrentyService
    {
        public static DataTable Receive_Warrenty_Product(WarrentyService obj)
        {
            ISalesPOSDBManager dbManager = new SalesPOSDBManager();
            DataTable dt = new DataTable();
            try
            {
                dbManager.Open();
                IDbDataParameter[] param = SalesPOSDBManagerFactory.GetParameters(dbManager.ProviderType, 17);
                param[0] = dbManager.getparam("@ProductSizeID", obj.ProductSizeID);
                param[1] = dbManager.getparam("@Manufacturer", obj.Manufacturer);
                param[2] = dbManager.getparam("@SerialNo", obj.SerialNo);
                param[3] = dbManager.getparam("@IsWarrentyApplicable", obj.IsWarrentyApplicable);
                param[4] = dbManager.getparam("@IsNewFareAdded", obj.IsNewFareAdded);
                param[5] = dbManager.getparam("@Status", obj.Status);
                param[6] = dbManager.getparam("@VehicleNo", obj.VehicleNo);
                param[7] = dbManager.getparam("@CustomerID", obj.CustomerID);
                param[8] = dbManager.getparam("@CustomerName", obj.CustomerName);
                param[9] = dbManager.getparam("@Address", obj.Address);
                param[10] = dbManager.getparam("@WarrentyExpiredDate", obj.WarrentyExpiredDate);
                param[11] = dbManager.getparam("@TotalServiceAmount", obj.TotalServiceAmount);
                param[12] = dbManager.getparam("@DiscountAmount", obj.DiscountAmount);
                param[13] = dbManager.getparam("@PaidAmount", obj.PaidAmount);
                param[14] = dbManager.getparam("@ReadyForGatePass", obj.ReadyForGatePass);
                param[15] = dbManager.getparam("@IsPaid", obj.IsPaid);
                param[16] = dbManager.getparam("@CreatedBy", bllUtility.LoggedInSystemInformation.LoggedUserId);

                IDbCommand cmd = dbManager.getCommand(CommandType.StoredProcedure, "[insert_service_parent]", param);
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

        public static DataTable Receive_Payment(WarrentyService obj)
        {
            ISalesPOSDBManager dbManager = new SalesPOSDBManager();
            DataTable dt = new DataTable();
            try
            {
                dbManager.Open();
                IDbDataParameter[] param = SalesPOSDBManagerFactory.GetParameters(dbManager.ProviderType, 6);
                param[0] = dbManager.getparam("@ServiceNumber", obj.ServiceNumber);
                param[1] = dbManager.getparam("@PaidAmount", obj.PaidAmount);
                param[2] = dbManager.getparam("@Status", obj.Status);
                param[3] = dbManager.getparam("@CustomerID", obj.CustomerID);
                param[4] = dbManager.getparam("@TerminalID", bllUtility.LoggedInSystemInformation.TerminalID);
                param[5] = dbManager.getparam("@CreatedBy", bllUtility.LoggedInSystemInformation.LoggedUserId);

                IDbCommand cmd = dbManager.getCommand(CommandType.StoredProcedure, "[update_service_payment]", param);
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
