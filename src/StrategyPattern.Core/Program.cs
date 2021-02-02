using System;
using StrategyPattern.Core.Models;


namespace StrategyPattern.Core
{
    class Program
    {
        static void Main(string[] args)
        {
	    ICustomer customer = new Customer(PrefferedCustomerType.Diamond);
	    var originalPrice = 54.3F;
	    var newPrice = customer.GetPriceModifier() * originalPrice;

            Console.WriteLine($"Price is: {newPrice}");
        }
    }
}
