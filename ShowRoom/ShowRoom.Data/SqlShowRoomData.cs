using ShowRoom.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShowRoom.Data
{
    public class SqlShowRoomData : IShowRoomData
    {
        private readonly ShowRoomContext db;

        public SqlShowRoomData(ShowRoomContext db)
        {
            this.db = db;
        }

        public Bike addBike(Bike b)
        {
            db.Bike.Add(b);
            return b;
        }

        public Car AddCar(Car c)
        {
            db.Car.Add(c);
            return c;
        }

        public Engine AddEngine(Engine e)
        {
            db.Engine.Add(e);
            return e;
        }

        public FuelEconomy AddFuelCard(FuelEconomy f)
        {
            db.FuelEconomy.Add(f);
            return f;
        }

        public Vehicle AddVehicle(Vehicle v)
        {
            db.Vehicle.Add(v);
            return v;
        }

        public Wheel AddWheel(Wheel w)
        {
            db.Wheel.Add(w);
            return w;
        }

        public int commit()
        {
          return  db.SaveChanges();
        }

        public IEnumerable<Bike> GetBikeByName(string name)
        {
            var query = from b in db.Bike
                        where b.Name.StartsWith(name) || string.IsNullOrEmpty(name)
                        orderby b.Name
                        select b;
            return query;
        }

        public IEnumerable<Bike> GetBikes()
        {
            var query = from b in db.Bike
                        orderby b.VehicleId
                        select b;
            return query;
        }

        public IEnumerable<Car> GetCarByName(string name)
        {
            var query = from c in db.Car
                        where c.Name.StartsWith(name) || string.IsNullOrEmpty(name)
                        orderby c.Name
                        select c;
            return query;
        }

        public IEnumerable<Car> GetCars()
        {
            var query = from c in db.Car
                        orderby c.VehicleId
                        select c;
            return query;
        }

        public IEnumerable<Engine> GetEngines()
        {
            var query = from e in db.Engine
                        orderby e.Id
                        select e;
            return query;
        }

        public IEnumerable<FuelEconomy> GetFuelCards()
        {
            var query = from f in db.FuelEconomy
                        orderby f.Id
                        select f;
            return query;
        }

        public IEnumerable<Vehicle> GetVehicles()
        {
            var query = from v in db.Vehicle
                        orderby v.VehicleId
                        select v;
            return query;
        }

        public IEnumerable<Wheel> GetWheels()
        {
            var query = from w in db.Wheel
                        orderby w.Id
                        select w;
            return query;
        }
    }
}
