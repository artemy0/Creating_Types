using System;

namespace CreatingTypesLibrary
{
    public class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public string Manufacturer { get; set; }

        public Product(string name, double price, string manufacturer)
        {
            Name = name;
            Price = price;
            Manufacturer = manufacturer;
        }

        public virtual double GetDiscountPrice(Customer customer)
        {
            if (customer.Spent < 1000)
                return Price;
            if (customer.Spent < 3000)
                return Price * 0.95;
            return Price * 0.9;
        }

        public virtual void GetInfo()
        {
            Console.WriteLine($"Product name: {Name}\nPrice: {Price}\nManufacturer: {Manufacturer}\n");
        }
    }
}
