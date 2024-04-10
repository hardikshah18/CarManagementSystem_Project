using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Windows.Forms;
using System.Net;
using System.Runtime.Remoting.Contexts;
using System.Xml.Linq;

namespace CarManagementSystem
{
    public class Driver
    {
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter adapter = new SqlDataAdapter();

        private dbConnection dbConnection;

        public Driver()
        {
            dbConnection = new dbConnection();
        }

        public bool CreateDriver(string Dname, string Dmail, string Dpass, decimal fees, int experiance)
        {
            using (SqlConnection conn = dbConnection.GetConnection())
            {
                try
                {
                    conn.Open();

                    string CheckUserMail = "Select * from cUserDetails WHERE EmailID = @EmailID";

                    using (SqlCommand checkUser = new SqlCommand(CheckUserMail, conn))
                    {
                        checkUser.Parameters.AddWithValue("@EmailID", Dmail);
                        adapter = new SqlDataAdapter(checkUser);
                        DataTable table = new DataTable();
                        adapter.Fill(table);

                        if (table.Rows.Count >= 1)
                        {
                            MessageBox.Show(Dmail + " is Already Exist", "Database Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                        else
                        {
                            string CheckDriverMail = "Select * from cDriverDetails WHERE EmailID = @EmailID";

                            using (SqlCommand checkDriver = new SqlCommand(CheckDriverMail, conn))
                            {
                                checkDriver.Parameters.AddWithValue("@EmailID", Dmail);
                                adapter = new SqlDataAdapter(checkDriver);
                                DataTable tb = new DataTable();
                                adapter.Fill(tb);

                                if (tb.Rows.Count >= 1)
                                {
                                    MessageBox.Show(Dmail + " is Already Exist", "Database Error",
                                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                }
                                else
                                {
                                    string query = "INSERT INTO cDriverDetails (DriverName, EmailID, " +
                                        "Password, Fees, Experiance) VALUES (@FullName, @Email, " +
                                        "@Password, @Fees, @Experiance)";

                                    using (cmd = new SqlCommand(query, conn))
                                    {
                                        cmd.Parameters.AddWithValue("@FullName", Dname);
                                        cmd.Parameters.AddWithValue("@Email", Dmail);
                                        cmd.Parameters.AddWithValue("@Password", Dpass);
                                        cmd.Parameters.AddWithValue("@Fees", fees);
                                        cmd.Parameters.AddWithValue("@Experiance", experiance);

                                        cmd.ExecuteNonQuery();
                                        MessageBox.Show("Driver registered successfully.");
                                        conn.Close();
                                    }
                                }
                            }
                        }
                    }
                }
                catch (Exception ex)
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

        public bool UpdateDriver(string Dname, string Dmail, string Dpass, decimal fees, int experiance)
        {
            using(SqlConnection connect = dbConnection.GetConnection())
            {
                try
                {
                    connect.Open();

                    string CheckDriverMail = "Select * from cDriverDetails WHERE EmailID = @EmailID";

                    using (SqlCommand checkDriver = new SqlCommand(CheckDriverMail, connect))
                    {
                        checkDriver.Parameters.AddWithValue("@EmailID", Dmail);
                        adapter = new SqlDataAdapter(checkDriver);
                        DataTable tb = new DataTable();
                        adapter.Fill(tb);

                        if (tb.Rows.Count >= 1)
                        {
                            string query = "UPDATE cDriverDetails SET DriverName = @Dname, Password = @Dpass, " +
                            "Fees = @fees, Experiance = @experiance WHERE EmailID = @Dmail";

                            using (cmd = new SqlCommand(query, connect))
                            {
                                cmd.Parameters.AddWithValue("@Dname", Dname);
                                cmd.Parameters.AddWithValue("@Dmail", Dmail);
                                cmd.Parameters.AddWithValue("@Dpass", Dpass);
                                cmd.Parameters.AddWithValue("@fees", fees);
                                cmd.Parameters.AddWithValue("@experiance", experiance);

                                cmd.ExecuteNonQuery();
                                MessageBox.Show("Driver Updated...");
                            }
                        }
                        else
                        {
                            MessageBox.Show(Dmail + " does not Already Exist", "Database Error",
                           MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Connection Error Occured" + ex,
                        "Connection Error", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
                finally
                {
                    connect.Close();
                }
            }
            return true;
        }

        public bool DeleteDriver(string Dmail)
        {
            using (SqlConnection connect = dbConnection.GetConnection())
            {
                try
                {
                    connect.Open();

                    string CheckDriverMail = "Select * from cDriverDetails WHERE EmailID = @EmailID";

                    using (SqlCommand checkDriver = new SqlCommand(CheckDriverMail, connect))
                    {
                        checkDriver.Parameters.AddWithValue("@EmailID", Dmail);
                        adapter = new SqlDataAdapter(checkDriver);
                        DataTable tb = new DataTable();
                        adapter.Fill(tb);

                        if (tb.Rows.Count >= 1)
                        {
                            string query = "DELETE cDriverDetails  WHERE EmailID = @Dmail";

                            using (cmd = new SqlCommand(query, connect))
                            {
                                cmd.Parameters.AddWithValue("@Dmail", Dmail);   

                                cmd.ExecuteNonQuery();
                                MessageBox.Show("Driver Deleted...");
                            }
                        }
                        else
                        {
                            MessageBox.Show(Dmail + " does not Already Exist", "Database Error",
                           MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Connection Error Occured" + ex,
                        "Connection Error", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
                finally
                {
                    connect.Close();
                }
            }
            return true;
        }
    }
}