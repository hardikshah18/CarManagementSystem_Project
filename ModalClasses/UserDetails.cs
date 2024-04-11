using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarManagementSystem.Models
{
    public class UserDetails
    {
        public int UserID { get; set; }
        public int IsAdmin { get; set; }
        public string FullName { get; set; }
        public string EmailID { get; set; }
        public string Password { get; set; }
        public DateTime DOB { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Province { get; set; }
        public string Country { get; set; }
        public UserDetails(int UserID, int IsAdmin, string FullName, string EmailID, string Password, DateTime DOB, string Address, string City, string Province, string Country) 
        {
            this.UserID = UserID;
            this.IsAdmin = IsAdmin;
            this.FullName = FullName;
            this.EmailID = EmailID;
            this.Password = Password;
            this.DOB = DOB;
            this.Address = Address;
            this.City = City;
            this.Province = Province;
            this.Country = Country;
        }
    }
}
