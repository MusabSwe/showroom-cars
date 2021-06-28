using System;
using System.Collections.Generic;

namespace Task2
{
    public class BikeFactory
    {
        public List<Bike> arrBike = new List<Bike>();
        public Wheel[] wheels = new Wheel[2];

        public BikeFactory(List<Bike> arr)
        {
            this.arrBike = arr;
        }

        public BikeFactory()
        {
        }

        public void AddBike(Bike arr)
        {
            if (arr.engine.EngineName != null)
            {
                arrBike.Add(new Bike(arr.name, arr.passengerNum, arr.numberOfWheels, arr.bikeType, arr.engine,
                    arr.wheel));
            }
            else if (arr.engine.EngineName.ToLower().Equals("regular"))
            {
                arrBike.Add(new Bike(arr.name, arr.passengerNum, arr.numberOfWheels, arr.bikeType, arr.engine,
                    arr.wheel, arr.fuelEcon));
            }
            else
            {
                arrBike.Add(new Bike(arr.name, arr.passengerNum, arr.numberOfWheels, arr.bikeType, arr.wheel));
            }
        }

        public void ConnectToDB()
        {
            wheels[0] = new Wheel("Cobra", "German ", new DateTime(2021, 2, 22), 12);
            wheels[1] = new Wheel("Kenda", "America ", new DateTime(2020, 9, 17), 9);
            
            /*0*/
            arrBike.Add(new Bike("Venom", 2, 2, "motor bike", new EngineType(2, "Regular"),
                new Wheel("Cobra", "German ", new DateTime(2021, 2, 22), 12),
                new FuelEconomy("Venom", new DateTime(2021, 3, 4), "Green", "Good")));
            /*1*/
            arrBike.Add(
                new Bike("Rambo", 1, 2, "Bicycle", new Wheel("Kenda", "America ", new DateTime(2020, 9, 17), 9)));
        }

        public void Main(string userName)
        {
            //-------------------------Bike var------------------------------------
            string bikeType = "";
            string bicycleType = "";
            string VenomMotor = "";
            BikeFactory bikes = new BikeFactory();
            bikes.ConnectToDB();
            Console.WriteLine("Welcome to bikes market");
            Console.WriteLine("There are 2 types of bikes Bicycle and Motor Bike,\nwhat type do you want?");
            while (!(bikeType.ToLower().Equals("bicycle") || bikeType.ToLower().Equals("motor bike")))
            {
                bikeType = Console.ReadLine();
                if (bikeType.ToLower().Equals("bicycle"))
                {
                    Console.WriteLine("In the bicycles market there is only one type to sell");
                    while (!bicycleType.ToLower().Equals("rambo"))
                    {
                        Console.WriteLine("1.Rambo\n2.Exit\nSelect an option?");
                        bicycleType = Console.ReadLine();
                        if (bicycleType.ToLower().Equals("rambo"))
                        {
                            Console.WriteLine("Nice choice " + userName + " to select Rambo bicycle");

                            Console.WriteLine("This is a summary of your selection:");
                            Console.WriteLine(bikes.arrBike[1].toString());
                        }
                        else if (bicycleType.ToLower().Equals("exit"))
                        {
                            Console.WriteLine("Thank you to visit the bicycle market");
                            break;
                        }
                        else
                        {
                            Console.WriteLine(
                                "Invalid option you should select one of the displayed options");
                        }
                    }
                }
                else if (bikeType.ToLower().Equals("motor bike"))
                {
                    Console.WriteLine("Welcome to motor bike market");
                    Console.WriteLine("In the motor bikes market there is only one type to sell");
                    while (!VenomMotor.ToLower().Equals("venom"))
                    {
                        Console.WriteLine("1.Venom\n2.Exit\nSelect an option?");
                        VenomMotor = Console.ReadLine();
                        if (VenomMotor.ToLower().Equals("venom"))
                        {
                            Console.WriteLine("Nice choice " + userName + " to select Venom motor bike");

                            Console.WriteLine("This is a summary of your selection:");
                            Console.WriteLine(bikes.arrBike[0].toString());
                        }
                        else if (VenomMotor.ToLower().Equals("exit"))
                        {
                            Console.WriteLine("Thank you to visit the bicycle market");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Invalid option you should select one of the displayed options");
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input, you should select one either Bicycle or motor bike");
                }
            }
        }
    }
}
