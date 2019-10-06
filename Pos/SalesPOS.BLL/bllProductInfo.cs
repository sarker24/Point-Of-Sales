using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using AssetInventory.DataAccessLayer;
using AssetInventory.BOL;

namespace AssetInventory.BLL
{
    public static class bllProductInfo
    {
        public static DataTable getAll(int isFixedAsset)
        {
            ISalesPOSDBManager dbManager = new SalesPOSDBManager();
            DataTable dt = new DataTable();
            string sql;
            try
            {
                dbManager.Open();
                IDbDataParameter[] param = null;
                if (isFixedAsset == 2)
                {
                    sql = @"SELECT     dbo.ProductSizeLookup.ID, dbo.ProductInfo.PID, dbo.ProductInfo.ProductName, dbo.ManufacturerInfo.ManufacturarName, dbo.UnitInfo.UnitName, 
                      dbo.SectionInfo.SectionName, dbo.ProductInfo.FixedAsset, dbo.ProductInfo.Issuable, dbo.ProductSizeLookup.AssetCode
FROM         dbo.ProductInfo INNER JOIN
                      dbo.ProductSizeLookup ON dbo.ProductInfo.PID = dbo.ProductSizeLookup.PID INNER JOIN
                      dbo.ManufacturerInfo ON dbo.ProductSizeLookup.SizeID = dbo.ManufacturerInfo.ManufacturerID INNER JOIN
                      dbo.UnitInfo ON dbo.ProductInfo.UnitId = dbo.UnitInfo.UnitId INNER JOIN
                      dbo.SectionInfo ON dbo.ProductInfo.SectionID = dbo.SectionInfo.SectionID
WHERE     (dbo.ProductInfo.ActivityID = 1) order by dbo.ProductInfo.ProductName";
                }
                else
                {
                    sql = @"SELECT     dbo.ProductSizeLookup.ID, dbo.ProductInfo.PID, dbo.ProductInfo.ProductName, dbo.ManufacturerInfo.ManufacturarName, dbo.UnitInfo.UnitName, 
                      dbo.SectionInfo.SectionName, dbo.ProductInfo.FixedAsset, dbo.ProductInfo.Issuable, dbo.ProductSizeLookup.AssetCode
FROM         dbo.ProductInfo INNER JOIN
                      dbo.ProductSizeLookup ON dbo.ProductInfo.PID = dbo.ProductSizeLookup.PID INNER JOIN
                      dbo.ManufacturerInfo ON dbo.ProductSizeLookup.SizeID = dbo.ManufacturerInfo.ManufacturerID INNER JOIN
                      dbo.UnitInfo ON dbo.ProductInfo.UnitId = dbo.UnitInfo.UnitId INNER JOIN
                      dbo.SectionInfo ON dbo.ProductInfo.SectionID = dbo.SectionInfo.SectionID
WHERE     (dbo.ProductInfo.ActivityID = 1) and dbo.ProductInfo.FixedAsset=" + isFixedAsset + "order by dbo.ProductInfo.ProductName";
                }
                IDbCommand cmd = dbManager.getCommand(CommandType.Text, sql, param);
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
        public static DataTable getProductNameList()
        {
            ISalesPOSDBManager dbManager = new SalesPOSDBManager();
            DataTable dt = new DataTable();
            string sql;
            try
            {
                dbManager.Open();
                IDbDataParameter[] param = null;

                sql = "dbo.load_product_list";
                
                IDbCommand cmd = dbManager.getCommand(CommandType.StoredProcedure, sql, param);
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

        public static DataTable getAll1()
        {
            ISalesPOSDBManager dbManager = new SalesPOSDBManager();
            DataTable dt = new DataTable();
            try
            {
                dbManager.Open();
                IDbDataParameter[] param = null;
                IDbCommand cmd = dbManager.getCommand(CommandType.Text, @"SELECT     TOP (100) PERCENT ProductInfo.PID, ProductInfo.ProductName, UnitInfo.UnitName, ProductInfo.FixedAsset, 
                      ProductInfo.Issuable, Warrenty_Type_t.WarrentyID
FROM         ProductInfo INNER JOIN
                      UnitInfo ON ProductInfo.UnitId = UnitInfo.UnitId INNER JOIN
                      Warrenty_Type_t ON ProductInfo.WarrentyID = Warrenty_Type_t.WarrentyID
WHERE     (ProductInfo.ActivityID = 1)
ORDER BY ProductInfo.ProductName", param);
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
        public static DataTable getIssueProduct()
                {
                    ISalesPOSDBManager dbManager = new SalesPOSDBManager();
                    DataTable dt = new DataTable();
                    try
                    {
                        dbManager.Open();
                        IDbDataParameter[] param = null;
                        IDbCommand cmd = dbManager.getCommand(CommandType.Text, @"SELECT     ROW_NUMBER()  OVER (ORDER BY  PID) As Id,ProductInfo.PID,ProductInfo.ProductName, 0 AS 'Yes_No' , 0 as Qty, UnitInfo.UnitName, SectionInfo.SectionName
FROM         ProductInfo INNER JOIN
                      UnitInfo ON ProductInfo.UnitId = UnitInfo.UnitId INNER JOIN
                      SectionInfo ON ProductInfo.SectionID = SectionInfo.SectionID", param);
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
        public static DataTable InsertProductPriceInfo(string _ProductSizeID, string _PID,  string _RetailPrice, string _WholeSalePrice, string _ItemDescription,string _ItemCode_Manual)
        {
            ISalesPOSDBManager dbManager = new SalesPOSDBManager();
            DataTable dt = new DataTable();
            try
            {
                dbManager.Open();
                IDbDataParameter[] param = SalesPOSDBManagerFactory.GetParameters(dbManager.ProviderType, 6);

                param[0] = dbManager.getparam("@ProductSizeID", Convert.ToInt32(_ProductSizeID));
                param[1] = dbManager.getparam("@PID", _PID);                
                param[2] = dbManager.getparam("@RetailPrice", Convert.ToDecimal(_RetailPrice));
                param[3] = dbManager.getparam("@WholeSalePrice", Convert.ToDecimal(_WholeSalePrice));
                param[4] = dbManager.getparam("@ItemDescription", _ItemDescription);
                param[5] = dbManager.getparam("@ItemCode_Manual", _ItemCode_Manual);
                IDbCommand cmd = dbManager.getCommand(CommandType.StoredProcedure, "dbo.[insert_product_price_info]", param);

                //dt = dbManager.ExecuteQuery(cmd);  
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
        public static DataTable UpdateProductPriceInfo(string _ItemCode, string _ProductSizeID, string _PID, string _RetailPrice, string _WholeSalePrice, string _ItemDescription, string _ItemID)
        {
            ISalesPOSDBManager dbManager = new SalesPOSDBManager();
            DataTable dt = new DataTable();
            try
            {
                dbManager.Open();
                IDbDataParameter[] param = SalesPOSDBManagerFactory.GetParameters(dbManager.ProviderType, 7);

                param[0] = dbManager.getparam("@ItemCode", _ItemCode);
                param[1] = dbManager.getparam("@ProductSizeID", Convert.ToInt32(_ProductSizeID));
                param[2] = dbManager.getparam("@PID", _PID);                
                param[3] = dbManager.getparam("@RetailPrice", Convert.ToDecimal(_RetailPrice));
                param[4] = dbManager.getparam("@WholeSalePrice", Convert.ToDecimal(_WholeSalePrice));
                param[5] = dbManager.getparam("@ItemDescription", _ItemDescription);
                param[6] = dbManager.getparam("@ItemID", Convert.ToDecimal(_ItemID));
                IDbCommand cmd = dbManager.getCommand(CommandType.StoredProcedure, "dbo.[update_product_price_info]", param);

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
        public static DataTable getById(string ProductID)
        {
            ISalesPOSDBManager dbManager = new SalesPOSDBManager();
            DataTable dt = new DataTable();
            try
            {
                dbManager.Open();
                IDbDataParameter[] param = null;
                IDbCommand cmd = dbManager.getCommand(CommandType.Text, @"SELECT     PID, ProductName, FixedAsset, Issuable, SectionID, UnitId, WarrentyID, ActivityID,Vat
FROM         dbo.ProductInfo
WHERE     (PID = '"+ProductID+"')", param);
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
        public static string getProductID(string ProductName)
        {
            ISalesPOSDBManager dbManager = new SalesPOSDBManager();
            DataTable dt = new DataTable();
            string ProductID = "";
            try
            {
                dbManager.Open();
                IDbDataParameter[] param = null;
                IDbCommand cmd = dbManager.getCommand(CommandType.Text, @"Select ProductID From ProductInfo Where ProductName='"+ ProductName +"'", param);
                dt = dbManager.GetDataTable(cmd);
                if (dt.Rows.Count > 0)
                {
                    ProductID = dt.Rows[0][0].ToString();
                }
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
            return ProductID;
        }
        public static DataTable IsDuplicateProductName(string ProductID, string ProductName)//, string EventType)
        {
            ISalesPOSDBManager dbManager = new SalesPOSDBManager();
            DataTable dt = new DataTable();
            try
            {
                dbManager.Open();
                IDbDataParameter[] param = SalesPOSDBManagerFactory.GetParameters(dbManager.ProviderType, 2);
                param[0] = dbManager.getparam("@ProductID", ProductID);
                param[1] = dbManager.getparam("@ProductName", ProductName);
                //param[2] = dbManager.getparam("@EventType", EventType);
                IDbCommand cmd = dbManager.getCommand(CommandType.StoredProcedure, "dbo.USP_IsDuplicateProductName", param);
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
        public static DataTable InsertUpdate(ProductInfo objProductInfo)
        {
            ISalesPOSDBManager dbManager = new SalesPOSDBManager();
            DataTable dt = new DataTable();
            try
            {
                dbManager.Open();
                IDbDataParameter[] param = SalesPOSDBManagerFactory.GetParameters(dbManager.ProviderType, 10);
                param[0] = dbManager.getparam("@PID", objProductInfo.PID.ToString());
                param[1] = dbManager.getparam("@ProductName", objProductInfo.ProductName.ToString());                
                param[2] = dbManager.getparam("@SectionID", objProductInfo.SectionId);                
                param[3] = dbManager.getparam("@UnitId", objProductInfo.UnitID);
                param[4] = dbManager.getparam("@FixedAsset", objProductInfo.FixedAsset);
                param[5] = dbManager.getparam("@Issuable", objProductInfo.Issuable);
                param[6] = dbManager.getparam("@WarrentyID", Convert.ToInt32(objProductInfo.Warrenty.ToString()));
                param[7] = dbManager.getparam("@ActivityID", objProductInfo.ActivityID);
                param[8] = dbManager.getparam("@CreatedBy", objProductInfo.CreatedBy);
                param[9] = dbManager.getparam("@Vat", objProductInfo.Vat);

                IDbCommand cmd = dbManager.getCommand(CommandType.StoredProcedure, "[USP_ProductInfo_InsertUpdate]", param);
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
        public static DataTable getStockData(string _PID, string _ReportType)
        {
            ISalesPOSDBManager dbManager = new SalesPOSDBManager();
            DataTable dt = new DataTable();
            try
            {
                dbManager.Open();
                IDbDataParameter[] param = SalesPOSDBManagerFactory.GetParameters(dbManager.ProviderType, 2);
                param[0] = dbManager.getparam("@PID", _PID);
                param[1] = dbManager.getparam("@ReportType", _ReportType);         
                IDbCommand cmd = dbManager.getCommand(CommandType.StoredProcedure, "[USP_RptCurrentStock]", param);

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
        public static DataTable getProductInfo_WithoutFixedAsset()
        {
            ISalesPOSDBManager dbManager = new SalesPOSDBManager();
            DataTable dt = new DataTable();
            try
            {
                dbManager.Open();
                IDbDataParameter[] param = null;
                IDbCommand cmd = dbManager.getCommand(CommandType.StoredProcedure, "[getProductInfo_WithoutFixedAsset]", param);

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
        public static DataTable getProductInfo_FixedAsset()
        {
            ISalesPOSDBManager dbManager = new SalesPOSDBManager();
            DataTable dt = new DataTable();
            try
            {
                dbManager.Open();
                IDbDataParameter[] param = null;
                IDbCommand cmd = dbManager.getCommand(CommandType.StoredProcedure, "[getProductInfo_FixedAsset]", param);

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
