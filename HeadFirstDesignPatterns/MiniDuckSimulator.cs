using System;
using app.Strategy.Duck.Behaviors;
using app.Strategy.Duck.Ducks;

namespace HeadFirstDesignPatterns
{
    class MiniDuckSimulator
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World...This is my MiniDuckSimulator!");

            Duck mallard = new MallardDuck();
            mallard.PerformQuack();
            mallard.PerformFly();

            Duck model = new ModelDuck();
            model.PerformFly();
            model.SetFlyBehavior(new FlyRocketPowered());
            model.PerformFly();
        }
    }
}
