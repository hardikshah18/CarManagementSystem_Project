﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarManagementSystem
{
    public partial class AdminHomePage : Form
    {
        private dbConnection dbConnection;
        public AdminHomePage()
        {
            InitializeComponent();
            dbConnection = new dbConnection();
        }

        private void DriverDetailBtn_Click(object sender, EventArgs e)
        {
            DriverDetail driver = new DriverDetail();
            driver.ShowDialog();
            this.Hide();
        }

        private void CarDetailBtn_Click(object sender, EventArgs e)
        {
            CarDetail car = new CarDetail();
            car.ShowDialog();
            this.Hide();
        }

        private void LogOutBtn_Click(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            login.ShowDialog();
            this.Hide();
        }

        void DisplayCar()
        {
            using (SqlConnection conn = dbConnection.GetConnection())
            {
                conn.Open();
                string query = "SELECT R.RequestID, R.RequestDate, R.IsDriverReq, R.PickUpDate, R.NumofDays, " +
                    "C.CarModel, C.CarImage, U.FullName FROM cRequestDetails R JOIN cCarDetails C ON R.CarID = C.CarID join " +
                    "cUserDetails U ON R.UserID = U.UserID";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        DataTable carTable = new DataTable();
                        adapter.Fill(carTable);
                        RequestList.DataSource = carTable;
                    }
                }
            }
        }

        private void AdminHomePage_Load(object sender, EventArgs e)
        {
            DisplayCar();
        }

        private void RequestList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
