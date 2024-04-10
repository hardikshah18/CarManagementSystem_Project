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
    public partial class MakeRequest : Form
    {
        private dbConnection dbConnection;
        public MakeRequest(string data, int CardID)
        {
            InitializeComponent();
            dbConnection = new dbConnection();
            MessageBox.Show(CardID.ToString());

            string[] cardetail = data.Split(new string[] { "       -       " }, StringSplitOptions.None);

            if (cardetail.Length >= 1)
            {
                CModelTxt.Text = cardetail[0];
                CNameTxt.Text = cardetail[1];
                TypeTxt.Text = cardetail[2];
                HourlyRentTxt.Text = cardetail[3];
            }
        }
    }
}
