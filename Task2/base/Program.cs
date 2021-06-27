using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            string carType = "";
            string vehicleType = "";
            string sedanCar = "";
            string camryEngine = "";
            string camryWheel = "";
            string sonataWheel = "";
            //--------------------------SUV var------------------------------------
            string suvCar = "";
            string hyundaiCretaWheel = "";
            string FortunerWheel = "";
            //-------------------------Van var------------------------------------- 
            string vanCar = "";
            string GMCWheel = "";
            //-------------------------Bike var------------------------------------
            string bikeType = "";
            string bicycleType = "";
            string VenomMotor = "";
            //----------------------Factories-------------------------------------------
            CarFactory cars = new CarFactory();
            BikeFactory bikes = new BikeFactory();
            cars.ConnectToDB();
            bikes.ConnectToDB();
            //--------------------------------System-------------------------------------------------

            Console.WriteLine("Enter your name:");

            string userName = "";
            Regex r = new Regex("^[a-zA-Z\\s*]*$");
            userName = Console.ReadLine();
            while (!r.IsMatch(userName))
            {
                if (r.IsMatch(userName))
                {
                    userName = userName;
                }
                else
                {
                    Console.WriteLine("ReEnter your name only letters accepted");
                    userName = Console.ReadLine();
                }
            }

            Console.WriteLine("Hi " + userName +
                              ",Welcome to our website there are 3 options\n1.Car\n2.Bike\n3.Drive Simulation\nPlease write one:");


            while (!(vehicleType.ToLower().Equals("car") || vehicleType.ToLower().Equals("bike") ||
                     vehicleType.ToLower().Equals("drive simulation")))
            {
                vehicleType = Console.ReadLine();

                if (vehicleType.ToLower().Equals("car"))
                {
                    Console.WriteLine("There are 3 types of cars sedan, SUV, and van,\nwhat type do you want?");

                    while (!(carType.ToLower().Equals("sedan") || carType.ToLower().Equals("van") ||
                             carType.ToLower().Equals("suv")))
                    {
                        carType = Console.ReadLine();
                        switch (carType.ToLower())
                        {
                            case "sedan":
                                Console.WriteLine("----------------sedan cars showroom--------------------");
                                Console.WriteLine("In sedan cars showroom there are two cars to sell");
                                while (!(sedanCar.ToLower().Equals("camry") || sedanCar.ToLower().Equals("sonata")))
                                {
                                    Console.WriteLine("1.Camry\n2.Sonata\nSelect a car?");
                                    sedanCar = Console.ReadLine();
                                    if (sedanCar.ToLower().Equals("camry"))
                                    {
                                        Console.WriteLine("Nice choice " + userName +
                                                          " so, after you select the car there are 2 engines for Camry which one do you want?");

                                        Console.WriteLine("1." + cars.arrCar[0].engine.EngineName);
                                        Console.WriteLine("2." + cars.arrCar[1].engine.EngineName);
                                        while (!(camryEngine.ToLower()
                                                     .Equals(cars.arrCar[0].engine.EngineName.ToLower()) ||
                                                 camryEngine.ToLower()
                                                     .Equals(cars.arrCar[1].engine.EngineName.ToLower())))
                                        {
                                            camryEngine = Console.ReadLine();
                                            if (camryEngine.ToLower()
                                                .Equals(cars.arrCar[0].engine.EngineName.ToLower()))
                                            {
                                                Console.WriteLine("Great choice for " + camryEngine + " engine");
                                            }
                                            else if (camryEngine.ToLower()
                                                .Equals(cars.arrCar[1].engine.EngineName.ToLower()))
                                            {
                                                Console.WriteLine("Great choice for " + camryEngine + " engine");
                                            }
                                            else
                                            {
                                                Console.WriteLine("Invalid Option you should select one either " +
                                                                  cars.arrCar[0].engine.EngineName + " or " +
                                                                  cars.arrCar[1].engine.EngineName);
                                            }
                                        }


                                        Console.WriteLine("Nice choice " + userName + " so, after you select " +
                                                          camryEngine +
                                                          " engine there are 2 types of tires for Camry which one do you want?");

                                        Console.WriteLine("1." + cars.arrCar[0].wheel.tireName);
                                        Console.WriteLine("2." + cars.arrCar[3].wheel.tireName);
                                        while (!(camryWheel.ToLower().Equals(cars.arrCar[0].wheel.tireName.ToLower()) ||
                                                 camryWheel.ToLower().Equals(cars.arrCar[3].wheel.tireName.ToLower())))
                                        {
                                            camryWheel = Console.ReadLine();
                                            if (camryWheel.ToLower().Equals(cars.arrCar[0].wheel.tireName.ToLower()))
                                            {
                                                Console.WriteLine("Great choice for " + camryWheel + " tire");
                                            }
                                            else if (camryWheel.ToLower()
                                                .Equals(cars.arrCar[3].wheel.tireName.ToLower()))
                                            {
                                                Console.WriteLine("Great choice for " + camryWheel + " tire");
                                            }
                                            else
                                            {
                                                Console.WriteLine("Invalid Option you should select one either " +
                                                                  cars.arrCar[0].wheel.tireName + " or " +
                                                                  cars.arrCar[3].wheel.tireName);
                                            }
                                        }

                                        Console.WriteLine("This is a summary of your selection:");
                                        Console.WriteLine(cars.arrCar[0].toString(camryWheel, camryEngine));
                                    }
                                    else if (sedanCar.ToLower().Equals("sonata"))
                                    {
                                        Console.WriteLine("Nice choice " + userName + " to select sonata car");
                                        Console.WriteLine("Sonata has 2 two types of wheels, select one:");
                                        Console.WriteLine("1." + cars.wheels[2].tireName);
                                        Console.WriteLine("2." + cars.wheels[3].tireName);

                                        while (!(sonataWheel.ToLower().Equals(cars.wheels[2].tireName.ToLower()) ||
                                                 sonataWheel.ToLower().Equals(cars.wheels[3].tireName.ToLower())))
                                        {
                                            sonataWheel = Console.ReadLine();
                                            if (sonataWheel.ToLower().Equals(cars.wheels[2].tireName.ToLower()))
                                            {
                                                Console.WriteLine("Great choice for " + cars.wheels[2].tireName +
                                                                  " tire");
                                            }
                                            else if (sonataWheel.ToLower().Equals(cars.wheels[3].tireName.ToLower()))
                                            {
                                                Console.WriteLine("Great choice for " + cars.wheels[3].tireName +
                                                                  " tire");
                                            }
                                            else
                                            {
                                                Console.WriteLine("Invalid Option you should select one either " +
                                                                  cars.wheels[2].tireName + " or " +
                                                                  cars.wheels[3].tireName);
                                            }
                                        }

                                        Console.WriteLine("This is a summary of your selection:");
                                        Console.WriteLine(cars.arrCar[1].toString(sonataWheel));
                                    }
                                    else
                                    {
                                        Console.WriteLine("Invalid option, Select one of the displayed cars");
                                    }
                                }

                                break;
                            case "suv":
                                Console.WriteLine("----------------suv car showroom--------------------");
                                Console.WriteLine("In SUV cars showroom there are two cars to sell");
                                while (!(suvCar.ToLower().Equals("hyundai creta") ||
                                         suvCar.ToLower().Equals("toyota fortuner")))
                                {
                                    Console.WriteLine("1.Hyundai Creta\n2.Toyota Fortuner\nSelect a car?");
                                    suvCar = Console.ReadLine();
                                    if (suvCar.ToLower().Equals("hyundai creta"))
                                    {
                                        Console.WriteLine("Nice choice " + userName + " to select Hyundai Creta car");
                                        Console.WriteLine("Hyundai Creta has 2 two types of wheels, select one:");
                                        Console.WriteLine("1." + cars.wheels[4].tireName);
                                        Console.WriteLine("2." + cars.wheels[6].tireName);
                                        while (!(hyundaiCretaWheel.ToLower()
                                                     .Equals(cars.wheels[4].tireName.ToLower()) ||
                                                 hyundaiCretaWheel.ToLower().Equals(cars.wheels[6].tireName.ToLower())))
                                        {
                                            hyundaiCretaWheel = Console.ReadLine();
                                            if (hyundaiCretaWheel.ToLower().Equals(cars.wheels[4].tireName.ToLower()))
                                            {
                                                Console.WriteLine("Great choice to select " + hyundaiCretaWheel +
                                                                  " tire");
                                            }
                                            else if (hyundaiCretaWheel.ToLower()
                                                .Equals(cars.wheels[6].tireName.ToLower()))
                                            {
                                                Console.WriteLine("Great choice to select " + hyundaiCretaWheel +
                                                                  " tire");
                                            }
                                            else
                                            {
                                                Console.WriteLine("Invalid Option you should select one either " +
                                                                  cars.wheels[4].tireName + " or " +
                                                                  cars.wheels[6].tireName);
                                            }
                                        }

                                        Console.WriteLine("This is a summary of your selection:");
                                        Console.WriteLine(cars.arrCar[2].toString(hyundaiCretaWheel));
                                    }
                                    else if (suvCar.ToLower().Equals("toyota fortuner"))
                                    {
                                        Console.WriteLine("Nice choice " + userName + " to select Toyota Fortuner car");
                                        Console.WriteLine("Toyota Fortuner has 2 two types of wheels, select one:");
                                        Console.WriteLine("1." + cars.wheels[5].tireName);
                                        Console.WriteLine("2." + cars.wheels[7].tireName);
                                        while (!(FortunerWheel.ToLower().Equals(cars.wheels[5].tireName.ToLower()) ||
                                                 FortunerWheel.ToLower().Equals(cars.wheels[7].tireName.ToLower())))
                                        {
                                            FortunerWheel = Console.ReadLine();
                                            if (FortunerWheel.ToLower().Equals(cars.wheels[5].tireName.ToLower()))
                                            {
                                                Console.WriteLine("Great choice to select " + FortunerWheel + " tire");
                                            }
                                            else if (FortunerWheel.ToLower().Equals(cars.wheels[7].tireName.ToLower()))
                                            {
                                                Console.WriteLine("Great choice to select " + FortunerWheel + " tire");
                                            }
                                            else
                                            {
                                                Console.WriteLine("Invalid Option you should select one either " +
                                                                  cars.wheels[5].tireName + " or " +
                                                                  cars.wheels[7].tireName);
                                            }
                                        }

                                        Console.WriteLine("This is a summary of your selection:");
                                        Console.WriteLine(cars.arrCar[3].toString(FortunerWheel));
                                    }
                                    else
                                    {
                                        Console.WriteLine(
                                            "Invalid option you should select one of the displayed cars in showroom");
                                    }
                                }

                                break;
                            case "van":
                                Console.WriteLine("----------------van car showroom--------------------");
                                Console.WriteLine("In van cars showroom there is only one car to sell");
                                while (!vanCar.ToLower().Equals("gmc safari"))
                                {
                                    Console.WriteLine("1.GMC Safari\n2.Exit\nSelect an option?");
                                    vanCar = Console.ReadLine();
                                    if (vanCar.ToLower().Equals("gmc safari"))
                                    {
                                        Console.WriteLine("Nice choice " + userName + " to select GMC Safari car");
                                        Console.WriteLine("GMC Safari has 3 types of wheels, select one:");
                                        Console.WriteLine("1." + cars.wheels[8].tireName);
                                        Console.WriteLine("2." + cars.wheels[9].tireName);
                                        Console.WriteLine("3." + cars.wheels[10].tireName);
                                        while (!(GMCWheel.ToLower().Equals(cars.wheels[8].tireName.ToLower()) ||
                                                 GMCWheel.ToLower().Equals(cars.wheels[9].tireName.ToLower()) ||
                                                 GMCWheel.ToLower().Equals(cars.wheels[10].tireName.ToLower())))
                                        {
                                            GMCWheel = Console.ReadLine();
                                            if (GMCWheel.ToLower().Equals(cars.wheels[8].tireName.ToLower()))
                                            {
                                                Console.WriteLine("Great choice to select " + GMCWheel + " tire");
                                            }
                                            else if (GMCWheel.ToLower().Equals(cars.wheels[9].tireName.ToLower()))
                                            {
                                                Console.WriteLine("Great choice to select " + GMCWheel + " tire");
                                            }
                                            else if (GMCWheel.ToLower().Equals(cars.wheels[10].tireName.ToLower()))
                                            {
                                                Console.WriteLine("Great choice to select " + GMCWheel + " tire");
                                            }
                                            else
                                            {
                                                Console.WriteLine("Invalid Option you should select one either " +
                                                                  cars.wheels[8].tireName + " or " +
                                                                  cars.wheels[9].tireName + " or " +
                                                                  cars.wheels[10].tireName);
                                            }
                                        }

                                        Console.WriteLine("This is a summary of your selection:");
                                        Console.WriteLine(cars.arrCar[4]
                                            .toString(GMCWheel, cars.engines[2].EngineName));
                                    }
                                    else if (vanCar.ToLower().Equals("exit"))
                                    {
                                        Console.WriteLine("Thank you to visit the van showroom");
                                        break;
                                    }
                                    else
                                    {
                                        Console.WriteLine(
                                            "Invalid option you should select one of the displayed options");
                                    }
                                }

                                break;
                            default:
                                Console.WriteLine(
                                    "Invalid car type the car types should be sedan or suv or van.\nReEnter the car type?");
                                break;
                        }
                    }
                }
                //-------------------------------------------------Bike-------------------------------------------------
                else if (vehicleType.ToLower().Equals("bike"))
                {
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
                //-----------------------Drive Simulation-------------------------------
                else if (vehicleType.ToLower().Equals("drive simulation"))
                {
                    Console.WriteLine("Welcome to Drive Simulation");
                    Console.WriteLine("Let start..");
                    Vehicle v = new Vehicle();

                    string gear = "";
                    Console.WriteLine("Instrutions of Drive Simulation\nD--> moveForward\nR--> moveBackward" +
                                      "\nN--> stop\nExit--> to leave out Drive Simulation");
                    while (!gear.ToUpper().Equals("EXIT"))
                    {
                        Console.WriteLine("Select an option: \n1.D\n2.N\n3.R\n4.EXIT");
                        gear = Console.ReadLine();

                        if (gear.ToUpper().Equals("D"))
                        {
                            // Console.WriteLine(gear);
                            v.move(gear.ToUpper());
                        }
                        else if (gear.ToUpper().Equals("EXIT"))
                        {
                            Console.WriteLine("Good bye..");
                            break;
                        }
                        else if (gear.ToUpper().Equals("R"))
                        {
                            v.move(gear.ToUpper());
                        }
                        else if (gear.ToUpper().Equals("N"))
                        {
                            v.move(gear.ToUpper());
                        }
                        else
                        {
                            Console.WriteLine("Invalid Input ReEnter the displayed options");
                        }
                    }
                }
                else
                {
                    Console.WriteLine(
                        "Invalid vehicle type the vehicle types should be either car or bike.\nReEnter the type?");
                }
            }
        }
    }
}
