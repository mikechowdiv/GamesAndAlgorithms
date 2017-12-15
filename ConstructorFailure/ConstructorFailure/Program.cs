using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorFailure
{
    class Program
    {
        static void Main(string[] args)
        {
            //write a program that shows a constructor passing information about constructor failure to an exception handler
            //the exception thrown also should contain the arguments sent to the constructor

            try
            {
                var test = new TestClass(10, 0);
            }
            catch(DivideByZeroException ex)
            {
                Console.WriteLine("The message is \n" + ex.Message);
            }

            Console.ReadLine();
        }
    }
}
