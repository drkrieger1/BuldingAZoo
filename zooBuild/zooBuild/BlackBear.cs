using System;
using System.Collections.Generic;
using System.Text;

namespace zooBuild
{
    class BlackBear : Ursidae
    {
        public override void Eat (string food)
        {
            Console.WriteLine($"Black bears eat {food}"); 
        }

        public override bool Hair()
        {
            return true;
        }
        public override void Hairtype()
        {
            Console.WriteLine("shaggy");
        }
    }
}
