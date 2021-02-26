using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using app.HeadFirstDesignPatterns.CommandPattern.Commands.Lights;

namespace app.HeadFirstDesignPatterns.CommandPattern.Commands.Stereos
{
    public class StereoOffCommand : ICommand
    {
        private readonly Stereo _stereo;

        public StereoOffCommand(Stereo stereo)
        {
            _stereo = stereo;
        }

        public void Execute()
        {
            _stereo.Off();
        }
    }
}