using System;
using System.Collections.Generic;
using System.Text;

namespace app.HeadFirstDesignPatterns.CommandPattern.Commands.Stereos
{
    public class Stereo
    {
        private readonly string _location;

        public Stereo(string location = "")
        {
            _location = location;
        }

        public void On()
        {
            Console.Write($"{_location} Stereo is On");
        }

        public void Off()
        {
            Console.Write($"{_location} Stereo is Off");
        }

        public void SetCD()
        {
            Console.Write($"{_location} Stereo is set for CD input");
        }

        public void SetDVD()
        {
            Console.Write($"{_location} Stereo is set for DVD input");
        }

        public void SetRadio()
        {
            Console.Write($"{_location} Stereo is set for Radio input");
        }

        public void SetVolume(int level)
        {
            Console.Write($"{_location} Stereo volume set to {level}");
        }
    }
}