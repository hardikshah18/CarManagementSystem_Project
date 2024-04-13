using System;
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
    public partial class PaymentDetails : Form
    {
        dbConnection db;
        PaymentOprations oprations;

        public PaymentDetails()
        {
            InitializeComponent();
            db = new dbConnection();
            oprations = new PaymentOprations();
        }

        private void PaymentDetails_Load(object sender, EventArgs e)
        {
            string uname;

            bool success = oprations.Display(out uname);

            if (success)
            {
                UserNameTxt.Text = uname;
            }

            AmountTxt.Text = ViewRequestCustomer.FinalAmount.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int userid = User.userid;
            int requestid = ViewRequestCustomer.requestid;
            int driverid = ViewRequestCustomer.driverid;
            int amount = ViewRequestCustomer.FinalAmount;
            decimal cardNum = Convert.ToDecimal(CardNoTxt.Text);
            int cvv = Convert.ToInt32(CVVTxt.Text);
            DateTime date = Convert.ToDateTime(expdate.Text);

            bool success = oprations.Payment(requestid, userid, driverid, cardNum, cvv, date, amount);

            if (success)
            {
                MessageBox.Show("Payment Success", "information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                if (DialogResult == DialogResult.OK)
                {
                    CustomerPage HomePage = new CustomerPage();
                    HomePage.Show();
                    this.Close();
                }
            }
        }
    }
}
