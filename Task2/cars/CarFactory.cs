using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Intrinsics.Arm;

namespace Task2
{
    public class CarFactory
    {
        public List<Car> arrCar = new List<Car>();

        public CarFactory(List<Car> arr)
        {
            this.arrCar = arr;
        }

        public CarFactory()
        {
            
        }
        public void AddCar(Car a)
        {
            arrCar.Add(new Car(a.name, a.passengerNum, a.numberOfCylinders, a.numberOfDoors));
        }

        public void DB()
        {
            arrCar.Add(new Car("Camry", 5, 6, 4));
            arrCar.Add(new Car("Sonata", 5, 4, 4));
            arrCar.Add(new Car("Hyundai Creta", 7, 6, 4));
            arrCar.Add(new Car("Toyota Fortuner", 7, 4, 4));
            arrCar.Add(new Car("GMC Safari", 9, 8, 4));
            // arrCar.Add(new Car("Accent", 5, 4, 4));
        }

    }
}