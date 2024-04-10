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
        public List<int> CarID = new List<int>();
        public CustomerPage()
        {
            InitializeComponent();
            dbConnection = new dbConnection();
            
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
                string query = "SELECT CarID,CarModel,ComapanyName,Type,Rent FROM cCarDetails WHERE IsAvailable = 1";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    SqlDataReader reader = cmd.ExecuteReader();
                    CarListView.Items.Clear();
                    while (reader.Read())
                    {
                        CarID.Add((int)reader["CarID"]);
                        string CarList = $"{reader["CarModel"]}       -       {reader["ComapanyName"]}       -       {reader["Type"]}       -       {reader["Rent"]}";
                        CarListView.Items.Add(CarList);
                    }
                    reader.Close();
                }
            }
        }

        private void CarListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CarListView.SelectedItems.Count != -1)
            {
                string selctedCar = CarListView.SelectedItem.ToString();

                string[] details = selctedCar.Split(new string[] { "       -       " }, StringSplitOptions.None);

                if (details.Length >= 3)
                {

                    CModelTxt.Text = details[0];
                    CNameTxt.Text = details[1];
                    TypeTxt.Text = details[2];
                    HourlyRentTxt.Text = details[3];

                    //byte[] CarImage = ImageStore(details[4]);

                    //if (CarImage != null && CarImage.Length > 0)
                    //{
                    //    // Convert the byte array to a memory stream
                    //    using (MemoryStream ms = new MemoryStream(CarImage))
                    //    {
                    //        // Create an image from the memory stream
                    //        Image image = Image.FromStream(ms);

                    //        // Assign the image to the PictureBox
                    //        CarImageBox.Image = image;
                    //    }
                    //}
                    //else
                    //{
                    //    // If image data is null or empty, clear the PictureBox
                    //    CarImageBox.Image = null;
                    //}
                }
            }
        }
        private byte[] ImageStore(string ImageLocation)
        {
            if (string.IsNullOrEmpty(ImageLocation))
            {
                MessageBox.Show("Add Image of the Car");
                return null;
            }

            try
            {
                if (!File.Exists(ImageLocation))
                {
                    MessageBox.Show("Image file does not exist at the specified location: " + ImageLocation);
                    return null;
                }

                byte[] CarImage = File.ReadAllBytes(ImageLocation);
                return CarImage;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while loading image: " + ex.Message);
                return null;
            }
        }

        private void BookBtn_Click(object sender, EventArgs e)
        {
            MakeRequest request = new MakeRequest(CarListView.SelectedItem.ToString(), CarID[CarListView.SelectedIndex]);
            request.Show();
            this.Hide();
        }

        void searchcar()
        {
            using (SqlConnection connect = dbConnection.GetConnection())
            {
                connect.Open();
                string search = "SELECT * FROM cCarDetails WHERE IsAvailable = 1 and Type = @Type";

                using (SqlCommand cmd = new SqlCommand(search, connect))
                {
                    cmd.Parameters.AddWithValue("@Type", SearchComBox.Text);
                    SqlDataReader reader = cmd.ExecuteReader();
                    CarListView.Items.Clear();
                    while (reader.Read())
                    {
                        string CarList = $"{reader["CarModel"]}       -       {reader["ComapanyName"]}       -       {reader["Type"]}";
                        CarListView.Items.Add(CarList);
                    }
                    reader.Close();
                }
                connect.Close();
            }
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            searchcar();
        }
    }
}
