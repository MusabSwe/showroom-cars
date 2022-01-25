using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata.Ecma335;

namespace ShowRoom.Core
{
    public class Bike : Vehicle
    {
        //columns
        [Required]
        public string Name { get; set; }
        [Required(ErrorMessage = "The Passenger Number field is required.")]
        [Display(Name = "Passenger Number")]
        public int? PassengerNum { get; set; }
        [Required(ErrorMessage = "The Number Of Wheels field is required.")]
        [Display(Name = "Number Of Wheels")]
        public int? NumberOfWheels { get; set; }
        [Required]
        [Display(Name = "Bike Type")]
        public string BikeType { get; set; }
        //FKs
        [Required(ErrorMessage = "The Fuel Economy field is required.")]
        public int? FuelEconomyId { get; set; }
        public FuelEconomy fuelEconomy { get; set; }
        [Required(ErrorMessage = "The Engine field is required.")]
        public int? EngineId { get; set; }
        public Engine engine { get; set; }
        [Required(ErrorMessage = "The Wheel field is required.")]
        public int? WheelId { get; set; }
        public Wheel wheel { get; set; }

        BikeFactory b = new BikeFactory();

        public Bike(string name, int passengerNum, int numOfWheels, string bikeType, Engine e, Wheel w,
            FuelEconomy f)
        {
            if (passengerNum > 0 && numOfWheels > 0)
            {
                this.Name = name;
                this.PassengerNum = passengerNum;
                this.NumberOfWheels = numOfWheels;
                this.BikeType = bikeType;
                this.engine = e;
                this.wheel = w;
                this.fuelEconomy = f;
            }
            else
            {
                Console.WriteLine("Invalid input");
            }
        }

        public Bike(string name, int passengerNum, int numOfWheels, string bikeType, int f, int e, int w)
        {
                this.Name = name;
                this.PassengerNum = passengerNum;
                this.NumberOfWheels = numOfWheels;
                this.BikeType = bikeType;
                this.FuelEconomyId = f;
                this.EngineId = e;
                this.WheelId = w;       
        }

        public Bike(string name, int passengerNum, int numOfWheels, string bikeType, Wheel w)
        {
            if (passengerNum > 0 && numOfWheels > 0)
            {
                this.Name = name;
                this.PassengerNum = passengerNum;
                this.NumberOfWheels = numOfWheels;
                this.BikeType = bikeType;
                this.wheel = w;
            }
            else
            {
                Console.WriteLine("Invalid input");
            }
        }


        public Bike(string name, int passengerNum, int numOfWheels, string bikeType, Engine e, Wheel w)
        {
            if (passengerNum > 0 && numOfWheels > 0)
            {
                this.Name = name;
                this.PassengerNum = passengerNum;
                this.NumberOfWheels = numOfWheels;
                this.BikeType = bikeType;
                this.engine = e;
                this.wheel = w;
            }
            else
            {
                Console.WriteLine("Invalid input");
            }
        }

        public Bike()
        {
        }

        public string toString()
        {
            if (this.BikeType.ToLower().Equals("bicycle"))
            {
                return "Specifications for " + Name + " bike are:\nnumber of passengers: "
                       + PassengerNum + "\nnumber of wheels: " + NumberOfWheels + "\nbike type: " + BikeType
                       + "\n" + wheel.toString();
            }
            else
            {
                return "Specifications for " + Name + " bike are:\nnumber of passengers: "
                       + PassengerNum + "\nnumber of wheels: " + NumberOfWheels + "\nbike type: " + BikeType
                       + "\nThe engine type is Regular\n" + wheel.toString();
            }
        }

        public String Display(int? i = null)
        {
            return "Specifications for: " + Name + " car with Id: " + i + " are:\nnumber of passengers: " + PassengerNum +
                    "\nnumber of Wheels " + NumberOfWheels +
                    "\nType of Bike: " + BikeType + " - fuelEconomyId: " + FuelEconomyId +
                    " - EngineId: " + EngineId + " - WheelId: " + WheelId; ;
        }

    }
}