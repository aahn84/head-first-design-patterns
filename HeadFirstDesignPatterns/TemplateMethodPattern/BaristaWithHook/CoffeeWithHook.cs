using System;
using System.Collections.Generic;
using System.Text;

namespace app.HeadFirstDesignPatterns.TemplateMethodPattern.BaristaWithHook
{
    public class CoffeeWithHook : CaffeineBeverageWithHook
    {
        protected override void Brew()
        {
            Console.WriteLine("Dripping Coffee through filter");
        }

        protected override void AddCondiments()
        {
            Console.WriteLine("Adding Sugar and Milk");
        }

        public override bool CustomerWantsCondiments()
        {
            var answer = GetUserInput();

            return answer.ToLower().StartsWith("y");
        }

        private string GetUserInput()
        {
            Console.WriteLine("Would you like milk and sugar with your coffee (y/n)?");

            var response = Console.ReadLine();

            return response ?? "no";
        }
    }
}