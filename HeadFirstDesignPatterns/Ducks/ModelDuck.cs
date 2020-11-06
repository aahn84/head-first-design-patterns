using System;
using System.Collections.Generic;
using System.Text;
using app.Strategy.Duck.Behaviors;

namespace app.Strategy.Duck.Ducks
{
  public class ModelDuck : Duck
    {
        public ModelDuck()
        {
            flyBehavior = new FlyNoWWay();
            quackBehavior = new Quack();
        }

        public override void Display()
        {
            Console.WriteLine("I'm a model duck");
        }
    }
}
