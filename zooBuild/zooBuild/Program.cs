using System;

namespace zooBuild
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is my zoo");

            BlackBear bill = new BlackBear();
            bill.Location = "Seattle";
            bill.Handler = "Erik";
            bill.HairColor = "black";
            bill.Cage = "big cage";

            Console.WriteLine($"Bill is a Black Bear that lives in a zoo located in {bill.Location}");
            Console.WriteLine($"Bills handler is {bill.Handler}");
            Console.WriteLine($"Bills fur color is {bill.HairColor} and he has a {bill.Cage}");
            Console.WriteLine($"Bill likes to:");
            bill.Eat("meat");
            bill.Sleep();
            Console.WriteLine($"Bills fur is");
            bill.Hairtype();
            Console.WriteLine($"Black bears are mammals because they:");
            bill.GiveBirth();


            Console.Read();
        }
    }
}
