using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace CarManagementSystem
{
    public partial class MakeRequest : Form
    {
        private dbConnection dbConnection;
        public CarDetail CarDetail;
        private RequestOperation operation;

        public int HRent;
        public int days;
        public int totamount;

        public MakeRequest()
        {
            InitializeComponent();
            operation = new RequestOperation();
        }
        private void MakeRequest_Load(object sender, EventArgs e)
        {
            CModelTxt.Text = CustomerPage.CarModel;
            CNameTxt.Text = CustomerPage.Compnay;
            HourlyRentTxt.Text = CustomerPage.Rent.ToString();
            TypeTxt.Text = CustomerPage.Type.ToString();
            CarImageBox.Image = CustomerPage.image;
        }

        private void RequestBtn_Click(object sender, EventArgs e)
        {
            DateTime ReqDate = DateTime.Now;
            int driverReq;
            if (DriverReq.Checked)
            {
                driverReq = 1;
            }else
            {
                driverReq = 0;
            }
            DateTime PickUpDate = FromDate.Value;
            int NumofDays = Convert.ToInt32(DaysTxt.Text);
            int CID = CustomerPage.CarID;
            int UID = User.userid;
            int TAmount = Convert.ToInt32(lblTotalAmount.Text);

            bool success = operation.UserRequest(ReqDate, driverReq, PickUpDate, NumofDays, CID, UID, TAmount);

            if (success)
            {
                MessageBox.Show("Request Generated successfully.");
                // Optionally, close the sign-up form or clear the textboxes
                CustomerPage customerPage = new CustomerPage();
                customerPage.ShowDialog();
                this.Close();
            }
        }

        private void TotalAmount_Click(object sender, EventArgs e)
        {

        }

        private void DaysTxt_TextChanged(object sender, EventArgs e)
        {
            try
            {
                totamount = 0;
                HRent = Convert.ToInt32(HourlyRentTxt.Text);
                days = Convert.ToInt32(DaysTxt.Text);
                totamount = HRent * days * 24;
                lblTotalAmount.Text = totamount.ToString();
            }catch (Exception ex)
            {
                lblTotalAmount.Text = "0";
            }
        }
    }
}
