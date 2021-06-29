namespace Task2
{
    public class Van : Car
    {
        public Van(string n, int passNum, int cylindNum, int doorNum, EngineType e, Wheel w, FuelEconomy f)
        {
            this.name = n;
            this.passengerNum = passNum;
            this.numberOfCylinders = cylindNum;
            this.numberOfDoors = doorNum;
            this.engine = e;
            this.wheel = w;
            this.fuelEconomy = f;
        }

        public Van(string n, int passNum, int cylindNum, int doorNum, EngineType e, Wheel w)
        {
            this.name = n;
            this.passengerNum = passNum;
            this.numberOfCylinders = cylindNum;
            this.numberOfDoors = doorNum;
            this.engine = e;
            this.wheel = w;
        }
        public string toString(string w, string e = "Regular")
        {
            CarFactory c = new CarFactory();
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
                return "Specifications for " + name + " sedan car are:\nnumber of passengers: " + passengerNum +
                       "\nnumber of cylinders: " + numberOfCylinders + "\nnumber of doors: " + numberOfDoors +
                       "\nThe engine type is Regular\n" + c.wheels[j].toString() + "\n" +
                       fuelEconomy.toString();
            }
            else if (e.ToLower().Equals("hybrid"))
            {
                return "Specifications for " + name + " van car are:\nnumber of passengers: " + passengerNum +
                       "\nnumber of cylinders: " + numberOfCylinders + "\nnumber of doors: " + numberOfDoors +
                       "\nThe engine type is  " + engine.EngineName + "\n" + c.wheels[j].toString();
            }
            else
            {
                return "Specifications for " + name + " car are:\nnumber of passengers: " + passengerNum +
                       "\nnumber of cylinders: " + numberOfCylinders + "\nnumber of doors: " + numberOfDoors +
                       "\nThe engine type is Diesel\n" + c.wheels[j].toString();
            }
        }
    }
}
