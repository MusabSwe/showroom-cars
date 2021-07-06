using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;

namespace Task2
{
    public class Car : Vehicle
    {
        public int CarId { get; set; }
        public string Name { get; set; }
        public int PassengerNum { get; set; }
        public int NumberOfCylinders { get; set; }
        public int NumberOfDoors { get; set; }
        public Wheel Wheel = new Wheel();
        public Engine Engines = new Engine();
        public FuelEconomy FuelEconomy = new FuelEconomy();

        CarFactory c = new CarFactory();

        // --------------------------------
        public bool IsOpen = false;

        public Car(string n, int passengerNum, int numOfCylinders, int numOfDoors, Engine e, Wheel w)
        {
            if (passengerNum > 0 && numOfCylinders > 0 && numOfDoors > 0)
            {
                this.Name = n;
                this.PassengerNum = passengerNum;
                this.NumberOfCylinders = numOfCylinders;
                this.NumberOfDoors = numOfDoors;
                this.Engines = e;
                this.Wheel = w;
            }
            else
            {
                Console.WriteLine("Invalid input, the values should be > 0");
            }
        }

        public Car(string n, int passengerNum, int numOfCylinders, int numOfDoors, Engine e, Wheel w, FuelEconomy f)
        {
            if (passengerNum > 0 && numOfCylinders > 0 && numOfDoors > 0)
            {
                this.Name = n;
                this.PassengerNum = passengerNum;
                this.NumberOfCylinders = numOfCylinders;
                this.NumberOfDoors = numOfDoors;
                this.Engines = e;
                this.Wheel = w;
                this.FuelEconomy = f;
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
                if (c.wheels[i].TireName.ToLower().Equals(w.ToLower()))
                {
                    j = i;
                }
            }
            if (e.ToLower().Equals("regular"))
            {
                return "Specifications for " + Name + " car are:\nnumber of passengers: " + PassengerNum +
                       "\nnumber of cylinders: " + NumberOfCylinders + "\nnumber of doors: " + NumberOfDoors +
                       "\nThe engine type is Regular\n" + c.wheels[j].toString() + "\n" +
                       FuelEconomy.toString();
            }
            else if (e.ToLower().Equals("hybrid"))
            {
                return "Specifications for " + Name + " car are:\nnumber of passengers: " + PassengerNum +
                       "\nnumber of cylinders: " + NumberOfCylinders + "\nnumber of doors: " + NumberOfDoors +
                       "\nThe engine type is  " + Engines.EngineName + "\n" + c.wheels[j].toString();
            }
            else
            {
                return "Specifications for " + Name + " car are:\nnumber of passengers: " + PassengerNum +
                       "\nnumber of cylinders: " + NumberOfCylinders + "\nnumber of doors: " + NumberOfDoors +
                       "\nThe engine type is Diesel\n" + c.wheels[j].toString();
            }
        }
    }
}
