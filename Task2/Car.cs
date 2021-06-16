using System;
using System.Collections.Generic;

namespace Task2
{
    class Car : Vehicle
    {
        private int passengerNum;
        private int numberOfCylinders;
        private int numberOfDoors;
        private double Price;

        public Car(int passengerNum, int numOfCylinders, int numOfDoors, double price)
        {
            if (passengerNum > 0 && numOfCylinders > 0 && numOfDoors > 0 && price > 0.0)
            {
                this.passengerNum = passengerNum;
                this.numberOfCylinders = numOfCylinders;
                this.numberOfDoors = numOfDoors;
                this.Price = price;
            }
            else
            {
                Console.WriteLine("Invalid input, the values should be > 0");
            }


        }

        public Car()
        {

        }

        public void setPassengerNum(int n)
        {
            if(n > 0){
                this.passengerNum = n;
            }else {
                     Console.WriteLine("Invalid input, the value should be > 0");
            }
            
        }

        public int getPassengerNum()
        {
            return passengerNum;
        }

        public void setNumberOfCylinders(int n)
        {
             if(n > 0){
                this.numberOfCylinders = n;
            }else {
                     Console.WriteLine("Invalid input, the value should be > 0");
            }
            
        }

        public int getNumberOfCylinders()
        {
            return numberOfCylinders;
        }

        public void setNumberOfDoors(int n)
        {
             if(n > 0){
                this.numberOfDoors = n;
            }else {
                     Console.WriteLine("Invalid input, the value should be > 0");
            }
            
        }

        public int getNumberOfDoors()
        {
            return numberOfDoors;
        }

        public void setPrice(double n)
        {
            if(n > 0){
                this.Price = n;
            }else {
                     Console.WriteLine("Invalid input, the value should be > 0");
            }
            
        }

        public double getPrice(double tax = 0)
        {// default value
            return (Price * tax) + Price;
        }

    }

}