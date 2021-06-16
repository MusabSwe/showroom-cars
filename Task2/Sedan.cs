using System;

namespace Task2
{
    class Sedan : Car, ISunroof
    {
         public void close()
        {
            Console.WriteLine("The sunroof of Sedan car is closed");

        }

        public void open()
        {
            Console.WriteLine("The sunroof of Sedan car is open");
        }
    }

}