namespace Task2
{
    public class Van : Car
    {
        public Van(string n, int passNum, int cylindNum, int doorNum, Engine e, Wheel w, FuelEconomy f)
        {
            this.Name = n;
            this.PassengerNum = passNum;
            this.NumberOfCylinders = cylindNum;
            this.NumberOfDoors = doorNum;
            this.Engines = e;
            this.Wheel = w;
            this.FuelEconomy = f;
        }

        public Van(string n, int passNum, int cylindNum, int doorNum, Engine e, Wheel w)
        {
            this.Name = n;
            this.PassengerNum = passNum;
            this.NumberOfCylinders = cylindNum;
            this.NumberOfDoors = doorNum;
            this.Engines = e;
            this.Wheel = w;
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
                return "Specifications for " + Name + " van car are:\nnumber of passengers: " + PassengerNum +
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
