using System;

namespace Task2
{
    class Sedan : Car, ISunRoof
    {
        Car c1 = new Car();

        public void toggle()
        {

            if (c1.IsOpen == true)
            {
                Console.WriteLine("The sunroof of Sedan car is open");
                Console.WriteLine("off");
                c1.IsOpen = false;
            }
            else if (c1.IsOpen == false)
            {
                Console.WriteLine("The sunroof of Sedan car is closed");
                Console.WriteLine("on");
                c1.IsOpen = true;
            }
        }

    }

}
