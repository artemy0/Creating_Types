using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreatingTypesLibrary.Products
{
    public class Electronics : Product
    {
        public string Company { get; set; }

        public Electronics(string name, double price, string manufacture, string company) : base(name, price, manufacture)
        {
            Company = company;
        }

        public override double GetDiscountPrice(Customer customer)
        {
            if (customer.Spent < 300)
                return Price;
            if (customer.Spent < 2000)
                return Price * 0.95;
            return Price * 0.9;
        }

        public override void GetInfo()
        {
            Console.WriteLine($"Product name: {Name}\nPrice: {Price}\nManufacturer: {Manufacturer}\nManufacturing company: {Company}\n");
        }
    }
}
