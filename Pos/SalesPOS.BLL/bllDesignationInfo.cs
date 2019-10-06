using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using AssetInventory.DataAccessLayer;
using AssetInventory.BOL;

namespace AssetInventory.BLL
{
    public static class bllDesignationInfo
    {
        public static DataTable InsertUpdate(DesignationInfo objDesignationInfo)
        {
            ISalesPOSDBManager dbManager = new SalesPOSDBManager();
            DataTable dt = new DataTable();
            try
            {
                dbManager.Open();
                IDbDataParameter[] param = SalesPOSDBManagerFactory.GetParameters(dbManager.ProviderType, 5);
                param[0] = dbManager.getparam("@DesignationID", objDesignationInfo.DesignationID.ToString());
                param[1] = dbManager.getparam("@DepartmentID", objDesignationInfo.DepartmentID.ToString());
                param[2] = dbManager.getparam("@DesignationName", objDesignationInfo.DesignationName.ToString());
                param[3] = dbManager.getparam("@ActivityID", objDesignationInfo.ActivityID.ToString());
                param[4] = dbManager.getparam("@CreatedBy", objDesignationInfo.CreatedBy.ToString());

                IDbCommand cmd = dbManager.getCommand(CommandType.StoredProcedure, "dbo.USP_DesignationInfo_InsertUpdate", param);
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

        public static DataTable GetDesignationInfoByID(string DesignationID)
        {
            DataTable dt = new DataTable();
            dt = bllUtility.GetDataBySP("dbo.[USP_GetDesignationInfoByID]" + DesignationID + "");
            return dt;
        }
        public static DataTable GetDesignationInfoByDepartmentID(string DepartmentID)
        {
            DataTable dt = new DataTable();
            dt = bllUtility.GetDataBySP("dbo.[USP_GetDesignationInfoByDepartmentID]" + DepartmentID + "");
            return dt;
        }
    }
}
