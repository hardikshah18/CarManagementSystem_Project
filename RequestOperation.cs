using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace CarManagementSystem
{
    public class RequestOperation
    {
        dbConnection dbConnection;
        SqlCommand cmd;
        
        public RequestOperation()
        {
            dbConnection = new dbConnection();
        }
        public bool UserRequest(DateTime RequestDate, int IsDriverReq, DateTime PickUpDate, int NumofDays, int CarID, int UID, int TotalAmount)
        {
            using (SqlConnection connection = dbConnection.GetConnection())
            {
                connection.Open();

                string query = "INSERT INTO cRequestDetails (RequestDate, IsDriverReq, PickUpDate, NumofDays, CarID, UserID, TotalAmount) " +
                    "VALUES (@RequestDate, @IsDriverReq, @PickUpDate, @NumofDays, @CarID, @UserID, @TotalAmount)";

                using (cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@RequestDate", RequestDate);
                    cmd.Parameters.AddWithValue("@IsDriverReq", IsDriverReq);
                    cmd.Parameters.AddWithValue("@PickUpDate", PickUpDate);
                    cmd.Parameters.AddWithValue("@NumofDays", NumofDays);
                    cmd.Parameters.AddWithValue("@CarID", CarID);
                    cmd.Parameters.AddWithValue("@UserID", UID);
                    cmd.Parameters.AddWithValue("@TotalAmount", TotalAmount);

                    cmd.ExecuteNonQuery();
                }
            }
            return true;
        }
    }
}
