using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AssetInventory.BOL
{
    public class SalesChild
    {
        private string _SalesMasterID;
		private string _ItemCode;
        private string _ProductSizeID;
        private string _Manufacturer;
		private string _SalesQuantity;
		private string _UnitSalesPrice;
		private string _UnitCostPrice;
		private string _VatRate;
		private string _WarrentyID;
		private string _SerialNo;
		private string _StoreID;

        public string SalesMasterID
        {
            get
            {
                return _SalesMasterID;
            }
            set
            {
                if (_SalesMasterID == value)
                    return;
                _SalesMasterID = value;
            }
        }
        
        public string ProductSizeID
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

        public string SalesQuantity
        {
            get
            {
                return _SalesQuantity;
            }
            set
            {
                if (_SalesQuantity == value)
                    return;
                _SalesQuantity = value;
            }
        }

        public string UnitSalesPrice
        {
            get
            {
                return _UnitSalesPrice;
            }
            set
            {
                if (_UnitSalesPrice == value)
                    return;
                _UnitSalesPrice = value;
            }
        }
        public string UnitCostPrice
        {
            get
            {
                return _UnitCostPrice;
            }
            set
            {
                if (_UnitCostPrice == value)
                    return;
                _UnitCostPrice = value;
            }
        }
        public string VatRate
        {
            get
            {
                return _VatRate;
            }
            set
            {
                if (_VatRate == value)
                    return;
                _VatRate = value;
            }
        }
        public string WarrentyID
        {
            get
            {
                return _WarrentyID;
            }
            set
            {
                if (_WarrentyID == value)
                    return;
                _WarrentyID = value;
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
        public string StoreID
        {
            get
            {
                return _StoreID;
            }
            set
            {
                if (_StoreID == value)
                    return;
                _StoreID = value;
            }
        }
    }
}
