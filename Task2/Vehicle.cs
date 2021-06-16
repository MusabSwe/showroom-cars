using System;
namespace Task2
{

    class Vehicle
    {
        private int manufacturerNumber;
        private DateTime model;
        private string vehicleType;

        public Vehicle(int manufacturerNumber, DateTime model,string vehicleType){

            this.manufacturerNumber = manufacturerNumber;
            this.model = model;
            this.vehicleType = vehicleType;
        
        }

        public Vehicle(){
            
        }

        public void setManufactureNum(int x)
        {
            if (x > 0)
            {

                this.manufacturerNumber = x;
            }
            else
            {
                Console.WriteLine("Invalid number, should be positive");
            }

        }

        public int getManufacturerNumber()
        {

            return manufacturerNumber;
        }

        public void setModel(DateTime x)
        {
            this.model = x;
        }

        public DateTime getModel()
        {
            return model;
        }

        public void setVehicleType(string x)
        {
            if (x.ToLower().Equals("car") || x.ToLower().Equals("bike"))
            {
                this.vehicleType = x;
            }else{
                Console.WriteLine("Invalid type, should be car or bike types");
            }

        }

        public string getVehicleType()
        {
            return vehicleType;
        }


        public void MoveForward()
        {
            Console.WriteLine("Move Forward");
        }

        public void MoveBackward()
        {
            Console.WriteLine("Move backward");
        }

        public void turnRight()
        {
            Console.WriteLine("Move right");
        }

        public void turnLeft()
        {
            Console.WriteLine("Move left");
        }

        public void stop()
        {
            Console.WriteLine("stop!!");
        }

        public void fillColor()
        {
            Console.WriteLine("fill vehicle by color ");
        }

    }

}