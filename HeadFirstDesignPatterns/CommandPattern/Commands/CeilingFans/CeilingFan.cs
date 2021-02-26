using System;
using System.Collections.Generic;
using System.Text;

namespace app.HeadFirstDesignPatterns.CommandPattern.Commands.CeilingFans
{
    public class CeilingFan
    {
        private readonly string _name;

        public CeilingFan(string name = "")
        {
            _name = name;
        }

        public void On()
        {
            Console.Write($"{_name} Ceiling Fan is On");
        }

        public void Off()
        {
            Console.Write($"{_name} Ceiling Fan is Off");
        }
    }
}