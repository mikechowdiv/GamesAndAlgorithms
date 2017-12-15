using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvoiceClass
{
    class Invoice
    {
        //constructor with all parameters
        public Invoice(string id, string desc, double unitPrice, int qty)
        {
            Number = id;
            Description = desc;
            UnitPrice = unitPrice;
            Quantity = qty;
        }

        //constructor with description, unit price, default quantity
        public Invoice(string desc, double unitPrice, int qty = 5)
        {
            Description = desc;
            UnitPrice = unitPrice;
            Quantity = qty;
        }

        public string Number { get; set; }
        public string Description { get; set; }
        public double UnitPrice { get; set; }
        public int Quantity { get; set; }
        public double CalcTotal()
        {
            return UnitPrice * Quantity;
        }

        public override string ToString()
        {
            var id = (Number == null) ? "" : "Item Numnber " + Number + "\n";
            return String.Format(
                "\n{0}Item Description: {1}\nTotal Cost: {2:C2}\n",
                id,Description, CalcTotal()); 
        }

        public string CompleteOutput()
        {
            return String.Format("Item Description: {0}\n" + "Item Number: {1}\n" + "Qty Purchased: {2}\n" + "Unit Price: {3:C2}\n" + "Total Cost: {4:C2}", Description, Number, Quantity, UnitPrice, CalcTotal());
        }
    }
}
