using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AssetInventory.BOL
{
    public class SaleMaster
    {
        private string _SalesType;	
	    private string _CustomerID;
	    private string _SalemanID;
	    private string _CustomerAddress;
	    private string _SalesAmount;
	    private string _TerminalID;
        private string _CreatedBy;
        private string _CashPaid;
        private string _CustomerName;
        private string _CustomerPhone;
        private string _VehicleNo;
        private string _PO_Number;
        
        public string PO_Number
        {
            get
            {
                return _PO_Number;
            }
            set
            {
                if (_PO_Number == value)
                    return;
                _PO_Number = value;
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
        public string CustomerPhone
        {
            get
            {
                return _CustomerPhone;
            }
            set
            {
                if (_CustomerPhone == value)
                    return;
                _CustomerPhone = value;
            }
        }

        public string CashPaid
        {
            get
            {
                return _CashPaid;
            }
            set
            {
                if (_CashPaid == value)
                    return;
                _CashPaid = value;
            }
        }

        public string SalesType
        {
            get
            {
                return _SalesType;
            }
            set
            {
                if (_SalesType == value)
                    return;
                _SalesType = value;
            }
        }

        public string CustomerID
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
        public string SalemanID
        {
            get
            {
                return _SalemanID;
            }
            set
            {
                if (_SalemanID == value)
                    return;
                _SalemanID = value;
            }
        }
        public string CustomerAddress
        {
            get
            {
                return _CustomerAddress;
            }
            set
            {
                if (_CustomerAddress == value)
                    return;
                _CustomerAddress = value;
            }
        }
        public string SalesAmount
        {
            get
            {
                return _SalesAmount;
            }
            set
            {
                if (_SalesAmount == value)
                    return;
                _SalesAmount = value;
            }
        }
        public string TerminalID
        {
            get
            {
                return _TerminalID;
            }
            set
            {
                if (_TerminalID == value)
                    return;
                _TerminalID = value;
            }
        }
        public string CreatedBy
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
    }
}
