using System;
using System.Collections.Generic;
using System.Text;

namespace zooBuild
{
    abstract class Mammals : Animal
    {
        public string HairColor { get; set; }

        public abstract bool Hair(); 

        public void GiveBirth()
        {
            Console.WriteLine("Give birth to living young");
        }


    }
}
