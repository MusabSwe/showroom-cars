using System;

namespace Task2
{
    public class FuelEconomy
    {
        public int FuelEconomyId { get; set; }
        public string EconomyLevel { get; set; }

        public string FuelType { get; set; }

        public string VehicleName { get; set; }

        public DateTime VehicleModel { get; set; }

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

            return "Fuel economy for " + VehicleName + " Model " + VehicleModel + " is:\nfuel Type: " + FuelType + "\nEconomy level: " + EconomyLevel;

        }

    }
}
