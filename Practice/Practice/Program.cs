using System;

namespace Practice
{
    class Program
    {
        static void Main(string[] arge)
        {
            double number1 = 3.5623;
            float number2 = 3.5623f; // f for float
            decimal number3 = 3.5623m; // m for money

            double avogadrosNumber = 6.022e23;

            bool itWorked = true;
            itWorked= false;

            string name = "Mansor";

            var message = "Hello there";

            Console.WriteLine("What is your favorite number?"); ;
            string favoriteNumberText = Console.ReadLine();
            
            int favoriteNumber = int.Parse(favoriteNumberText);
            

            Console.WriteLine(number1);
            Console.WriteLine(number2);
            Console.WriteLine(number3);
            Console.WriteLine(avogadrosNumber);
            Console.WriteLine(itWorked);
            Console.WriteLine(name);
            Console.WriteLine(message);
            Console.WriteLine(favoriteNumber);
            

            Console.ReadLine(); 
        }
    }
}
