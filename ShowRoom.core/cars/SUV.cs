using System;

namespace ShowRoom.Core
{
    public class SUV : Car, ISunRoof
    {
        Car c1 = new Car();

        public SUV(string n, int passNum, int cylindNum, int doorNum, Engine e, Wheel w, FuelEconomy f)
        {
            this.Name = n;
            this.PassengerNum = passNum;
            this.NumberOfCylinders = cylindNum;
            this.NumberOfDoors = doorNum;
            this.engine = e;
            this.wheel = w;
            this.fuelEconomy = f;
        }

        public SUV(string n, int passNum, int cylindNum, int doorNum, Engine e, Wheel w)
        {
            this.Name = n;
            this.PassengerNum = passNum;
            this.NumberOfCylinders = cylindNum;
            this.NumberOfDoors = doorNum;
            this.engine = e;
            this.wheel = w;
        }

        public void toggle()
        {
            if (c1.IsOpen == true)
            {
                Console.WriteLine("The sunroof of SUV car is open");
                Console.WriteLine("off");
                c1.IsOpen = false;
            }
            else if (c1.IsOpen == false)
            {
                Console.WriteLine("The sunroof of SUV car is closed");
                Console.WriteLine("on");
                c1.IsOpen = true;
            }
        }
        
        public string toString(string w, string e = "Regular")
        {
            CarFactory s = new CarFactory();
            s.ConnectToDB();
            int j = 0;
            for (int i = 0; i < s.wheels.Length; i++)
            {
                if (s.wheels[i].TireName.ToLower().Equals(w.ToLower()))
                {
                    j = i;
                }
            }

            if (e.ToLower().Equals("regular"))
            {
                return "Specifications for " + Name + " SUV car are:\nnumber of passengers: " + PassengerNum +
                       "\nnumber of cylinders: " + NumberOfCylinders + "\nnumber of doors: " + NumberOfDoors +
                       "\nThe engine type is Regular\n" + s.wheels[j].toString() + "\n" +
                       fuelEconomy.toString();
            }
            else if (e.ToLower().Equals("hybrid"))
            {
                return "Specifications for " + Name + " sedan car are:\nnumber of passengers: " + PassengerNum +
                       "\nnumber of cylinders: " + NumberOfCylinders + "\nnumber of doors: " + NumberOfDoors +
                       "\nThe engine type is  " + engine.EngineName + "\n" + s.wheels[j].toString();
            }
            else
            {
                return "";
            }
        }
    }
}