using System;
using System.Collections.Generic;

namespace Task2
{
    public class SUVFactory
    {
        public List<SUV> arrSUV = new List<SUV>();
        public EngineType[] engines = new EngineType[3];
        public Wheel[] wheels = new Wheel[8];

        public SUVFactory(List<SUV> arr)
        {
            this.arrSUV = arr;
        }

        public SUVFactory()
        {
        }

        public void AddSedanCar(SUV a)
        {
            arrSUV.Add(new SUV(a.name, a.passengerNum, a.numberOfCylinders, a.numberOfDoors, a.engine, a.wheel));
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
            wheels[4] = new Wheel("bridgestone", "Korean", new DateTime(2021, 4, 17), 19);
            wheels[5] = new Wheel("Falken", "Japan ", new DateTime(2019, 3, 26), 21);
            wheels[6] = new Wheel("Pirelli", "Korian ", new DateTime(2021, 6, 11), 20);
            wheels[7] = new Wheel("Atlas", "Indian ", new DateTime(2020, 9, 17), 21);

            /*0*/
            arrSUV.Add(new SUV("Hyundai Creta", 7, 6, 4, engines[1],
                new Wheel("bridgestone", "China ", new DateTime(2021, 2, 23), 19),
                new FuelEconomy("Hyundai Creta", new DateTime(2019, 10, 23), "Red", "Very Bad")));
            /*1*/
            arrSUV.Add(new SUV("Toyota Fortuner", 7, 4, 4, engines[1],
                new Wheel("Hankook", "China ", new DateTime(2020, 2, 23), 19),
                new FuelEconomy("Toyota Fortuner", new DateTime(2018, 5, 1), "Red", "Bad")));
        }

        public void Main(string userName)
        {
            //--------------------------SUV var------------------------------------
            string suvCar = "";
            string hyundaiCretaWheel = "";
            string FortunerWheel = "";
            SUVFactory suvs = new SUVFactory();
            suvs.ConnectToDB();

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
                    Console.WriteLine("1." + suvs.wheels[3].tireName);
                    Console.WriteLine("2." + suvs.wheels[4].tireName);

                    while (!(hyundaiCretaWheel.ToLower().Equals(suvs.wheels[3].tireName.ToLower()) ||
                             hyundaiCretaWheel.ToLower().Equals(suvs.wheels[4].tireName.ToLower())))
                    {
                        hyundaiCretaWheel = Console.ReadLine();
                        if (hyundaiCretaWheel.ToLower().Equals(suvs.wheels[3].tireName.ToLower()))
                        {
                            Console.WriteLine("Great choice to select " + hyundaiCretaWheel +
                                              " tire");
                        }
                        else if (hyundaiCretaWheel.ToLower()
                            .Equals(suvs.wheels[4].tireName.ToLower()))
                        {
                            Console.WriteLine("Great choice to select " + hyundaiCretaWheel +
                                              " tire");
                        }
                        else
                        {
                            Console.WriteLine("Invalid Option you should select one either " +
                                              suvs.wheels[3].tireName + " or " +
                                              suvs.wheels[4].tireName);
                            Console.WriteLine("You are writing " + hyundaiCretaWheel + "\nWheel: " +
                                              suvs.wheels[4].tireName);
                        }
                    }

                    Console.WriteLine("This is a summary of your selection:");
                    Console.WriteLine(suvs.arrSUV[0].toString(hyundaiCretaWheel));
                }
                else if (suvCar.ToLower().Equals("toyota fortuner"))
                {
                    Console.WriteLine("Nice choice " + userName + " to select Toyota Fortuner car");
                    Console.WriteLine("Toyota Fortuner has 2 two types of wheels, select one:");
                    Console.WriteLine("1." + suvs.wheels[4].tireName);
                    Console.WriteLine("2." + suvs.wheels[1].tireName);
                    while (!(FortunerWheel.ToLower().Equals(suvs.wheels[4].tireName.ToLower()) ||
                             FortunerWheel.ToLower().Equals(suvs.wheels[1].tireName.ToLower())))
                    {
                        FortunerWheel = Console.ReadLine();
                        if (FortunerWheel.ToLower().Equals(suvs.wheels[4].tireName.ToLower()))
                        {
                            Console.WriteLine("Great choice to select " + FortunerWheel + " tire");
                        }
                        else if (FortunerWheel.ToLower().Equals(suvs.wheels[1].tireName.ToLower()))
                        {
                            Console.WriteLine("Great choice to select " + FortunerWheel + " tire");
                        }
                        else
                        {
                            Console.WriteLine("Invalid Option you should select one either " +
                                              suvs.wheels[4].tireName + " or " +
                                              suvs.wheels[1].tireName);
                        }
                    }

                    Console.WriteLine("This is a summary of your selection:");
                    Console.WriteLine(suvs.arrSUV[1].toString(FortunerWheel));
                }
                else
                {
                    Console.WriteLine(
                        "Invalid option you should select one of the displayed cars in showroom");
                }
            }
        }
    }
}