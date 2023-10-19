using System;

namespace Practice
{
    internal class Practice
    {
        static void Main(string[] args)
        {
            Soda coke = new Soda("Coke", 1.50m, 10, "Cola");
            Juice orangeJuice = new Juice("Orange Juice", 2.00m, 5, "Orange");

            coke.PrintDetails();
            coke.Open();
            coke.Shake();
            coke.Buy(2);
            coke.PrintDetails();

            Console.WriteLine();

            orangeJuice.PrintDetails();
            orangeJuice.Open();
            orangeJuice.Pour();
            orangeJuice.Buy(10);
            orangeJuice.PrintDetails();
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
        }
    }
}
