using System;
using System.Collections.Generic;

namespace tuples
{
    class Program
    {
        static void Main(string[] args)
        {
            List<(string product, double amount, int quantity)> transactions = new List<(string, double, int)>();
            transactions.Add(("Hammer", 19.99, 4));
            transactions.Add(("Nails", 0.50, 1000));
            transactions.Add(("Screwdriver", 5.99, 12));
            transactions.Add(("Drill", 199.99, 2));
            transactions.Add(("Saw", 9.99, 1));
            transactions.Add(("Screw", 0.75, 500));

            int quant = 0;
            double amt = 0;
            double revenue = 0;


            foreach ((string product, double amount, int quantity) t in transactions)
            {
                quant = t.quantity + quant;
                amt = amt + t.amount;
                revenue = t.quantity * t.amount + revenue;
            }
            
             Console.WriteLine($"Total Items Sold {quant}, totalling {revenue}");
             Console.WriteLine("Hello World!");
        }
    }
}
