using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace app.HeadFirstDesignPatterns.FactoryPattern
{
    public class CaliforniaPizzaStore : PizzaStore
    {
        protected override Pizza CreatePizza(string item)
        {
            if (item.Equals("cheese"))
            {
                return new CaliforniaStyleCheesePizza();
            }
            //else if (item.Equals("veggie"))
            //{
            //    return new CaliforniaStyleVeggiePizza();
            //}
            //else if (item.Equals("clam"))
            //{
            //    return new CaliforniaStyleClamPizza();
            //}
            //else if (item.Equals("pepperoni"))
            //{
            //    return new CaliforniaStylePepperoniPizza();
            //}
            else return null;
        }
    }
}