using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using AssetInventory.DataAccessLayer;
using AssetInventory.BOL;

namespace AssetInventory.BLL
{
    public static class bllIssueReceive
    {
        public static DataTable insert_issue_master(DateTime _IssueDate, string _IssueTo, string _ProjectID, DateTime _ReturnDate)
        {
            ISalesPOSDBManager dbManager = new SalesPOSDBManager();
            DataTable dt = new DataTable();
            try
            {
                dbManager.Open();
                IDbDataParameter[] param = SalesPOSDBManagerFactory.GetParameters(dbManager.ProviderType, 5);
                param[0] = dbManager.getparam("@IssueDate", _IssueDate);
                param[1] = dbManager.getparam("@IssueTo", _IssueTo);
                param[2] = dbManager.getparam("@ProjectID", Convert.ToInt32(_ProjectID));
                param[3] = dbManager.getparam("@ReturnDate", _ReturnDate);
                param[4] = dbManager.getparam("@CreatedBy", bllUtility.LoggedInSystemInformation.LoggedUserId.ToString());

                IDbCommand cmd = dbManager.getCommand(CommandType.StoredProcedure, "insert_issue_master", param);
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

        public static bool insert_issue_child(string _IssueID, string _ProductSizeID, string _Issue_Qty, string _AssetID, string _IssueFrom_StoreID, string _Recv_Qty, string _RecvTo_StoreID)
        {
            ISalesPOSDBManager dbManager = new SalesPOSDBManager();
            Boolean chk = false;
            try
            {
                dbManager.Open();
                IDbDataParameter[] param = SalesPOSDBManagerFactory.GetParameters(dbManager.ProviderType, 7);
                param[0] = dbManager.getparam("@IssueID", _IssueID);
                param[1] = dbManager.getparam("@ProductSizeID", Convert.ToInt32(_ProductSizeID));
                param[2] = dbManager.getparam("@Issue_Qty", Convert.ToInt32(_Issue_Qty));
                param[3] = dbManager.getparam("@AssetID", _AssetID);
                param[4] = dbManager.getparam("@IssueFrom_StoreID", Convert.ToInt32(_IssueFrom_StoreID));
                param[5] = dbManager.getparam("@Recv_Qty", Convert.ToInt32(_Recv_Qty));
                param[6] = dbManager.getparam("@RecvTo_StoreID", Convert.ToInt32(_RecvTo_StoreID));

                IDbCommand cmd = dbManager.getCommand(CommandType.StoredProcedure, "insert_issue_child", param);
                chk = dbManager.ExecuteQuery(cmd);
            }
            catch (Exception ex)
            {
                return false;
            }
            finally
            {
                dbManager.Dispose();

            }
            return chk;
        }

        public static DataTable load_issue_master(string _IssueID)
        {
            ISalesPOSDBManager dbManager = new SalesPOSDBManager();
            DataTable dt = new DataTable();
            try
            {
                dbManager.Open();
                IDbDataParameter[] param = SalesPOSDBManagerFactory.GetParameters(dbManager.ProviderType, 1);
                param[0] = dbManager.getparam("@IssueID", _IssueID);

                IDbCommand cmd = dbManager.getCommand(CommandType.StoredProcedure, "load_issue_master_by_issue_no", param);
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

        public static DataTable load_issue_child(string _IssueID)
        {
            ISalesPOSDBManager dbManager = new SalesPOSDBManager();
            DataTable dt = new DataTable();
            try
            {
                dbManager.Open();
                IDbDataParameter[] param = SalesPOSDBManagerFactory.GetParameters(dbManager.ProviderType, 1);
                param[0] = dbManager.getparam("@IssueID", _IssueID);

                IDbCommand cmd = dbManager.getCommand(CommandType.StoredProcedure, "load_issue_details_by_issue_no", param);
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

        public static bool insert_receive_product(string _RcvDate, string _IssueChildID, string _RcvQty, string _RcvTo_StoreID, string _AssetID, string _ProductSizeID)
        {
            ISalesPOSDBManager dbManager = new SalesPOSDBManager();
            Boolean chk = false;
            try
            {
                dbManager.Open();
                IDbDataParameter[] param = SalesPOSDBManagerFactory.GetParameters(dbManager.ProviderType, 7);
                param[0] = dbManager.getparam("@RcvDate", _RcvDate);
                param[1] = dbManager.getparam("@IssueChildID", Convert.ToInt32(_IssueChildID));
                param[2] = dbManager.getparam("@RcvQty", Convert.ToInt32(_RcvQty));
                param[3] = dbManager.getparam("@RcvTo_StoreID", Convert.ToInt32(_RcvTo_StoreID));
                param[4] = dbManager.getparam("@RcvBy", Convert.ToInt32(bllUtility.LoggedInSystemInformation.LoggedUserId.ToString()));
                param[5] = dbManager.getparam("@AssetID", Convert.ToInt32(_AssetID));
                param[6] = dbManager.getparam("@ProductSizeID", Convert.ToInt32(_ProductSizeID));

                IDbCommand cmd = dbManager.getCommand(CommandType.StoredProcedure, "insert_receive_product", param);
                chk = dbManager.ExecuteQuery(cmd);
            }
            catch (Exception ex)
            {
                return false;
            }
            finally
            {
                dbManager.Dispose();

            }
            return chk;
        }
    }
}
