using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using AssetInventory.DataAccessLayer;
using AssetInventory.BOL;

namespace AssetInventory.BLL
{
    public static class bllProjectInfo
    {
        public static DataTable InsertUpdate(ProjectInfo objProjectInfo)
        {
            ISalesPOSDBManager dbManager = new SalesPOSDBManager();
            DataTable dt = new DataTable();
            try
            {
                dbManager.Open();
                IDbDataParameter[] param = SalesPOSDBManagerFactory.GetParameters(dbManager.ProviderType, 4);
                param[0] = dbManager.getparam("@ProjectID", objProjectInfo.ProjectID.ToString());
                param[1] = dbManager.getparam("@ProjectName", objProjectInfo.ProjectName.ToString());
                param[2] = dbManager.getparam("@ActivityID", objProjectInfo.ActivityID.ToString());
                param[3] = dbManager.getparam("@CreatedBy", objProjectInfo.CreatedBy.ToString());

                IDbCommand cmd = dbManager.getCommand(CommandType.StoredProcedure, "USP_ProjectInfo_InsertUpdate", param);
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

        public static DataTable GetProjectInfoByID(string ProjectId)
        {
            DataTable dt = new DataTable();
            dt = bllUtility.GetDataBySP("dbo.[USP_GetProjectInfoByID]" + ProjectId + "");
            return dt;
        }

        public static DataTable LoadProjectList()
        {
            DataTable dt = new DataTable();
            dt = bllUtility.GetDataBySP("dbo.USP_LoadProjectList");
            return dt;
        }
    }
}
