using System;
using System.Collections.Generic;
using System.Text;

namespace app.HeadFirstDesignPatterns.CommandPattern.Commands.Stereos
{
    public class Stereo
    {
        private readonly string _name;

        public Stereo(string name = "")
        {
            _name = name;
        }

        public void On()
        {
            Console.Write($"{_name} Stereo is On");
        }

        public void Off()
        {
            Console.Write($"{_name} Stereo is Off");
        }

        public void SetCD()
        {
            Console.Write($"{_name} Stereo is set for CD input");
        }

        public void SetDVD()
        {
            Console.Write($"{_name} Stereo is set for DVD input");
        }

        public void SetRadio()
        {
            Console.Write($"{_name} Stereo is set for Radio input");
        }

        public void SetVolume(int level)
        {
            Console.Write($"{_name} Stereo volume set to {level}");
        }
    }
}