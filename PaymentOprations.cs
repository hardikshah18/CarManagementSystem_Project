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
    public class PaymentOprations
    {
        dbConnection dbConnection;
        SqlCommand cmd;
        public PaymentOprations()
        {
            dbConnection = new dbConnection();
        }

        public bool Display(out string username)
        {
            using (SqlConnection conn = dbConnection.GetConnection())
            {
                conn.Open();

                string query = "SELECT FullName from cUserDetails WHERE UserID = @UserID";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@UserID", User.userid);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            username = reader["FullName"].ToString();
                            return true;
                        }
                    }
                }
                
            }
            username = string.Empty;
            return false;
        }

        public bool Payment(int RequestID, int UserID, int DriverID, decimal CardNumber, int CVV, DateTime ExpiryDate, int Amount)
        {
            using (SqlConnection conn = dbConnection.GetConnection())
            {
                //try
                //{
                    conn.Open();

                    if (DriverID == 0)
                    {
                        string query = "INSERT INTO cPaymentDetails (RequestID, UserID, " +
                                "CardNumber, CVV, ExpiryDate, Amount) VALUES (@RequestID, @UserID, " +
                                "@CardNumber, @CVV, @ExpiryDate, @Amount)";

                        using (cmd = new SqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@RequestID", RequestID);
                            cmd.Parameters.AddWithValue("@UserID", UserID);
                            cmd.Parameters.AddWithValue("@CardNumber", CardNumber);
                            cmd.Parameters.AddWithValue("@CVV", CVV);
                            cmd.Parameters.AddWithValue("@ExpiryDate", ExpiryDate);
                            cmd.Parameters.AddWithValue("@Amount", Amount);

                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Payment Done successfully.");
                            conn.Close();
                        }
                    }
                    else
                    {
                        string query = "INSERT INTO cPaymentDetails (RequestID, UserID, " +
                            "DriverID, CardNumber, CVV, ExpiryDate, Amount) VALUES (@RequestID, @UserID, " +
                            "@DriverID, @CardNumber, @CVV, @ExpiryDate, @Amount)";

                        using (cmd = new SqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@RequestID", RequestID);
                            cmd.Parameters.AddWithValue("@UserID", UserID);
                            cmd.Parameters.AddWithValue("@DriverID", DriverID);
                            cmd.Parameters.AddWithValue("@CardNumber", CardNumber);
                            cmd.Parameters.AddWithValue("@CVV", CVV);
                            cmd.Parameters.AddWithValue("@ExpiryDate", ExpiryDate);
                            cmd.Parameters.AddWithValue("@Amount", Amount);

                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Payment Done successfully.");
                            conn.Close();
                        }
                    }
                
                
                }
                //catch (Exception ex)
                //{
                //    MessageBox.Show("Connection Error Occured" + ex,
                //        "Connection Error", MessageBoxButtons.OK,
                //        MessageBoxIcon.Error);
                //}
                //finally
                //{
                //    conn.Close();
                //}
                return true;
            }
        }
    }

