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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace CarManagementSystem
{
    public partial class ViewRequestCustomer : Form
    {
        private dbConnection dbConnection;

        public static int FinalAmount;
        public static int requestid;
        public static int driverid;

        public ViewRequestCustomer()
        {
            InitializeComponent();
            dbConnection = new dbConnection();
        }

        private void ViewRequestCustomer_Load(object sender, EventArgs e)
        {
            DisplayRequest();
        }

        void DisplayRequest()
        {
            using (SqlConnection conn = dbConnection.GetConnection())
            {
                conn.Open();
                string query = "SELECT C.CarModel, C.ComapanyName, C.Type, C.Rent, " +
                    "R.IsDriverReq, R.PickUpDate, R.NumofDays, R.TotalAmount, R.ReqStatus, R.RequestID, D.DriverID " +
                    "FROM cRequestDetails R JOIN cCarDetails C ON R.CarID = C.CarID JOIN cConformationDetails CD ON CD.RequestID = " +
                    " R.RequestID JOIN cUserDetails U ON R.UserID = U.UserID JOIN cDriverDetails D on D.DriverID = CD.DriverID WHERE U.UserID = @UserID";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@UserID",User.userid); 

                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        DataTable carTable = new DataTable();
                        adapter.Fill(carTable);
                        RequestGridView.DataSource = carTable;
                    }
                }
            }
        }

        void FilterOption()
        {
            using (SqlConnection conn = dbConnection.GetConnection())
            {
                conn.Open();

                string query = "SELECT C.CarModel, C.ComapanyName, C.Type, C.Rent, " +
                    "R.IsDriverReq, R.PickUpDate, R.NumofDays, CD.FinalAmount, R.ReqStatus, R.RequestID " +
                    "D.DriverID FROM cRequestDetails R JOIN cConformationDetails CD ON CD.RequsetID = " +
                    "R.RequestID JOIN cDriverDetails D on D.DriverID = CD.DriverID JOIN cCarDetails C ON R.CarID = C.CarID JOIN " +
                    "cUserDetails U ON R.UserID = U.UserID WHERE U.UserID = @UserID AND ReqStatus = @option";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@UserID", User.userid);
                    cmd.Parameters.AddWithValue("@option", FilterComboBox.Text);

                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        DataTable carTable = new DataTable();
                        adapter.Fill(carTable);
                        RequestGridView.DataSource = carTable;
                    }
                }
            }
        }
        private void RequestGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.RequestGridView.Rows[e.RowIndex];

                CModelTxt.Text = row.Cells[0].Value.ToString();
                CNameTxt.Text = row.Cells[1].Value.ToString();
                TypeTxt.Text = row.Cells[2].Value.ToString();
                HourlyRentTxt.Text = row.Cells[3].Value.ToString();

                FromDate.Text = row.Cells[5].Value.ToString();
                DaysTxt.Text = row.Cells[6].Value.ToString();
                lblTotalAmount.Text = row.Cells[7].Value.ToString();

                ReqStatusTextBox.Text = row.Cells[8].Value.ToString();
                if(ReqStatusTextBox.Text == "Accepted")
                {
                    PayBtn.Enabled = true;
                }
                else
                {
                    PayBtn.Enabled=false;
                }

                int isDriverReq = Convert.ToInt32(row.Cells[4].Value);

                if (isDriverReq == 1)
                {
                    DriReqRadioBtn.Checked = true;
                }
                else
                {
                    DriReqRadioBtn.Checked = false;
                }
                requestid= Convert.ToInt32(row.Cells[9].Value.ToString());
                driverid = Convert.ToInt32(row.Cells[10].Value.ToString());
            }
        }

        private void FilterComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {           
            if (FilterComboBox.SelectedIndex >= 0)
            {
                FilterOption();
            }
        }

        private void PayBtn_Click(object sender, EventArgs e)
        {
            FinalAmount = Convert.ToInt32(lblTotalAmount.Text);
            PaymentDetails pay = new PaymentDetails();
            pay.Show();
            this.Close();
        }

        private void MailBtn_Click(object sender, EventArgs e)
        {
            CustomerPage HomePage = new CustomerPage();
            HomePage.Show();
            this.Close();
        }
    }
}
