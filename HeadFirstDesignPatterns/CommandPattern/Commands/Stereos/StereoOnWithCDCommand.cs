using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using app.HeadFirstDesignPatterns.CommandPattern.Commands.Lights;

namespace app.HeadFirstDesignPatterns.CommandPattern.Commands.Stereos
{
    public class StereoOnWithCDCommand : ICommand
    {
        private readonly Stereo _stereo;

        public StereoOnWithCDCommand(Stereo stereo)
        {
            _stereo = stereo;
        }

        public void Execute()
        {
            _stereo.On();
            Console.WriteLine();
            _stereo.SetCD();
            Console.WriteLine();
            _stereo.SetVolume(11);
        }
    }
}