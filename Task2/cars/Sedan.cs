using System;

namespace Task2
{
    public class Sedan : Car, ISunRoof
    {
        Car c1 = new Car();

        public Sedan(string n, int passNum, int cylindNum, int doorNum, Engine e, Wheel w, FuelEconomy f)
        {
            this.Name = n;
            this.PassengerNum = passNum;
            this.NumberOfCylinders = cylindNum;
            this.NumberOfDoors = doorNum;
            this.Engines = e;
            this.Wheel = w;
            this.FuelEconomy = f;
        }

        public Sedan(string n, int passNum, int cylindNum, int doorNum, Engine e, Wheel w)
        {
            this.Name = n;
            this.PassengerNum = passNum;
            this.NumberOfCylinders = cylindNum;
            this.NumberOfDoors = doorNum;
            this.Engines = e;
            this.Wheel = w;
        }


        public void toggle()
        {
            if (c1.IsOpen == true)
            {
                Console.WriteLine("The sunroof of Sedan car is open");
                Console.WriteLine("off");
                c1.IsOpen = false;
            }
            else if (c1.IsOpen == false)
            {
                Console.WriteLine("The sunroof of Sedan car is closed");
                Console.WriteLine("on");
                c1.IsOpen = true;
            }
        }

        public string toString(string w, string e = "Regular")
        {
            CarFactory c = new CarFactory();
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
                return "Specifications for " + Name + " sedan car are:\nnumber of passengers: " + PassengerNum +
                       "\nnumber of cylinders: " + NumberOfCylinders + "\nnumber of doors: " + NumberOfDoors +
                       "\nThe engine type is Regular\n" + c.wheels[j].toString() + "\n" +
                       FuelEconomy.toString();
            }
            else if (e.ToLower().Equals("hybrid"))
            {
                return "Specifications for " + Name + " sedan car are:\nnumber of passengers: " + PassengerNum +
                       "\nnumber of cylinders: " + NumberOfCylinders + "\nnumber of doors: " + NumberOfDoors +
                       "\nThe engine type is  " + Engines.EngineName + "\n" + c.wheels[j].toString();
            }
            else
            {
                return "";
            }
        }
    }
}
