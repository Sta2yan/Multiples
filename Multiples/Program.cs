using System;
using System.Collections.Generic;

namespace Multiples
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int maximumNumber = 28;
            int minimumNumber = 1;
            int number = random.Next(minimumNumber, maximumNumber);
            int multipleNumbers = 0;

            for (int i = number; i < 1000; i += number)
            {
                if (i > 99)
                    multipleNumbers++;
            }

            Console.WriteLine(multipleNumbers);
        }
    }
}