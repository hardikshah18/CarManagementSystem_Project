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
    public partial class DriverHomePage : Form
    {
        private dbConnection dbConnection;
        public DriverHomePage()
        {
            InitializeComponent();
            dbConnection = new dbConnection();
        }
        void DisplayCar()
        {
            using (SqlConnection conn = dbConnection.GetConnection())
            {
                conn.Open();

                int DID = User.driverid;

                string query = "SELECT C.CarModel, C.ComapanyName, U.Address, U.FullName, R.PickUpDate, R.NumofDays" +
                    " FROM cConformationDetails CD JOIN cRequestDetails R ON R.RequestID = CD.RequestID join " +
                    "cCarDetails C ON CD.CarID = C.CarID JOIN cUserDetails U ON R.UserID = U.UserID JOIN " +
                    "cDriverDetails D ON D.DriverID = CD.DriverID WHERE D.DriverID = @DriverID";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@DriverID", DID);

                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        DataTable carTable = new DataTable();
                        adapter.Fill(carTable);
                        DriverReq.DataSource = carTable;

                        //carID = int.Parse(carTable.Rows[0][9].ToString());
                        //SqlDataReader reader1 = cmd.ExecuteReader();
                        //reader1.Read();
                        //reader1.Close();
                    }
                }
            }
        }
        private void DriverHomePage_Load(object sender, EventArgs e)
        {
            DisplayCar();
        }

        private void DriverReq_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0) 
            {
                DataGridViewRow row = this.DriverReq.Rows[e.RowIndex];

                CModelTxt.Text = row.Cells[0].Value.ToString();
                CNameTxt.Text = row.Cells[1].Value.ToString();
                CustomerNameTxt.Text = row.Cells[3].Value.ToString();
                LocationTxt.Text = row.Cells[2].Value.ToString();
                DateTxt.Text = row.Cells[4].Value.ToString();
                NumOfDays.Text = row.Cells[5].Value.ToString();
            }
        }

        private void LogOutBtn_Click(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            login.ShowDialog();
            this.Hide();
        }
    }
}
