using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace CarManagementSystem
{
    public partial class DriverDetail : Form
    {
        private Driver DriverDetails;
        private dbConnection dbConnection;
        public DriverDetail()
        {
            InitializeComponent();
            DriverDetails = new Driver();
            dbConnection = new dbConnection();
        }

        private void ReqBtn_Click(object sender, EventArgs e)
        {
            AdminHomePage admin = new AdminHomePage();
            admin.ShowDialog();
            this.Dispose();
        }

        private void CarDetailBtn_Click(object sender, EventArgs e)
        {
            CarDetail car = new CarDetail();
            car.ShowDialog();
            this.Dispose();
        }

        private void LogOutBtn_Click(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            login.ShowDialog();
            this.Dispose();
        }

        private void DriverDetail_Load(object sender, EventArgs e)
        {
            string Dname = DNameTxt.Text;
            string Dmail = EIDTxt.Text;
            string Dpass = PassTxt.Text;
            string DFees = FeesTxt.Text;
            string DEx = ExTxt.Text;
            clear();
            DisplayDriver();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            string Dname = DNameTxt.Text;
            string Dmail = EIDTxt.Text;
            string Dpass = PassTxt.Text;
            decimal DFees = decimal.Parse(FeesTxt.Text);
            int DEx = int.Parse(ExTxt.Text);

            bool success = DriverDetails.CreateDriver(Dname, Dmail, Dpass, DFees, DEx);

            if (success)
            {
                clear();
                DisplayDriver();
            }
        }

        private void clear()
        {
            DNameTxt.Clear();
            EIDTxt.Clear();
            PassTxt.Clear();
            FeesTxt.Clear();
            ExTxt.Clear();
        }
        public void DisplayDriver()
        {
            using (SqlConnection conn = dbConnection.GetConnection())
            {
                SqlCommand cmd = new SqlCommand("Select * From cDriverDetails", conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable table = new DataTable();
                adapter.Fill(table);
                RequestList.DataSource = table;
            }
        }
        private void RequestList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                DataGridViewRow row = this.RequestList.Rows[e.RowIndex];

                DNameTxt.Text = row.Cells["DriverName"].Value.ToString();
                EIDTxt.Text = row.Cells["EmailID"].Value.ToString();
                PassTxt.Text = row.Cells["Password"].Value.ToString();
                FeesTxt.Text = row.Cells["Fees"].Value.ToString();
                ExTxt.Text = row.Cells["Experiance"].Value.ToString();
            }
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            string Dname = DNameTxt.Text;
            string Dmail = EIDTxt.Text;
            string Dpass = PassTxt.Text;
            decimal DFees = decimal.Parse(FeesTxt.Text);
            int DEx = int.Parse(ExTxt.Text);

            bool success = DriverDetails.UpdateDriver(Dname, Dmail, Dpass, DFees, DEx);

            if (success)
            {
                clear();
                DisplayDriver();
            }
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            string Dmail = EIDTxt.Text;

            bool success = DriverDetails.DeleteDriver( Dmail );

            if (success)
            {
                clear();
                DisplayDriver();
            }
        }
    }
}
