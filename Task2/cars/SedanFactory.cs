using System;
using System.Collections.Generic;

namespace Task2
{
    public class SedanFactory
    {
        public List<Sedan> arrSedan = new List<Sedan>();
        public EngineType[] engines = new EngineType[3];
        public Wheel[] wheels = new Wheel[8];

        public SedanFactory(List<Sedan> arr)
        {
            this.arrSedan = arr;
        }

        public SedanFactory()
        {
        }

        public void AddSedanCar(Sedan a)
        {
            arrSedan.Add(new Sedan(a.name, a.passengerNum, a.numberOfCylinders, a.numberOfDoors, a.engine, a.wheel));
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
            arrSedan.Add(new Sedan("Camry", 5, 6, 4, engines[0],
                wheels[0],
                new FuelEconomy("Camry", new DateTime(2020, 10, 23), "Green", "Very Good")));
            /*1*/
            arrSedan.Add(new Sedan("Sonata", 5, 4, 4, engines[1],
                wheels[3],
                new FuelEconomy("Sonata", new DateTime(2017, 5, 1), "Green", "Good")));
        }

        public void Main(string userName)
        {
            string sedanCar = "";
            string camryEngine = "";
            string camryWheel = "";
            string sonataWheel = "";
            SedanFactory sedan = new SedanFactory();
            sedan.ConnectToDB();
            Console.WriteLine("----------------sedan cars showroom--------------------");
            Console.WriteLine(sedan.arrSedan[0].wheel.tireName + " I'm Here");
            Console.WriteLine("In sedan cars showroom there are two cars to sell");
            while (!(sedanCar.ToLower().Equals("camry") || sedanCar.ToLower().Equals("sonata")))
            {
                Console.WriteLine("1.Camry\n2.Sonata\nSelect a car?");
                sedanCar = Console.ReadLine();
                if (sedanCar.ToLower().Equals("camry"))
                {
                    Console.WriteLine("Nice choice " + userName +
                                      " so, after you select the car there are 2 engines for Camry which one do you want?");

                    Console.WriteLine("1." + sedan.arrSedan[0].engine.EngineName);
                    Console.WriteLine("2." + sedan.arrSedan[1].engine.EngineName);
                    while (!(camryEngine.ToLower()
                                 .Equals(sedan.arrSedan[0].engine.EngineName.ToLower()) ||
                             camryEngine.ToLower()
                                 .Equals(sedan.arrSedan[1].engine.EngineName.ToLower())))
                    {
                        camryEngine = Console.ReadLine();
                        if (camryEngine.ToLower()
                            .Equals(sedan.arrSedan[0].engine.EngineName.ToLower()))
                        {
                            Console.WriteLine("Great choice for " + camryEngine + " engine");
                        }
                        else if (camryEngine.ToLower()
                            .Equals(sedan.arrSedan[1].engine.EngineName.ToLower()))
                        {
                            Console.WriteLine("Great choice for " + camryEngine + " engine");
                        }
                        else
                        {
                            Console.WriteLine("Invalid Option you should select one either " +
                                              sedan.arrSedan[0].engine.EngineName + " or " +
                                              sedan.arrSedan[1].engine.EngineName);
                        }
                    }


                    Console.WriteLine("Nice choice " + userName + " so, after you select " +
                                      camryEngine +
                                      " engine there are 2 types of tires for Camry which one do you want?");

                    Console.WriteLine("1." + sedan.arrSedan[0].wheel.tireName);
                    Console.WriteLine("2." + sedan.wheels[1].tireName);
                    while (!(camryWheel.ToLower().Equals(sedan.arrSedan[0].wheel.tireName.ToLower()) ||
                             camryWheel.ToLower().Equals(sedan.wheels[1].tireName.ToLower())))
                    {
                        camryWheel = Console.ReadLine();
                        if (camryWheel.ToLower().Equals(sedan.arrSedan[0].wheel.tireName.ToLower()))
                        {
                            Console.WriteLine("Great choice for " + camryWheel + " tire");
                        }
                        else if (camryWheel.ToLower()
                            .Equals(sedan.wheels[1].tireName.ToLower()))
                        {
                            Console.WriteLine("Great choice for " + camryWheel + " tire");
                        }
                        else
                        {
                            Console.WriteLine("Invalid Option you should select one either " +
                                              sedan.arrSedan[0].wheel.tireName + " or " +
                                              sedan.wheels[1].tireName);
                        }
                    }

                    Console.WriteLine("This is a summary of your selection:");
                    Console.WriteLine(sedan.arrSedan[0].toString(camryWheel, camryEngine));
                }
                else if (sedanCar.ToLower().Equals("sonata"))
                {
                    Console.WriteLine("Nice choice " + userName + " to select sonata car");
                    Console.WriteLine("Sonata has 2 two types of wheels, select one:");
                    Console.WriteLine("1." + sedan.wheels[3].tireName);
                    Console.WriteLine("2." + sedan.wheels[2].tireName);

                    while (!(sonataWheel.ToLower().Equals(sedan.wheels[3].tireName.ToLower()) ||
                             sonataWheel.ToLower().Equals(sedan.wheels[2].tireName.ToLower())))
                    {
                        sonataWheel = Console.ReadLine();
                        if (sonataWheel.ToLower().Equals(sedan.wheels[3].tireName.ToLower()))
                        {
                            Console.WriteLine("Great choice for " + sedan.wheels[3].tireName +
                                              " tire");
                        }
                        else if (sonataWheel.ToLower().Equals(sedan.wheels[2].tireName.ToLower()))
                        {
                            Console.WriteLine("Great choice for " + sedan.wheels[2].tireName +
                                              " tire");
                        }
                        else
                        {
                            Console.WriteLine("Invalid Option you should select one either " +
                                              sedan.wheels[3].tireName + " or " +
                                              sedan.wheels[2].tireName);
                        }
                    }

                    Console.WriteLine("This is a summary of your selection:");
                    Console.WriteLine(sedan.arrSedan[1].toString(sonataWheel));
                }
                else
                {
                    Console.WriteLine("Invalid option, Select one of the displayed cars");
                }
            }
        }
    }
}