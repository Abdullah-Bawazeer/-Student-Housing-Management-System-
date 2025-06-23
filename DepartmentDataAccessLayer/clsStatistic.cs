using DepartmentDataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DepartmentBusinessLayer
{
    public class clsStatistic
    {
        public static DataTable GetAllStatisticData()
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSetting.ConnectionString);
                string Query = "SELECT  v.Name,Percentage = (CAST((SELECT COUNT(*) FROM ViolationsDetails WHERE ViolationID = v.ID) AS FLOAT) " +
                   "  /   CAST((SELECT COUNT(*) FROM ViolationsDetails) AS FLOAT)) *10  FROM Violations v;";
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
