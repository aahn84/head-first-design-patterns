﻿using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace app.HeadFirstDesignPatterns.FactoryPattern
{
    public abstract class Pizza
    {
        protected string Name;
        protected string Dough;
        protected string Sauce;
        protected List<string> Toppings = new List<string>();

        public void Prepare()
        {
            Console.WriteLine("Preparing " + Name);
            Console.WriteLine("Tossing dough...");
            Console.WriteLine("Adding sauce...");
            Console.WriteLine("Adding toppings: ");
            foreach (var topping in Toppings)
            {
                Console.WriteLine("   " + topping);
            }
        }

        public void Bake()
        {
            Console.WriteLine("Bake for 25 minutes at 350");
        }

        public void Cut()
        {
            Console.WriteLine("Cutting the pizza into diagonal slices");
        }

        public void Box()
        {
            Console.WriteLine("Place pizza in official PizzaStore box");
        }

        public string GetName()
        {
            return Name;
        }
    }
}