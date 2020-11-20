using System;
using app.HeadFirstDesignPatterns.Observer;
using HeadFirstDesignPatterns.Strategy;


namespace app.HeadFirstDesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            // Chapter 1 - Strategy
            Console.WriteLine("// MINI DUCK SIMULATOR //");
            MiniDuckSimulator.Run();
            Console.WriteLine();

            //Chapter 2 - Observer
            Console.WriteLine();
            Console.WriteLine("// WEATHER STATION //");
            WeatherStation.Run();
            Console.WriteLine();
        }
    }
}
