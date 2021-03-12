using System;
using System.Collections.Generic;
using System.Text;
using app.HeadFirstDesignPatterns.StrategyPattern;

namespace app.HeadFirstDesignPatterns.AdapterPattern
{
    public static class DuckAdapterTestDrive
    {
        public static void Run()
        {
            var duck = new MallardDuck();
            var turkey = new WildTurkey();
            IDuck turkeyAdapter = new TurkeyAdapter(turkey);

            Console.WriteLine();
            Console.WriteLine("The Turkey says...");
            turkey.Gobble();
            turkey.Fly();

            Console.WriteLine();
            Console.WriteLine("The Duck says...");
            TestDuck(duck);

            Console.WriteLine();
            Console.WriteLine("The TurkeyAdapter says...");
            TestDuck(turkeyAdapter);
        }

        private static void TestDuck(IDuck duck)
        {
            duck.Quack();
            duck.Fly();
        }
    }
}