using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarManagementSystem
{
    public class dbConnection
    {
        private const string conn = @"Data Source=45.40.159.133;Initial Catalog=TourismDMS;Persist Security Info=True;User ID=Arjav;Password=@Myproj123";
        public SqlConnection GetConnection()
        {
            return new SqlConnection(conn);
        }
    }
}
