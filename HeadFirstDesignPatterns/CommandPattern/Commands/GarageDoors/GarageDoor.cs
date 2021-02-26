using System;
using System.Collections.Generic;
using System.Text;

namespace app.HeadFirstDesignPatterns.CommandPattern.Commands.Lights
{
    public class GarageDoor
    {
        public GarageDoor()
        {
        }

        public void Open()
        {
            Console.Write("Garage Door is Open");
        }

        public void Close()
        {
            Console.Write("Garage Door is Closed");
        }
    }
}