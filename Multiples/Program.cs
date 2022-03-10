using System;
using System.Collections.Generic;

namespace Multiples
{
    class Program
    {
        static void Main(string[] args)
        {
            int maximumNumber = 27;
            int startNumber = 3;
            int multipleNumbers = 0;
            int enlargedNumber = 3;

            for (int i = startNumber; i <= maximumNumber; i += enlargedNumber)
            {
                ++multipleNumbers;
            }

            Console.WriteLine($"{multipleNumbers}");
        }
    }
}