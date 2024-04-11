using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace CarManagementSystem.Models
{
    public class RequestDetails
    {
        public int RequestID { get; set; }
        public DateTime RequestDate { get; set; }
        public int IsDriverReq { get; set; }
        public DateTime PickUpDate { get; set; }
        public int NumofDays { get; set; }
        public int CarID { get; set; }
        public int UserID { get; set; }

        public RequestDetails(int RequestID, DateTime RequestDate, int IsDriverReq, DateTime PickUpDate, int NumofDays, int CarID, int UserID) 
        {
            this.RequestID = RequestID;
            this.RequestDate = RequestDate;
            this.IsDriverReq = IsDriverReq;
            this.PickUpDate = PickUpDate;
            this.NumofDays = NumofDays;
            this.CarID = CarID;
            this.UserID = UserID;
        }


    }
}
