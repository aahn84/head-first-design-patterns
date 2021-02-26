using System;
using System.Collections.Generic;
using System.Text;
using app.HeadFirstDesignPatterns.CommandPattern.Commands;

namespace app.HeadFirstDesignPatterns.CommandPattern
{
    public class RemoteControlWithUndo
    {
        private ICommand[] _onCommands;
        private ICommand[] _offCommands;
        private ICommand _undoCommand;

        public RemoteControlWithUndo()
        {
            _onCommands = new ICommand[7];
            _offCommands = new ICommand[7];

            ICommand noCommand = new NoCommand();

            for (var i = 0; i < 7; i++)
            {
                _onCommands[i] = noCommand;
                _offCommands[i] = noCommand;
            }

            _undoCommand = noCommand;
        }

        public void SetCommand(int slot, ICommand onCommand, ICommand offCommand)
        {
            _onCommands[slot] = onCommand;
            _offCommands[slot] = offCommand;
        }

        public void OnButtonWasPushed(int slot)
        {
            _onCommands[slot].Execute();
            _undoCommand = _onCommands[slot];
        }

        public void OffButtonWasPushed(int slot)
        {
            _offCommands[slot].Execute();
            _undoCommand = _offCommands[slot];
        }

        public void UndoButtonWasPushed(int slot)
        {
            _undoCommand.Undo();
        }

        public override string ToString()
        {
            var stringBuilder = new StringBuilder();
            stringBuilder.AppendLine("\n------ Remote Control ------\n");
            for (var i = 0; i < _onCommands.Length; i++)
            {
                stringBuilder.AppendLine("[slot " + i + "] " + _onCommands[i].GetType().Name + "     " + _offCommands[i].GetType().Name + "\n");
            }

            return stringBuilder.ToString();
        }
    }
}