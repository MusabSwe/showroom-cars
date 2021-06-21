using System;
using System.Collections.Generic;

namespace Task2
{
    class Car : Vehicle
    {
        private int passengerNum;
        private int numberOfCylinders;
        private int numberOfDoors;
        private string name;
        // --------------------------------
        public bool IsOpen = false;

        public Car(string n,int passengerNum, int numOfCylinders, int numOfDoors)
        {
            if (passengerNum > 0 && numOfCylinders > 0 && numOfDoors > 0)
            {
                this.name = n;
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
        public string NameProp { get; set; }

        public int PassengerNumProp { get; set; }

        public int NumberOfCylindersProp { get; set; }

        public int NumberOfDoorsProp { get; set; }


    }

}
