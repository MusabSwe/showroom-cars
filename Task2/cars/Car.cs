using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;

namespace Task2
{
    public class Car : Vehicle
    {
        public string name { get; set; }

        public int passengerNum { get; set; }
        public int numberOfCylinders { get; set; }

        public int numberOfDoors { get; set; }
        public Wheel wheel = new Wheel();
        public EngineType engine = new EngineType();
        public FuelEconomy fuelEconomy = new FuelEconomy();
        public CarFactory c = new CarFactory();

        // --------------------------------
        public bool IsOpen = false;

        public Car(string n, int passengerNum, int numOfCylinders, int numOfDoors, EngineType e, Wheel w)
        {
            if (passengerNum > 0 && numOfCylinders > 0 && numOfDoors > 0)
            {
                this.name = n;
                this.passengerNum = passengerNum;
                this.numberOfCylinders = numOfCylinders;
                this.numberOfDoors = numOfDoors;
                this.engine = e;
                this.wheel = w;
            }
            else
            {
                Console.WriteLine("Invalid input, the values should be > 0");
            }
        }

        public Car(string n, int passengerNum, int numOfCylinders, int numOfDoors, EngineType e, Wheel w, FuelEconomy f)
        {
            if (passengerNum > 0 && numOfCylinders > 0 && numOfDoors > 0)
            {
                this.name = n;
                this.passengerNum = passengerNum;
                this.numberOfCylinders = numOfCylinders;
                this.numberOfDoors = numOfDoors;
                this.engine = e;
                this.wheel = w;
                this.fuelEconomy = f;
            }
            else
            {
                Console.WriteLine("Invalid input, the values should be > 0");
            }
        }

        public Car()
        {
        }

        public string toString(string w, string e = "Regular")
        {
            
            c.ConnectToDB();
            int j = 0;
            for (int i = 0; i < c.wheels.Length; i++)
            {
                if (c.wheels[i].tireName.ToLower().Equals(w.ToLower()))
                {
                    j = i;
                }
            }

            if (e.ToLower().Equals("regular"))
            {
                return "Specifications for " + name + " car are:\nnumber of passengers: " + passengerNum +
                       "\nnumber of cylinders: " + numberOfCylinders + "\nnumber of doors: " + numberOfDoors +
                       "\nThe engine type is Regular\n" + c.wheels[j].toString() + "\n" +
                       fuelEconomy.toString();
            }
            else if (e.ToLower().Equals("hybrid"))
            {
                return "Specifications for " + name + " car are:\nnumber of passengers: " + passengerNum +
                       "\nnumber of cylinders: " + numberOfCylinders + "\nnumber of doors: " + numberOfDoors +
                       "\nThe engine type is  " + engine.EngineName + "\n" + c.wheels[j].toString();
            }else
            {
                return "Specifications for " + name + " car are:\nnumber of passengers: " + passengerNum +
                       "\nnumber of cylinders: " + numberOfCylinders + "\nnumber of doors: " + numberOfDoors +
                       "\nThe engine type is Diesel\n" + c.wheels[j].toString();
            }
        }
    }
}
