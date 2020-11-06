using System;
using System.Collections.Generic;
using System.Text;

namespace app.Strategy.Duck.Behaviors
{
    public class Quack : QuackBehavior
    {
        public void Quacking()
        {
            Console.WriteLine("Quack");
        }
    }
}
