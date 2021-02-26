﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using app.HeadFirstDesignPatterns.CommandPattern.Commands;

namespace app.HeadFirstDesignPatterns.CommandPattern
{
    public class SimpleRemoteControl
    {
        private ICommand _slot;

        public SimpleRemoteControl()
        {
        }

        public void SetCommand(ICommand command)
        {
            _slot = command;
        }

        public void ButtonWasPressed()
        {
            _slot.Execute();
        }
    }
}