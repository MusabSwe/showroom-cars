using System;
using System.ComponentModel.DataAnnotations;

namespace ShowRoom.Core
{

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

    public class Vehicle : IMove
    {
        public int VehicleId { get; set; }
        [Required(ErrorMessage = "The Price field is required.")]
        [Range(typeof(double), "0", "1000000000")]
        public double? Price { get; set; }
        [Required(ErrorMessage = "The Manufacturer Number field is required.")]
        [Display(Name = "Manufacturer Number")]
        [Range(typeof(int), "0","99999999")]
        public int? ManufacturerNumber { get; set; }
        [Required(ErrorMessage = "The Vehicle Model field is required.")]
        [Display(Name = "Vehicle Model")]
        public DateTime? Model { get; set; }
        [Required(ErrorMessage = "The Vehicle Type field is required.")]
        [Display(Name = "Vehicle Type")]
        public string VehicleType { get; set; }

        public string currentGear = "N";

        public Vehicle(int manufacturerNumber, DateTime model, string vehicleType, double price)
        {
            this.ManufacturerNumber = manufacturerNumber;
            this.Model = model;
            this.VehicleType = vehicleType;
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
            return "vehicle type is " + VehicleType + ", manufacturer number is " + ManufacturerNumber +
                   ", and model " + Model.Value.Year + " and price: " + Price + " SAR";
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
        
        public void DriveSimulator(string userName)
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