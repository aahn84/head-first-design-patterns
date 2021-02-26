using System;
using System.Collections.Generic;
using System.Text;

namespace app.HeadFirstDesignPatterns.CommandPattern.Commands.Lights
{
    public class GarageDoor
    {
        private readonly string _location;

        public GarageDoor(string location = "")
        {
            _location = location;
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