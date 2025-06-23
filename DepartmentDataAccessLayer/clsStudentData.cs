using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DepartmentDataAccessLayer
{
    public class clsStudentData
    {
        public static DataTable GetAllStudent()
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSetting.ConnectionString);
            string Query = "Select* from Students";
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

        


        public static DataTable GetDataGridStudentInfo(string Filter = "")
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSetting.ConnectionString);
            string Query = "select Students.ID , Students.Name , Phone  , Levels.Level , Majors.Major ," +
                " Universtys.Universty , Periods.Period\r\nfrom Students inner join \r\nLevels on Levels.ID = Students.LevelID" +
                " inner join Majors on Majors.ID = Students.MajorID \r\ninner join Universtys on Universtys.ID = Students.UniverstyID" +
                " inner join Periods on Periods.ID = Students.PeriodID "+ Filter;
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

        public static DataTable GetWhatDoYouWhantCmbData(string TypeData)
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSetting.ConnectionString);
            string query = "Select * from " + TypeData;
            SqlCommand command = new SqlCommand(query ,connection);
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
            catch(Exception ex)
            {
                Console.WriteLine("error  " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return dt;
        }

        public static int GetIdValueForCmbBoxItem(string TableName, string ColumnName, string combValue)
        {
            int id = 0;
            SqlConnection connection = new SqlConnection(clsDataAccessSetting.ConnectionString);
            string query = "select * from @TableName where @ColumnName = @combValue";
            SqlCommand command = new SqlCommand(query,connection);
            command.Parameters.AddWithValue("@TableName", TableName);
            command.Parameters.AddWithValue("@ColumnName", ColumnName);
            command.Parameters.AddWithValue("@combValue", combValue);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if(reader.Read())
                {
                    id = Convert.ToInt32(reader["ID"]);
                }
               

                //if (result != null && int.TryParse(result.ToString(), out int InstedId))
                //{
                //    id = InstedId;
                //}

            }
            catch (Exception ex)
            {
                Console.WriteLine("error " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return id;
        }

        public static int  GetIdStudentByName (string Name)
        {
            int id = 0;
            SqlConnection connection = new SqlConnection(clsDataAccessSetting.ConnectionString);
            string query = "Select* from Students where Name =@Name";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Name", Name);
            
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    id = Convert.ToInt32(reader["ID"]);
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
            return id;
        }

        public static string GetItemNameByItemID(int ID ,string TableName, string ColumnName)
        {
            string Item = "";
            SqlConnection connection = new SqlConnection(clsDataAccessSetting.ConnectionString);
            string query = "select " + ColumnName +  " from " + TableName + " where ID =@ID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@TableName", TableName);
            command.Parameters.AddWithValue("@ColumnName", ColumnName);
            command.Parameters.AddWithValue("@ID", ID);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    Item =(string)reader["ColumnName"];
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
            return Item;
        }

        public static string GetStudentNameByItemID(int ID)
        {
            string Item = "";
            SqlConnection connection = new SqlConnection(clsDataAccessSetting.ConnectionString);
            string query = "select * from Students where ID =@ID";
            SqlCommand command = new SqlCommand(query, connection);       
            command.Parameters.AddWithValue("@ID", ID);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    Item = (string)reader["Name"];
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
            return Item;
        }

        public static bool FindStudentById(int ID,ref string FullName ,ref DateTime DateOfBirth ,ref string phoneNumber,ref string whatsappNumber ,
         ref string FatherName ,ref string FatherNumber ,ref string PlaceLiving ,ref bool Status ,ref int MajorId,ref int UniverstyId 
         ,ref int LevelId ,ref int PeriodId,ref string PersonalPicture ,ref string Identity ,ref string proofRegistration ,ref string formImage )
        {
            bool IsFound = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSetting.ConnectionString);
            string query = "select* from Students where ID =@ID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ID", ID);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if(reader.Read())
                {
                    IsFound = true;
                    //ID = (int)reader["ID"];
                    FullName = (string)reader["Name"];
                    phoneNumber = (string)reader["Phone"];
                    whatsappNumber = (string)reader["WhatsappPhone"];
                    DateOfBirth = (DateTime)reader["DateOfBirth"];
                    Status = (bool)reader["Stutus"];
                    FatherName = (string)reader["FatherName"];
                    FatherNumber = (string)reader["FatherPhone"];
                    LevelId = (int)reader["LevelID"];
                    MajorId = (int)reader["MajorID"];
                    PeriodId = (int)reader["PeriodID"];
                    UniverstyId = (int)reader["UniverstyID"];
                    PlaceLiving = (string)reader["PlaceLiving"];

                    if(reader["IdentityPicture"] != DBNull.Value)
                    {
                        Identity = (string)reader["IdentityPicture"];
                    }
                    else
                    {
                        Identity = "";
                    }

                    if (reader["PersonalPhoto"] != DBNull.Value)
                    {
                        PersonalPicture = (string)reader["PersonalPhoto"];
                    }
                    else
                    {
                        PersonalPicture = "";
                    }

                    if (reader["FormImage"] != DBNull.Value)
                    {
                        formImage = (string)reader["FormImage"];
                    }
                    else
                    {
                        formImage = "";
                    }

                    if (reader["ProofPhoto"] != DBNull.Value)
                    {
                        proofRegistration = (string)reader["FormImage"];
                    }
                    else
                    {
                        proofRegistration = "";
                    }

                }

            }
            catch(Exception ex)
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



        public static bool UpdateStudent(int ID, string FullName,  DateTime DateOfBirth,  string phoneNumber,  string whatsappNumber,
         string FatherName,  string FatherNumber,  string PlaceLiving,  bool Status,  int MajorId,  int UniverstyId
        , int LevelId,int PeriodId, string PersonalPicture,string Identity,string proofRegistration, string formImage)
        {
            int rowEffiected = -1;
            SqlConnection connection = new SqlConnection(clsDataAccessSetting.ConnectionString);
            string query = "UPDATE Students " +
                                  "SET Name = @FullName" +
                                  ",WhatsappPhone =@whatsappNumber" +
                                  ",DateOfBirth = @DateOfBirth" +
                                  ",Phone = @phoneNumber" +
                                  ", Stutus = @Status" +
                                  ",FatherName = @FatherName" +
                                  ",IdentityPicture = @Identity" +
                                  ",PersonalPhoto = @PersonalPicture" +
                                  ",FatherPhone = @FatherNumber" +
                                  ",ProofPhoto = @proofRegistration" +
                                  ",FormImage = @formImage" +
                                  ",LevelID = @LevelId" +
                                  ",MajorID = @MajorId" +
                                  ",PeriodID = @PeriodId" +
                                  ",UniverstyID = @UniverstyId" +
                                  ",PlaceLiving = @PlaceLiving" +
                                  " WHERE  ID = @ID";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ID", ID);
            command.Parameters.AddWithValue("@FullName", FullName);
            command.Parameters.AddWithValue("@DateOfBirth", DateOfBirth);
            command.Parameters.AddWithValue("@whatsappNumber", whatsappNumber);
            command.Parameters.AddWithValue("@phoneNumber", phoneNumber);
            command.Parameters.AddWithValue("@Status", Status);
            command.Parameters.AddWithValue("@FatherName", FatherName);

            if (Identity  == "")
            {
                command.Parameters.AddWithValue("@Identity", DBNull.Value);
            }
            if (PersonalPicture == "")
            {
                command.Parameters.AddWithValue("@PersonalPicture", DBNull.Value);
            }
            if (proofRegistration == "")
            {
                command.Parameters.AddWithValue("@proofRegistration", DBNull.Value);
            }
            if (formImage == "")
            {
                command.Parameters.AddWithValue("@formImage", DBNull.Value);
            }

            

            command.Parameters.AddWithValue("@FatherNumber", FatherNumber);
            
            command.Parameters.AddWithValue("@LevelId", LevelId);
            command.Parameters.AddWithValue("@MajorId", MajorId);
            command.Parameters.AddWithValue("@PeriodId", PeriodId);
            command.Parameters.AddWithValue("@UniverstyId", UniverstyId);
            command.Parameters.AddWithValue("@PlaceLiving", PlaceLiving);
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


        public static int AddNewStudent(string FullName, DateTime DateOfBirth, string phoneNumber, string whatsappNumber,
         string FatherName, string FatherNumber, string PlaceLiving, bool Status, int MajorId, int UniverstyId
        , int LevelId, int PeriodId, string PersonalPicture, string Identity, string proofRegistration, string formImage)
        {
            int rowEffiected = -1;
            SqlConnection connection = new SqlConnection(clsDataAccessSetting.ConnectionString);
            string query = "INSERT INTO Students" +
                          "(Name, Phone, WhatsappPhone, DateOfBirth, Stutus, FatherName, IdentityPicture, PersonalPhoto" +
                          ",FatherPhone, ProofPhoto, FormImage, LevelID, MajorID, PeriodID, UniverstyID, PlaceLiving)" +
                          " VALUES (" +
                                      "@FullName" +
                                      ",@phoneNumber" +
                                      ",@WhatsappPhone" +
                                      ",@DateOfBirth" +
                                      ",@Status" +
                                      ",@FatherName" +
                                      ",@Identity" +
                                      ",@PersonalPicture" +
                                      ",@FatherNumber" +
                                      ",@proofRegistration" +
                                      ",@formImage" +
                                      ",@LevelId" +
                                      ",@MajorId" +
                                      ",@PeriodId" +
                                      ",@UniverstyId" +
                                      ",@PlaceLiving)";
                                      
                                      

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@FullName", FullName);
            command.Parameters.AddWithValue("@DateOfBirth", DateOfBirth);
            command.Parameters.AddWithValue("@phoneNumber", phoneNumber);
            command.Parameters.AddWithValue("@WhatsappPhone", whatsappNumber);
            command.Parameters.AddWithValue("@Status", Status);
            command.Parameters.AddWithValue("@FatherName", FatherName);
            command.Parameters.AddWithValue("@Identity", Identity);
          
            command.Parameters.AddWithValue("@PersonalPicture", PersonalPicture);
            command.Parameters.AddWithValue("@FatherNumber", FatherNumber);
            command.Parameters.AddWithValue("@proofRegistration", proofRegistration);
            command.Parameters.AddWithValue("@formImage", formImage);

            command.Parameters.AddWithValue("@LevelId", LevelId);
            command.Parameters.AddWithValue("@MajorId", MajorId);
            command.Parameters.AddWithValue("@PeriodId", PeriodId);
            command.Parameters.AddWithValue("@UniverstyId", UniverstyId);
            command.Parameters.AddWithValue("@PlaceLiving", PlaceLiving);
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
            return rowEffiected;
        }

        public static bool DeleteStudent(int ID)
        {
            int rowEfeccted = 0;
            SqlConnection connection = new SqlConnection(clsDataAccessSetting.ConnectionString);
            string Query = "delete Students where ID =@ID";
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
        
      
    }
}
