using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DepartmentDataAccessLayer
{
    public class clsVailoationsDataAccess
    {

      

        public static int AddNewViolation(int StudentID, int ViolationID, DateTime Date, string Description)
        {
            int RowEffected = -1;
            SqlConnection connection = new SqlConnection(clsDataAccessSetting.ConnectionString);
            string query = "INSERT INTO ViolationsDetails(StudentID ,ViolationID ,ViolationDate,ViolationDescription) values" +
                "(@StudentID ,@ViolationID ,@Date ,@Description)";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@StudentID", StudentID);
            command.Parameters.AddWithValue("@ViolationID", ViolationID);
            command.Parameters.AddWithValue("@Date", Date);
            command.Parameters.AddWithValue("@Description", Description);


            try
            {
                connection.Open();
                RowEffected = command.ExecuteNonQuery();

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

     

        public static DataTable GetViolationsListCmbData()
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSetting.ConnectionString);
            string query = "Select * from Violations";
            SqlCommand command = new SqlCommand(query, connection);
            //command.Parameters.AddWithValue("@TypeData", TypeData);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    dt.Load(reader);
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("error  " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return dt;
        }

        public static string GetViolationNameById(int ID)
        {
            string Name = "";
            SqlConnection connection = new SqlConnection(clsDataAccessSetting.ConnectionString);
            string query = "Select* from Violations where Id =@ID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ID", ID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    Name = (string)(reader["Name"]);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("error " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return Name;
        }
       
        public static DataTable GetAllDataGridInfo(string Filter ="")
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSetting.ConnectionString);
            string Query = "SELECT vd.Id as ID, s.Name as StudentName, v.Name AS ViolationName, vd.ViolationDate as ViolationDate, " +
                      " vd.ViolationDescription as ViolationDescription ,(select count(*) from ViolationsDetails " +
                      " where ViolationsDetails.ViolationID = vd.ViolationID and s.ID = ViolationsDetails.StudentID) as ViolationCount " +
                      " FROM Violations v INNER JOIN " +
                      " ViolationsDetails vd ON v.Id = vd.ViolationID INNER JOIN " +
                      " Students s ON vd.StudentID = s.ID " + Filter;

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



        public static DataTable GetAllStudentViloationsByID(int ID)
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSetting.ConnectionString);
            string Query = "SELECT vd.Id as ID, s.Name as StudentName, v.Name AS ViolationName, vd.ViolationDate as ViolationDate, " +
                      " vd.ViolationDescription as ViolationDescription ,(select count(*) from ViolationsDetails " +
                      " where ViolationsDetails.ViolationID = vd.ViolationID and s.ID = ViolationsDetails.StudentID) as ViolationCount " +
                      " FROM Violations v INNER JOIN " +
                      " ViolationsDetails vd ON v.Id = vd.ViolationID INNER JOIN " +
                      " Students s ON vd.StudentID = s.ID  where s.ID =@ID ;" ;


            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@ID", ID);

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

        public static bool DeleteViolation(int ID)
        {
            int rowEfeccted = 0;
            SqlConnection connection = new SqlConnection(clsDataAccessSetting.ConnectionString);
            string Query = "delete ViolationsDetails where ID =@ID";
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

        public static bool UpdateViolation(int StudentID, int ViolationID, DateTime Date, string Description)
        {
            int rowEffiected = -1;
            SqlConnection connection = new SqlConnection(clsDataAccessSetting.ConnectionString);
            string query = "UPDATE ViolationsDetails SET StudentID =@StudentID, ViolationID =@ViolationID," +
                "ViolationDate=@Date, ViolationDescription=@Description";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@StudentID", StudentID);
            command.Parameters.AddWithValue("@VioaionID", ViolationID);
            command.Parameters.AddWithValue("@Date", Date);
            command.Parameters.AddWithValue("@Description", Description);

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


        public static bool FindViolationById(int ID ,ref int StudentID,ref int ViolationID,ref DateTime Date,ref string Description)
        {
            bool IsFound = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSetting.ConnectionString);
            string query = "Select * from ViolationsDetails where ID=@ID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ID", ID);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    IsFound = true;
                    StudentID = (int)reader["StudentID"];
                    ViolationID = (int)reader["ViolationID"];
                    Date = (DateTime)reader["ViolationDate"];
                    Description = (String)reader["ViolationDescription"];
                    
                }
                reader.Close();

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

        public static DataTable GetReportYearsData(string Filter =  "")
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSetting.ConnectionString);
            string Query = "SELECT distinct s.ID,  s.Name as StudentName, " +
           " (select count(*) from ViolationsDetails where ViolationsDetails.ViolationID = 1 and s.ID = ViolationsDetails.StudentID) as Vajer,       " +
           " (select count(*) from ViolationsDetails where ViolationsDetails.ViolationID = 2 and s.ID = ViolationsDetails.StudentID)as Quran,        " +
           " (select count(*) from ViolationsDetails where ViolationsDetails.ViolationID = 3 and s.ID = ViolationsDetails.StudentID) as Activties,   " +
           " (select count(*) from ViolationsDetails where ViolationsDetails.ViolationID = 4 and s.ID = ViolationsDetails.StudentID) as Behavior,    " +
           " (select count(*) from ViolationsDetails where ViolationsDetails.ViolationID = 5 and s.ID = ViolationsDetails.StudentID) as Clean,       " +
           " (select count(*) from ViolationsDetails where ViolationsDetails.ViolationID = 6 and s.ID = ViolationsDetails.StudentID) as WeaklyHalak, " +
           " (select count(ViolationID) from ViolationsDetails where StudentID = s.ID) as TotalViolations " +
            " from Students s left " +
            " join ViolationsDetails vd ON vd.StudentID = s.ID left join Violations v  ON v.Id = vd.ViolationID " + Filter;

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

    }
}
