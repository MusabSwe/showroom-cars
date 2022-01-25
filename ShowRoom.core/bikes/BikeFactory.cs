using System;
using System.Collections.Generic;

namespace ShowRoom.Core
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
                arrBike.Add(new Bike(arr.Name, arr.PassengerNum.Value, arr.NumberOfWheels.Value, arr.BikeType, arr.engine,
                    arr.wheel));
            }
            else if (arr.engine.EngineName.ToLower().Equals("regular"))
            {
                arrBike.Add(new Bike(arr.Name, arr.PassengerNum.Value, arr.NumberOfWheels.Value, arr.BikeType, arr.engine,
                    arr.wheel, arr.fuelEconomy));
            }
            else
            {
                arrBike.Add(new Bike(arr.Name, arr.PassengerNum.Value, arr.NumberOfWheels.Value, arr.BikeType, arr.wheel));
            }
        }

        public void ConnectToDB()
        {
            wheels[0] = new Wheel("Cobra", "German ", new DateTime(2021, 2, 22), 12);
            wheels[1] = new Wheel("Kenda", "America ", new DateTime(2020, 9, 17), 9);

            /*0*/
            arrBike.Add(new Bike("Venom", 2, 2, "motor bike", new Engine(2, "Regular"),
                new Wheel("Cobra", "German ", new DateTime(2021, 2, 22), 12),
                new FuelEconomy("Venom", new DateTime(2021, 3, 4), "Green", "Good")));
            /*1*/
            arrBike.Add(
                new Bike("Rambo", 1, 2, "Bicycle", new Wheel("Kenda", "America ", new DateTime(2020, 9, 17), 9)));
        }

        public void BikesShowroom(string userName)
        {
            int bikeType = 0;
            int bicycleType = 0;
            int VenomMotor = 0;
            BikeFactory bikes = new BikeFactory();
            bikes.ConnectToDB();
            Console.WriteLine("Welcome to bikes market");
            Console.WriteLine("There are 2 types of bikes \n1.Bicycle\n2.Motor Bike\nSelect a number:");
            while (!(bikeType == (int) BikeOptions.bicycle || bikeType == (int) BikeOptions.motor))
            {
                try
                {
                    bikeType = Convert.ToInt32(Console.ReadLine());
                    if (bikeType == (int) BikeOptions.bicycle)
                    {
                        Console.WriteLine("In the bicycles market there is only one type to sell");
                        while (!(bicycleType == (int) bicycleOptions.rambo || bicycleType == (int) bicycleOptions.exit))
                        {
                            try
                            {
                                Console.WriteLine("1.Rambo\n2.Exit\nSelect an option?");
                                bicycleType = Convert.ToInt32(Console.ReadLine());
                                if (bicycleType == (int) bicycleOptions.rambo)
                                {
                                    Console.WriteLine("Nice choice " + userName + " to select Rambo bicycle");

                                    Console.WriteLine("This is a summary of your selection:");
                                    Console.WriteLine(bikes.arrBike[1].toString());
                                }
                                else if (bicycleType == (int) bicycleOptions.exit)
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
                            catch (Exception e)
                            {
                                Console.WriteLine(
                                    "Invalid option you should select number of the displayed options");
                            }
                        }
                    }
                    else if (bikeType == (int) BikeOptions.motor)
                    {
                        Console.WriteLine("Welcome to motor bike market");
                        Console.WriteLine("In the motor bikes market there is only one type to sell");
                        while (!(VenomMotor == (int) MotorOptions.venom || VenomMotor == (int) MotorOptions.exit))
                        {
                            try
                            {
                                Console.WriteLine("1.Venom\n2.Exit\nSelect an option?");
                                VenomMotor = Convert.ToInt32(Console.ReadLine());
                                if (VenomMotor == (int) MotorOptions.venom)
                                {
                                    Console.WriteLine("Nice choice " + userName + " to select Venom motor bike");

                                    Console.WriteLine("This is a summary of your selection:");
                                    Console.WriteLine(bikes.arrBike[0].toString());
                                }
                                else if (VenomMotor == (int) MotorOptions.exit)
                                {
                                    Console.WriteLine("Thank you to visit the bicycle market");
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("Invalid option you should select one of the displayed options");
                                }
                            }
                            catch (Exception e)
                            {
                                Console.WriteLine("Invalid option you should select number of the displayed options");
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid input, you should select number either Bicycle or motor bike");
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Invalid input, you should select number either Bicycle or motor bike");
                }
            }
        }
    }
}