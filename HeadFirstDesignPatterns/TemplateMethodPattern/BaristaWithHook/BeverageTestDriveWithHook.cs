using System;
using System.Collections.Generic;
using System.Text;

namespace app.HeadFirstDesignPatterns.TemplateMethodPattern.BaristaWithHook
{
    public class BeverageTestDriveWithHook
    {
        public static void Run()
        {
            var teaWithHook = new TeaWithHook();
            var coffeeWithHook = new CoffeeWithHook();

            Console.WriteLine();
            Console.WriteLine("Making tea...");
            teaWithHook.PrepareRecipe();

            Console.WriteLine();
            Console.WriteLine("Making coffee...");
            coffeeWithHook.PrepareRecipe();
        }
    }
}