using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace app.HeadFirstDesignPatterns.Decorator
{
    public abstract class PizzaStore
    {
        public Pizza OrderPizza(string type)
        {
            Pizza Pizza;

            Pizza = CreatePizza(type);

            Pizza.Prepare();
            Pizza.Bake();
            Pizza.Cut();
            Pizza.Box();

            return Pizza;
        }

        protected abstract Pizza CreatePizza(string type);
    }
}