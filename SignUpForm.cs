using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarManagementSystem
{
    public partial class SignUpForm : Form
    {
        private User user;

        public SignUpForm()
        {
            InitializeComponent();
            user = new User();
        }

        private void SignUpForm_Load(object sender, EventArgs e)
        {
            string fullName = Fnametxt.Text;
            string password = passtxt.Text;
            string email = mailtxt.Text;
            string address = AddTxt.Text;
            string dob = DobTxt.Text;
            string city = CityCmbBox.Text;
            string province = ProvinceCmbBox.Text;
            string country = CountryCmbBox.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Retrieve user input from textboxes
            string fullName = Fnametxt.Text;
            string password = passtxt.Text;
            string email = mailtxt.Text;
            string address = AddTxt.Text;
            string dob = DobTxt.Text;
            string city = CityCmbBox.Text;
            string province = ProvinceCmbBox.Text;
            string country = CountryCmbBox.Text;

            // Call CreateUser method to save user information
            bool success = user.CreateUser(fullName, password, email, dob, address, city, province, country);

            if (success)
            {
                MessageBox.Show("User registered successfully.");
                // Optionally, close the sign-up form or clear the textboxes
                LoginForm loginForm = new LoginForm();
                loginForm.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Failed to register user. Please try again.");
            }

        }
    }
}
