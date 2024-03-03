using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double start = -3.14;
            double end = 3.14;
            double step = 0.2;

            Console.WriteLine("|   x   |   f(x)   |");
            Console.WriteLine("|-------|----------|");

            for (double x = start; x <= end; x += step)
            {
                double result = Math.Sin(x);
                Console.WriteLine($"| {x,5:F2}|{result,8:F4}|");
            }
            Console.ReadKey();
        }
    }
}
