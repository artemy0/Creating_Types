using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreatingTypesLibrary.Products
{
    public class Food : Product
    {
        public DateTime ShelfLife { get; set; }

        public Food(string name, double price, string manufacture, DateTime shelfLife) : base(name, price, manufacture)
        {
            ShelfLife = shelfLife;
        }

        public override double GetDiscountPrice(Customer customer)
        {
            if (customer.Spent < 500)
                return Price;
            if (customer.Spent < 1000)
                return Price * 0.95;
            return Price * 0.9;
        }

        public override void GetInfo()
        {
            Console.WriteLine($"Product name: {Name}\nPrice: {Price}\nManufacturer: {Manufacturer}\nShelf life: {ShelfLife.ToShortDateString()}\n");
        }
    }
}
