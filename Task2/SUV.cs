using System;

namespace Task2
{
    class SUV : Car, ISunroof
    {
        public void close()
        {
            Console.WriteLine("The sunroof of SUV car is closed");

        }

        public void open()
        {
            Console.WriteLine("The sunroof of SUV car is open");
        }
    }

}