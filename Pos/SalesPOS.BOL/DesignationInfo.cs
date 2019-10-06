using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AssetInventory.BOL
{
    public class DesignationInfo
    {
        #region _attributes

        private string _DepartmentID;
        private string _DesignationID;
        private string _DesignationName;
        private string _ActivityID;
        private string _UpdatedDate;
        private string _UpdatedBy;
        private string _CreatedDate;
        private string _CreatedBy;

        #endregion


        #region _propertise

        public string DepartmentID
        {

            get { return _DepartmentID; }
            set { _DepartmentID = value; }

        }
        public string DesignationID
        {

            get { return _DesignationID; }
            set { _DesignationID = value; }

        }
        public string DesignationName
        {

            get { return _DesignationName; }
            set { _DesignationName = value; }

        }
        public string ActivityID
        {

            get { return _ActivityID; }
            set { _ActivityID = value; }

        }
        public string UpdatedDate
        {

            get { return _UpdatedDate; }
            set { _UpdatedDate = value; }

        }
        public string UpdatedBy
        {

            get { return _UpdatedBy; }
            set { _UpdatedBy = value; }

        }
        public string CreatedDate
        {

            get { return _CreatedDate; }
            set { _CreatedDate = value; }

        }
        public string CreatedBy
        {

            get { return _CreatedBy; }
            set { _CreatedBy = value; }

        }


        #endregion
    }
}
