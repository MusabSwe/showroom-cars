using System;

namespace Task2
{
    public class Vehicle : IMove
    {
        public double Price { get; set; }

        public int manufacturerNumber { get; set; }

        public DateTime model { get; set; }

        public string vehicleType { get; set; }

        public string currentGear = "N";

        public bool IsMoveForward = false;
        public bool IsMoveBackward = false;
        public bool IsStop = true;

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

        public string toString()
        {
            return "vehicle type is " + vehicleType + ", manufacturer number is " + manufacturerNumber +
                   ", and model " + model + " and price: " + Price + " SAR";
        }

        public void move(string gear)
        {
            if (gear == "D" && currentGear == "N")
            {
                Console.WriteLine("The vehicle moving forward");

                currentGear = "D";
            }
            else if (gear == "N")
            {
                Console.WriteLine("The vehicle is stopped");
                currentGear = "N";
            }
            else if (gear == "R" && currentGear == "N")
            {
                Console.WriteLine("The vehicle moving backward");

                currentGear = "R";
            }
            else if (gear == "D" && currentGear == "R")
            {
                Console.WriteLine("You must stop, to change gear");
            }
            else if (gear == "R" && currentGear == "D")
            {
                Console.WriteLine("You must stop, to change gear");
            }
            else if (gear == "R" && currentGear == "R")
            {
                Console.WriteLine("Already vehicle moving backward");
            }
            else if (gear == "D" && currentGear == "D")
            {
                Console.WriteLine("Already vehicle moving forward");
            }
            else
            {
                Console.WriteLine("Invalid input the gear values should be D, N or R");
            }
            
        }
        
        public void Main(string userName)
        {
            Console.WriteLine("Hi " + userName + ",");
            Console.WriteLine("Welcome to Drive Simulation");
            Console.WriteLine("Let start..");
            Vehicle v = new Vehicle();
            string gear = "";
            Console.WriteLine("Instrutions of Drive Simulation\nD--> moveForward\nR--> moveBackward" +
                              "\nN--> stop\nExit--> to leave out Drive Simulation");
            while (!gear.ToUpper().Equals("EXIT"))
            {
                Console.WriteLine("Select an option: \n1.D\n2.N\n3.R\n4.EXIT");
                gear = Console.ReadLine();

                if (gear.ToUpper().Equals("D"))
                {
                    // Console.WriteLine(gear);
                    v.move(gear.ToUpper());
                }
                else if (gear.ToUpper().Equals("EXIT"))
                {
                    Console.WriteLine("Good bye..");
                    break;
                }
                else if (gear.ToUpper().Equals("R"))
                {
                    v.move(gear.ToUpper());
                }
                else if (gear.ToUpper().Equals("N"))
                {
                    v.move(gear.ToUpper());
                }
                else
                {
                    Console.WriteLine("Invalid Input ReEnter the displayed options");
                }
            }
        }
        
    }
}
