using System;

namespace Practice
{
    class Program
    {
        static void Main(string[] arge)
        {
            int result1 = 2 + 5 * 2;

            int partialResult = 2 + 5;
            int result2 = partialResult * 2;

            // Parentheses force the computer to do 2 + 5 before the multiplication
            int result3 = (2 + 5) * 2;

            int result4 = ((2 + 1) * 8 - (3 * 2) * 2) / 4;

            Console.WriteLine(result1);
            Console.WriteLine(result2);
            Console.WriteLine(result3);
            Console.WriteLine(result4);

            Console.ReadLine(); 
        }
    }
}
