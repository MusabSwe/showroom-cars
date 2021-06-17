using System;

namespace Task2
{
    class Sedan : Car, ISunRoof
    {
        public void toggle()
        {
            bool isOpen = false;

            switch (isOpen)
            {
                case true:
                    Console.WriteLine("The sunroof of Sedan car is open");
                    break;
                case false:
                    Console.WriteLine("The sunroof of Sedan car is closed");
                    break;
            }

        }
    }

}