using System;
using System.Collections.Generic;
using System.Text;
using app.HeadFirstDesignPatterns.Observer;

namespace app.HeadFirstDesignPatterns.Decorator
{
    public static class StarbuzzCoffee
    {
        public static void Run()
        {
            Beverage beverage = new Espresso();
            Console.WriteLine(beverage.GetDescription() + " $" + beverage.Cost());

            Beverage beverage2 = new DarkRoast();
            beverage2 = new Mocha(beverage2);
            beverage2 = new Mocha(beverage2);
            beverage2 = new Whip(beverage2);
            Console.WriteLine(beverage2.GetDescription() + " $" + beverage2.Cost());

            Beverage beverage3 = new HouseBlend();
            beverage3 = new Soy(beverage3);
            beverage3 = new Mocha(beverage3);
            beverage3 = new Whip(beverage3);
            Console.WriteLine(beverage3.GetDescription() + " $" + beverage3.Cost());

            Beverage beverage4 = new Decaf();
            beverage4 = new SteamedMilk(beverage4);
            Console.WriteLine(beverage4.GetDescription() + " $" + beverage4.Cost());
        }
    }
}
