using System;
using System.Collections.Generic;
using System.Text;

namespace app.Strategy.Ducks.Behaviors
{
    public class FlyWithWings : FlyBehavior
    {
        public void fly()
        {
            Console.WriteLine("I'm flying!");
        }
    }
}
