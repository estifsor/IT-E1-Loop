using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
           //Sum of Squares: Write a program to calculate the sum of the squares of the first 10 natural numbers.
            for (int i = 1; i <= 10; i++)
            {
                int sum = i*i;
                Console.WriteLine(sum);
            }
        }
    }
}
