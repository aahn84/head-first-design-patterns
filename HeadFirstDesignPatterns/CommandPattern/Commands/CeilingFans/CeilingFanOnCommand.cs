using System;
using System.Collections.Generic;
using System.Text;

namespace app.HeadFirstDesignPatterns.CommandPattern.Commands.CeilingFans
{
    public class CeilingFanOnCommand : ICommand
    {
        private int _prevSpeed;
        private readonly CeilingFan _ceilingFan;

        public CeilingFanOnCommand(CeilingFan ceilingFan)
        {
            _ceilingFan = ceilingFan;
        }

        public void Execute()
        {
            _prevSpeed = _ceilingFan.GetSpeed();
            _ceilingFan.On();
        }

        public void Undo()
        {
            _ceilingFan.Off();
        }
    }
}