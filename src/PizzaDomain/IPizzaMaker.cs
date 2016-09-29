using System.Collections.Generic;

namespace PizzaDomain
{
    public interface IPizzaMaker
    {
        void TakeOrder(Size size, List<string> toppings);
    }
}
