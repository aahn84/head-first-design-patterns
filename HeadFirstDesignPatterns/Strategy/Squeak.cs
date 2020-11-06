using System;
using System.Collections.Generic;
using System.Text;

namespace app.HeadFirstDesignPatterns.Strategy
{
    public class Squeak : QuackBehavior
    {
        public void Quacking()
        {
            Console.WriteLine("Squeak");
        }
    }
}
