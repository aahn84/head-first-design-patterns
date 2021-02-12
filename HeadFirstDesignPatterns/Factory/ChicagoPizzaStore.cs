using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace app.HeadFirstDesignPatterns.Decorator
{
    public class ChicagoPizzaStore : PizzaStore
    {
        protected override Pizza CreatePizza(string item)
        {
            if (item.Equals("cheese"))
            {
                return new ChicagoStyleCheesePizza();
            }
            //else if (item.Equals("veggie"))
            //{
            //    return new ChicagoStyleVeggiePizza();
            //}
            //else if (item.Equals("clam"))
            //{
            //    return new ChicagoStyleClamPizza();
            //}
            //else if (item.Equals("pepperoni"))
            //{
            //    return new ChicagoStylePepperoniPizza();
            //}
            else return null;
        }
    }
}