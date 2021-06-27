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
        public Wheel[] wheels = new Wheel[13];

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
            wheels[2] = new Wheel("Goodyear", "China ", new DateTime(2021, 2, 23), 18);
            wheels[3] = new Wheel("Firestone", "America", new DateTime(2021, 4, 17), 17);
            wheels[4] = new Wheel("Goodyear", "China ", new DateTime(2021, 2, 23), 19);
            wheels[5] = new Wheel("bridgestone ", "Korean", new DateTime(2021, 4, 17), 19);
            wheels[6] = new Wheel("bridgestone", "China ", new DateTime(2021, 2, 23), 19);
            wheels[7] = new Wheel("Hankook", "China ", new DateTime(2020, 2, 23), 19);
            wheels[8] = new Wheel("Falken", "Japan ", new DateTime(2019, 3, 26), 21);
            wheels[9] = new Wheel("Pirelli", "Korian ", new DateTime(2021, 6, 11), 20);
            wheels[10] = new Wheel("Atlas", "Indian ", new DateTime(2020, 9, 17), 21);

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
    }
}
