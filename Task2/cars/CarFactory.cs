using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Intrinsics.Arm;

namespace Task2
{
    public class CarFactory
    {
        public List<Car> arrCar = new List<Car>();
        public EngineType[] engines = new EngineType[3];
        public Wheel[] wheels = new Wheel[8];

        public CarFactory(List<Car> arr)
        {
            this.arrCar = arr;
        }

        public CarFactory()
        {
            
        }

        public void AddCar(Car a)
        {
            arrCar.Add(new Car(a.name, a.passengerNum, a.numberOfCylinders, a.numberOfDoors, a.engine, a.wheel));
        }

        public void ConnectToDB()
        {
            engines[0] = new EngineType(1, "Hybrid");
            engines[1] = new EngineType(2, "Regular");
            engines[2] = new EngineType(3, "Diesel Engine");
            
            wheels[0] = new Wheel("Okohama", "Japan", new DateTime(2021, 2, 23), 17);
            wheels[1] = new Wheel("Hankook", "China", new DateTime(2021, 4, 17), 16);
            wheels[2] = new Wheel("Firestone", "America", new DateTime(2021, 4, 17), 17);
            wheels[3] = new Wheel("Goodyear", "China ", new DateTime(2021, 2, 23), 19);
            wheels[4] = new Wheel("bridgestone ", "Korean", new DateTime(2021, 4, 17), 19);
            wheels[5] = new Wheel("Falken", "Japan ", new DateTime(2019, 3, 26), 21);
            wheels[6] = new Wheel("Pirelli", "Korian ", new DateTime(2021, 6, 11), 20);
            wheels[7] = new Wheel("Atlas", "Indian ", new DateTime(2020, 9, 17), 21);
            /*0*/
            arrCar.Add(new Car("Camry", 5, 6, 4, engines[0],
                new Wheel("Okohama", "Japan", new DateTime(2021, 2, 23), 17),
                new FuelEconomy("Camry", new DateTime(2020, 10, 23), "Green", "Very Good")));
            /*1*/
            arrCar.Add(new Car("Sonata", 5, 4, 4, engines[1],
                new Wheel("Goodyear", "China ", new DateTime(2021, 2, 23), 18),
                new FuelEconomy("Sonata", new DateTime(2017, 5, 1), "Green", "Good")));
            /*2*/
            arrCar.Add(new Car("Hyundai Creta", 7, 6, 4, engines[1],
                new Wheel("bridgestone", "China ", new DateTime(2021, 2, 23), 19),
                new FuelEconomy("Hyundai Creta", new DateTime(2019, 10, 23), "Red", "Very Bad")));
            /*3*/
            arrCar.Add(new Car("Toyota Fortuner", 7, 4, 4, engines[1],
                new Wheel("Hankook", "China ", new DateTime(2020, 2, 23), 19),
                new FuelEconomy("Toyota Fortuner", new DateTime(2018, 5, 1), "Red", "Bad")));
            /*4*/
            arrCar.Add(new Car("GMC Safari", 9, 8, 4, engines[2],
                new Wheel("Pirelli", "Korian ", new DateTime(2021, 6, 11), 20),
                new FuelEconomy("GMC Safari", new DateTime(2018, 5, 1), "Desil", "Excellent")));
            // arrCar.Add(new Car("Accent", 5, 4, 4,new EngineType(2, "Regular"),));
        }

