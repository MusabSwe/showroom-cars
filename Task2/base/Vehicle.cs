using System;
namespace Task2
{

    class Vehicle
    {
        private int manufacturerNumber;
        private DateTime model;
        private string vehicleType;
        private double Price;

        public Vehicle(int manufacturerNumber, DateTime model, string vehicleType, double price)
        {

            this.manufacturerNumber = manufacturerNumber;
            this.model = model;
            this.vehicleType = vehicleType;
            this.Price = price;
        }

        public Vehicle()
        {

        }

        public double PriceProp { get; set; }

        public int ManufacturerNumberProp { get; set; }

        public DateTime VehicleModelProp { get; set; }

        public string VehicleTyperProp { get; set; }


        public void Move()
        {
            bool IsMoveForward = true;
            bool IsMoveBackward = true;
            bool IsStop = true;

            switch (IsStop)
            {

                case true:
                    if (IsMoveBackward == false && IsMoveForward == false)
                        Console.WriteLine("The vehicle is stopped, you can moveForward or backward");
                    break;
                case false:
                    if (IsMoveForward == true && IsMoveBackward == false)
                    {
                        Console.WriteLine("The vehicle moving Forward");
                    }
                    else if (IsMoveBackward == true && IsMoveForward == false)
                    {
                        Console.WriteLine("The vehicle moving backward");
                    }
                    else
                    {
                        Console.WriteLine("The vehicle must stop, to change gear");
                    }
                    break;

            }


        }

        public void turnRight()
        {
            Console.WriteLine("Move right");
        }

        public void turnLeft()
        {
            Console.WriteLine("Move left");
        }

        public void fillColor()
        {
            Console.WriteLine("fill vehicle by color ");
        }

    }

}