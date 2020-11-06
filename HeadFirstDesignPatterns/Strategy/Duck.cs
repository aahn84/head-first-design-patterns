using System;
using System.Collections.Generic;
using System.Text;

namespace app.HeadFirstDesignPatterns.Strategy
{
  public abstract class Duck
    {
        public FlyBehavior flyBehavior;
        public QuackBehavior quackBehavior;

        protected Duck() { }

        public void SetFlyBehavior(FlyBehavior fb)
        {
            flyBehavior = fb;
        }

        public void SetQuackBehavior(QuackBehavior qb)
        {
            quackBehavior = qb;
        }

        public abstract void Display();

        public void PerformFly()
        {
            flyBehavior.Fly();
        }

        public void PerformQuack()
        {
            quackBehavior.Quacking();
        }

        public void Swim()
        {
            Console.WriteLine("All ducks float, even decoys!");
        }
    }
}
