using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarManagementSystem
{
    public class User
    {

        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter adapter = new SqlDataAdapter();

        private dbConnection dbConnection;

        public User()
        {
            dbConnection = new dbConnection();
        }

        public bool CreateUser(string fullName, string password, string email, string dob, string address, string city, string province, string country)
        {
            using (SqlConnection connection = dbConnection.GetConnection())
            {
                connection.Open();
                
                string checkDrive = "Select * from cDriverDetails WHERE EmailID = @EmailID";

                using (SqlCommand checkDriver = new SqlCommand(checkDrive, connection))
                {
                    checkDriver.Parameters.AddWithValue("@EmailID",email);
                    adapter = new SqlDataAdapter(checkDriver);
                    DataTable table = new DataTable();
                    adapter.Fill(table);

                    if (table.Rows.Count >= 1)
                    {
                        MessageBox.Show(email + " is Already Exist", "Database Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        string CheckUserMail = "Select * from cUserDetails WHERE EmailID = @EmailID";

                        using (SqlCommand checkUser = new SqlCommand(CheckUserMail, connection))
                        {
                            checkUser.Parameters.AddWithValue("@EmailID", email);
                            adapter = new SqlDataAdapter(checkUser);
                            DataTable tb = new DataTable();
                            adapter.Fill(tb);

                            if (tb.Rows.Count >= 1)
                            {
                                MessageBox.Show(email + " is Already Exist", "Database Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            }
                            else
                            {
                                string query = "INSERT INTO cUserDetails (FullName, EmailID, Password, DOB, " +
                                    "Address, City, Province, Country) VALUES (@FullName, @Email, @Password," +
                                    "@DOB, @Address, @City, @Province, @Country)";

                                using(cmd = new SqlCommand(query, connection))
                                {
                                    cmd.Parameters.AddWithValue("@FullName", fullName);
                                    cmd.Parameters.AddWithValue("@Email", email);
                                    cmd.Parameters.AddWithValue("@Password", password);
                                    cmd.Parameters.AddWithValue("@DOB", dob);
                                    cmd.Parameters.AddWithValue("@Address", address);
                                    cmd.Parameters.AddWithValue("@City", city);
                                    cmd.Parameters.AddWithValue("@Province", province);
                                    cmd.Parameters.AddWithValue("@Country", province);

                                    cmd.ExecuteNonQuery();
                                }
                            }
                        }
                    }
                }

                //string query = "INSERT INTO cUserDetails (FullName, Password, UserRole) VALUES (@FullName, @Password, @Email, @UserRole)";
                //SqlCommand command = new SqlCommand(query, connection);
                //command.Parameters.AddWithValue("@FullName", fullName);
                //command.Parameters.AddWithValue("@Password", password);
                //command.Parameters.AddWithValue("@Email", email);
                //// Assuming 'UserRole' should be 'Customer' by default
                //command.Parameters.AddWithValue("@UserRole", true); // Assuming 'Customer' is represented as true in the database

                
                //int rowsAffected = command.ExecuteNonQuery();

                //return rowsAffected > 0;
                return true;
            }
        }

        public bool Login(string email, string password)
        {
            using (SqlConnection conn = dbConnection.GetConnection())
            {
                conn.Open();

                cmd = new SqlCommand("SELECT * FROM cDriverDetails WHERE EmailID = @UserMail AND Password = @Password", conn);
                cmd.Parameters.AddWithValue("@UserMail", email);
                cmd.Parameters.AddWithValue("@Password", password);
                adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                cmd.ExecuteNonQuery();
                adapter.Fill(dt);

                if(dt.Rows.Count > 0)
                {
                    DriverHomePage driver = new DriverHomePage();
                    driver.ShowDialog();
                }
                else
                {
                    cmd = new SqlCommand("SELECT IsAdmin FROM cUserDetails WHERE EmailID = @UserMail AND Password = @Password", conn);
                    cmd.Parameters.AddWithValue("@UserMail", email);
                    cmd.Parameters.AddWithValue("@Password", password);
                    adapter = new SqlDataAdapter(cmd);
                    DataTable table = new DataTable();
                    cmd.ExecuteNonQuery();
                    adapter.Fill(table);

                    if (table.Rows.Count > 0)
                    {
                        SqlDataReader reader = cmd.ExecuteReader();
                        reader.Read();
                        if (reader[0].ToString() == "True")
                        {
                            AdminHomePage admin = new AdminHomePage();
                            admin.ShowDialog();
                        }
                        else
                        {
                            CustomerPage customer = new CustomerPage();
                            customer.ShowDialog();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please Check your user name and password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }
                return true;
                //object result = cmd.ExecuteScalar();

                //if (result != null && result != DBNull.Value)
                //{
                //    bool userRole = Convert.ToBoolean(result);

                //    if (userRole)
                //    {
                //        CustomerHomePage customer = new CustomerHomePage();
                //        customer.ShowDialog();
                //    }
                //    else
                //    {
                //        AdminHomePage admin = new AdminHomePage();
                //        admin.ShowDialog();

                //    }

                //    return true;
                //}
                //else
                //{
                //    MessageBox.Show("Please Check your user name and password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //    return false;
                //}
            }
        }
    }
}

