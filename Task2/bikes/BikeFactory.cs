using System;
using System.Collections.Generic;

namespace Task2
{
    public class BikeFactory
    {
        public List<Bike> arrBike = new List<Bike>();
        public Wheel[] wheels = new Wheel[2];
        public BikeFactory(List<Bike> arr)
        {
            this.arrBike = arr;
        }

        public BikeFactory()
        {
        }

        public void AddBike(Bike arr)
        {
            if (arr.engine.EngineName != null)
            {
                arrBike.Add(new Bike(arr.name, arr.passengerNum, arr.numberOfWheels, arr.bikeType, arr.engine,
                    arr.wheel));
            }
            else if (arr.engine.EngineName.ToLower().Equals("regular"))
            {
                arrBike.Add(new Bike(arr.name, arr.passengerNum, arr.numberOfWheels, arr.bikeType, arr.engine,
                    arr.wheel, arr.fuelEcon));
            }
            else
            {
                arrBike.Add(new Bike(arr.name, arr.passengerNum, arr.numberOfWheels, arr.bikeType, arr.wheel));
            }
        }

        public void ConnectToDB()
        {
            wheels[0] = new Wheel("Cobra", "German ", new DateTime(2021, 2, 22), 12);
            wheels[1] = new Wheel("Kenda", "America ", new DateTime(2020, 9, 17), 9);

            /*0*/
            arrBike.Add(new Bike("Venom", 2, 2, "motor bike", new EngineType(2, "Regular"),
                new Wheel("Cobra", "German ", new DateTime(2021, 2, 22), 12),
                new FuelEconomy("Venom", new DateTime(2021, 3, 4), "Green", "Good")));
            /*1*/
            arrBike.Add(
                new Bike("Rambo", 1, 2, "Bicycle", new Wheel("Kenda", "America ", new DateTime(2020, 9, 17), 9)));
        }
    }
}
