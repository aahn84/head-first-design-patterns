﻿using System;
using System.Collections.Generic;
using System.Text;

namespace app.HeadFirstDesignPatterns.Strategy
{
    public class FlyNoWWay : IFlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("I can't fly");
        }
    }
}
