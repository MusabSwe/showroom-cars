using System;
using System.Reflection.Metadata.Ecma335;

namespace Task2
{
    public class Bike
    {
        public string name { get; set; }

        public int passengerNum { get; set; }

        public int numberOfWheels { get; set; }

        public string bikeType { get; set; }

        public Wheel wheel = new Wheel();

        public EngineType engine = new EngineType();
        public FuelEconomy fuelEcon = new FuelEconomy();
        public BikeFactory b = new BikeFactory();

        public Bike(string name, int passengerNum, int numOfWheels, string bikeType, EngineType e, Wheel w,
            FuelEconomy f)
        {
            if (passengerNum > 0 && numOfWheels > 0)
            {
                this.name = name;
                this.passengerNum = passengerNum;
                this.numberOfWheels = numOfWheels;
                this.bikeType = bikeType;
                this.engine = e;
                this.wheel = w;
                this.fuelEcon = f;
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
                this.name = name;
                this.passengerNum = passengerNum;
                this.numberOfWheels = numOfWheels;
                this.bikeType = bikeType;
                this.wheel = w;
            }
            else
            {
                Console.WriteLine("Invalid input");
            }
        }

        public Bike(string name, int passengerNum, int numOfWheels, string bikeType, EngineType e, Wheel w)
        {
            if (passengerNum > 0 && numOfWheels > 0)
            {
                this.name = name;
                this.passengerNum = passengerNum;
                this.numberOfWheels = numOfWheels;
                this.bikeType = bikeType;
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
            // b.ConnectToDB();
            // int j = 0;
            // for (int i = 0; i < b.wheels.Length; i++)
            // {
            //     if (b.wheels[i].tireName.ToLower().Equals(w.ToLower()))
            //     {
            //         j = i;
            //     }
            // }

            if (this.bikeType.ToLower().Equals("bicycle"))
            {
                return "Specifications for " + name + " bike are:\nnumber of passengers: "
                       + passengerNum + "\nnumber of wheels: " + numberOfWheels + "\nbike type: " + bikeType
                       + "\n" + wheel.toString();
            }
            else
            {
                return "Specifications for " + name + " bike are:\nnumber of passengers: "
                       + passengerNum + "\nnumber of wheels: " + numberOfWheels + "\nbike type: " + bikeType
                       + "\nThe engine type is Regular\n" + wheel.toString();
            }
        }
    }
}
