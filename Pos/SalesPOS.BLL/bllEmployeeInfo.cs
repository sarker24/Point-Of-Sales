using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using AssetInventory.DataAccessLayer;
using AssetInventory.BOL;

namespace AssetInventory.BLL
{
    public static class bllEmployeeInfo
    {
        public static DataTable InsertUpdate(EmployeeInfo objEmployeeInfo)
        {
            ISalesPOSDBManager dbManager = new SalesPOSDBManager();
            DataTable dt = new DataTable();
            try
            {
                dbManager.Open();
                IDbDataParameter[] param = SalesPOSDBManagerFactory.GetParameters(dbManager.ProviderType, 19);
                param[0] = dbManager.getparam("@EmployeeID", objEmployeeInfo.EmployeeID.ToString());
                param[1] = dbManager.getparam("@EmployeeName", objEmployeeInfo.EmployeeName.ToString());
                param[2] = dbManager.getparam("@FathersName", objEmployeeInfo.FathersName.ToString());
                param[3] = dbManager.getparam("@MothersName", objEmployeeInfo.MothersName.ToString());
                param[4] = dbManager.getparam("@DepartmentID", objEmployeeInfo.DepartmentID.ToString());
                param[5] = dbManager.getparam("@DesignationID", objEmployeeInfo.DesignationID.ToString());
                param[6] = dbManager.getparam("@JoiningDate", objEmployeeInfo.JoiningDate.ToString());
                param[7] = dbManager.getparam("@BirthDate", objEmployeeInfo.BirthDate.ToString());
                param[8] = dbManager.getparam("@PresentAddress", objEmployeeInfo.PresentAddress.ToString());
                param[9] = dbManager.getparam("@PermanentAddress", objEmployeeInfo.PermanentAddress.ToString());
                param[10] = dbManager.getparam("@ContactNo", objEmployeeInfo.ContactNo.ToString());
                param[11] = dbManager.getparam("@Photo", objEmployeeInfo.Photo);
                param[12] = dbManager.getparam("@Gender", objEmployeeInfo.Gender.ToString());
                param[13] = dbManager.getparam("@MaritalStatus", objEmployeeInfo.MaritalStatus.ToString());
                param[14] = dbManager.getparam("@ReferancePersonName", objEmployeeInfo.ReferancePersonName.ToString());
                param[15] = dbManager.getparam("@RelationshipWithRefPerson", objEmployeeInfo.RelationshipWithRefPerson.ToString());
                param[16] = dbManager.getparam("@ReferanceContactNo", objEmployeeInfo.ReferanceContactNo.ToString());
                param[17] = dbManager.getparam("@Activity", objEmployeeInfo.Activity.ToString());
                param[18] = dbManager.getparam("@CreatedBy", objEmployeeInfo.CreatedBy.ToString());                

                IDbCommand cmd = dbManager.getCommand(CommandType.StoredProcedure, "USP_EmployeeInfo_InsertUpdate", param);
                dt = dbManager.GetDataTable(cmd);
                //dt = dbManager.ExecuteNonQuery(cmd);
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

        public static DataTable GetEmployeeInfoByID(string EmployeeId)
        {
            DataTable dt = new DataTable();
            dt = bllUtility.GetDataBySP("dbo.[USP_GetEmployeeInfoByID] '"+EmployeeId+"'");
            return dt;
        }

        public static DataTable GetEmployeeInfo()
        {
            DataTable dt = new DataTable();
            dt = bllUtility.GetDataBySP(@"SELECT     dbo.trim(EmployeeID) AS EmployeeID, EmployeeName + ' -- (' + EmployeeID + ')' AS 'EmployeeName'
FROM         dbo.EmployeeInfo 
WHERE     (Activity = N'Active') ORDER BY EmployeeName");
            return dt;
        }
    }
}
