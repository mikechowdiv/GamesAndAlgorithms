using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            var n1 = 0;
            var n2 = 1;

            Console.WriteLine(n1);
            Console.WriteLine(n2);

            for (int i = 0; i <= 15; i++)
            {
                var next = n1 + n2;
                n1 = n2;
                n2 = next;
                Console.WriteLine(next);
            }
            Console.WriteLine("");
            Console.WriteLine("Fibonacci recusive solution with return value");
            for (int i = 0; i <= 15; i++)
            {
                Console.WriteLine(Recursion(i));
            }
        }

        private static int Recursion(int n)
        {
            if (n <= 1) return 1;
            return Recursion(n - 2) + Recursion(n - 1);
        }
    }
}
