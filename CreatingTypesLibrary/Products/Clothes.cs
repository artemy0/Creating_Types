
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace CreatingTypesLibrary.Products
{
    public class Clothes : Product
    {
        public string Size { get; set; }

        public Clothes(string name, double price, string manufacture, string size) : base(name, price, manufacture)
        {
            Size = size;
        }

        public override double GetDiscountPrice(Customer customer)
        {
            if (customer.Spent < 250)
                return Price;
            if (customer.Spent < 500)
                return Price * 0.95;
            return Price * 0.9;
        }

        public override void GetInfo()
        {
            Console.WriteLine($"Product name: {Name}\nPrice: {Price}\nManufacturer: {Manufacturer}\nSize: {Size}\n");
        }
    }
}