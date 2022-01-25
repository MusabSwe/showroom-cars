using System;
using System.Collections.Generic;

namespace ShowRoom.Core
{
    public class VanFactory
    {
        public List<Van> arrVan = new List<Van>();
        public Engine[] engines = new Engine[3];
        public Wheel[] wheels = new Wheel[8];

        public VanFactory(List<Van> arr)
        {
            this.arrVan = arr;
        }

        public VanFactory()
        {
        }

        public void AddSedanCar(Van a)
        {
            arrVan.Add(new Van(a.Name, a.PassengerNum.Value, a.NumberOfCylinders.Value, a.NumberOfDoors.Value, a.engine, a.wheel));
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
            arrVan.Add(new Van("GMC Safari", 9, 8, 4, engines[2],
                new Wheel("Pirelli", "Korian ", new DateTime(2021, 6, 11), 20),
                new FuelEconomy("GMC Safari", new DateTime(2018, 5, 1), "Desil", "Excellent")));
        }

        public void VanShowroom(string userName)
        {
            int vanCar = 0;
            int GMCWheel = 0;
            string w1 = "";
            VanFactory vans = new VanFactory();
            vans.ConnectToDB();
            Console.WriteLine("----------------van car showroom--------------------");
            Console.WriteLine("In van cars showroom there is only one car to sell");
            while (vanCar != (int) VanOptions.gmc)
            {
                try
                {
                    Console.WriteLine("1.GMC Safari\n2.Exit\nSelect an option?");
                    vanCar = Convert.ToInt32(Console.ReadLine());
                    if (vanCar == (int) VanOptions.gmc)
                    {
                        Console.WriteLine("Nice choice " + userName + " to select GMC Safari car");
                        Console.WriteLine("GMC Safari has 3 types of wheels, select one:");
                        Console.WriteLine("1." + vans.wheels[5].TireName);
                        Console.WriteLine("2." + vans.wheels[6].TireName);
                        Console.WriteLine("3." + vans.wheels[7].TireName);
                        while (!(GMCWheel == (int) GMCWheel1.Falken ||
                                 GMCWheel == (int) GMCWheel1.Pirelli ||
                                 GMCWheel == (int) GMCWheel1.Atlas))
                        {
                            try
                            {
                                GMCWheel = Convert.ToInt32(Console.ReadLine());
                                if (GMCWheel == (int) GMCWheel1.Falken)
                                {
                                    Console.WriteLine("Great choice to select " + vans.wheels[5].TireName + " tire");
                                    w1 = vans.wheels[5].TireName;
                                }
                                else if (GMCWheel == (int) GMCWheel1.Pirelli)
                                {
                                    Console.WriteLine("Great choice to select " + vans.wheels[6].TireName + " tire");
                                    w1 = vans.wheels[6].TireName;
                                }
                                else if (GMCWheel == (int) GMCWheel1.Atlas)
                                {
                                    Console.WriteLine("Great choice to select " + vans.wheels[7].TireName + " tire");
                                    w1 = vans.wheels[7].TireName;
                                }
                                else
                                {
                                    Console.WriteLine("Invalid Option you should select a number:\n1." +
                                                      vans.wheels[5].TireName + "\n2." +
                                                      vans.wheels[6].TireName + "\n3." +
                                                      vans.wheels[7].TireName);
                                }
                            }
                            catch (Exception e)
                            {
                                Console.WriteLine("Invalid Option you should select a number:\n1." +
                                                  vans.wheels[5].TireName + "\n2." +
                                                  vans.wheels[6].TireName + "\n3." +
                                                  vans.wheels[7].TireName);
                            }
                        }

                        Console.WriteLine("This is a summary of your selection:");
                        Console.WriteLine(vans.arrVan[0]
                            .toString(w1, vans.engines[2].EngineName));
                    }
                    else if (vanCar == (int) VanOptions.exit)
                    {
                        Console.WriteLine("Thank you to visit the van showroom");
                        break;
                    }
                    else
                    {
                        Console.WriteLine(
                            "Invalid option you should select number of the displayed options");
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(
                        "Invalid option you should select number of the displayed options");
                }
            }
        }
    }
}