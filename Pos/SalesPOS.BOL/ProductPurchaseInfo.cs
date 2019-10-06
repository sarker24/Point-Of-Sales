using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AssetInventory.BOL
{
    public class ProductPurchaseInfo
    {
        #region _attributes

        string _TransactionType;
        public string TransactionType
        {
            get
            {
                return _TransactionType;
            }
            set
            {
                if (_TransactionType == value)
                    return;
                _TransactionType = value;
            }
        }
        string _SupplierID;
        public string SupplierID
        {
            get
            {
                return _SupplierID;
            }
            set
            {
                if (_SupplierID == value)
                    return;
                _SupplierID = value;
            }
        }

        DateTime _TransactionDate;
        public DateTime TransactionDate
        {
            get
            {
                return _TransactionDate;
            }
            set
            {
                if (_TransactionDate == value)
                    return;
                _TransactionDate = value;
            }
        }
        string _MemoNo;
        public string MemoNo
        {
            get
            {
                return _MemoNo;
            }
            set
            {
                if (_MemoNo == value)
                    return;
                _MemoNo = value;
            }
        }
        string _AccountNo;
        public string AccountNo
        {
            get
            {
                return _AccountNo;
            }
            set
            {
                if (_AccountNo == value)
                    return;
                _AccountNo = value;
            }
        }
        long _CreatedBy;
        public long CreatedBy
        {
            get
            {
                return _CreatedBy;
            }
            set
            {
                if (_CreatedBy == value)
                    return;
                _CreatedBy = value;
            }
        }
        string _TotalPrice;
        public string TotalPrice
        {
            get
            {
                return _TotalPrice;
            }
            set
            {
                if (_TotalPrice == value)
                    return;
                _TotalPrice = value;
            }
        }
        #endregion
    }
}
