using System;
using System.Collections.Generic;

namespace ArraysAndLists
{
    class Program
    {
        static void Main(string[] args)
        {
            var numArray = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            var evens = new List<int>();
            var odds = new List<int>();

            foreach (var number in numArray)
            {
                if (number % 2 == 0)
                {
                    evens.Add(number);
                }
                else
                {
                    odds.Add(number);
                }
            }

            Console.WriteLine("Evens List: ");

            for (int i = 0; i < evens.Count; i++)
            {
                Console.WriteLine(evens[i]);
            }

            Console.WriteLine("");
            Console.WriteLine("Odds List: ");

            for (int i = 0; i < odds.Count; i++)
            {
                Console.WriteLine(odds[i]);
            }

            Console.WriteLine("");
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }
    }
}
