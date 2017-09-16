using System;
using System.Collections.Generic;
using System.Text;

namespace zooBuild
{
    abstract class Mammals : Animal
    {
        public string HairColor { get; set; }

        public abstract bool hair(); 

        public void GiveBirth()
        {
            Console.WriteLine("Gives birth to living young");
        }


    }
}
