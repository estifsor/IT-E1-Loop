using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOdd
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Sum of Odd Digits: Write a program to calculate the sum of odd digits in a given number.

            int i = 1;
            int sum = 0;
            while (i <= 50)
            {
                sum = sum + i;
                Console.WriteLine(sum);
                i = i + 2;
            }
        }
    }
}
