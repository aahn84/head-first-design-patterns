using System;
using System.Collections.Generic;
using System.Text;

namespace app.HeadFirstDesignPatterns.Strategy
{
    public class Quack : QuackBehavior
    {
        public void Quacking()
        {
            Console.WriteLine("Quack");
        }
    }
}
