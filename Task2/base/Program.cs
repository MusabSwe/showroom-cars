using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Car c1 = new Car();
            Bike bike1 = new Bike();
            string carType = "";
            string vehicleType = "";
            string sedanCar = "";
            string camryEngine = "";
            string camryWheel = "";
            string sonataWheel = "";

            Car c2 = new Car("Camry", 5, 6, 4);
            Car c3 = new Car("Sonata", 5, 4, 4);
            Car c4 = new Car("Hyundai Creta", 7, 6, 4);
            Car c5 = new Car("Toyota Fortuner", 7, 4, 4);
            EngineType engine1 = new EngineType(1, "Hybrid");
            EngineType engine2 = new EngineType(2, "Regular");
            Wheel wheel1 = new Wheel("Camry", "Okohama", "Japan", new DateTime(2021, 2, 23), 17);
            Wheel wheel2 = new Wheel("Camry", "Hankook", "China", new DateTime(2021, 4, 17), 16);
            Wheel wheel3 = new Wheel("Sonata", "Goodyear", "China ", new DateTime(2021, 2, 23), 18);
            Wheel wheel4 = new Wheel("Sonata", "Firestone", "America", new DateTime(2021, 4, 17), 17);
            Wheel wheel5 = new Wheel("Hyundai Creta", "Goodyear", "China ", new DateTime(2021, 2, 23), 19);
            Wheel wheel6 = new Wheel("Toyota Fortuner", "bridgestone ", "Korean", new DateTime(2021, 4, 17), 19);

            Console.WriteLine("Enter your name:");
            FuelEconomy f1 = new FuelEconomy("Camry", new DateTime(2020, 10, 23), "Green", "Very Good");
            FuelEconomy f2 = new FuelEconomy("Sonata", new DateTime(2017, 5, 1), "Green", "Good");
            FuelEconomy f3 = new FuelEconomy("Hyundai Creta", new DateTime(2019, 10, 23), "Red", "Very Bad");
            FuelEconomy f4 = new FuelEconomy("Toyota Fortuner", new DateTime(2018, 5, 1), "Red", "Bad");
            
            string userName = Console.ReadLine();

            Console.WriteLine("Hi " + userName + ",There are 2 types of " +
                              "vehicles Bike and Car.\nwhat type do you want?");


            while (!(vehicleType.ToLower().Equals("car") || vehicleType.ToLower().Equals("car")))
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
                                
                                break;
                            case "van":
                                Console.WriteLine("----------------van car showroom--------------------");
                                break;
                            default:
                                Console.WriteLine(
                                    "Invalid car type the car types should be sedan or suv or van.\n ReEnter the car type?");
                                break;
                        }
                    }
                }
                //------------------------------------Bike-----------------------------------
                else if (vehicleType.ToLower().Equals("bike"))
                {
                    Console.WriteLine("Enter your bike name:");
                }
                else
                {
                    Console.WriteLine(
                        "Invalid vehicle type the vehicle types should be either car or bike.\n ReEnter the type?");
                }
            }
        }
    }
}
