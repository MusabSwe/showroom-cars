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

        public FuelEconomy(){
            
        }

        public void setEconomyLevel(string e)
        {
            this.economyLevel = e;
        }

        public string getEconomyLevel()
        {
            return economyLevel;
        }

        public void setfuelType(string e)
        {
            this.fuelType = e;
        }

        public string getfuelType()
        {
            return fuelType;
        }

        public void setVehicleName(string e)
        {
            this.vehicleName = e;
        }

        public string getVehicleName()
        {
            return vehicleName;
        }

        public void setvehicleModel(DateTime e)
        {
            this.vehicleModel = e;
        }

        public DateTime getVehicleModel()
        {
            return vehicleModel;
        }

        public string DisplayFuelInfo()
        {

            return "Fuel economy for " + getVehicleName() + " Model " + getVehicleModel() + " is:\nfuel Type: " + getfuelType() + "\nEconomy level: " + getEconomyLevel();

        }

    }
}