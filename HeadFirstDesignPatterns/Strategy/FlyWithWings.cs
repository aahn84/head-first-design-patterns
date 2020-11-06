using System;
using System.Collections.Generic;
using System.Text;

namespace app.HeadFirstDesignPatterns.Strategy
{
    public class FlyWithWings : IFlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("I'm flying!");
        }
    }
}
