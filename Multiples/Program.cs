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
            int maximumThreeDigitNumber = 999;
            int minimumThreeDigitNumber = 100;

            for (int i = number; i <= maximumThreeDigitNumber; i += number)
            {
                if (i >= minimumThreeDigitNumber)
                    multipleNumbers++;
            }

            Console.WriteLine(multipleNumbers);
        }
    }
}