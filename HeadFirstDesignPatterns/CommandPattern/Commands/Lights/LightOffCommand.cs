﻿using System;
using System.Collections.Generic;
using System.Text;

namespace app.HeadFirstDesignPatterns.CommandPattern.Commands.Lights
{
    public class LightOffCommand : ICommand
    {
        private readonly Light _light;

        public LightOffCommand(Light light)
        {
            _light = light;
        }

        public void Execute()
        {
            _light.Off();
        }
    }
}