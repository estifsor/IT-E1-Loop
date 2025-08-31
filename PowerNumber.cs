using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PowerNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Power of a Number: Write a program to calculate the power of a given base
            //number raised to a given exponent without using built-in functions.
            

            int baseNumber = 3;
            int exponent = 10;
            int i = 0;
            int result = 1;

            do
            {
                result = result * baseNumber;
                Console.WriteLine(result); 
                i++;
            }
            while (i < exponent);

        }
    }
}
