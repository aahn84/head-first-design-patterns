using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace app.HeadFirstDesignPatterns.CommandPattern.Commands.CeilingFans
{
    public class CeilingFan
    {
        public static int HIGH = 3;
        public static int MEDIUM = 2;
        public static int LOW = 1;
        public static int OFF = 0;

        private IDictionary<string, int> FAN_SPEED = new Dictionary<string, int>
        {
            {"High", 3},
            {"Medium", 2},
            {"Low", 1},
            {"Off", 0},
        };

        private readonly string _location;
        private int _speed;

        public CeilingFan(string location = "")
        {
            _location = location;
            _speed = FAN_SPEED["Off"];
        }

        public void On()
        {
            var fanSpeed = FAN_SPEED.FirstOrDefault(s => s.Value == _speed).Key;
            Console.Write($"{_location} Ceiling Fan is set to {fanSpeed}");
        }

        public void Off()
        {
            _speed = FAN_SPEED["Off"];
        }

        public int GetSpeed()
        {
            return _speed;
        }

        public void High()
        {
            _speed = FAN_SPEED["High"];
        }

        public void Medium()
        {
            _speed = FAN_SPEED["Medium"];
        }

        public void Low()
        {
            _speed = FAN_SPEED["Low"];
        }
    }
}