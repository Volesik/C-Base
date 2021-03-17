using System;

namespace additionaltask
{
    class Program
    {
        static void Main(string[] args)
        {
            Address newHome = new Address();

            newHome.Index = 11111;
            newHome.Country = "Ukraine";
            newHome.City = "Kyiv";
            newHome.Street = "Some str.";
            newHome.House = 66;
            newHome.Apartment = 99;

            Console.WriteLine($"{newHome.Index} {newHome.Street}");
            Console.WriteLine($"{newHome.City},");
            Console.WriteLine($"h: {newHome.House} app: {newHome.Apartment}");
            Console.WriteLine($"{newHome.Country}");

            Console.ReadKey();
        }
    }
}
