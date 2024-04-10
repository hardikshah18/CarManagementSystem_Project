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
    public partial class AdminHomePage : Form
    {
        public AdminHomePage()
        {
            InitializeComponent();
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
    }
}
