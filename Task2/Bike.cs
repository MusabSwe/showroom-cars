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

        public void setPassengerNum(int p)
        {
            if (p > 0)
            {
                this.passengerNum = p;
            }
            else
            {
                Console.WriteLine("Invalid input, the value should be > 0");
            }

        }

        public int getPassengerNum()
        {
            return passengerNum;
        }

        public void setNumberOfWheels(int p)
        {
            if (p > 0)
            {
                this.numberOfWheels = p;
            }
            else
            {
                Console.WriteLine("Invalid input, the value should be > 0");
            }

        }

        public int getNumberOfWheels()
        {
            return numberOfWheels;
        }

        public void setBikeType(string p)
        {
            if (p.ToLower().Equals("bicycle") || p.ToLower().Equals("motorbike"))
            {
                this.bikeType = p;
            }
            else
            {
                Console.WriteLine("Invalid input, the value should be bicycle or motorbike");
            }
        }

        public string getBikeType()
        {
            return bikeType;
        }


    }
}