        public void Main(string userName)
        {
            string carType = "";
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
            CarFactory cars = new CarFactory();
            cars.ConnectToDB();

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
                                Console.WriteLine("2." + cars.arrCar[2].wheel.tireName);
                                while (!(camryWheel.ToLower().Equals(cars.arrCar[0].wheel.tireName.ToLower()) ||
                                         camryWheel.ToLower().Equals(cars.arrCar[2].wheel.tireName.ToLower())))
                                {
                                    camryWheel = Console.ReadLine();
                                    if (camryWheel.ToLower().Equals(cars.arrCar[0].wheel.tireName.ToLower()))
                                    {
                                        Console.WriteLine("Great choice for " + camryWheel + " tire");
                                    }
                                    else if (camryWheel.ToLower()
                                        .Equals(cars.arrCar[2].wheel.tireName.ToLower()))
                                    {
                                        Console.WriteLine("Great choice for " + camryWheel + " tire");
                                    }
                                    else
                                    {
                                        Console.WriteLine("Invalid Option you should select one either " +
                                                          cars.arrCar[0].wheel.tireName + " or " +
                                                          cars.arrCar[2].wheel.tireName);
                                    }
                                }

                                Console.WriteLine("This is a summary of your selection:");
                                Console.WriteLine(cars.arrCar[0].toString(camryWheel, camryEngine));
                            }
                            else if (sedanCar.ToLower().Equals("sonata"))
                            {
                                Console.WriteLine("Nice choice " + userName + " to select sonata car");
                                Console.WriteLine("Sonata has 2 two types of wheels, select one:");
                                Console.WriteLine("1." + cars.wheels[3].tireName);
                                Console.WriteLine("2." + cars.wheels[2].tireName);

                                while (!(sonataWheel.ToLower().Equals(cars.wheels[3].tireName.ToLower()) ||
                                         sonataWheel.ToLower().Equals(cars.wheels[2].tireName.ToLower())))
                                {
                                    sonataWheel = Console.ReadLine();
                                    if (sonataWheel.ToLower().Equals(cars.wheels[3].tireName.ToLower()))
                                    {
                                        Console.WriteLine("Great choice for " + cars.wheels[3].tireName +
                                                          " tire");
                                    }
                                    else if (sonataWheel.ToLower().Equals(cars.wheels[2].tireName.ToLower()))
                                    {
                                        Console.WriteLine("Great choice for " + cars.wheels[2].tireName +
                                                          " tire");
                                    }
                                    else
                                    {
                                        Console.WriteLine("Invalid Option you should select one either " +
                                                          cars.wheels[3].tireName + " or " +
                                                          cars.wheels[2].tireName);
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
                                Console.WriteLine("1." + cars.wheels[3].tireName);
                                Console.WriteLine("2." + cars.wheels[4].tireName);
                                while (!(hyundaiCretaWheel.ToLower()
                                             .Equals(cars.wheels[3].tireName.ToLower()) ||
                                         hyundaiCretaWheel.ToLower().Equals(cars.wheels[4].tireName.ToLower())))
                                {
                                    hyundaiCretaWheel = Console.ReadLine();
                                    if (hyundaiCretaWheel.ToLower().Equals(cars.wheels[3].tireName.ToLower()))
                                    {
                                        Console.WriteLine("Great choice to select " + hyundaiCretaWheel +
                                                          " tire");
                                    }
                                    else if (hyundaiCretaWheel.ToLower()
                                        .Equals(cars.wheels[4].tireName.ToLower()))
                                    {
                                        Console.WriteLine("Great choice to select " + hyundaiCretaWheel +
                                                          " tire");
                                    }
                                    else
                                    {
                                        Console.WriteLine("Invalid Option you should select one either " +
                                                          cars.wheels[3].tireName + " or " +
                                                          cars.wheels[4].tireName);
                                    }
                                }

                                Console.WriteLine("This is a summary of your selection:");
                                Console.WriteLine(cars.arrCar[2].toString(hyundaiCretaWheel));
                            }
                            else if (suvCar.ToLower().Equals("toyota fortuner"))
                            {
                                Console.WriteLine("Nice choice " + userName + " to select Toyota Fortuner car");
                                Console.WriteLine("Toyota Fortuner has 2 two types of wheels, select one:");
                                Console.WriteLine("1." + cars.wheels[4].tireName);
                                Console.WriteLine("2." + cars.wheels[1].tireName);
                                while (!(FortunerWheel.ToLower().Equals(cars.wheels[4].tireName.ToLower()) ||
                                         FortunerWheel.ToLower().Equals(cars.wheels[1].tireName.ToLower())))
                                {
                                    FortunerWheel = Console.ReadLine();
                                    if (FortunerWheel.ToLower().Equals(cars.wheels[4].tireName.ToLower()))
                                    {
                                        Console.WriteLine("Great choice to select " + FortunerWheel + " tire");
                                    }
                                    else if (FortunerWheel.ToLower().Equals(cars.wheels[1].tireName.ToLower()))
                                    {
                                        Console.WriteLine("Great choice to select " + FortunerWheel + " tire");
                                    }
                                    else
                                    {
                                        Console.WriteLine("Invalid Option you should select one either " +
                                                          cars.wheels[4].tireName + " or " +
                                                          cars.wheels[1].tireName);
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
                                Console.WriteLine("1." + cars.wheels[5].tireName);
                                Console.WriteLine("2." + cars.wheels[6].tireName);
                                Console.WriteLine("3." + cars.wheels[7].tireName);
                                while (!(GMCWheel.ToLower().Equals(cars.wheels[5].tireName.ToLower()) ||
                                         GMCWheel.ToLower().Equals(cars.wheels[6].tireName.ToLower()) ||
                                         GMCWheel.ToLower().Equals(cars.wheels[7].tireName.ToLower())))
                                {
                                    GMCWheel = Console.ReadLine();
                                    if (GMCWheel.ToLower().Equals(cars.wheels[5].tireName.ToLower()))
                                    {
                                        Console.WriteLine("Great choice to select " + GMCWheel + " tire");
                                    }
                                    else if (GMCWheel.ToLower().Equals(cars.wheels[6].tireName.ToLower()))
                                    {
                                        Console.WriteLine("Great choice to select " + GMCWheel + " tire");
                                    }
                                    else if (GMCWheel.ToLower().Equals(cars.wheels[7].tireName.ToLower()))
                                    {
                                        Console.WriteLine("Great choice to select " + GMCWheel + " tire");
                                    }
                                    else
                                    {
                                        Console.WriteLine("Invalid Option you should select one either " +
                                                          cars.wheels[5].tireName + " or " +
                                                          cars.wheels[6].tireName + " or " +
                                                          cars.wheels[7].tireName);
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
    }
}
