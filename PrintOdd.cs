using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintOdd
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Print Odd Numbers: Write a program to print all odd numbers between 1 and 50. 
            int i = 1;
            while (i <= 50)
            {
                Console.WriteLine(i);
                i = i + 2;
            }
            

        }
    }
}
