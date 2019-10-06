using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using AssetInventory.DataAccessLayer;
using AssetInventory.BOL;

namespace AssetInventory.BLL
{
    public static class bllDepartmentInfo
    {
        public static DataTable InsertUpdate(DepartmentInfo objDepartmentInfo)
        {
            ISalesPOSDBManager dbManager = new SalesPOSDBManager();
            DataTable dt = new DataTable();
            try
            {
                dbManager.Open();
                IDbDataParameter[] param = SalesPOSDBManagerFactory.GetParameters(dbManager.ProviderType, 4);
                param[0] = dbManager.getparam("@DepartmentID", objDepartmentInfo.DepartmentID.ToString());
                param[1] = dbManager.getparam("@DepartmentName", objDepartmentInfo.DepartmentName.ToString());
                param[2] = dbManager.getparam("@ActivityID", objDepartmentInfo.ActivityID.ToString());
                param[3] = dbManager.getparam("@CreatedBy", objDepartmentInfo.CreatedBy.ToString());

                IDbCommand cmd = dbManager.getCommand(CommandType.StoredProcedure, "USP_DepartmentInfo_InsertUpdate", param);                
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

        public static DataTable GetDepartmentInfoByID(string DepartmentId)
        {
            DataTable dt = new DataTable();
            dt = bllUtility.GetDataBySP("dbo.[USP_GetDepartmentInfoByID]" + DepartmentId +"");
            return dt;
        }
        
        public static DataTable LoadDepartmentList()
        {
            DataTable dt = new DataTable();
            dt = bllUtility.GetDataBySP("dbo.USP_LoadDepartmentList");
            return dt;
        }
    }
}
