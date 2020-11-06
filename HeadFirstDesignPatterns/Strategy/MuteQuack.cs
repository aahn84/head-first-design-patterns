using System;
using System.Collections.Generic;
using System.Text;
using app.Strategy.Duck.Behaviors;

namespace app.HeadFirstDesignPatterns.Strategy
{
    public class MuteQuack : IQuackBehavior
    {
        public void Quacking()
        {
            Console.WriteLine("<<Silence>>");
        }
    }
}
