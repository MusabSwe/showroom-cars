using System;
using System.Text.RegularExpressions;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Car c1 = new Car();
            // string pattern = @"^[a-zA-Z]+$";
            // Regex a = new Regex(pattern);

            Bike bike1 = new Bike();
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
            //-------------------------Van var------------------------------------ 
            string vanCar = "";
            string GMCWheel = "";
            //-------------------------Bike var------------------------------------
            string bikeType = "";
            string bicycleType = "";
            string VenomMotor = "";
            Car c2 = new Car("Camry", 5, 6, 4);
            Car c3 = new Car("Sonata", 5, 4, 4);
            Car c4 = new Car("Hyundai Creta", 7, 6, 4);
            Car c5 = new Car("Toyota Fortuner", 7, 4, 4);
            Car c6 = new Car("GMC Safari", 9, 8, 4);
            EngineType engine1 = new EngineType(1, "Hybrid");
            EngineType engine2 = new EngineType(2, "Regular");
            EngineType engine3 = new EngineType(3, " diesel engine");
            Wheel wheel1 = new Wheel("Camry", "Okohama", "Japan", new DateTime(2021, 2, 23), 17);
            Wheel wheel2 = new Wheel("Camry", "Hankook", "China", new DateTime(2021, 4, 17), 16);
            Wheel wheel3 = new Wheel("Sonata", "Goodyear", "China ", new DateTime(2021, 2, 23), 18);
            Wheel wheel4 = new Wheel("Sonata", "Firestone", "America", new DateTime(2021, 4, 17), 17);
            Wheel wheel5 = new Wheel("Hyundai Creta", "Goodyear", "China ", new DateTime(2021, 2, 23), 19);
            Wheel wheel6 = new Wheel("Toyota Fortuner", "bridgestone ", "Korean", new DateTime(2021, 4, 17), 19);
            Wheel wheel7 = new Wheel("Hyundai Creta", "bridgestone", "China ", new DateTime(2021, 2, 23), 19);
            Wheel wheel8 = new Wheel("Toyota Fortuner", "Hankook", "China ", new DateTime(2020, 2, 23), 19);
            Wheel wheel9 = new Wheel("GMC Safari", "Falken", "Japan ", new DateTime(2019, 3, 26), 21);
            Wheel wheel10 = new Wheel("GMC Safari", "Pirelli", "Korian ", new DateTime(2021, 6, 11), 20);
            Wheel wheel11 = new Wheel("GMC Safari", "Atlas", "Indian ", new DateTime(2020, 9, 17), 21);


            FuelEconomy f1 = new FuelEconomy("Camry", new DateTime(2020, 10, 23), "Green", "Very Good");
            FuelEconomy f2 = new FuelEconomy("Sonata", new DateTime(2017, 5, 1), "Green", "Good");
            FuelEconomy f3 = new FuelEconomy("Hyundai Creta", new DateTime(2019, 10, 23), "Red", "Very Bad");
            FuelEconomy f4 = new FuelEconomy("Toyota Fortuner", new DateTime(2018, 5, 1), "Red", "Bad");
            FuelEconomy f5 = new FuelEconomy("GMC Safari", new DateTime(2018, 5, 1), "Desil", "Excellent");
            //-------------------------------Bike Data --------------------------------------------
            Bike b1 = new Bike("Venom", 2, 2, "motor bike");
            Bike b2 = new Bike("Rambo", 1, 2, "Bicycle");

            FuelEconomy f6 = new FuelEconomy("Venom", new DateTime(2021, 3, 4), "Green", "Good");

            Wheel wheel12 = new Wheel("Venom", "Cobra", "German ", new DateTime(2021, 2, 22), 12);
            Wheel wheel13 = new Wheel("Rambo", "Kenda", "America ", new DateTime(2020, 9, 17), 9);

            //--------------------------------System-------------------------------------------------
            Console.WriteLine("Enter your name:");

            string userName = "";
            Regex r = new Regex("^[a-zA-Z]*$");
            userName = Console.ReadLine();
            while (!r.IsMatch(userName))
            {
                if (r.IsMatch(userName))
                {
                    userName = userName;
                }
                else
                {
                    Console.WriteLine("ReEnter only letters");
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
                                        Console.WriteLine("1." + engine1.EngineName);
                                        Console.WriteLine("2." + engine2.EngineName);
                                        while (!(camryEngine.ToLower().Equals(engine1.EngineName.ToLower()) ||
                                                 camryEngine.ToLower().Equals(engine2.EngineName.ToLower())))
                                        {
                                            camryEngine = Console.ReadLine();
                                            if (camryEngine.ToLower().Equals(engine1.EngineName.ToLower()))
                                            {
                                                Console.WriteLine("Great choice for " + camryEngine + " engine");
                                            }
                                            else if (camryEngine.ToLower().Equals(engine2.EngineName.ToLower()))
                                            {
                                                Console.WriteLine("Great choice for " + camryEngine + " engine");
                                            }
                                            else
                                            {
                                                Console.WriteLine("Invalid Option you should select one either " +
                                                                  engine1.EngineName + " or " + engine2.EngineName);
                                            }
                                        }


                                        Console.WriteLine("Nice choice " + userName + " so, after you select " +
                                                          camryEngine +
                                                          " engine there are 2 types of tires for Camry which one do you want?");
                                        Console.WriteLine("1." + wheel1.tireName);
                                        Console.WriteLine("2." + wheel2.tireName);
                                        while (!(camryWheel.ToLower().Equals(wheel1.tireName.ToLower()) ||
                                                 camryWheel.ToLower().Equals(wheel2.tireName.ToLower())))
                                        {
                                            camryWheel = Console.ReadLine();
                                            if (camryWheel.ToLower().Equals(wheel1.tireName.ToLower()))
                                            {
                                                Console.WriteLine("Great choice for " + camryWheel + " tire");
                                            }
                                            else if (camryWheel.ToLower().Equals(wheel2.tireName.ToLower()))
                                            {
                                                Console.WriteLine("Great choice for " + camryWheel + " tire");
                                            }
                                            else
                                            {
                                                Console.WriteLine("Invalid Option you should select one either " +
                                                                  wheel1.tireName + " or " + wheel2.tireName);
                                            }
                                        }

                                        Console.WriteLine("This is a summary of your selection:");
                                        Console.WriteLine(c2.toString());
                                        Console.WriteLine("The engine type for sonata is " + engine2.EngineName);


                                        if (camryWheel.ToLower().Equals(wheel1.tireName.ToLower()))
                                        {
                                            Console.WriteLine(wheel1.toString());
                                        }
                                        else if (camryWheel.ToLower().Equals(wheel2.tireName.ToLower()))
                                        {
                                            Console.WriteLine(wheel2.toString());
                                        }

                                        Console.WriteLine(f1.toString());
                                    }
                                    else if (sedanCar.ToLower().Equals("sonata"))
                                    {
                                        Console.WriteLine("Nice choice " + userName + " to select sonata car");
                                        Console.WriteLine("Sonata has 2 two types of wheels, select one:");
                                        Console.WriteLine("1." + wheel3.tireName);
                                        Console.WriteLine("2." + wheel4.tireName);

                                        while (!(sonataWheel.ToLower().Equals(wheel3.tireName.ToLower()) ||
                                                 sonataWheel.ToLower().Equals(wheel4.tireName.ToLower())))
                                        {
                                            sonataWheel = Console.ReadLine();
                                            if (sonataWheel.ToLower().Equals(wheel3.tireName.ToLower()))
                                            {
                                                Console.WriteLine("Great choice for " + wheel3.tireName + " tire");
                                            }
                                            else if (sonataWheel.ToLower().Equals(wheel4.tireName.ToLower()))
                                            {
                                                Console.WriteLine("Great choice for " + wheel4.tireName + " tire");
                                            }
                                            else
                                            {
                                                Console.WriteLine("Invalid Option you should select one either " +
                                                                  wheel3.tireName + " or " + wheel4.tireName);
                                            }
                                        }

                                        Console.WriteLine("This is a summary of your selection:");
                                        Console.WriteLine(c3.toString());

                                        Console.WriteLine("The engine type is " + engine2.EngineName);
                                        if (sonataWheel.ToLower().Equals(wheel3.tireName.ToLower()))
                                        {
                                            Console.WriteLine(wheel3.toString());
                                        }
                                        else if (sonataWheel.ToLower().Equals(wheel4.tireName.ToLower()))
                                        {
                                            Console.WriteLine(wheel4.toString());
                                        }

                                        Console.WriteLine(f2.toString());
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
                                        Console.WriteLine("1." + wheel5.tireName);
                                        Console.WriteLine("2." + wheel7.tireName);
                                        while (!(hyundaiCretaWheel.ToLower().Equals(wheel5.tireName.ToLower()) ||
                                                 hyundaiCretaWheel.ToLower().Equals(wheel7.tireName.ToLower())))
                                        {
                                            hyundaiCretaWheel = Console.ReadLine();
                                            if (hyundaiCretaWheel.ToLower().Equals(wheel5.tireName.ToLower()))
                                            {
                                                Console.WriteLine("Great choice to select " + hyundaiCretaWheel +
                                                                  " tire");
                                            }
                                            else if (hyundaiCretaWheel.ToLower().Equals(wheel7.tireName.ToLower()))
                                            {
                                                Console.WriteLine("Great choice to select " + hyundaiCretaWheel +
                                                                  " tire");
                                            }
                                            else
                                            {
                                                Console.WriteLine("Invalid Option you should select one either " +
                                                                  wheel5.tireName + " or " + wheel7.tireName);
                                            }
                                        }

                                        Console.WriteLine("This is a summary of your selection:");
                                        Console.WriteLine(c4.toString());

                                        Console.WriteLine("The engine type is " + engine2.EngineName);
                                        if (hyundaiCretaWheel.ToLower().Equals(wheel5.tireName.ToLower()))
                                        {
                                            Console.WriteLine(wheel5.toString());
                                        }
                                        else if (hyundaiCretaWheel.ToLower().Equals(wheel7.tireName.ToLower()))
                                        {
                                            Console.WriteLine(wheel7.toString());
                                        }

                                        Console.WriteLine(f3.toString());
                                    }
                                    else if (suvCar.ToLower().Equals("toyota fortuner"))
                                    {
                                        Console.WriteLine("Nice choice " + userName + " to select Toyota Fortuner car");
                                        Console.WriteLine("Toyota Fortuner has 2 two types of wheels, select one:");
                                        Console.WriteLine("1." + wheel6.tireName);
                                        Console.WriteLine("2." + wheel8.tireName);
                                        while (!(FortunerWheel.ToLower().Equals(wheel6.tireName.ToLower()) ||
                                                 FortunerWheel.ToLower().Equals(wheel8.tireName.ToLower())))
                                        {
                                            FortunerWheel = Console.ReadLine();
                                            if (FortunerWheel.ToLower().Equals(wheel6.tireName.ToLower()))
                                            {
                                                Console.WriteLine("Great choice to select " + FortunerWheel + " tire");
                                            }
                                            else if (FortunerWheel.ToLower().Equals(wheel8.tireName.ToLower()))
                                            {
                                                Console.WriteLine("Great choice to select " + FortunerWheel + " tire");
                                            }
                                            else
                                            {
                                                Console.WriteLine("Invalid Option you should select one either " +
                                                                  wheel6.tireName + " or " + wheel8.tireName);
                                            }
                                        }

                                        Console.WriteLine("This is a summary of your selection:");
                                        Console.WriteLine(c5.toString());

                                        Console.WriteLine("The engine type is " + engine2.EngineName);
                                        if (FortunerWheel.ToLower().Equals(wheel6.tireName.ToLower()))
                                        {
                                            Console.WriteLine(wheel6.toString());
                                        }
                                        else if (FortunerWheel.ToLower().Equals(wheel8.tireName.ToLower()))
                                        {
                                            Console.WriteLine(wheel8.toString());
                                        }

                                        Console.WriteLine(f4.toString());
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
                                        Console.WriteLine("1." + wheel9.tireName);
                                        Console.WriteLine("2." + wheel10.tireName);
                                        Console.WriteLine("3." + wheel11.tireName);
                                        while (!(GMCWheel.ToLower().Equals(wheel9.tireName.ToLower()) ||
                                                 GMCWheel.ToLower().Equals(wheel10.tireName.ToLower()) ||
                                                 GMCWheel.ToLower().Equals(wheel11.tireName.ToLower())))
                                        {
                                            GMCWheel = Console.ReadLine();
                                            if (GMCWheel.ToLower().Equals(wheel9.tireName.ToLower()))
                                            {
                                                Console.WriteLine("Great choice to select " + GMCWheel + " tire");
                                            }
                                            else if (GMCWheel.ToLower().Equals(wheel10.tireName.ToLower()))
                                            {
                                                Console.WriteLine("Great choice to select " + GMCWheel + " tire");
                                            }
                                            else if (GMCWheel.ToLower().Equals(wheel11.tireName.ToLower()))
                                            {
                                                Console.WriteLine("Great choice to select " + GMCWheel + " tire");
                                            }
                                            else
                                            {
                                                Console.WriteLine("Invalid Option you should select one either " +
                                                                  wheel9.tireName + " or " + wheel10.tireName + " or " +
                                                                  wheel11.tireName);
                                            }
                                        }

                                        Console.WriteLine("This is a summary of your selection:");
                                        Console.WriteLine(c6.toString());

                                        Console.WriteLine("The engine type is " + engine3.EngineName);
                                        if (GMCWheel.ToLower().Equals(wheel9.tireName.ToLower()))
                                        {
                                            Console.WriteLine(wheel9.toString());
                                        }
                                        else if (GMCWheel.ToLower().Equals(wheel10.tireName.ToLower()))
                                        {
                                            Console.WriteLine(wheel10.toString());
                                        }
                                        else if (GMCWheel.ToLower().Equals(wheel11.tireName.ToLower()))
                                        {
                                            Console.WriteLine(wheel11.toString());
                                        }

                                        Console.WriteLine(f5.toString());
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
                //------------------------------------Bike------------------------------------------
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
                                    Console.WriteLine(b2.toString());
                                    Console.WriteLine(wheel13.toString());
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
                                    Console.WriteLine(b1.toString());
                                    Console.WriteLine("Engine type for Venom is " + engine2.EngineName);
                                    Console.WriteLine(wheel12.toString());
                                    Console.WriteLine(f6.toString());
                                }
                                else if (VenomMotor.ToLower().Equals("exit"))
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
