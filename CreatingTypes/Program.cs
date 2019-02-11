﻿using System;
using CreatingTypesLibrary;

namespace CreatingTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creating a store, filling it with users and products.
            Customer[] customers = new Customer[] { new Customer("Artem", "100 Victoria St", 0.0), new Customer("Gleb", "115 Buckingham Palace Rd", 1000), new Customer("Bil", "51 Piccadilly", 500) };
            Product[] products = new Product[] { new Product("bread", 4.5, "Belarus"), new Product("milk", 3, "Belarus"), new Product("butter", 8, "Ukraine"), new Product("meat", 18, "Russia") };
            Shop shop = new Shop("Almi", customers, products);

            Console.WriteLine($"Welcome to the {shop.Name} shop.");
            //Boolean variables to exit the loop
            bool continueIteration;
            do
            {
                continueIteration = true;
                Customer customer = null;
                do
                {
                    Console.Write("1.Sign in to your account.\n2.Create an account.\n3.End the program.\nSelect option: ");
                    //use TryParse to avoid errors
                    int.TryParse(Console.ReadLine(), out int choose);
                    //I could use the enum keyword
                    switch (choose)
                    {
                        case 1:
                            shop.GetAllCustomers();
                            Console.Write("Select customers index: ");
                            customer = shop.GetCustomer(Convert.ToInt32(Console.ReadLine()));
                            if (customer != null)
                                continueIteration = false;
                            break;
                        case 2:
                            Console.Write("\nSelect name: ");
                            string name = Console.ReadLine();
                            Console.Write("Select addres: ");
                            string addres = Console.ReadLine();
                            customer = new Customer(name, addres, 0.0);
                            shop.AddCustomer(customer);
                            if (customer != null)
                                continueIteration = false;
                            break;
                        case 3:
                            return;
                        default:
                            Console.WriteLine("You entered an invalid value. Try again.\n");
                            break;
                    }
                } while (continueIteration);

                Console.Clear();

                continueIteration = true;
                do
                {
                    Console.Write("\n1.Top up the balance.\n2.Purchase product.\n3.Get account information.\n4.Log out.\nSelect option: ");
                    int.TryParse(Console.ReadLine(), out int choose);
                    //I could use the enum keyword
                    switch (choose)
                    {
                        case 1:
                            Console.Write("Enter how much money you want to add: ");
                            customer.AdjunctionBalance(Convert.ToDouble(Console.ReadLine()));
                            break;
                        case 2:
                            shop.GetAllProducts();
                            Console.Write("Select product index: ");
                            Product product = shop.GetProduct(Convert.ToInt32(Console.ReadLine()));
                            customer.Buy(product);
                            break;
                        case 3:
                            customer.GetInfo();
                            break;
                        case 4:
                            continueIteration = false;
                            break;
                        default:
                            Console.WriteLine("You entered an invalid value. Try again.");
                            break;
                    }
                } while (continueIteration);

                Console.Clear();
            } while (true);
        }
    }
}
