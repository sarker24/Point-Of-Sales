using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AssetInventory.DataAccessLayer;
using AssetInventory.BOL;
using System.Data;

namespace AssetInventory.BLL
{
    public class bllAccountTransaction
    {
        public static DataTable GetAccTransDetails(AccountTransaction objAccountTransaction)
        {
            ISalesPOSDBManager dbManager = new SalesPOSDBManager();
            DataTable dt = new DataTable();            
            try
            {
                dbManager.Open();
                IDbDataParameter[] param = SalesPOSDBManagerFactory.GetParameters(dbManager.ProviderType, 5);
                param[0] = dbManager.getparam("@ATTID", objAccountTransaction.SearchATTID);
                param[1] = dbManager.getparam("@AccountNo", objAccountTransaction.SearchAccountNo);
                param[2] = dbManager.getparam("@DateFrom", objAccountTransaction.SearchDateFrom);
                param[3] = dbManager.getparam("@DateTo", objAccountTransaction.SearchDateTo);
                param[4] = dbManager.getparam("@IsEditable", objAccountTransaction.SearchIsEditable);

                IDbCommand cmd = dbManager.getCommand(CommandType.StoredProcedure, "[dbo].[USP_GetAccTransDetails]", param);
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
        public static DataTable getById(long ATID)
        {
            ISalesPOSDBManager dbManager = new SalesPOSDBManager();
            DataTable dt = new DataTable();
            try
            {
                dbManager.Open();
                IDbDataParameter[] param = SalesPOSDBManagerFactory.GetParameters(dbManager.ProviderType, 1);

                param[0] = dbManager.getparam("@ATID", ATID);

                IDbCommand cmd = dbManager.getCommand(CommandType.StoredProcedure, "[usp_AccTransactionInfo_getbyId]", param);
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

        public static DataTable GetTransactionType(long ATTID)
        {
            ISalesPOSDBManager dbManager = new SalesPOSDBManager();
            DataTable dt = new DataTable();
            try
            {
                dbManager.Open();
                IDbDataParameter[] param = null;
                IDbCommand cmd = dbManager.getCommand(CommandType.Text, @"SELECT AccTypeID, TransactionType, DrCr, CashFlow
                FROM dbo.AccountTransactionTypeInfo WHERE (AccTypeID = "+ATTID+")", param);
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

        public static DataTable InsertData(AccountTransaction objAccountTransaction)
        {
            ISalesPOSDBManager dbManager = new SalesPOSDBManager();
            DataTable dt = new DataTable();
            try
            {
                dbManager.Open();
                IDbDataParameter[] param = SalesPOSDBManagerFactory.GetParameters(dbManager.ProviderType, 8);
                param[0] = dbManager.getparam("@TransactionDate", objAccountTransaction.TransactionDate);
                param[1] = dbManager.getparam("@TerminalID", Convert.ToInt64(objAccountTransaction.TerminalID));
                param[2] = dbManager.getparam("@AccountNo", objAccountTransaction.AccountHolderID.ToUpper());
                param[3] = dbManager.getparam("@ATTID", Convert.ToInt64(objAccountTransaction.ATTID));
                param[4] = dbManager.getparam("@Description", objAccountTransaction.Description);
                param[5] = dbManager.getparam("@Debit", Convert.ToDecimal(objAccountTransaction.Debit));
                param[6] = dbManager.getparam("@Credit", Convert.ToDecimal(objAccountTransaction.Credit));
                param[7] = dbManager.getparam("@CreatedBy", Convert.ToInt64(objAccountTransaction.CreatedBy));

                IDbCommand cmd = dbManager.getCommand(CommandType.StoredProcedure, "[dbo].[USP_AccountTransactionDetailsInfo_Add]", param);
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

        public static bool UpdateData(AccountTransaction objAccountTransaction)
        {
            ISalesPOSDBManager dbManager = new SalesPOSDBManager();
            Boolean chk = false;
            try
            {
                dbManager.Open();
                IDbDataParameter[] param = SalesPOSDBManagerFactory.GetParameters(dbManager.ProviderType, 9);
                param[0] = dbManager.getparam("@ATID", Convert.ToInt64(objAccountTransaction.ATID));
                param[1] = dbManager.getparam("@TransactionDate", objAccountTransaction.TransactionDate.ToString());
                param[2] = dbManager.getparam("@TerminalID", Convert.ToInt64(objAccountTransaction.TerminalID));
                param[3] = dbManager.getparam("@AccountNo", objAccountTransaction.AccountHolderID.ToUpper());
                param[4] = dbManager.getparam("@ATTID", Convert.ToInt64(objAccountTransaction.ATTID));
                param[5] = dbManager.getparam("@Description", objAccountTransaction.Description);
                param[6] = dbManager.getparam("@Debit", Convert.ToDecimal(objAccountTransaction.Debit));
                param[7] = dbManager.getparam("@Credit", Convert.ToDecimal(objAccountTransaction.Credit));
                param[8] = dbManager.getparam("@UpdatedBy", Convert.ToInt64(objAccountTransaction.CreatedBy));                

                IDbCommand cmd = dbManager.getCommand(CommandType.StoredProcedure, "[dbo].[USP_AccountTransactionDetailsInfo_Update]", param);

                chk = dbManager.ExecuteQuery(cmd);
                //dbManager.ExecuteReader(cmd);
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
