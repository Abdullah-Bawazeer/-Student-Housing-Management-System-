using DepartmentDataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DepartmentBusinessLayer
{
    public class clsUser
    {
        enum eMode { eAdd = 0 , eUpdate = 1 };
        eMode Mode;
        clsUser _User;
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public int Permmions { get; set; }

        public clsUser()
        {
            UserName = "";
            Password = "";
            Permmions = 0;
            Mode = eMode.eAdd;
        }

        public clsUser(string UserName , string Password , int Permmions)
        {
            this.UserName =UserName;
            this.Password = Password;
            this.Permmions = Permmions;
            Mode = eMode.eUpdate;
        }

        public static bool FindUserByUserNameAndPassword(string userName, string password)
        {
            return clsUserData.FindUserByUserNameAndPassword(userName, password);
        }

        public static clsUser FindUserByID(int ID)
        {
            string UserName="" , Password="" ;
            int Permmions = 0;
            if(clsUserData.FindUserByID(ID ,ref UserName, ref Password ,ref Permmions))
            {
                return new clsUser(UserName , Password , Permmions);
            }
            return null;
        }


        public static DataTable GetAllUsers()
        {

            DataTable DtNew = new DataTable();
            DtNew.Columns.Add("ID", typeof(int));
            DtNew.Columns.Add("UserName", typeof(string));
            DtNew.Columns.Add("Password", typeof(string));
            DtNew.Columns.Add("StudentMangement", typeof(bool));
            DtNew.Columns.Add("UsersMangement", typeof(bool));
            DtNew.Columns.Add("ExpensesMangement", typeof(bool));
            DtNew.Columns.Add("ActivitiesMangement", typeof(bool));
            DtNew.Columns.Add("VioltionsMangement", typeof(bool));

            int ID, Permmions;
            string UserName, Password;
            bool StudentMangement, UsersMangement, ExpensesMangement, ActivitiesMangement, VioltionsMangement = false;

            DataTable dt = new DataTable();
            dt = clsUserData.GetAllUsers();

            foreach (DataRow dr in dt.Rows)
            {
                ID = (int)dr["ID"];
                UserName = (string)dr["UserName"];
                Password = (string)dr["Password"];
                Permmions = (int)dr["Permmions"];
                if ((Permmions & 1) == 1)
                {
                    StudentMangement = true;
                }
                else
                {
                    StudentMangement = false;
                }
                /////////////////////////
                if ((Permmions & 2) == 2)
                {
                    UsersMangement = true;
                }
                else
                {
                    UsersMangement = false;
                }
                ////////////////////
                if ((Permmions & 4) == 4)
                {
                    ExpensesMangement = true;
                }
                else
                {
                    ExpensesMangement = false;
                }
                ///////////////////////
                if ((Permmions & 8) == 8)
                {
                    ActivitiesMangement = true;
                }
                else
                {
                    ActivitiesMangement = false;
                }
                ///////////////////////
                if ((Permmions & 16) == 16)
                {
                    VioltionsMangement = true;
                }
                else
                {
                    VioltionsMangement = false;
                }
                DtNew.Rows.Add(ID, UserName, Password, StudentMangement, UsersMangement, ExpensesMangement, ActivitiesMangement, VioltionsMangement);
            }
            return DtNew;
        }

        private bool _AddNewUser()
        {
            if(clsUserData.AddNewUser(this.UserName , this.Password ,this.Permmions) > 0)
            {
                return true;
            }
            return false;
        }
        private bool _UpdateUser()
        {
            return clsUserData.UpdateUser(this.Id ,this.UserName, this.Password, this.Permmions);
        }

        public static bool DeleteUser(int ID)
        {
            return clsUserData.DeleteUser(ID);
        }

        public bool Save()
        {
            switch(Mode)
            {
                case eMode.eAdd:
                    if(_AddNewUser())
                    {
                        Mode = eMode.eAdd;
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                    break;
                case eMode.eUpdate:
                    return _UpdateUser();
            }
            return false;
        }
    }
}



