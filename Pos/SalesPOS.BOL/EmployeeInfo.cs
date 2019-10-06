using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AssetInventory.BOL
{
    public class EmployeeInfo
    {
        #region _attributes
            string _EmployeeID;
            string _EmployeeName;
            string _FathersName;
            string _MothersName;
            string _DepartmentID;
            string _DesignationID;
            string _JoiningDate;
            string _BirthDate;
            string _PresentAddress;
            string _PermanentAddress;
            string _ContactNo;
            byte[] _Photo;
            string _Gender;
            string _MaritalStatus;
            string _ReferancePersonName;
            string _RelationshipWithRefPerson;
            string _ReferanceContactNo;
            string _Activity;
            string _UpdatedDate;
            string _UpdatedBy;
            string _CreatedDate;
            string _CreatedBy;
        #endregion
        
        #region _propertise

        public string EmployeeID
        {
            get {return _EmployeeID;}
            set { _EmployeeID=value;}
        }
        public string EmployeeName
        {
            get {return _EmployeeName;}
            set { _EmployeeName=value;}
        }
        public string FathersName
        {
            get {return _FathersName;}
            set { _FathersName=value;}
        }
        public string MothersName
        {
            get {return _MothersName;}
            set { _MothersName=value;}
        }
        public string DepartmentID
        {
            get {return _DepartmentID;}
            set { _DepartmentID=value;}
        }
        public string DesignationID
        {
            get {return _DesignationID;}
            set { _DesignationID=value;}
        }
        public string JoiningDate
        {
            get {return _JoiningDate;}
            set { _JoiningDate=value;}
        }
        public string BirthDate
        {
            get {return _BirthDate;}
            set { _BirthDate=value;}
        }
        public string PresentAddress
        {
            get {return _PresentAddress;}
            set { _PresentAddress=value;}
        }
        public string PermanentAddress
        {
            get {return _PermanentAddress;}
            set { _PermanentAddress=value;}
        }
        public string ContactNo
        {
            get {return _ContactNo;}
            set { _ContactNo=value;}
        }
        public byte[] Photo
        {
            get {return _Photo;}
            set { _Photo=value;}
        }
        public string Gender
        {
            get {return _Gender;}
            set { _Gender=value;}
        }
        public string MaritalStatus
        {
            get {return _MaritalStatus;}
            set { _MaritalStatus=value;}
        }
        public string ReferancePersonName
        {
            get { return _ReferancePersonName; }
            set { _ReferancePersonName = value; }
        }
        public string RelationshipWithRefPerson
        {
            get { return _RelationshipWithRefPerson; }
            set { _RelationshipWithRefPerson = value; }
        }
        public string ReferanceContactNo
        {
            get { return _ReferanceContactNo; }
            set { _ReferanceContactNo = value; }
        }
        public string Activity
        {
            get {return _Activity;}
            set { _Activity=value;}
        }
        public string UpdatedDate
        {
            get {return _UpdatedDate;}
            set { _UpdatedDate=value;}
        }
        public string UpdatedBy
        {
            get {return _UpdatedBy;}
            set { _UpdatedBy=value;}
        }
        public string CreatedDate
        {
            get {return _CreatedDate;}
            set { _CreatedDate=value;}
        }
        public string CreatedBy
        {
            get {return _CreatedBy;}
            set { _CreatedBy=value;}
        }

        #endregion

    }
}
