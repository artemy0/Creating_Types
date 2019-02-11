using System;
using CreatingTypesLibrary;

namespace CreatingTypes
{
    class Shop
    {
        public string Name { get; private set; }

        //Storage of arrays of users and products.
        Product[] products;
        Customer[] customers;

        public Shop(string name, Customer[] customers, Product[] products)
        {
            Name = name;
            this.products = products;
            this.customers = customers;
        }

        //Displays all values of users or products.
        public void GetAllProducts()
        {

            ConsoleColor consoleColor = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine();

            foreach (Product item in products)
                item.GetInfo();

            Console.ForegroundColor = consoleColor;
        }
        public void GetAllCustomers()
        {
            ConsoleColor consoleColor = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine();
            foreach (Customer item in customers)
                item.GetInfo();
            Console.ForegroundColor = consoleColor;
        }

        //Getting a user or product object.
        public Product GetProduct(int index)
        {
            if (index >= 0 && index < products.Length)
                return products[index];
            else
            {
                Console.WriteLine("There are no product with this index.\n");
                return null;
            }
        }
        public Customer GetCustomer(int index)
        {
            if (index >= 0 && index < customers.Length)
                return customers[index];
            else
            {
                Console.WriteLine("There are no customer with this index.\n");
                return null;
            }
        }

        //method to add a new user
        public void AddCustomer(Customer customer)
        {
            Customer[] temp = new Customer[customers.Length + 1];
            for (int i = 0; i < customers.Length; i++)
                temp[i] = customers[i];
            temp[customers.Length] = customer;
            customers = temp;
        }
    }
}
