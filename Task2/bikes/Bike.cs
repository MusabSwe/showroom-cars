using System;

namespace Task2
{
    class Bike
    {
        private int passengerNum;
        private int numberOfWheels;
        private string bikeType;

        public Bike(int passengerNum, int numOfWheels, string bikeType)
        {

            if (passengerNum > 0 && numOfWheels > 0 && (bikeType.ToLower().Equals("bicycle") || bikeType.ToLower().Equals("motorbike")))
            {

                this.passengerNum = passengerNum;
                this.numberOfWheels = numOfWheels;
                this.bikeType = bikeType;
            }
            else
            {
                Console.WriteLine("Invalid input");
            }

        }

        public Bike(){
            
        }

        public int PassengerNumProp { get; set; }

        public int NumberOfWheelsProp { get; set; }

        public string BikeTypeProp { get; set; }


    }
}