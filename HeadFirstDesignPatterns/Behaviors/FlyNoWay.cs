using System;
using System.Collections.Generic;
using System.Text;

namespace app.Strategy.Ducks.Behaviors
{
    public class FlyNoWWay : FlyBehavior
    {
        public void fly()
        {
            Console.WriteLine("I can't fly");
        }
    }
}
