using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AssetInventory.BOL
{
    public class WarrentyService
    {

        #region _attributes

        string _ServiceNumber;
        Int32 _ProductSizeID;
        string _Manufacturer;
        string _SerialNo;
        bool _IsWarrentyApplicable;
        bool _IsNewFareAdded;
        string _Status;
        string _VehicleNo;
        Int32 _CustomerID;
        string _CustomerName;
        string _Address;
        DateTime _WarrentyExpiredDate;
        double _TotalServiceAmount;
        double _DiscountAmount;
        double _PaidAmount;
        string _ReadyForGatePass;
        bool _IsPaid;
        long _CreatedBy;

        #endregion


        #region _propertise
        public string ServiceNumber
        {
            get
            {
                return _ServiceNumber;
            }
            set
            {
                if (_ServiceNumber == value)
                    return;
                _ServiceNumber = value;
            }
        }
        public Int32 ProductSizeID
        {
            get
            {
                return _ProductSizeID;
            }
            set
            {
                if (_ProductSizeID == value)
                    return;
                _ProductSizeID = value;
            }
        }
        public string Manufacturer
        {
            get
            {
                return _Manufacturer;
            }
            set
            {
                if (_Manufacturer == value)
                    return;
                _Manufacturer = value;
            }
        }
        public string SerialNo
        {
            get
            {
                return _SerialNo;
            }
            set
            {
                if (_SerialNo == value)
                    return;
                _SerialNo = value;
            }
        }
        public bool IsWarrentyApplicable
        {
            get
            {
                return _IsWarrentyApplicable;
            }
            set
            {
                if (_IsWarrentyApplicable == value)
                    return;
                _IsWarrentyApplicable = value;
            }
        }
        public bool IsNewFareAdded
        {
            get
            {
                return _IsNewFareAdded;
            }
            set
            {
                if (_IsNewFareAdded == value)
                    return;
                _IsNewFareAdded = value;
            }
        }
        public string Status
        {
            get
            {
                return _Status;
            }
            set
            {
                if (_Status == value)
                    return;
                _Status = value;
            }
        }
        public string VehicleNo
        {
            get
            {
                return _VehicleNo;
            }
            set
            {
                if (_VehicleNo == value)
                    return;
                _VehicleNo = value;
            }
        }
        public Int32 CustomerID
        {
            get
            {
                return _CustomerID;
            }
            set
            {
                if (_CustomerID == value)
                    return;
                _CustomerID = value;
            }
        }
        public string CustomerName
        {
            get
            {
                return _CustomerName;
            }
            set
            {
                if (_CustomerName == value)
                    return;
                _CustomerName = value;
            }
        }
        public string Address
        {
            get
            {
                return _Address;
            }
            set
            {
                if (_Address == value)
                    return;
                _Address = value;
            }
        }
        public DateTime WarrentyExpiredDate
        {
            get
            {
                return _WarrentyExpiredDate;
            }
            set
            {
                if (_WarrentyExpiredDate == value)
                    return;
                _WarrentyExpiredDate = value;
            }
        }
        public double TotalServiceAmount
        {
            get
            {
                return _TotalServiceAmount;
            }
            set
            {
                if (_TotalServiceAmount == value)
                    return;
                _TotalServiceAmount = value;
            }
        }
        public double DiscountAmount
        {
            get
            {
                return _DiscountAmount;
            }
            set
            {
                if (_DiscountAmount == value)
                    return;
                _DiscountAmount = value;
            }
        }
        public double PaidAmount
        {
            get
            {
                return _PaidAmount;
            }
            set
            {
                if (_PaidAmount == value)
                    return;
                _PaidAmount = value;
            }
        }
        public string ReadyForGatePass
        {
            get
            {
                return _ReadyForGatePass;
            }
            set
            {
                if (_ReadyForGatePass == value)
                    return;
                _ReadyForGatePass = value;
            }
        }
        public bool IsPaid
        {
            get
            {
                return _IsPaid;
            }
            set
            {
                if (_IsPaid == value)
                    return;
                _IsPaid = value;
            }
        }
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

        #endregion
    }
}
