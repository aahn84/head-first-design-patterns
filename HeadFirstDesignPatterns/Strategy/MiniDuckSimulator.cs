using System;
using app.HeadFirstDesignPatterns.Strategy;

namespace HeadFirstDesignPatterns.Strategy
{
    public static class MiniDuckSimulator
    {
        public static void Run()
        {
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
