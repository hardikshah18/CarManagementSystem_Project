using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarManagementSystem
{
    public partial class CarDetail : Form
    {
        private Cars cars;
        private dbConnection dbConnection;
        public CarDetail()
        {
            InitializeComponent();
            dbConnection = new dbConnection();
            cars = new Cars();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

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

        void clear()
        {
            CModelTxt.Clear();
            CNameTxt.Clear();
            HourlyRentTxt.Clear();
            NumPlateTxt.Clear();
            TypeComBox.SelectedIndex = -1;
        }

        void DisplayCar()
        {
            using(SqlConnection conn = dbConnection.GetConnection())
            {
                conn.Open();
                string query = "SELECT CarModel,ComapanyName,Type FROM cCarDetails";

                using(SqlCommand cmd = new SqlCommand(query, conn))
                {
                    SqlDataReader reader = cmd.ExecuteReader();
                    CarListBox.Items.Clear();
                    while (reader.Read())
                    {
                        string CarList = $"{reader["CarModel"]}       -       {reader["ComapanyName"]}       -       {reader["Type"]}";
                        CarListBox.Items.Add(CarList);
                    }
                    reader.Close();
                }
            }
        }

        private string SelectedImage = "";
        private void BrowseImgBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            // Set the file dialog properties
            openFileDialog1.Title = "Browse Image";
            openFileDialog1.Filter = "Image Files (*.jpg; *.jpeg; *.png; *.gif; *.bmp)|*.jpg; *.jpeg; *.png; *.gif; *.bmp|All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // Get the selected image file path
                SelectedImage = openFileDialog1.FileName;

                // Display the selected image in the PictureBox control
                CarImageBox.Image = new Bitmap(SelectedImage);
            }
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            string CModel = CModelTxt.Text;
            string CName = CNameTxt.Text;
            string Type = TypeComBox.Text;
            decimal Rent = decimal.Parse(HourlyRentTxt.Text);
            string NumPlate = NumPlateTxt.Text;
            byte[] image = ImageStore(SelectedImage);

            bool success = cars.CreateCar(CModel, CName, Type, Rent, NumPlate, image);

            if (success)
            {
                clear();
                DisplayCar();
            }
        }

        private void CarDetail_Load(object sender, EventArgs e)
        {
            clear();
            DisplayCar();
        }

        private void CarListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            if(CarListBox.SelectedItems.Count != -1)
            {
                string selctedCar = CarListBox.SelectedItem.ToString();

                string[] details = selctedCar.Split(new string[] { "       -       " }, StringSplitOptions.None);
                
                if (details.Length >= 3)
                {
                    CModelTxt.Text = details[0];
                    CNameTxt.Text = details[1];
                    TypeComBox.Text = details[2];
                }
            }
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            string CModel = CModelTxt.Text;
            string CName = CNameTxt.Text;
            string Type = TypeComBox.Text;
            decimal Rent = decimal.Parse(HourlyRentTxt.Text);
            string NumPlate = NumPlateTxt.Text;
            byte[] image = ImageStore(SelectedImage);

            bool success = cars.UpdateCar(CModel, CName, Type, Rent, NumPlate, image);

            if (success)
            {
                clear();
                DisplayCar();
            }
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            string NumPlate = NumPlateTxt.Text;

            bool success = cars.DeleteCar(NumPlate);

            if (success)
            {
                clear();
                DisplayCar();
            }
        }
    }
}
