using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarManagementSystem.Models
{
    public class CarDetails
    {
        public int CarID { get; set; }
        public string CarModel { get; set; }
        public string CompanyName { get; set; }
        public string Type { get; set; }
        public decimal Rent {  get; set; }
        public int IsAvailable { get; set; }
        public Image CarImage { get; set; }
        public string NumberPlate { get; set; }
        public CarDetails(int CarID, string CarModel, string CompanyName, string Type, decimal Rent, int IsAvailable, Image CarImage, string NumberPlate) 
        {
            this.CarID = CarID;
            this.CarModel = CarModel;
            this.CompanyName = CompanyName;
            this.Type = Type;
            this.Rent = Rent;
            this.IsAvailable = IsAvailable;
            this.CarImage = CarImage;
            this.NumberPlate = NumberPlate;
        }
    }
}
