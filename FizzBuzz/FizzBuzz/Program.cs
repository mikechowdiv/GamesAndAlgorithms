using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("For Loop Solution");
            string text;

            for (int i = 100; i >= 1; i--)
            {
                if (i % 15 == 0)
                    text = "FizzBuzz";
                else if (i % 3 == 0)
                    text = "Fizz";
                else if (i % 5 == 0) 
                    text = "Buzz";
                else
                    text = i.ToString();

                Console.WriteLine(text);
            }
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine("Recursive Solution: ");
            Recursion(1);
        }

        private static void Recursion(int n)
        {
            string text = "";
            if (n > 100) return;

            if(n % 15 == 0)
                text = "FizzBuzz";
            else if (n % 3 == 0)
                text = "Fizz";
            else if (n % 5 == 0)
                text = "Buzz";
            else
                text = n.ToString();

            Console.WriteLine(text);
            Recursion(n + 1);
        }

    }
}
