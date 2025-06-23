using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;

namespace DepartmentDataAccessLayer
{
    public class clsUserData
    {
        public static bool FindUserByUserNameAndPassword(string userName, string password)
        {
            bool IsFound = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSetting.ConnectionString);
            string Query = "Select* from Users where UserName=@UserName and Password =@Password";
            SqlCommand command = new SqlCommand(Query ,connection);
            command.Parameters.AddWithValue("@UserName", userName);
            command.Parameters.AddWithValue("@Password", password);

            try
            {
                connection.Open();
                SqlDataReader readr = command.ExecuteReader();
                if(readr.Read())
                {
                    IsFound = true;
                }
                else
                {
                    IsFound = false;
                }
                readr.Close();

            }
            catch (Exception ex)
            {
                IsFound = false;
                Console.WriteLine("error " + ex.Message);
                
            }
            finally
            {
                connection.Close();
            }
            return IsFound;
        }

        public static bool FindUserByID(int ID ,ref string UserName ,ref string Password ,ref int Permmions)
        {
            bool IsFound = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSetting.ConnectionString);
            string Query = "Select* from Users where ID=@ID";
            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@ID", ID);

            try
            {
                connection.Open();
                SqlDataReader readr = command.ExecuteReader();
                if (readr.Read())
                {
                    UserName = (string)readr["UserName"];
                    Password = (string)readr["Password"];
                    Permmions = (int)readr["Permmions"];
                    IsFound = true;
                }
                else
                {
                    IsFound = false;
                }
                readr.Close();

            }
            catch (Exception ex)
            {
                IsFound = false;
                Console.WriteLine("error " + ex.Message);

            }
            finally
            {
                connection.Close();
            }
            return IsFound;
        }

        public static DataTable GetAllUsers ()
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSetting.ConnectionString);
            string Query = "Select* from Users";
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

        public static int AddNewUser(string UserName, string Password , int Permisstions)
        {
            int UserID = -1;
            SqlConnection connection = new SqlConnection (clsDataAccessSetting.ConnectionString);
            string query = "insert into Users (UserName , Password , Permmions) values (@UserName ,@Password,@Permisstions)";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@UserName", UserName);
            command.Parameters.AddWithValue("@Password", Password);
            command.Parameters.AddWithValue("@Permisstions", Permisstions);
            try
            {
                connection.Open ();
                UserID = command.ExecuteNonQuery();
               
            }
            catch (Exception ex)
            {
                Console.WriteLine("error " + ex.Message);
            }
            finally
            {
                connection.Close ();
            }
            return UserID;
        }

        public static bool DeleteUser(int ID)
        {
            int RowEfficted = 0;
            SqlConnection connection = new SqlConnection(clsDataAccessSetting.ConnectionString);
            string query = "delete Users where ID=@ID";
            SqlCommand command = new SqlCommand (query, connection);
            command.Parameters.AddWithValue("@ID",ID);
            try
            {
                connection.Open();
                RowEfficted = command.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                Console.WriteLine("error " +ex.Message);
            }
            finally
            {
                connection.Close ();
            }
            return RowEfficted > 0;
        }

        public static bool UpdateUser(int ID , string UserName ,string Password , int Permmitions)
        {
            int RowEffivted = -1;
            SqlConnection connection = new SqlConnection(clsDataAccessSetting.ConnectionString);
            string query = "Update Users Set UserName=@UserName , Password=@Password ,Permmions=@Permmitions where ID=@ID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ID", ID);
            command.Parameters.AddWithValue("@UserName", UserName);
            command.Parameters.AddWithValue("@Password", Password);
            command.Parameters.AddWithValue("@Permmitions", Permmitions);
            try
            {
                connection.Open ();
                RowEffivted = command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine("error " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return RowEffivted > 0;
        }
    }
}




