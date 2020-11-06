using System;
using HeadFirstDesignPatterns.Strategy;


namespace app.HeadFirstDesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            MiniDuckSimulator.Run();
        }
    }
}

//namespace HeadFirstDesignPatterns
//{
//    class MiniDuckSimulator
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Hello World...This is my MiniDuckSimulator!");

//            Duck mallard = new MallardDuck();
//            mallard.PerformQuack();
//            mallard.PerformFly();

//            Duck model = new ModelDuck();
//            model.PerformFly();
//            model.SetFlyBehavior(new FlyRocketPowered());
//            model.PerformFly();
//        }
//    }
//}
