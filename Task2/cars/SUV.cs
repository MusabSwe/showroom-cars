using System;

namespace Task2
{
    class SUV : Car, ISunRoof
    {
        public void toggle()
        {
            bool isOpen = false;

            switch (isOpen)
            {
                case true:
                    Console.WriteLine("The sunroof of SUV car is open");
                    break;
                case false:
                    Console.WriteLine("The sunroof of SUV car is closed");
                    break;
            }
        }
    }

}