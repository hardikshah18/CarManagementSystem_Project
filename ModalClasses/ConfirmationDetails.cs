using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarManagementSystem.Models
{
    public class ConfirmationDetails
    {
        public int ConfirmationID { get; set; }
        public int RequestID { get; set; }
        public int DriverID { get; set; }
        public ConfirmationDetails(int ConfirmationID, int RequestID, int DriverID)
        {
            this.ConfirmationID = ConfirmationID;
            this.RequestID = RequestID;
            this.DriverID = DriverID;
        }
    }
}
