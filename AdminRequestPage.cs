using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarManagementSystem
{
    public class AdminRequestPage
    {
        dbConnection dbConnection;
        SqlCommand cmd;
        SqlDataReader reader;

        public static int carID;
        public AdminRequestPage() 
        {
            dbConnection = new dbConnection();
        }

        public bool ViewDriver(int DriverID, out string driverName, out decimal fees, out int experience)
        {
            driverName = string.Empty;
            fees = 0;
            experience = 0;

            using (SqlConnection conn = dbConnection.GetConnection())
            {
                conn.Open();

                string query = "SELECT DriverName, Fees, Experiance FROM cDriverDetails WHERE DriverID = @DriverID";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@DriverID", DriverID);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            driverName = reader["DriverName"].ToString();
                            fees = Convert.ToDecimal(reader["Fees"]);
                            experience = Convert.ToInt32(reader["Experiance"]);
                            return true;
                        }
                    }
                }
                conn.Close();
            }
            return false;
        }

        public bool GetDriverIDs(out List<int> driverIDs)
        {
            driverIDs = new List<int>();

            using (SqlConnection conn = dbConnection.GetConnection())
            {
                conn.Open();

                string query = "SELECT DriverID FROM cDriverDetails";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int driverID = reader.GetInt32(0);
                            driverIDs.Add(driverID);
                        }
                    }
                }
            }
            return true;
        }

        public bool AcceptRequest(int RequestID, int DriverID, int CarID, int FinalAmount)
        {
            using(SqlConnection conn = dbConnection.GetConnection())
            {
                conn.Open();

                if (DriverID == 0)
                {
                    string Insertquery = "INSERT INTO cConformationDetails (RequestID, CarID, FinalAmount) VALUES (@RequestID, @CarID, @FinalAmount)";

                    using (cmd = new SqlCommand(Insertquery, conn))
                    {
                        cmd.Parameters.AddWithValue("@RequestID", RequestID);
                        cmd.Parameters.AddWithValue("@CarID", CarID);
                        cmd.Parameters.AddWithValue("@FinalAmount", FinalAmount);

                        cmd.ExecuteNonQuery();
                    }
                }
                else
                {
                    string Insertquery = "INSERT INTO cConformationDetails (RequestID, DriverID, CarID, FinalAmount) VALUES (@RequestID, @DriverID, @CarID, @FinalAmount)";

                    using (cmd = new SqlCommand(Insertquery, conn))
                    {
                        cmd.Parameters.AddWithValue("@RequestID", RequestID);
                        cmd.Parameters.AddWithValue("@DriverID", DriverID);
                        cmd.Parameters.AddWithValue("@CarID", CarID);
                        cmd.Parameters.AddWithValue("@FinalAmount", FinalAmount);

                        cmd.ExecuteNonQuery();
                    }
                }

                string CarUpdatequery = "UPDATE cCarDetails SET IsAvailable = 0 WHERE CarID = @CarID";

                using (cmd = new SqlCommand(CarUpdatequery, conn))
                {
                    cmd.Parameters.AddWithValue("@CarID", CarID);

                    cmd.ExecuteNonQuery();
                }

                string ReqUpdatequery = "UPDATE cRequestDetails SET ReqStatus = 'Accepted' WHERE RequestID = @RequestID";

                using (cmd = new SqlCommand(ReqUpdatequery, conn))
                {
                    cmd.Parameters.AddWithValue("@RequestID", RequestID);

                    cmd.ExecuteNonQuery();
                }
            }
            return true ;
        }

        public bool DeclineRequest(int RequestID)
        {
            using (SqlConnection conn = dbConnection.GetConnection())
            {
                conn.Open();

                
                string Updatequery = "UPDATE cRequestDetails SET ReqStatus = 'Decline' WHERE RequestID = @RequestID";

                using (cmd = new SqlCommand(Updatequery, conn))
                {
                    cmd.Parameters.AddWithValue("@RequestID", RequestID);

                    cmd.ExecuteNonQuery();
                }
            }
            return true;
        }
    }
}
