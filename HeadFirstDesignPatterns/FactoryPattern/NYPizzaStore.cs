using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace app.HeadFirstDesignPatterns.FactoryPattern
{
    public class NYPizzaStore : PizzaStore
    {
        protected override Pizza CreatePizza(string item)
        {
            if (item.Equals("cheese"))
            {
                return new NYStyleCheesePizza();
            }
            //else if (item.Equals("veggie"))
            //{
            //    return new NYStyleVeggiePizza();
            //}
            //else if (item.Equals("clam"))
            //{
            //    return new NYStyleClamPizza();
            //}
            //else if (item.Equals("pepperoni"))
            //{
            //    return new NYStylePepperoniPizza();
            //}
            else return null;
        }
    }
}