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

        public string EngineNameProp { get; set; }


        public void addEngine(string n)
        {

            engineType.Add(n);
        }

        public void DisplayInfo()
        {
            if (engineType.Count > 1)
            {
                Console.WriteLine("Engines for " + EngineNameProp + " car are");
                for (int i = 0; i < engineType.Count; i++)
                {
                    Console.Write(engineType[i] + ",");
                }

            }
            else if (engineType.Count == 1)
            {

                Console.WriteLine("Engine for " + EngineNameProp + " car is");
                for (int i = 0; i < engineType.Count; i++)
                {
                    Console.WriteLine(engineType[i]);
                }
            }

        }

    }

}