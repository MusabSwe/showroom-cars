using System;
using System.Collections.Generic;

namespace Task2
{
    public class Engine
    {
        public int Id { get; set; }

        public string EngineName { get; set; }

        public Engine(int id, string EngineName)
        {
            this.Id = id;
            this.EngineName = EngineName;
        }

        public Engine()
        {
            
        }
    }
}
