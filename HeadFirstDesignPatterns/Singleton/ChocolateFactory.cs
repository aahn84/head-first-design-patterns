﻿using System;
using System.Collections.Generic;
using System.Text;

namespace app.HeadFirstDesignPatterns.Singleton
{
    public class ChocolateFactory
    {
        public static void Run()
        {
            var chocolateBoiler = ChocolateBoiler.GetInstance();

            chocolateBoiler.Fill();
            chocolateBoiler.Boil();
            chocolateBoiler.Drain();
        }
    }
}