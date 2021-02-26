﻿using System;
using System.Collections.Generic;
using System.Text;

namespace app.HeadFirstDesignPatterns.CommandPattern.Commands.Lights
{
    public class Light
    {
        private readonly string _name;

        public Light(string name = "")
        {
            _name = name;
        }

        public void On()
        {
            Console.Write($"{_name} Light is On");
        }

        public void Off()
        {
            Console.Write($"{_name} Light is Off");
        }
    }
}