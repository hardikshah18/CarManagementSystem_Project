using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarManagementSystem
{
    public class Cars
    {
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter adapter = new SqlDataAdapter();

        private dbConnection dbConnection;

        public Cars()
        {
            dbConnection = new dbConnection();
        }

        public bool CreateCar(string CModel, string CName, string Type, decimal Rent, string NumPlate, byte[] image)
        {
            using (SqlConnection conn = dbConnection.GetConnection())
            {
                try
                {
                    conn.Open();

                    string CheckNumberPlate = "Select * from cCarDetails WHERE NumberPlate = @NumPlate";

                    using (SqlCommand checkCar = new SqlCommand(CheckNumberPlate, conn))
                    {
                        checkCar.Parameters.AddWithValue("@NumPlate", NumPlate);
                        adapter = new SqlDataAdapter(checkCar);
                        DataTable tb = new DataTable();
                        adapter.Fill(tb);

                        if (tb.Rows.Count >= 1)
                        {
                            MessageBox.Show("Car With " + NumPlate + " is Already Exist", "Database Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                        else
                        {
                            string query = "INSERT INTO cCarDetails (CarModel, ComapanyName, " +
                                "Type, Rent, CarImage, NumberPlate) VALUES (@CModel, @CName, " +
                                "@Type, @Rent, @image, @NumPlate)";

                            using (cmd = new SqlCommand(query, conn))
                            {
                                cmd.Parameters.AddWithValue("@CModel", CModel);
                                cmd.Parameters.AddWithValue("@CName", CName);
                                cmd.Parameters.AddWithValue("@Type", Type);
                                cmd.Parameters.AddWithValue("@Rent", Rent);
                                cmd.Parameters.AddWithValue("@NumPlate", NumPlate);
                                cmd.Parameters.AddWithValue("@image", image);

                                cmd.ExecuteNonQuery();
                                MessageBox.Show("Car registered successfully.");
                                conn.Close();
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

        public bool UpdateCar(string CModel, string CName, string Type, decimal Rent, string NumPlate, byte[] image)
        {
            using (SqlConnection connect = dbConnection.GetConnection())
            {
                try
                {
                    connect.Open();

                    string CheckNumberPlate = "Select * from cCarDetails WHERE NumberPlate = @NumPlate";

                    using (SqlCommand checkCar = new SqlCommand(CheckNumberPlate, connect))
                    {
                        checkCar.Parameters.AddWithValue("@NumPlate", NumPlate);
                        adapter = new SqlDataAdapter(checkCar);
                        DataTable tb = new DataTable();
                        adapter.Fill(tb);

                        if (tb.Rows.Count >= 1)
                        {
                            string query = "UPDATE cCarDetails SET CarModel = @CModel, ComapanyName = @CName, " +
                            "Type = @Type, Rent = @Rent, CarImage = @image WHERE NumberPlate = @NumPlate";

                            using (cmd = new SqlCommand(query, connect))
                            {
                                cmd.Parameters.AddWithValue("@CModel", CModel);
                                cmd.Parameters.AddWithValue("@CName", CName);
                                cmd.Parameters.AddWithValue("@Type", Type);
                                cmd.Parameters.AddWithValue("@Rent", Rent);
                                cmd.Parameters.AddWithValue("@NumPlate", NumPlate);
                                cmd.Parameters.AddWithValue("@image", image);

                                cmd.ExecuteNonQuery();
                                MessageBox.Show("Car Updated...");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Car With Number Plate " + NumPlate + " does not Already Exist", "Database Error",
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

        public bool DeleteCar(string NumPlate)
        {
            using (SqlConnection connect = dbConnection.GetConnection())
            {
                try
                {
                    connect.Open();

                    string CheckNumberPlate = "Select * from cCarDetails WHERE NumberPlate = @NumPlate";

                    using (SqlCommand checkCar = new SqlCommand(CheckNumberPlate, connect))
                    {
                        checkCar.Parameters.AddWithValue("@NumPlate", NumPlate);
                        adapter = new SqlDataAdapter(checkCar);
                        DataTable tb = new DataTable();
                        adapter.Fill(tb);

                        if (tb.Rows.Count >= 1)
                        {
                            string query = "DELETE cCarDetails  WHERE NumberPlate = @NumPlate";

                            using (cmd = new SqlCommand(query, connect))
                            {
                                cmd.Parameters.AddWithValue("@NumPlate", NumPlate);

                                cmd.ExecuteNonQuery();
                                MessageBox.Show("Driver Deleted...");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Car With Number Plate " + NumPlate + " does not Already Exist", 
                                "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
