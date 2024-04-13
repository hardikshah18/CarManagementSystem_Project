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
    public partial class AdminHomePage : Form
    {

        public static int requestID;
        public static int carID;
        public static int driverID;

        public static int finalamount;

        private dbConnection dbConnection;
        private AdminRequestPage Operation;
        public AdminHomePage()
        {
            InitializeComponent();
            dbConnection = new dbConnection();
            Operation = new AdminRequestPage();
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

                string query = "SELECT R.RequestID, R.RequestDate, R.IsDriverReq, R.PickUpDate, R.NumofDays, R.TotalAmount, " +
                    "C.CarModel, C.CarImage, U.FullName, C.CarID, R.ReqStatus FROM cRequestDetails R JOIN cCarDetails C ON R.CarID = C.CarID join " +
                    "cUserDetails U ON R.UserID = U.UserID";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        DataTable carTable = new DataTable();
                        adapter.Fill(carTable);
                        RequestList.DataSource = carTable;

                        //requestID = int.Parse(carTable.Rows[0][0].ToString());
                        //SqlDataReader reader = cmd.ExecuteReader();
                        //reader.Read();
                        //reader.Close();

                        carID = int.Parse(carTable.Rows[0][9].ToString());
                        SqlDataReader reader1 = cmd.ExecuteReader();
                        reader1.Read();
                        reader1.Close();
                    }
                }
            }
        }
        public Image ConvertArraytoImage(byte[] image)
        {
            using (MemoryStream ms = new MemoryStream(image))
            {
                return Image.FromStream(ms);
            }
        }

        private void AdminHomePage_Load(object sender, EventArgs e)
        {
            DisplayCar();

            List<int> driverIDs;

            bool success = Operation.GetDriverIDs(out driverIDs);

            if (success)
            {
                DIDCmbBox.DataSource = driverIDs;

                DIDCmbBox.SelectedIndex = 0;
            }
        }

        private void RequestList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.RequestList.Rows[e.RowIndex];

                ReqDateTxt.Text = row.Cells[1].Value.ToString();
                PickUpDateTxt.Text = row.Cells[3].Value.ToString();
                NumDaysTxt.Text = row.Cells[4].Value.ToString();
                CarModalTxt.Text = row.Cells[6].Value.ToString();
                CustomerNameTxt.Text = row.Cells[8].Value.ToString();
                PaymentTxt.Text = row.Cells[5].Value.ToString();

                CarImageBox.Image = ConvertArraytoImage((byte[])row.Cells[7].Value);


                int isDriverReq = Convert.ToInt32(row.Cells[2].Value);

                if (isDriverReq == 1)
                {
                    IsDriverReqRadioButton.Checked = true;

                    AppointDriver.Visible = true;
                }
                else
                {
                    IsDriverReqRadioButton.Checked = false;
                    
                    AppointDriver.Visible = false;
                }
                requestID = Convert.ToInt32(row.Cells[0].Value.ToString());

                string Pending = row.Cells["ReqStatus"].Value.ToString();

                if(Pending == "Pending")
                {
                    ApproveBtn.Enabled = true;
                    DeclineBtn.Enabled = true;
                }
                else
                {
                    ApproveBtn.Enabled = false;
                    DeclineBtn.Enabled = false;
                }

                FinalAmountLbl.Text = PaymentTxt.Text;
            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void DIDCmbBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DIDCmbBox.SelectedIndex >= 0)
            {
                int DriverID = (int)DIDCmbBox.SelectedItem;
                int did1=Convert.ToInt32(DIDCmbBox.SelectedItem.ToString());

                driverID = Convert.ToInt32(DriverID);

                bool success = Operation.ViewDriver(DriverID, out string driverName, out decimal fees, out int experience);

                if (success)
                {
                    DNameTxt.Text = driverName;
                    FeesTxt.Text = fees.ToString();
                    ExTxt.Text = experience.ToString();
                }
            }

            int payment;
            int dfees;
            int numDays;

            if (int.TryParse(PaymentTxt.Text, out payment) && int.TryParse(FeesTxt.Text, out dfees) && int.TryParse(NumDaysTxt.Text, out numDays))
            {
                finalamount = payment + dfees * numDays;

                FinalAmountLbl.Text = finalamount.ToString();
            }
        }

        

        private void ApproveBtn_Click(object sender, EventArgs e)
        {
            int driverID;
            if(AppointDriver.Visible == false)
            {
                driverID = 0;
            }else
            {
                driverID = AdminHomePage.driverID;
            }
            int carid = AdminHomePage.carID;
            int requestid = AdminHomePage.requestID;

            int payment;
            int fees;
            int numDays;

            if (int.TryParse(PaymentTxt.Text, out payment) && int.TryParse(FeesTxt.Text, out fees) && int.TryParse(NumDaysTxt.Text, out numDays))
            {
                finalamount = payment + fees * numDays;

                bool success = Operation.AcceptRequest(requestid, driverID, carid, finalamount);
            }
        }

        private void DeclineBtn_Click(object sender, EventArgs e)
        {
            int requestid = AdminHomePage.requestID;

            bool success = Operation.DeclineRequest(requestid);
        }
    }
}
