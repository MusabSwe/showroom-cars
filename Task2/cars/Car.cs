using System;
using System.Collections.Generic;

namespace Task2
{
    class Car : Vehicle
    {
        private int passengerNum;
        private int numberOfCylinders;
        private int numberOfDoors;

        public Car(int passengerNum, int numOfCylinders, int numOfDoors)
        {
            if (passengerNum > 0 && numOfCylinders > 0 && numOfDoors > 0)
            {
                this.passengerNum = passengerNum;
                this.numberOfCylinders = numOfCylinders;
                this.numberOfDoors = numOfDoors;

            }
            else
            {
                Console.WriteLine("Invalid input, the values should be > 0");
            }


        }

        public Car()
        {

        }

        public int PassengerNumProp { get; set; }

        public int NumberOfCylindersProp { get; set; }

        public int NumberOfDoorsProp { get; set; }


    }

}