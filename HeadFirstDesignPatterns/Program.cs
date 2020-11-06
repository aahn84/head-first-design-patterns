using System;
using app.Strategy.Duck.Ducks;

namespace HeadFirstDesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World...This is my MiniDucks app!");

            Duck mallard = new MallardDuck();
            mallard.performQuack();
            mallard.performFly();
        }
    }
}
