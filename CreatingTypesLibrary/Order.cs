using System;

namespace CreatingTypesLibrary
{
    public static class Order
    {
        //The use of extension method
        public static void Buy(this Customer customer, Product product)
        {
            if (customer.Balance>=product.Price)
            {
                double priceWithDiscount = product.GetDiscountPrice(customer);
                double discount = product.Price / priceWithDiscount - 1;
                customer.Balance -= priceWithDiscount;
                customer.Spent += priceWithDiscount;

                ConsoleColor consoleColor = Console.ForegroundColor;
                Console.ForegroundColor = ConsoleColor.Green;

                Console.WriteLine($"Customer {customer.Name} bought {product.Name} made in {product.Manufacturer} for {priceWithDiscount:C2} and discount = {discount:P2}.\nProduct({product.Name}) sent to the address {customer.Adress}");

                Console.ForegroundColor = consoleColor;
            }
            else
            {
                ConsoleColor consoleColor = Console.ForegroundColor;
                Console.ForegroundColor = ConsoleColor.Green;

                Console.WriteLine($"There is not enough funds on the {customer.Name}'s balance.");

                Console.ForegroundColor = consoleColor;
            }
        }

        public static void AdjunctionBalance(this Customer customer, double balance)
        {
            customer.Balance += balance;
            Console.WriteLine($"{customer.Name}'s balance replenished by {balance:C2}");
        }
    }
}
