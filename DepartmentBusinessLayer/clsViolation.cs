using DepartmentDataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DepartmentBusinessLayer
{
    public class clsViolation
    {
        enum eMode { addNew = 0, Update = 1   }
        eMode Mode;

        public int ID { get; set; }
        public int StudentID { get; set; }
        public int ViolationID { get; set; }
        public DateTime ViolationDate { get; set; }
        public string ViolationDescription { get; set; }
     

        public clsViolation()
        {
            StudentID = 0;
            ViolationID = 0;
            ViolationDate = DateTime.Now;
            ViolationDescription = "";
            
        }

        public clsViolation(int ID, int StudentID, int ViolationID, DateTime ViolationDate, string ViolationDescription)
        {
            this.ID = ID;
            this.StudentID = StudentID;
            this.ViolationID = ViolationID;
            this.ViolationDate = ViolationDate;
            this.ViolationDescription = ViolationDescription; 
        }
        public static DataTable GetViolationsListCmbData()
        {
            return clsVailoationsDataAccess.GetViolationsListCmbData();
        }

        //public static DataTable GetAllExpenseData()
        //{
        //    DataTable dt = new DataTable();
        //    dt = clsExpenseDataAccesscs.GetAllExpenseData();
        //    return dt;
        //}

        public static bool DeleteViolation(int ID)
        {
            return clsVailoationsDataAccess.DeleteViolation(ID);
        }

        public static DataTable GetAllDataGridInfo()
        {
            return clsVailoationsDataAccess.GetAllDataGridInfo();
        }

        public static DataTable GetAllDataGridInfoFiltered(string Filter)
        {
            return clsVailoationsDataAccess.GetAllDataGridInfo(Filter);
        }

        public static DataTable GetAllStudentViloationsByID(int ID)
        {
            return clsVailoationsDataAccess.GetAllStudentViloationsByID(ID);
        }
        public static clsViolation FindViolationById(int ID)
        {
            int StudentID=0, ViolationID = 0;
            DateTime ViolationDate = DateTime.Now;
            string ViolationDescription = "";
            if (clsVailoationsDataAccess.FindViolationById(ID ,ref StudentID,ref ViolationID,ref ViolationDate,ref ViolationDescription))
            {
                return new clsViolation(ID, StudentID, ViolationID, ViolationDate, ViolationDescription);
            }
            return null;
        }

        public static string GetViolationNameById(int ID)
        {
            return clsVailoationsDataAccess.GetViolationNameById(ID);
        }

        bool _AddNewViolation()
        {
            this.ID = clsVailoationsDataAccess.AddNewViolation(this.StudentID, this.ViolationID, this.ViolationDate, this.ViolationDescription);
            return this.ID > -1;
        }

        bool _UpdateViolation()
        {
            return clsVailoationsDataAccess.UpdateViolation(this.StudentID, this.ViolationID, this.ViolationDate, this.ViolationDescription);
        }
        public static DataTable GetReportYearsData()
        {
            return clsVailoationsDataAccess.GetReportYearsData();
        }
        public static DataTable GetReportYearsDataFiltered(string Filter = "")
        {
            return clsVailoationsDataAccess.GetReportYearsData(Filter);
        }

        public bool Save()
        {
            switch (Mode)
            {
                case eMode.addNew:
                    if (_AddNewViolation())
                    {
                        Mode = eMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                    break;
                case eMode.Update:
                    return _UpdateViolation();
            }
            return false;
        }
    }
}
