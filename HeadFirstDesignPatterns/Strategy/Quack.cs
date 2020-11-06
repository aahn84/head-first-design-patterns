using System;
using System.Collections.Generic;
using System.Text;
using app.Strategy.Duck.Behaviors;

namespace app.HeadFirstDesignPatterns.Strategy
{
    public class Quack : IQuackBehavior
    {
        public void Quacking()
        {
            Console.WriteLine("Quack");
        }
    }
}
