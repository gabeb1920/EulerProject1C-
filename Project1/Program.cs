using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    class Program
    {
        static void Main(string[] args)
        {
            int totalSum = CalculateSumOfMultiples(3, 1000) + CalculateSumOfMultiples(5, 1000) - CalculateSumOfMultiples(15, 1000);
            Console.WriteLine("The sum of all multiples of 3 and 5 below 1000 is: " + totalSum);
            Console.ReadLine();
        }

        private static int CalculateSumOfMultiples(int divisor, int max)
        {
            int sum = 0;

            for(int i = 0; i * divisor < max; ++i)
            {
                sum += i * divisor;
            }

            return sum;
        }
    }
}
