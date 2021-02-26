using System;
using System.Collections.Generic;
using System.Text;

namespace app.HeadFirstDesignPatterns.CommandPattern.Commands.Lights
{
    public class Light
    {
        private readonly string _location;

        public Light(string location = "")
        {
            _location = location;
        }

        public void On()
        {
            Console.Write($"{_location} Light is On");
        }

        public void Off()
        {
            Console.Write($"{_location} Light is Off");
        }
    }
}