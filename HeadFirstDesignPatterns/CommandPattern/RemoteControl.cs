using System;
using System.Collections.Generic;
using System.Text;
using app.HeadFirstDesignPatterns.CommandPattern.Commands;

namespace app.HeadFirstDesignPatterns.CommandPattern
{
    public class RemoteControl
    {
        private readonly ICommand[] _onCommands;
        private readonly ICommand[] _offCommands;

        public RemoteControl()
        {
            _onCommands = new ICommand[7];
            _offCommands = new ICommand[7];

            ICommand noCommand = new NoCommand();
            for (var i = 0; i < 7; i++)
            {
                _onCommands[i] = noCommand;
                _offCommands[i] = noCommand;
            }
        }

        public void SetCommand(int slot, ICommand onCommand, ICommand offCommand)
        {
            _onCommands[slot] = onCommand;
            _offCommands[slot] = offCommand;
        }

        public void OnButtonWasPushed(int slot)
        {
            _onCommands[slot].Execute();
        }

        public void OffButtonWasPushed(int slot)
        {
            _offCommands[slot].Execute();
        }

        public override String ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine("\n------ Remote Control ------\n");
            for (var i = 0; i < _onCommands.Length; i++)
            {
                stringBuilder.AppendLine("[slot " + i + "] " + _onCommands[i].GetType().Name + "     " + _offCommands[i].GetType().Name + "\n");
            }

            return stringBuilder.ToString();
        }
    }
}