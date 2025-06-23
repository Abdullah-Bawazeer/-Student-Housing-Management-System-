using DepartmentDataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DepartmentBusinessLayer
{
    public class clsStudent
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public DateTime BirthDay { get; set; }
        public string phoneNumber { get; set; }
        public string whatsappNumber { get; set; }
        public string FatherName { get; set; }
        public string FatherNumber { get; set; }
        public string PlaceLiving { get; set; }
        public bool Status { get; set; }
        public int MajorId { get; set; }
        public int UniverstyId { get; set; }
        public int CurrentLevelId { get; set; }
        public int TimeStudyId { get; set; }
        public string Picture { get; set; }
        public string Identity { get; set; }
        public string proofRegistration { get; set; }
        public string formImage { get; set; }

        enum enMode {eAddNew = 0 , eUpdate =1}
        enMode Mode;
        public clsStudent()
        {
            this.Id = -1;
            this.FullName = "";
            this.BirthDay =DateTime.Now;
            this.phoneNumber = "";
            this.whatsappNumber = "";
            this.FatherName = "";
            this.FatherNumber = "";
            this.PlaceLiving = "";
            this.Status = true;
            this.MajorId = 0;
            this.UniverstyId = 0;
            this.CurrentLevelId = 0;
            this.TimeStudyId = 0;
            this.Picture = "";
            this.Identity = "";
            this.proofRegistration = "";
            this.formImage = "";
            this.Mode = enMode.eAddNew;
        }

        private clsStudent(int Id,string FullName ,DateTime BirthDay ,string phoneNumber ,string whatsappNumber ,
          string FatherName ,string FatherNumber , string PlaceLiving , bool SocialStatus , int MajorId , int UniverstyId
            ,int CurrentLevelId , int TimeStudyId , string Picture , string Identity , string proofRegistration , string form)
        {
            this.Id =Id ;
            this.FullName = FullName;
            this.BirthDay = BirthDay;
            this.phoneNumber = phoneNumber;
            this.whatsappNumber = whatsappNumber;
            this.FatherName = FatherName;
            this.FatherNumber = FatherNumber;
            this.PlaceLiving = PlaceLiving;
            this.Status = SocialStatus;
            this.MajorId = MajorId;
            this.UniverstyId = UniverstyId;
            this.CurrentLevelId = CurrentLevelId;
            this.TimeStudyId = TimeStudyId;
            this.Picture = Picture;
            this.Identity = Identity;
            this.proofRegistration = proofRegistration;
            this.formImage = form;
            this.Mode = enMode.eUpdate;
        }

        public static DataTable GetAllStudent()
        {
            return clsStudentData.GetAllStudent();
        }

        //public static DataTable GetAllStudentBySerach(string Filter)
        //{
        //    return clsStudentData.GetAllStudentBySerach(Filter);
        //}
        public static DataTable GetDataGridStudentInfo(string Filter ="")
        {
            return clsStudentData.GetDataGridStudentInfo(Filter);
        }

        public static DataTable GetWhatDoYouWhantCmbData(string TypeData)
        {
            return clsStudentData.GetWhatDoYouWhantCmbData(TypeData);
        }

        public static int GetIdValueForCmbBoxItem(string TableName, string ColumnName, string combValue)
        {
            return clsStudentData.GetIdValueForCmbBoxItem(TableName, ColumnName, combValue);
        }

        public static string GetItemNameByItemID(int ID, string TableName, string ColumnName)
        {
            return clsStudentData.GetItemNameByItemID((int)ID, TableName, ColumnName);
        }

        public static int GetIdStudentByName(string Name)
        {
            return clsStudentData.GetIdStudentByName(Name);
        }

        public static string GetStudentNameById(int ID)
        {
            return clsStudentData.GetStudentNameByItemID(ID);
        } 

        public static clsStudent FindStudentById(int Id)
        {
            int ID = Id; string FullName = ""; DateTime DateOfBirth = DateTime.Now; string phoneNumber = "", whatsappNumber = "",
           FatherName = "", FatherNumber = "", PlaceLiving = "" ; int MajorId = 0; int UniverstyId = 0
            , CurrentLevelId = 0, TimeStudyId = 0 ; string Picture = "", Identity = "", proofRegistration = "", form = "";
            bool SocialStatus = true;

            if (clsStudentData.FindStudentById( ID, ref FullName, ref DateOfBirth, ref phoneNumber, ref whatsappNumber,
           ref FatherName, ref FatherNumber, ref PlaceLiving, ref SocialStatus, ref MajorId, ref UniverstyId
            , ref CurrentLevelId, ref TimeStudyId, ref Picture, ref Identity, ref proofRegistration, ref form))
            {
                return new clsStudent (ID,  FullName,  DateOfBirth,  phoneNumber,  whatsappNumber,
            FatherName,  FatherNumber,  PlaceLiving,  SocialStatus,  MajorId,  UniverstyId
            ,  CurrentLevelId,  TimeStudyId,  Picture,  Identity,  proofRegistration,  form);
            }
            return null;
        }

        private bool _UpdateStudent()
        {
            return clsStudentData.UpdateStudent(this.Id , this.FullName ,this.BirthDay ,this.phoneNumber ,this.whatsappNumber
                ,this.FatherName , this.FatherNumber , this.PlaceLiving , this.Status, this.MajorId , this.UniverstyId
                ,this.CurrentLevelId ,this.TimeStudyId , this.Picture ,this.Identity ,this.proofRegistration ,this.formImage);

        }

        private bool _AddNewStudent()
        {
            this.Id = clsStudentData.AddNewStudent(this.FullName, this.BirthDay, this.phoneNumber, this.whatsappNumber
                 , this.FatherName, this.FatherNumber, this.PlaceLiving, this.Status, this.MajorId, this.UniverstyId
                 , this.CurrentLevelId, this.TimeStudyId, this.Picture, this.Identity, this.proofRegistration, this.formImage);
            return this.Id > -1;
        }

        public static bool DeleteStudent(int ID)
        {
            return clsStudentData.DeleteStudent(ID);
        }

        public bool Save()
        {
            switch (Mode)
            {
                case enMode.eAddNew:
                    if (_AddNewStudent())
                    {
                        Mode = enMode.eUpdate;
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                    break;
                case enMode.eUpdate:
                    return _UpdateStudent();
            }
            return false;

        }
    }

  

    //private bool _UpdateStudent(int ID, string FullName, DateTime DateOfBirth, string phoneNumber, string whatsappNumber,
    //     string FatherName, string FatherNumber, string PlaceLiving, string Status, int MajorId, int UniverstyId
    //    , int LevelId, int PeriodId, string PersonalPicture, string Identity, string proofRegistration, string formImage)
    //{
    //    return clsStudentData.UpdateStudent(ID,FullName,DateOfBirth,phoneNumber,whatsappNumber,
    //     FatherName,FatherNumber,PlaceLiving,Status,MajorId,UniverstyId
    //    , LevelId,PeriodId,PersonalPicture,Identity,proofRegistration,formImage);
    //}
}
