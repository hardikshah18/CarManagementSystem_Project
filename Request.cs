using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarManagementSystem
{
    public class Request
    {
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter adapter = new SqlDataAdapter();

        private dbConnection dbConnection;

        public Request()
        {
            dbConnection = new dbConnection();
        }

        public bool MakeRequest(DateTime ReqDate,int IsDriverRequired, DateTime PickUpDate, int days, int CarID, int CusomerID)
        {
            using (SqlConnection conn = dbConnection.GetConnection())
            {
                try
                {
                    conn.Open();

                    string query = "INSERT INTO cRequestDetails (RequestDate, IsDriverReq, " +
                                   "PickUpDate, NumofDays, CarID, UserID) VALUES (@ReqDate, @IsDriverRequired, " +
                                   "@PickUpDate, @days, @CarID, @UserID)";

                    using (cmd = new SqlCommand(query, conn))
                    {
                            cmd.Parameters.AddWithValue("@ReqDate", ReqDate);
                            cmd.Parameters.AddWithValue("@IsDriverRequired", IsDriverRequired);
                            cmd.Parameters.AddWithValue("@PickUpDate", PickUpDate);
                            cmd.Parameters.AddWithValue("@days", days);
                            cmd.Parameters.AddWithValue("@CarID", CarID);
                            cmd.Parameters.AddWithValue("@CusomerID", CusomerID);

                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Car registered successfully.");
                            conn.Close();
                    }
                }catch (Exception ex)
                {
                            MessageBox.Show("Connection Error Occured" + ex,
                            "Connection Error", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                }
                finally
                {
                            conn.Close();
                }
                return true;
            }
        }
    }
}
