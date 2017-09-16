using System;
using System.Collections.Generic;
using System.Text;

namespace zooBuild
{
   abstract class Animal
    {
        public string Handler { get; set; }
        
        public string Location { get ; set; }
        public string Cage { get; set; }

        public void Sleep()
        {
            Console.WriteLine("ZZZZzzz...");
        }
        public abstract void Eat(string food); 
    }
}
