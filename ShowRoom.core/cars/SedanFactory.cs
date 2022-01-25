using System;
using System.Collections.Generic;

namespace ShowRoom.Core
{
    public class SedanFactory
    {
        public List<Sedan> arrSedan = new List<Sedan>();
        public Engine [] engines = new Engine[3];
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
            arrSedan.Add(new Sedan(a.Name, a.PassengerNum.Value, a.NumberOfCylinders.Value, a.NumberOfDoors.Value, a.engine, a.wheel));
        }

        public void ConnectToDB()
        {
            engines[0] = new Engine(1, "Hybrid");
            engines[1] = new Engine(2, "Regular");
            engines[2] = new Engine(3, "Diesel Engine");

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

        public void SedanShowroom(string userName)
        {
            int sedanCar = 0;
            int camryEngine = 0;
            int camryWheel = 0;
            int sonataWheel = 0;
            SedanFactory sedan = new SedanFactory();
            sedan.ConnectToDB();
            Console.WriteLine("----------------sedan cars showroom--------------------");
            Console.WriteLine("In sedan cars showroom there are two cars to sell");
            while (!(sedanCar == (int) SedanOptions.camry || sedanCar == (int) SedanOptions.sonata))
            {
                try
                {
                    Console.WriteLine("1.Camry\n2.Sonata\nSelect a car?");

                    sedanCar = Convert.ToInt32(Console.ReadLine());

                    if (sedanCar == (int) SedanOptions.camry)
                    {
                        Console.WriteLine("Nice choice " + userName +
                                          " so, after you select the car there are 2 engines for Camry which one do you want?");

                        Console.WriteLine("1." + sedan.arrSedan[0].engine.EngineName);
                        Console.WriteLine("2." + sedan.arrSedan[1].engine.EngineName);
                        string e1 = "";
                        while (!(camryEngine == (int) CamryEngines.hybrid || camryEngine == (int) CamryEngines.regular))
                        {
                            try
                            {
                                camryEngine = Convert.ToInt32(Console.ReadLine());
                                if (camryEngine == (int) CamryEngines.hybrid)
                                {
                                    Console.WriteLine("Great choice for " + CamryEngines.hybrid + " engine");
                                    e1 = "Hybrid";
                                }
                                else if (camryEngine == (int) CamryEngines.regular)
                                {
                                    Console.WriteLine("Great choice for " + CamryEngines.regular + " engine");
                                    e1 = "Regular";
                                }
                                else
                                {
                                    Console.WriteLine("Invalid Option you should select one either " +
                                                      sedan.arrSedan[0].engine.EngineName + " or " +
                                                      sedan.arrSedan[1].engine.EngineName);
                                }
                            }
                            catch (Exception e)
                            {
                                Console.WriteLine("Invalid Option you should select a number either " +
                                                  sedan.arrSedan[0].engine.EngineName + " or " +
                                                  sedan.arrSedan[1].engine.EngineName);
                            }
                        }


                        Console.WriteLine("Nice choice " + userName + " so, after you select " +
                                          e1 +
                                          " engine there are 2 types of tires for Camry which one do you want?");

                        Console.WriteLine("1." + sedan.arrSedan[0].wheel.TireName);
                        Console.WriteLine("2." + sedan.wheels[1].TireName);
                        string w1 = "";

                        while (!(camryWheel == (int) CamryWheel.Okohama || camryWheel == (int) CamryWheel.Hankook))
                        {
                            try
                            {
                                camryWheel = Convert.ToInt32(Console.ReadLine());
                                if (camryWheel == (int) CamryWheel.Okohama)
                                {
                                    Console.WriteLine("Great choice for " + CamryWheel.Okohama + " tire");
                                    w1 = "Okohama";
                                }
                                else if (camryWheel == (int) CamryWheel.Hankook)
                                {
                                    Console.WriteLine("Great choice for " + CamryWheel.Hankook + " tire");
                                    w1 = "Hankook";
                                }
                                else
                                {
                                    Console.WriteLine("Invalid Option you should select a number either " +
                                                      sedan.arrSedan[0].wheel.TireName + " or " +
                                                      sedan.wheels[1].TireName);
                                }
                            }
                            catch (Exception e)
                            {
                                Console.WriteLine("Invalid Option you should select a number either " +
                                                  sedan.arrSedan[0].wheel.TireName + " or " +
                                                  sedan.wheels[1].TireName);
                            }
                        }

                        Console.WriteLine("This is a summary of your selection:");
                        Console.WriteLine(sedan.arrSedan[0].toString(w1, e1));
                    }
                    else if (sedanCar == (int) SedanOptions.sonata)
                    {
                        string w2 = "";
                        Console.WriteLine("Nice choice " + userName + " to select sonata car");
                        Console.WriteLine("Sonata has 2 two types of wheels, select one:");
                        Console.WriteLine("1." + sedan.wheels[3].TireName);
                        Console.WriteLine("2." + sedan.wheels[2].TireName);

                        while (!(sonataWheel == (int) SonataWheel.Goodyear ||
                                 sonataWheel == (int) SonataWheel.Firestone))
                        {
                            try
                            {
                                sonataWheel = Convert.ToInt32(Console.ReadLine());
                                if (sonataWheel == (int) SonataWheel.Goodyear)
                                {
                                    Console.WriteLine("Great choice for " + sedan.wheels[3].TireName +
                                                      " tire");
                                    w2 = "Goodyear";
                                }
                                else if (sonataWheel == (int) SonataWheel.Firestone)
                                {
                                    Console.WriteLine("Great choice for " + sedan.wheels[2].TireName +
                                                      " tire");
                                    w2 = "Firestone";
                                }
                                else
                                {
                                    Console.WriteLine("Invalid Option you should select a number:\n1." +
                                                      sedan.wheels[3].TireName + "\n2." +
                                                      sedan.wheels[2].TireName);
                                }
                            }
                            catch (Exception e)
                            {
                                Console.WriteLine("Invalid Option you should select a number:\n1." +
                                                  sedan.wheels[3].TireName + "\n2." +
                                                  sedan.wheels[2].TireName);
                            }
                        }

                        Console.WriteLine("This is a summary of your selection:");
                        Console.WriteLine(sedan.arrSedan[1].toString(w2));
                    }
                    else
                    {
                        Console.WriteLine("Invalid option, Select a number of the displayed cars");
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Invalid option, Select a number of the displayed cars");
                }
            }
        }
    }
}