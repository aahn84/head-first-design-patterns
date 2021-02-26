using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Text;
using app.HeadFirstDesignPatterns.ObserverPattern;

namespace app.HeadFirstDesignPatterns.FactoryPattern
{
    public static class PizzaTestDrive
    {
        public static void Run()
        {
            PizzaStore nyStore = new NYPizzaStore();
            PizzaStore chicagoStore = new ChicagoPizzaStore();

            var pizza = nyStore.OrderPizza("cheese");
            Console.WriteLine("Ethan ordered a " + pizza.GetName() + "\n");

            pizza = chicagoStore.OrderPizza("cheese");
            Console.WriteLine("Joel ordered a " + pizza.GetName() + "\n");
        }
    }
}