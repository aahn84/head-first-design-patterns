using System;
using System.Collections.Generic;
using System.Text;

namespace app.Strategy.Ducks.Behaviors
{
    public class Quack : QuackBehavior
    {
        public void quack()
        {
            Console.WriteLine("Quack");
        }
    }
}
