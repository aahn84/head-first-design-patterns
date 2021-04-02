using System;
using System.Collections.Generic;
using System.Text;

namespace app.HeadFirstDesignPatterns.TemplateMethodPattern.Barista
{
    public class BeverageTestDrive
    {
        public static void Run()
        {
            var tea = new Tea();
            var coffee = new Coffee();

            Console.WriteLine();
            Console.WriteLine("Making tea...");
            tea.PrepareRecipe();

            Console.WriteLine();
            Console.WriteLine("Making coffee...");
            coffee.PrepareRecipe();
        }
    }
}