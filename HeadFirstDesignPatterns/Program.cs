using System;
using app.HeadFirstDesignPatterns.Decorator;
using app.HeadFirstDesignPatterns.Observer;
using HeadFirstDesignPatterns.Strategy;


namespace app.HeadFirstDesignPatterns
{
    class Program
    {
        static void Main(string[] args)
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
        }
    }
}
