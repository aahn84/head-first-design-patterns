using System;
using System.Collections.Generic;
using System.Text;
using app.Strategy.Duck.Behaviors;

namespace app.Strategy.Duck.Ducks
{
  public abstract class Duck
    {
        public FlyBehavior flyBehavior;
        public QuackBehavior quackBehavior;

        public Duck() { }

        public abstract void display();

        public void performFly()
        {
            flyBehavior.fly();
        }

        public void performQuack()
        {
            quackBehavior.quack();
        }

        public void swim()
        {
            Console.WriteLine("All ducks float, even decoys!");
        }
    }
}
