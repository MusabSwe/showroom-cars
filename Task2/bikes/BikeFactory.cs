using System.Collections.Generic;

namespace Task2
{
    public class BikeFactory
    {
        public List<Bike> arrBike = new List<Bike>();

        public BikeFactory(List<Bike> arr)
        {
            this.arrBike = arr;
        }
        public BikeFactory()
        {
            
        }

        public void AddBike(Bike arr)
        {
            arrBike.Add(new Bike(arr.name, arr.passengerNum, arr.numberOfWheels, arr.bikeType));
        }

        public void DB()
        {
            arrBike.Add(new Bike("Venom", 2, 2, "motor bike"));
            arrBike.Add(new Bike("Rambo", 1, 2, "Bicycle"));
       
        }
    }
}