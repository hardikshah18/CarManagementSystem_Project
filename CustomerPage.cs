using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarManagementSystem
{
    public partial class CustomerPage : Form
    {
        private Cars cars;
        private dbConnection dbConnection;
        public CustomerPage()
        {
            InitializeComponent();
            dbConnection = new dbConnection();
            cars = new Cars();
        }

        private void CustomerPage_Load(object sender, EventArgs e)
        {
            
            DisplayCar();
        }

        void DisplayCar()
        {
            using (SqlConnection conn = dbConnection.GetConnection())
            {
                conn.Open();
                string query = "SELECT CarModel, ComapanyName, Type , Rent , CarImage FROM cCarDetails";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        DataTable carTable = new DataTable();
                        adapter.Fill(carTable);
                        CarGridView.DataSource = carTable;
                    }
                }
            }
        }
        private byte[] ImageStore(string image)
        {
            if (string.IsNullOrEmpty(image))
            {
                MessageBox.Show("Invalid image path");
                return null;
            }

            byte[] imageData = File.ReadAllBytes(image);
            return imageData;
        }

        public Image ConvertArraytoImage(byte[] image)
        {
            using (MemoryStream ms = new MemoryStream(image))
            {
                return Image.FromStream(ms);
            }
        }

        void SearchCars()
        {
            using (SqlConnection connect = dbConnection.GetConnection())
            {
                connect.Open();
                string searchQuery;
                SqlCommand cmd;

                if (SearchComBox.Text == "All")
                {
                    searchQuery = "SELECT CarModel, ComapanyName, Type , Rent , CarImage FROM cCarDetails WHERE IsAvailable = 1";
                    cmd = new SqlCommand(searchQuery, connect);
                }
                else
                {
                    searchQuery = "SELECT CarModel, ComapanyName, Type , Rent , CarImage FROM cCarDetails WHERE IsAvailable = 1 and Type = @Type";
                    cmd = new SqlCommand(searchQuery, connect);
                    cmd.Parameters.AddWithValue("@Type", SearchComBox.Text);
                }

                using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                {
                    DataTable carTable = new DataTable();
                    adapter.Fill(carTable);
                    CarGridView.DataSource = carTable;
                }
                connect.Close();
            }
        }

            private void CarGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.CarGridView.Rows[e.RowIndex];

                CModelTxt.Text = row.Cells[0].Value.ToString();
                CNameTxt.Text = row.Cells[1].Value.ToString();
                TypeTxt.Text = row.Cells[2].Value.ToString();
                HourlyRentTxt.Text = row.Cells[3].Value.ToString();
                CarImageBox.Image = ConvertArraytoImage((byte[])row.Cells[4].Value);

                
            }
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            SearchCars();
        }
    }
}
