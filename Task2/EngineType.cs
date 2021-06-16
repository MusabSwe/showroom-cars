using System;
using System.Collections.Generic;

namespace Task2
{

    class EngineType
    {

        private List<string> engineType = new List<string>();
        private string carName;

        public EngineType(string carName)
        {
            this.carName = carName;

        }
        public void addEngine(string n)
        {

            engineType.Add(n);
        }

        public void setCarName(string car)
        {

            this.carName = car;

        }

        public string getCarName()
        {

            return carName;
        }

        public void DisplayInfo()
        {
            if (engineType.Count > 1)
            {
                Console.WriteLine("Engines for " + getCarName() + " car are");
                for (int i = 0; i < engineType.Count; i++)
                {
                    Console.Write(engineType[i]+",");
                }

            }
            else if (engineType.Count == 1)
            {

                Console.WriteLine("Engine for " + getCarName() + " car is");
                for (int i = 0; i < engineType.Count; i++)
                {
                    Console.WriteLine(engineType[i]);
                }
            }

        }

    }

}