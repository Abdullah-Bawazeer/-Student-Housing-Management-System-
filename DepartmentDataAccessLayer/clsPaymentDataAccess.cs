using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DepartmentDataAccessLayer
{
    public class clsPaymentDataAccess
    {

        public static DataTable GettAllActiveStudent()
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSetting.ConnectionString);
            string Query = "select * from Students where Stutus = 1";
            SqlCommand command = new SqlCommand(Query, connection);
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

        public static DataTable GetAllStudentPayments()
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSetting.ConnectionString);
            string Query = "SELECT Payments.ID, Students.Name as Name, Payments.FoodPrice, Payments.PlacePrice, Payments.TotalPayment, " +
                    " Payments.Date FROM     Payments INNER JOIN Students ON Payments.StudentID = Students.ID  ";
            SqlCommand command = new SqlCommand(Query, connection);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
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

        public static DataTable GetAllStudentPaymentedInSpecficDate(int Year, int Month)
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSetting.ConnectionString);
            string Query = "SELECT Payments.ID, Students.Name as Name, Payments.FoodPrice, Payments.PlacePrice, Payments.TotalPayment, " +
                    " Payments.Date FROM     Payments INNER JOIN Students ON Payments.StudentID = Students.ID where  " +
                    " MONTH(Date) = @Month and Year(Date) = @Year "; 

            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@Year", Year);
            command.Parameters.AddWithValue("@Month", Month);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
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

        public static DataTable GetAllStudentWhichNotPaymented(int Year , int Month)
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSetting.ConnectionString);
            string Query = "  select ID, Name, 0 as FoodPrice , 0 as PlacePrice ,0 as TotalPayment ,null as Date " +
             " from Students where ID not in (select StudentID from Payments where  MONTH(Date) = @Month and Year(Date) = @Year) " ;
            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@Year", Year);
            command.Parameters.AddWithValue("@Month", Month);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
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
       

        //public static DataTable GetAllStudentWhichNotPaymented(string Filter = "")
        //{
        //    DataTable dt = new DataTable();
        //    SqlConnection connection = new SqlConnection(clsDataAccessSetting.ConnectionString);
        //    string Query = "SELECT  Students.ID, Students.Name as Name, 0 as FoodPrice  ,0 as PlacePrice,0 as TotalPayment, " +
        //            " 1-1-1999 as Date FROM Students where IsActive = 1 and   "  ;
        //    SqlCommand command = new SqlCommand(Query, connection);
        //    try
        //    {
        //        connection.Open();
        //        SqlDataReader reader = command.ExecuteReader();
        //        if (reader.HasRows)
        //        {
        //            dt.Load(reader);
        //        }
        //        reader.Close();
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine("error " + ex.Message);
        //    }
        //    finally
        //    {
        //        connection.Close();
        //    }
        //    return dt;
        //}

        public static bool AddNewPayment(int StudentID , decimal  FoodPrice ,decimal PlacePrice ,decimal TotalPayment ,DateTime Date)
        {
            int rowEffected = 0;
           
            SqlConnection connection = new SqlConnection(clsDataAccessSetting.ConnectionString);
            string Query = "INSERT INTO Payments (StudentID ,FoodPrice,PlacePrice,TotalPayment ,Date) VALUES " +
            " (@StudentID, @FoodPrice,@PlacePrice, @TotalPayment ,@Date)";
            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@StudentID", StudentID);
            command.Parameters.AddWithValue("@FoodPrice", FoodPrice);
            command.Parameters.AddWithValue("@PlacePrice", PlacePrice);
            command.Parameters.AddWithValue("@TotalPayment", TotalPayment);
            command.Parameters.AddWithValue("@Date", Date);
            try
            {
                connection.Open();
                rowEffected  = command.ExecuteNonQuery();
                
            }
            catch (Exception ex)
            {
                Console.WriteLine("error " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return rowEffected > 0;
        }
    }
}
