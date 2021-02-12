using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace app.HeadFirstDesignPatterns.Decorator
{
    public class CaliforniaStyleCheesePizza : Pizza
    {
        public CaliforniaStyleCheesePizza()
        {
            Name = "California Style Healthy Pizza";
            Dough = "Extra Thin Crust Dough";
            Sauce = "Organic Heirloom Tomato Sauce";

            Toppings.Add("Vegan Mozzarella Cheese");
        }

        public void Cut()
        {
            Console.WriteLine("Cutting the pizza into square slices");
        }
    }
}