using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AssetInventory.BOL
{
    public class ProductInfo
    {
        #region attributes
        string _PID;
        public string PID
        {
            get
            {
                return _PID;
            }
            set
            {
                if (_PID == value)
                    return;
                _PID = value;
            }
        }
        string _ProductName;
        public string ProductName
        {
            get
            {
                return _ProductName;
            }
            set
            {
                if (_ProductName == value)
                    return;
                _ProductName = value;
            }
        }
        string _Description;
        public string Description
        {
            get
            {
                return _Description;
            }
            set
            {
                if (_Description == value)
                    return;
                _Description = value;
            }
        }
        long _SectionId;
        public long SectionId
        {
            get
            {
                return _SectionId;
            }
            set
            {
                if (_SectionId == value)
                    return;
                _SectionId = value;
            }
        }
        long _SubSectionID;
        public long SubSectionID
        {
            get
            {
                return _SubSectionID;
            }
            set
            {
                if (_SubSectionID == value)
                    return;
                _SubSectionID = value;
            }
        }
        long _UnitID;
        public long UnitID
        {
            get
            {
                return _UnitID;
            }
            set
            {
                if (_UnitID == value)
                    return;
                _UnitID = value;
            }
        }
        int _FixedAsset;
        public int FixedAsset
        {
            get
            {
                return _FixedAsset;
            }
            set
            {
                if (_FixedAsset == value)
                    return;
                _FixedAsset = value;
            }
        }
        string _AssetCode;
        public string AssetCode
        {
            get
            {
                return _AssetCode;
            }
            set
            {
                if (_AssetCode == value)
                    return;
                _AssetCode = value;
            }
        }
        int _Issuable;
        public int Issuable
        {
            get
            {
                return _Issuable;
            }
            set
            {
                if (_Issuable == value)
                    return;
                _Issuable = value;
            }
        }
        string _Warrenty;
        public string Warrenty
        {
            get
            {
                return _Warrenty;
            }
            set
            {
                if (_Warrenty == value)
                    return;
                _Warrenty = value;
            }
        }
        long _ActivityID;
        public long ActivityID
        {
            get
            {
                return _ActivityID;
            }
            set
            {
                if (_ActivityID == value)
                    return;
                _ActivityID = value;
            }
        }
        DateTime _UpdatedDate;
        public DateTime UpdatedDate
        {
            get
            {
                return _UpdatedDate;
            }
            set
            {
                if (_UpdatedDate == value)
                    return;
                _UpdatedDate = value;
            }
        }
        long _UpdatedBy;
        public long UpdatedBy
        {
            get
            {
                return _UpdatedBy;
            }
            set
            {
                if (_UpdatedBy == value)
                    return;
                _UpdatedBy = value;
            }
        }
        DateTime _CreatedDate;
        public DateTime CreatedDate
        {
            get
            {
                return _CreatedDate;
            }
            set
            {
                if (_CreatedDate == value)
                    return;
                _CreatedDate = value;
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
        string _Vat;
        public string Vat
        {
            get
            {
                return _Vat;
            }
            set
            {
                if (_Vat == value)
                    return;
                _Vat = value;
            }
        }
        string _UnitName;
        public string UnitName
        {
            get
            {
                return _UnitName;
            }
            set
            {
                if (_UnitName == value)
                    return;
                _UnitName = value;
            }
        }
        #endregion

    }
}
