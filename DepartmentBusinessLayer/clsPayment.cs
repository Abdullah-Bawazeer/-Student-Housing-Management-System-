using DepartmentDataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DepartmentBusinessLayer
{
    public class clsPayment
    {
        public int ID { get; set; }
        public int StudentID { get; set; }
        public decimal FoodPrice { get; set; }
        public decimal PlcaePrice { get; set; }
        public decimal TotalPayment { get; set; }
        public DateTime Date { get; set; }

        public clsPayment()
        {
            StudentID = 0;
            FoodPrice = 0;
            PlcaePrice = 0;
            TotalPayment = 0;
            Date = DateTime.Now;
        }

        public static DataTable GetAllActiveStudent()
        {
            return clsPaymentDataAccess.GettAllActiveStudent();
        }

        public bool AddNewPayment()
        {
            return clsPaymentDataAccess.AddNewPayment(this.StudentID ,this.FoodPrice,this.PlcaePrice,this.TotalPayment,this.Date);
        }

        public static DataTable GetAllStudentWhichPaymented()
        {
            return clsPaymentDataAccess.GetAllStudentPayments();
        }

        public static DataTable GetAllStudentPaymentedInSpecficDate(int Year, int month)
        {
            return clsPaymentDataAccess.GetAllStudentPaymentedInSpecficDate(Year, month);
        }

        public static DataTable GetAllStudentWhichNotPaymented(int Year , int month)
        {
            return clsPaymentDataAccess.GetAllStudentWhichNotPaymented(Year , month);
        }


    }
}
