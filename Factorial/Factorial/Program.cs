using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the nth value as integer: ");
            var n = int.Parse(Console.ReadLine());
            Console.WriteLine($"Loop calculation: Factorial of {n} is {Run(n)}");
            Console.WriteLine($"Loop2 calculation: Factorial of {n} is {Run2(n)}");
            Console.WriteLine($"Recusion calculation: Factorial of {n} is {Run3(n)}");
        }

        private static int Run(int n)
        {
            var f = 1;
            for (int i = n; i >= 1; i--)
            {
                f *= i;
            }
            return f;
        }

        private static int Run2(int n)
        {
            var f = n;
            for (int i = 1; i < n; i++)
            {
                f *= i;
            }
            return f;
        }

        private static int Run3(int n)
        {
            if (n == 1) return 1;
            return n * Run3(n - 1);
        }

    }
}
