using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvoiceClass
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Create an invoice class that could be used by a bookstore. Items to include as data members are item number, description,
             * unit price, and quantity purchased.
             * 
             * Include appropriate constructors and properties plus an additional method that calculates the total cost using the
             * quantity and unit price. You will code additional items inside the calling program as static values and display them
             * as well as to show the different type of constructors.
             */
            Console.Write("enter item description: ");
            var item = Console.ReadLine();

            Console.Write("enter item number: ");
            var id = Console.ReadLine();

            Console.Write("enter quantity: ");
            var qty = int.Parse(Console.ReadLine());

            Console.Write("enter unit price: ");
            var price = double.Parse(Console.ReadLine());

            Console.WriteLine("FIRST INVOICE");
            Console.WriteLine(new Invoice(item, price, qty));

            Console.WriteLine("SECOND INVOICE");
            Console.WriteLine(new Invoice(item, price));

            Console.WriteLine("THIRD INVOICE");
            Console.WriteLine(new Invoice(id, item, price, qty));

            Console.WriteLine("LAST INVOICE");
            var invoice = new Invoice(id, item, price, qty);
            Console.WriteLine(invoice.CompleteOutput());
        }
    }
}
