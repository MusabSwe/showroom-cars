using System;

namespace Task2
{
    class FuelEconomy
    {
        private string economyLevel;
        private string fuelType;
        private string vehicleName;
        private DateTime vehicleModel;

        public FuelEconomy(string VehicleName, DateTime vehicleModel, string fuelType, string EconomyLevel)
        {

            this.vehicleName = VehicleName;
            this.vehicleModel = vehicleModel;
            this.fuelType = fuelType;
            this.economyLevel = EconomyLevel;

        }

        public FuelEconomy()
        {

        }

        public string EconomyLevelProp { get; set; }

        public string FuelTypeProp { get; set; }

        public string VehicleNameProp { get; set; }

        public DateTime VehicleModelProp { get; set; }

        public string DisplayFuelInfo()
        {

            return "Fuel economy for " + VehicleNameProp + " Model " + VehicleModelProp + " is:\nfuel Type: " + FuelTypeProp + "\nEconomy level: " + EconomyLevelProp;

        }

    }
}