using PizzaDomain;
using System;
using System.Collections.Generic;

namespace PizzaStore.PizzaMakers
{
    public class ZPizza : IPizzaMaker
    {
        public void TakeOrder(Size size, List<string> toppings)
        {
            // this would process some pizza order
            Console.WriteLine("Welcome to ZPizza.  Voted worst pizza in Raleigh by Eric!");
            Console.WriteLine($"Orderd a size {size} pizza with the following toppings: {string.Join(", ", toppings)}", size, toppings);
            Console.WriteLine("Your order will take a long time and will cost you all the money in your wallet.");
        }
    }
}
