using System;
using System.Collections.Generic;
using System.Text;

namespace app.HeadFirstDesignPatterns.TemplateMethodPattern.BaristaWithHook
{
    public class TeaWithHook : CaffeineBeverageWithHook
    {
        protected override void Brew()
        {
            Console.WriteLine("Steeping the tea");
        }

        protected override void AddCondiments()
        {
            Console.WriteLine("Adding Lemon");
        }

        public override bool CustomerWantsCondiments()
        {
            var answer = GetUserInput();

            return answer.ToLower().StartsWith("y");
        }

        private string GetUserInput()
        {
            Console.WriteLine("Would you like lemon with your tea (y/n)?");

            var response = Console.ReadLine();

            return response ?? "no";
        }
    }
}