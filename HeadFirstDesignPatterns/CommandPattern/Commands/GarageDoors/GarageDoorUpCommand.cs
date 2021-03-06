﻿using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using app.HeadFirstDesignPatterns.CommandPattern.Commands.Lights;

namespace app.HeadFirstDesignPatterns.CommandPattern.Commands.GarageDoors
{
    public class GarageDoorUpCommand : ICommand
    {
        private readonly GarageDoor _garageDoor;

        public GarageDoorUpCommand(GarageDoor garageDoor)
        {
            _garageDoor = garageDoor;
        }

        public void Execute()
        {
            _garageDoor.Open();
        }

        public void Undo()
        {
            _garageDoor.Close();
        }
    }
}