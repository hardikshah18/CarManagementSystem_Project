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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace CarManagementSystem
{
    public partial class ViewRequestCustomer : Form
    {
        private dbConnection dbConnection;

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
                string query = "SELECT R.RequestID, R.RequestDate, R.IsDriverReq, R.PickUpDate, R.NumofDays, " +
                    "C.CarModel, C.CarImage, U.FullName FROM cRequestDetails R JOIN cCarDetails C ON R.CarID = C.CarID join " +
                    "cUserDetails U ON R.UserID = U.UserID";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        DataTable carTable = new DataTable();
                        adapter.Fill(carTable);
                        RequestGridView.DataSource = carTable;
                    }
                }
            }
        }
    }
}
