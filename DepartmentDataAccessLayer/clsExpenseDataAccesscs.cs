using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DepartmentDataAccessLayer
{
    public class clsExpenseDataAccesscs
    {

        public static DataTable GetAllExpenseData()
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSetting.ConnectionString);
            string query = "select * from Expenses";
            SqlCommand command = new SqlCommand(query, connection);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if(reader.Read())
                {
                    dt.Load(reader);
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("error " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return dt;
        }

        public static int AddNewItem(string ItemName , decimal Price , int Amount , string BuyerName ,
                                     DateTime BuyDate ,decimal TotalPrice)
        {
            int RowEffected = -1;
            SqlConnection connection = new SqlConnection(clsDataAccessSetting.ConnectionString);
            string query = "INSERT INTO Expenses(ItemName ,Price ,Amount,BuyerName ,BuyDate,TotalPrice)values" +
                "(@ItemName ,@Price ,@Amoun ,@BuyerName ,@BuyDate,@TotalPrice)";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ItemName", ItemName);
            command.Parameters.AddWithValue("@Price", Price);
            command.Parameters.AddWithValue("@Amoun", Amount);
            command.Parameters.AddWithValue("@BuyerName", BuyerName);
            command.Parameters.AddWithValue("@BuyDate", BuyDate);
            command.Parameters.AddWithValue("@TotalPrice", TotalPrice);

            try
            {
                connection.Open();
                RowEffected  = command.ExecuteNonQuery();
                
            }
            catch (Exception ex)
            {
                Console.WriteLine("error " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return RowEffected;
        }

        public static bool DeleteItem(int ID)
        {
            int rowEfeccted = 0;
            SqlConnection connection = new SqlConnection(clsDataAccessSetting.ConnectionString);
            string Query = "delete Expenses where ID =@ID";
            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@ID", ID);

            try
            {
                connection.Open();
                rowEfeccted = command.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                Console.WriteLine("error " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return rowEfeccted > 0;
        }

        public static bool UpdateItem(int ID , string ItemName, decimal Price, int Amount, string BuyerName,
                                      DateTime BuyDate, decimal TotalPrice)
        {
            int rowEffiected = -1;
            SqlConnection connection = new SqlConnection(clsDataAccessSetting.ConnectionString);
            string query = "UPDATE Expenses SET ItemName =@ItemName, Price =@Price," +
                "Amount=@Amount, BuyerName=@BuyerName, BuyDate=@BuyDate, TotalPrice=@TotalPrice where ID =@ID";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ID", ID);
            command.Parameters.AddWithValue("@ItemName", ItemName);
            command.Parameters.AddWithValue("@Price", Price);
            command.Parameters.AddWithValue("@Amount", Amount);
            command.Parameters.AddWithValue("@BuyerName", BuyerName);
            command.Parameters.AddWithValue("@BuyDate", BuyDate);
            command.Parameters.AddWithValue("@TotalPrice", TotalPrice);

            try
            {
                connection.Open();
                rowEffiected = command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                Console.WriteLine("error " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return rowEffiected > 0;
        }

        public static bool FindBillsById(int ID ,ref string ItemName,ref decimal Price,ref int Amount,
             ref string BuyerName, ref DateTime BuyDate,ref decimal TotalPrice)
        {
            bool IsFound = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSetting.ConnectionString);
            string query = "Select * from Expenses where ID=@ID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ID", ID);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if(reader.Read())
                {
                    IsFound = true;
                    ItemName = (String)reader["ItemName"];
                    Price = (Decimal)reader["Price"];
                    Amount = (int)reader["Amount"];
                    BuyerName = (String)reader["BuyerName"];
                    BuyDate = (DateTime)reader["BuyDate"];
                    TotalPrice = (decimal)reader["TotalPrice"];
                }
                reader.Close();

            }
            catch(Exception ex)
            {
                IsFound=false;
                Console.WriteLine("error " + ex.Message);
            }
            finally {
                connection.Close(); 
            }
            return IsFound;
        }
    }
}
