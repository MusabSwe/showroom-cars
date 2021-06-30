using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Task2
{
    enum VehicleOptions
    {
        car = 1,
        bike = 2,
        simulation = 3,
    }

    enum CarOptions
    {
        sedan = 1,
        suv = 2,
        van = 3
    }

    enum SedanOptions
    {
        camry = 1,
        sonata = 2
    }

    enum CamryEngines
    {
        hybrid = 1,
        regular = 2
    }

    enum CamryWheel
    {
        Okohama = 1,
        Hankook = 2
    }

    enum SonataWheel
    {
        Goodyear = 1,
        Firestone = 2
    }

    enum SUVOptions
    {
        creta = 1,
        fortuner = 2
    }

    enum CretaWheel
    {
        Goodyear = 1,
        bridgestone = 2
    }

    enum FortunerWheel1
    {
        bridgestone = 1,
        Hankook = 2
    }

    enum VanOptions
    {
        gmc = 1,
        exit = 2
    }

    enum GMCWheel1
    {
        Falken = 1,
        Pirelli = 2,
        Atlas = 3
    }

    enum BikeOptions
    {
        bicycle = 1,
        motor = 2
    }
    
    enum bicycleOptions
    {
        rambo = 1,
        exit = 2
    }
    enum MotorOptions
    {
        venom = 1,
        exit = 2
    }

    public class Program
    {
        static void Main(string[] args)
        {
            int vehicleOption = 0;
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
                              ",Welcome to our website there are 3 options\n1.Car\n2.Bike\n3.Drive Simulation\nPlease select one:");

            while (!(vehicleOption == (int) VehicleOptions.car || vehicleOption == (int) VehicleOptions.bike ||
                     vehicleOption == (int) VehicleOptions.simulation))
            {
                try
                {
                    vehicleOption = Convert.ToInt32(Console.ReadLine());

                    if (vehicleOption == (int) VehicleOptions.car)
                    {
                        cars.CarsShowroom(userName);
                    }
                    else if (vehicleOption == (int) VehicleOptions.bike)
                    {
                        bikes.BikesShowroom(userName);
                    }
                    else if (vehicleOption == (int) VehicleOptions.simulation)
                    {
                        vehicle.DriveSimulator(userName);
                    }
                    else
                    {
                        Console.WriteLine(
                            "Invalid option the option should be number.\nReEnter the number?");
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Invalid input, select a number");
                }
            }
        }
    }
}
