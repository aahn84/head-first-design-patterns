using System;
using System.Collections.Generic;
using System.Text;

namespace app.HeadFirstDesignPatterns.CommandPattern.Commands.Lights
{
    public class Light
    {
        public Light()
        {
        }

        public void On()
        {
            Console.Write("Light is On");
        }

        public void Off()
        {
            Console.Write("Light is Off");
        }
    }
}