using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Task2
{
    public class Program
    {
        static void Main(string[] args)
        {
            string vehicleType = "";
            CarFactory cars = new CarFactory();
            cars.ConnectToDB();
            BikeFactory bikes = new BikeFactory();
            bikes.ConnectToDB();
            Vehicle vehicle = new Vehicle();
            Console.WriteLine("Enter your name:");
            string userName = "";
            Regex r = new Regex("^[a-zA-Z\\s*]*$");
            userName = Console.ReadLine();
            while (!r.IsMatch(userName))
            {
                if (!r.IsMatch(userName))
                {
                    Console.WriteLine("ReEnter your name only letters accepted");
                    userName = Console.ReadLine();
                }
            }

            Console.WriteLine("Hi " + userName +
                              ",Welcome to our website there are 3 options\n1.Car\n2.Bike\n3.Drive Simulation\nPlease write one:");

            while (!(vehicleType.ToLower().Equals("car") || vehicleType.ToLower().Equals("bike") ||
                     vehicleType.ToLower().Equals("drive simulation")))
            {
                vehicleType = Console.ReadLine();

                if (vehicleType.ToLower().Equals("car"))
                {
                    cars.Main(userName);
                }
                else if (vehicleType.ToLower().Equals("bike"))
                {
                    bikes.Main(userName);
                }
                else if (vehicleType.ToLower().Equals("drive simulation"))
                {
                    vehicle.Main(userName);
                }
                else
                {
                    Console.WriteLine(
                        "Invalid option the option should be either car or bike or Drive Simulation.\nReEnter the type?");
                }
            }
        }
    }
}
