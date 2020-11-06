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

        public void PerformFly()
        {
            flyBehavior.fly();
        }

        public void PerformQuack()
        {
            quackBehavior.quack();
        }

        public void Swim()
        {
            Console.WriteLine("All ducks float, even decoys!");
        }
    }
}
