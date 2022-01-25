using ShowRoom.Core;
using System.Collections.Generic;

public interface IShowRoomData
{
    Engine AddEngine(Engine e);
    FuelEconomy AddFuelCard(FuelEconomy f);
    Wheel AddWheel(Wheel w);
    Vehicle AddVehicle(Vehicle v);
    Car AddCar(Car c);
    Bike addBike(Bike b);

    IEnumerable<Engine> GetEngines();
    IEnumerable<Wheel> GetWheels();
    IEnumerable<FuelEconomy> GetFuelCards();
    IEnumerable<Vehicle> GetVehicles();
    IEnumerable<Car> GetCars();

    IEnumerable<Car> GetCarByName(string name);
    IEnumerable<Bike> GetBikes();
    IEnumerable<Bike> GetBikeByName(string name);
    int commit();
}

