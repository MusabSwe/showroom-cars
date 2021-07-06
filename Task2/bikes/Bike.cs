using System;
using System.Reflection.Metadata.Ecma335;

namespace Task2
{
    public class Bike
    {
        public int BikeId { get; set; }
        
        public string Name { get; set; }

        public int PassengerNum { get; set; }

        public int NumberOfWheels { get; set; }

        public string BikeType { get; set; }

        public Wheel Wheel = new Wheel();

        public Engine Engines = new Engine();
        public FuelEconomy FuelEcon = new FuelEconomy();
        public BikeFactory b = new BikeFactory();

        public Bike(string name, int passengerNum, int numOfWheels, string bikeType, Engine e, Wheel w,
            FuelEconomy f)
        {
            if (passengerNum > 0 && numOfWheels > 0)
            {
                this.Name = name;
                this.PassengerNum = passengerNum;
                this.NumberOfWheels = numOfWheels;
                this.BikeType = bikeType;
                this.Engines = e;
                this.Wheel = w;
                this.FuelEcon = f;
            }
            else
            {
                Console.WriteLine("Invalid input");
            }
        }

        public Bike(string name, int passengerNum, int numOfWheels, string bikeType, Wheel w)
        {
            if (passengerNum > 0 && numOfWheels > 0)
            {
                this.Name = name;
                this.PassengerNum = passengerNum;
                this.NumberOfWheels = numOfWheels;
                this.BikeType = bikeType;
                this.Wheel = w;
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
                this.Engines = e;
                this.Wheel = w;
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
                       + "\n" + Wheel.toString();
            }
            else
            {
                return "Specifications for " + Name + " bike are:\nnumber of passengers: "
                       + PassengerNum + "\nnumber of wheels: " + NumberOfWheels + "\nbike type: " + BikeType
                       + "\nThe engine type is Regular\n" + Wheel.toString();
            }
        }
    }
}
