using PizzaDomain;
using System;
using System.Collections.Generic;

namespace PizzaStore.PizzaMakers
{
    public class PapaGinos : IPizzaMaker
    {
        public void TakeOrder(Size size, List<string> toppings)
        {
            if(toppings.Count < 1)
            {
                throw new Exception("Pizza needs toppings!");
            }

            // this would process some pizza order
            Console.WriteLine("Welcome to Papa Gino's, voted the best pizza in New England!");
            Console.WriteLine($"Orderd a size {size} pizza with the following toppings: {string.Join(", ", toppings)}", size, toppings);
            Console.WriteLine("Order Complete!  Pickup in 10 minutes.");
        }
    }
}
