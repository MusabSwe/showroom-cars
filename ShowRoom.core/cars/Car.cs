using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata.Ecma335;

namespace ShowRoom.Core
{
    public class Car : Vehicle
    {

        //columns
        [Required]
        public string Name { get; set; }
        [Required(ErrorMessage = "The Passenger Number field is required.")]
        [Display(Name = "Passenger Number")]
        [Range(typeof(int),"1","20")]
        public int? PassengerNum { get; set; }
        [Required(ErrorMessage = "The Number Of Cylinders field is required.")]
        [Display(Name = "Number Of Cylinders")]
        [Range(typeof(int), "3", "12")]
        public int? NumberOfCylinders { get; set; }
        [Required(ErrorMessage = "The Number Of Doors field is required.")]
        [Display(Name = "Number Of Doors")]
        [Range(typeof(int), "2", "5")]
        public int? NumberOfDoors { get; set; }
        //FK
        [Required(ErrorMessage = "The Fuel Economy field is required.")]
        public int? FuelEconomyId { get; set; }
        public FuelEconomy fuelEconomy { get; set; }
        [Required(ErrorMessage = "The Engine field is required.")]
        public int? EngineId { get; set; }
        public Engine engine { get; set; }
        [Required(ErrorMessage = "The Wheel field is required.")]
        public int? WheelId { get; set; }
        public Wheel wheel { get; set; }

        CarFactory c = new CarFactory();
        public bool IsOpen = false;

        public Car(string n, int p, int c, int d,int FId, int EId, int WId)
        {
     
            this.Name = n;
            this.PassengerNum = p;
            this.NumberOfCylinders = c;
            this.NumberOfDoors = d;
            this.FuelEconomyId = FId;
            this.EngineId = EId;
            this.WheelId = WId;
        }

        public Car(string n, int passengerNum, int numOfCylinders, int numOfDoors, Engine e, Wheel w)
        {
            if (passengerNum > 0 && numOfCylinders > 0 && numOfDoors > 0)
            {
                this.Name = n;
                this.PassengerNum = passengerNum;
                this.NumberOfCylinders = numOfCylinders;
                this.NumberOfDoors = numOfDoors;
                this.engine = e;
                this.wheel = w;
            }
            else
            {
                Console.WriteLine("Invalid input, the values should be > 0");
            }
        }
        
        public void add(int i,string n, int p, int c, int d, int FId, int EId, int WId)
        {

            this.Name = n;
            this.PassengerNum = p;
            this.NumberOfCylinders = c;
            this.NumberOfDoors = d;
            this.FuelEconomyId = FId;
            this.EngineId = EId;
            this.WheelId = WId;
        }

        public void add(string n, int p, int c, int d, int FId, int EId, int WId)
        {
            this.Name = n;
            this.PassengerNum = p;
            this.NumberOfCylinders = c;
            this.NumberOfDoors = d;
            this.FuelEconomyId = FId;
            this.EngineId = EId;
            this.WheelId = WId;
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
                       fuelEconomy.toString();
            }
            else if (e.ToLower().Equals("hybrid"))
            {
                return "Specifications for " + Name + " car are:\nnumber of passengers: " + PassengerNum +
                       "\nnumber of cylinders: " + NumberOfCylinders + "\nnumber of doors: " + NumberOfDoors +
                       "\nThe engine type is  " + engine.EngineName + "\n" + c.wheels[j].toString();
            }
            else
            {
                return "Specifications for " + Name + " car are:\nnumber of passengers: " + PassengerNum +
                       "\nnumber of cylinders: " + NumberOfCylinders + "\nnumber of doors: " + NumberOfDoors +
                       "\nThe engine type is Diesel\n" + c.wheels[j].toString();
            }
        }

        public String Display(int? i = null)
        {
            return "Specifications for: " + Name + " car with Id: "+ i +" are:\nnumber of passengers: " + PassengerNum +
                    "\nnumber of cylinders: " + NumberOfCylinders +
                    "\nnumber of doors: " + NumberOfDoors + " - fuelEconomyId: " + FuelEconomyId +
                    " - EngineId: " + EngineId + " - WheelId: " + WheelId; ;
        }
    }
}
