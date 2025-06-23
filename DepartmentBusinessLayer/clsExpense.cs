using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DepartmentDataAccessLayer;

namespace DepartmentBusinessLayer
{
    public class clsExpense
    {
        enum eMode {addNew = 0, Update = 1}
        eMode Mode;

        public int ID { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Amount { get; set; }
        public decimal TotalPrice { get; set; }
        public string BuyerName { get; set; }
        public DateTime BuyDate { get; set; }

        public clsExpense()
        {
            Name = "";
            Price = 0;
            Amount = 0;
            TotalPrice = 0;
            BuyDate = DateTime.Now;
            BuyerName = "";
            Mode = eMode.addNew;
        }

        public clsExpense(int ID , string Name , decimal Price , int Amount , decimal TotalPrice , 
                                   string BuyerName, DateTime BuyDate)
        {
            this.ID = ID;
            this.Name = Name;
            this.Price = Price;
            this.Amount = Amount;
            this.TotalPrice = TotalPrice;
            this.BuyDate = BuyDate;
            this.BuyerName = BuyerName;
            this.Mode = eMode.Update;
        }

        public static DataTable GetAllExpenseData()
        {
            DataTable dt = new DataTable();
            dt = clsExpenseDataAccesscs.GetAllExpenseData();
            return dt;
        }

        public static bool DeleteBills(int ID)
        {
            return clsExpenseDataAccesscs.DeleteItem(ID);
        }

        public static clsExpense FindBillById(int Id)
        {
            int ID = Id; string Name = ""; decimal Price = 0; int Amount = 0; decimal TotalPrice = 0;
            string BuyerName = ""; DateTime BuyDate = DateTime.Now;
            if(clsExpenseDataAccesscs.FindBillsById( ID, ref  Name, ref Price, ref Amount,
             ref BuyerName, ref BuyDate, ref TotalPrice))
            {
                return new  clsExpense( ID,  Name,  Price,  Amount,  TotalPrice,
                                    BuyerName, BuyDate);
            }
            return null;
        }

        bool _AddNewBills()
        {
            this.ID = clsExpenseDataAccesscs.AddNewItem(this.Name, this.Price, this.Amount, this.BuyerName,
                                     this.BuyDate, this.TotalPrice);
            return this.ID > -1;
        }

        bool _UpdateBills()
        {
            return clsExpenseDataAccesscs.UpdateItem(this.ID ,this.Name, this.Price, this.Amount, this.BuyerName,
                                     this.BuyDate, this.TotalPrice);
        }

        public bool Save()
        {
            switch(Mode)
            {
                case eMode.addNew:
                    if(_AddNewBills())
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
                   return _UpdateBills();
            }
            return false;
        }
    }
}
