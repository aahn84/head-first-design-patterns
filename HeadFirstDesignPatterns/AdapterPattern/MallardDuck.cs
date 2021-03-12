using System;
using System.Collections.Generic;
using System.Text;
using app.HeadFirstDesignPatterns.AdapterPattern;

namespace app.HeadFirstDesignPatterns.AdapterPattern
{
    public class MallardDuck : IDuck
    {
        public void Quack()
        {
            Console.WriteLine("Quack");
        }

        public void Fly()
        {
            Console.WriteLine("I'm flying");
        }
    }
}