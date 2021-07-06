using System;
using System.Collections.Generic;

namespace Task2
{
    public class SUVFactory
    {
        public List<SUV> arrSUV = new List<SUV>();
        public Engine[] engines = new Engine[3];
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
            arrSUV.Add(new SUV(a.Name, a.PassengerNum, a.NumberOfCylinders, a.NumberOfDoors, a.Engines, a.Wheel));
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
            arrSUV.Add(new SUV("Hyundai Creta", 7, 6, 4, engines[1],
                new Wheel("bridgestone", "China ", new DateTime(2021, 2, 23), 19),
                new FuelEconomy("Hyundai Creta", new DateTime(2019, 10, 23), "Red", "Very Bad")));
            /*1*/
            arrSUV.Add(new SUV("Toyota Fortuner", 7, 4, 4, engines[1],
                new Wheel("Hankook", "China ", new DateTime(2020, 2, 23), 19),
                new FuelEconomy("Toyota Fortuner", new DateTime(2018, 5, 1), "Red", "Bad")));
        }

        public void SUVShowroom(string userName)
        {
            int suvCar = 0;
            int hyundaiCretaWheel = 0;
            int FortunerWheel = 0;
            SUVFactory suvs = new SUVFactory();
            suvs.ConnectToDB();

            Console.WriteLine("----------------suv car showroom--------------------");
            Console.WriteLine("In SUV cars showroom there are two cars to sell");
            string w1 = "";
            while (!(suvCar == (int) SUVOptions.creta || suvCar == (int) SUVOptions.fortuner))
            {
                try
                {
                    Console.WriteLine("1.Hyundai Creta\n2.Toyota Fortuner\nSelect a car?");
                    suvCar = Convert.ToInt32(Console.ReadLine());
                    if (suvCar == (int) SUVOptions.creta)
                    {
                        Console.WriteLine("Nice choice " + userName + " to select Hyundai Creta car");
                        Console.WriteLine("Hyundai Creta has 2 two types of wheels, select one:");
                        Console.WriteLine("1." + suvs.wheels[3].TireName);
                        Console.WriteLine("2." + suvs.wheels[4].TireName);

                        while (!(hyundaiCretaWheel == (int) CretaWheel.Goodyear ||
                                 hyundaiCretaWheel == (int) CretaWheel.bridgestone))
                        {
                            try
                            {
                                hyundaiCretaWheel = Convert.ToInt32(Console.ReadLine());
                                if (hyundaiCretaWheel == (int) CretaWheel.Goodyear)
                                {
                                    Console.WriteLine("Great choice to select " + suvs.wheels[3].TireName +
                                                      " tire");
                                    w1 = suvs.wheels[3].TireName;
                                }
                                else if (hyundaiCretaWheel == (int) CretaWheel.bridgestone)
                                {
                                    Console.WriteLine("Great choice to select " + suvs.wheels[4].TireName +
                                                      " tire");
                                    w1 = suvs.wheels[4].TireName;
                                }
                                else
                                {
                                    Console.WriteLine("Invalid Option you should select a number:\n1." +
                                                      suvs.wheels[3].TireName + "\n2." +
                                                      suvs.wheels[4].TireName);
                                }
                            }
                            catch (Exception e)
                            {
                                Console.WriteLine("Invalid Option you should select a number:\n1." +
                                                  suvs.wheels[3].TireName + "\n2." +
                                                  suvs.wheels[4].TireName);
                            }
                        }

                        Console.WriteLine("This is a summary of your selection:");
                        Console.WriteLine(suvs.arrSUV[0].toString(w1));
                    }
                    else if (suvCar == (int) SUVOptions.fortuner)
                    {
                        Console.WriteLine("Nice choice " + userName + " to select Toyota Fortuner car");
                        Console.WriteLine("Toyota Fortuner has 2 two types of wheels, select one:");
                        Console.WriteLine("1." + suvs.wheels[4].TireName);
                        Console.WriteLine("2." + suvs.wheels[1].TireName);
                        string w2 = "";
                        while (!(FortunerWheel == (int) FortunerWheel1.bridgestone ||
                                 FortunerWheel == (int) FortunerWheel1.Hankook))
                        {
                            try
                            {
                                FortunerWheel = Convert.ToInt32(Console.ReadLine());
                                if (FortunerWheel == (int) FortunerWheel1.bridgestone)
                                {
                                    Console.WriteLine("Great choice to select " + suvs.wheels[4].TireName + " tire");
                                    w2 = suvs.wheels[4].TireName;
                                }
                                else if (FortunerWheel == (int) FortunerWheel1.Hankook)
                                {
                                    Console.WriteLine("Great choice to select " + suvs.wheels[1].TireName + " tire");
                                    w2 = suvs.wheels[1].TireName;
                                }
                                else
                                {
                                    Console.WriteLine("Invalid Option you should select one either " +
                                                      suvs.wheels[4].TireName + " or " +
                                                      suvs.wheels[1].TireName);
                                }
                            }
                            catch (Exception e)
                            {
                                Console.WriteLine("Invalid Option you should select a number:\n1." +
                                                  suvs.wheels[4].TireName + "\n2." +
                                                  suvs.wheels[1].TireName);
                            }
                        }

                        Console.WriteLine("This is a summary of your selection:");
                        Console.WriteLine(suvs.arrSUV[1].toString(w2));
                    }
                    else
                    {
                        Console.WriteLine(
                            "Invalid option you should select number of the displayed cars in showroom");
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Invalid option you should select number of the displayed cars in showroom");
                }
            }
        }
    }
}
