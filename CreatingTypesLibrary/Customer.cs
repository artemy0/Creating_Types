using System;

namespace CreatingTypesLibrary
{
    public class Customer
    {
        public string Name { get; set; }
        public string Adress { get; set; }
        public double Balance { get; set; }
        public double Spent { get; set; } //the amount of money spent in our shop.

        public Customer(string name, string adress, double balance)
        {
            Name = name;
            Adress = adress;
            Balance = balance;
            Spent = 0;
        }

        public void GetInfo()
        {
            Console.WriteLine($"\nCustomer name: {Name}\nAdress: {Adress}\nBalance: {Balance:C2}, money spent: {Spent:C2}\n");
        }

        public static Customer CreateCustomerManually()
        {
            Console.Write("\nSelect name: ");
            string name = Console.ReadLine();
            Console.Write("Select addres: ");
            string addres = Console.ReadLine();
            return new Customer(name, addres, 0.0);
        }
    }
}
