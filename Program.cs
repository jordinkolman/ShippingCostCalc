using System;

namespace ShippingCostCalc
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Shipping cost is based on total cost.");
            Console.WriteLine("$100 or more is free.");
            Console.WriteLine("$50 to $99.99: $5 shipping.");
            Console.WriteLine("$30 to $49.99: $10 shipping.");
            Console.WriteLine("Up to $29.99: $20 flat shipping rate");
            Console.Write("\nEnter the total cost of your order: ");
            double totalCost = Convert.ToDouble(Console.ReadLine());
            if (totalCost >= 100)
                Console.WriteLine("You get free shipping!");
            else if (totalCost >= 50.0 && totalCost > 100.0)
                Console.WriteLine("You get a flat shipping rate of $5.00");
            else if (totalCost >= 30.0 && totalCost < 50.0)
                Console.WriteLine("You get a flat shipping rate of $10.00");
            else
                Console.WriteLine("You get a flat shipping rate of $20.00");

        }
    }
}