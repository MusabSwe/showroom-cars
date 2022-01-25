using System;
using System.ComponentModel.DataAnnotations;

namespace ShowRoom.Core
{
    public class FuelEconomy
    {
        public int Id { get; set; }
        [Required]
        [Display(Name = "Economy Level")]
        public string EconomyLevel { get; set; }
        [Required]
        [Display(Name = "Fuel Type")]
        public string FuelType { get; set; }
        [Required]
        [Display(Name = "Vehicle Name")]
        public string VehicleName { get; set; }
        [Required(ErrorMessage = "The Vehicle Model field is required.")]
        [Display(Name = "Vehicle Model")]
        public DateTime? VehicleModel { get; set; }
        //FK1&2
        public Car Car { get; set; }
        public Bike Bike { get; set; }

        public FuelEconomy(string VehicleName, DateTime vehicleModel, string fuelType, string EconomyLevel)
        {

            this.VehicleName = VehicleName;
            this.VehicleModel = vehicleModel;
            this.FuelType = fuelType;
            this.EconomyLevel = EconomyLevel;

        }

        public FuelEconomy()
        {

        }


        public string toString()
        { 
            return "Fuel Economy card for " + VehicleName + " Model " + VehicleModel.Value.Year + " is:\nfuel Type: " + FuelType + "\nEconomy level: " + EconomyLevel;
        }

    }
}