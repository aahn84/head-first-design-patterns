using System;
using app.HeadFirstDesignPatterns.DecoratorPattern;
using app.HeadFirstDesignPatterns.FactoryPattern;
using app.HeadFirstDesignPatterns.ObserverPattern;
using app.HeadFirstDesignPatterns.SingletonPattern;
using HeadFirstDesignPatterns.Strategy;

namespace app.HeadFirstDesignPatterns
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            // Chapter 1 - Strategy
            Console.WriteLine("********** CH.1 - STRATEGY **********");
            Console.WriteLine("// MINI DUCK SIMULATOR //");
            MiniDuckSimulator.Run();
            Console.WriteLine();

            //Chapter 2 - Observer
            Console.WriteLine("********** CH.2 - OBSERVER **********");
            Console.WriteLine();
            Console.WriteLine("// WEATHER STATION //");
            WeatherStation.Run();
            Console.WriteLine();

            //Chapter 3 - Decorator
            Console.WriteLine("********** CH.3 - DECORATOR **********");
            Console.WriteLine();
            Console.WriteLine("// STARBUZZ //");
            StarbuzzCoffee.Run();
            Console.WriteLine();

            //Console.WriteLine();
            //Console.WriteLine("// IO //");
            //InputTest.Run();
            //Console.WriteLine();

            //Chapter 4 - Factory
            Console.WriteLine("********** CH.4 - FACTORY **********");
            Console.WriteLine();
            Console.WriteLine("// PIZZA TEST DRIVE //");
            PizzaTestDrive.Run();
            Console.WriteLine();

            //Chapter 5 - Singleton
            Console.WriteLine("********** CH.5 - SINGLETON **********");
            Console.WriteLine();
            Console.WriteLine("// CHOCOLATE FACTORY //");
            ChocolateFactory.Run();
            Console.WriteLine();
        }
    }
}