﻿using System;
using app.HeadFirstDesignPatterns.AdapterPattern;
using app.HeadFirstDesignPatterns.CommandPattern;
using app.HeadFirstDesignPatterns.DecoratorPattern;
using app.HeadFirstDesignPatterns.FactoryPattern;
using app.HeadFirstDesignPatterns.IteratorAndCompositePattern;
using app.HeadFirstDesignPatterns.IteratorAndCompositePattern.Composite;
using app.HeadFirstDesignPatterns.ObserverPattern;
using app.HeadFirstDesignPatterns.SingletonPattern;
using app.HeadFirstDesignPatterns.StatePattern.GumballMachine;
using app.HeadFirstDesignPatterns.StatePattern.GumballMachineWithState;
using app.HeadFirstDesignPatterns.TemplateMethodPattern.Barista;
using app.HeadFirstDesignPatterns.TemplateMethodPattern.BaristaWithHook;
using app.HeadFirstDesignPatterns.TemplateMethodPattern.DuckSort;
using HeadFirstDesignPatterns.Strategy;

namespace app.HeadFirstDesignPatterns
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //Chapter 1 - Strategy
            //Console.WriteLine("********** CH.1 - STRATEGY **********");
            //Console.WriteLine("// MINI DUCK SIMULATOR //");
            //MiniDuckSimulator.Run();
            //Console.WriteLine();

            //Chapter 2 - Observer
            //Console.WriteLine("********** CH.2 - OBSERVER **********");
            //Console.WriteLine();
            //Console.WriteLine("// WEATHER STATION //");
            //WeatherStation.Run();
            //Console.WriteLine();

            //Chapter 3 - Decorator
            //Console.WriteLine("********** CH.3 - DECORATOR **********");
            //Console.WriteLine();
            //Console.WriteLine("// STARBUZZ //");
            //StarbuzzCoffee.Run();
            //Console.WriteLine();

            //Console.WriteLine();
            //Console.WriteLine("// IO //");
            //InputTest.Run();
            //Console.WriteLine();

            //Chapter 4 - Factory
            //Console.WriteLine("********** CH.4 - FACTORY **********");
            //Console.WriteLine();
            //Console.WriteLine("// PIZZA TEST DRIVE //");
            //PizzaTestDrive.Run();
            //Console.WriteLine();

            //Chapter 5 - Singleton
            //Console.WriteLine("********** CH.5 - SINGLETON **********");
            //Console.WriteLine();
            //Console.WriteLine("// CHOCOLATE FACTORY //");
            //ChocolateFactory.Run();
            //Console.WriteLine();

            //Chapter 6 - Command
            //Console.WriteLine("********** CH.6 - COMMAND **********");
            //Console.WriteLine();
            //Console.WriteLine("// SIMPLE REMOTE //");
            //SimpleRemoteControlTest.Run();
            //Console.WriteLine();
            //Console.WriteLine();
            //Console.WriteLine("// REMOTE LOADER //");
            //RemoteLoader.Run();
            //Console.WriteLine();
            //Console.WriteLine();
            //Console.WriteLine("// REMOTE LOADER WITH UNDO //");
            //RemoteLoaderWithUndo.Run();
            //Console.WriteLine();

            //Chapter 7 - Adapter & Facade
            //Console.WriteLine("********** CH.7 - ADAPTER & FACADE **********");
            //Console.WriteLine();
            //Console.WriteLine("// DUCK ADAPTER //");
            //DuckAdapterTestDrive.Run();
            //Console.WriteLine();

            //Chapter 8 - Template Method
            //Console.WriteLine("********** CH.8 - TEMPLATE METHOD **********");
            //Console.WriteLine();
            //Console.WriteLine("// BARISTA //");
            //BeverageTestDrive.Run();
            //Console.WriteLine();
            //Console.WriteLine();
            //Console.WriteLine("// BARISTA WITH HOOK //");
            //BeverageTestDriveWithHook.Run();
            //Console.WriteLine();
            //Console.WriteLine();
            //Console.WriteLine("// DUCK SORT //");
            //DuckSortTestDrive.Run();
            //Console.WriteLine();

            //Chapter 9 - Iterator & Composite
            //Console.WriteLine("********** CH.9 - ITERATOR & COMPOSITE **********");
            //Console.WriteLine();
            //Console.WriteLine("*** ITERATOR ***");
            //Console.WriteLine();
            //Console.WriteLine("// DINER MENU //");
            //DinerMenuTestDrive.Run();
            //Console.WriteLine();
            //Console.WriteLine("*** COMPOSITE ***");
            //MenuTestDrive.Run();
            //Console.WriteLine();

            //Chapter 10 - State
            Console.WriteLine("********** CH.10 - STATE **********");
            Console.WriteLine();
            Console.WriteLine("// GUMBALL MACHINE //");
            GumballMachineTestDrive.Run();
            Console.WriteLine();
            Console.WriteLine("// GUMBALL MACHINE WITH STATE //");
            GumballMachineWithStateTestDrive.Run();
            Console.WriteLine();
        }
    }
}