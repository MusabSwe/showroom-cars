using System;

namespace Task2
{
    class Program
    {
    
        static void Main(string[] args)
        {
        //     var x = new Vehicle();
        //     x.setModel(new DateTime(2021, 6 , 15));
        //     var n = new Car();
        //     Console.WriteLine(x.getModel());
        // MyMethod(child3: "Mosab", child1: "Ali", child2: "Jaber");

        Car c1 = new Car();
        Wheel w = new Wheel("Sonata","Okohama","Japan",new DateTime(2021,6,16),17);
        Console.WriteLine(w.toString());

        EngineType e = new EngineType("Camry");
            e.addEngine("Hybrid");
            e.addEngine("fuel only");
            Console.WriteLine("--------------------------------------");
            e.DisplayInfo();
            FuelEconomy f = new FuelEconomy();

             f.VehicleModelProp = new DateTime(2021,6,23);
            f.FuelTypeProp = "Red";
            f.VehicleNameProp = "Sonata";
            f.EconomyLevelProp = "Good";

           Console.WriteLine(f.DisplayFuelInfo());

    

        }
    }
}
