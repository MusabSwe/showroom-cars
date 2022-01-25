using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Intrinsics.Arm;

namespace ShowRoom.Core
{
    public class CarFactory
    {
        public List<Car> arrCar = new List<Car>();
        public Engine [] engines = new Engine[3];
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
            arrCar.Add(new Car(a.Name, a.PassengerNum.Value, a.NumberOfCylinders.Value, a.NumberOfDoors.Value, a.engine, a.wheel));
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
            wheels[6] = new Wheel("Pirelli", "Korean ", new DateTime(2021, 6, 11), 20);
            wheels[7] = new Wheel("Atlas", "Indian ", new DateTime(2020, 9, 17), 21);
        }

        public void CarsShowroom(string userName)
        {
            int carType = 0;
            CarFactory cars = new CarFactory();
            cars.ConnectToDB();
            Console.WriteLine("There are 3 types of cars:\n1.sedan\n2.SUV\n3.van\nSelect a type:");
            while (!(carType == (int) CarOptions.sedan || carType == (int) CarOptions.suv || carType == (int) CarOptions.van))
            {
                try
                {
                    carType = Convert.ToInt32(Console.ReadLine());
                    switch (carType)
                    {
                        case (int)CarOptions.sedan:
                            SedanFactory sedans = new SedanFactory();
                            sedans.SedanShowroom(userName);
                            break;
                        case (int)CarOptions.suv:
                            SUVFactory suvs = new SUVFactory();
                            suvs.SUVShowroom(userName);
                            break;
                        case (int)CarOptions.van:
                            VanFactory vans = new VanFactory();
                            vans.VanShowroom(userName);
                            break;
                        default:
                            Console.WriteLine(
                                "Invalid option the option should be a number.\nReEnter the number\n1.sedan\n2.suv\n3.van");
                            break;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Invalid option the option should be a number.\nReEnter the number\n1.sedan\n2.suv\n3.van");
                }
            }
        }
    }
}