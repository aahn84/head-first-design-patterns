using System;
using System.Collections.Generic;
using System.Text;

namespace app.HeadFirstDesignPatterns.CommandPattern.Commands.CeilingFans
{
    public class CeilingFanLowCommand : ICommand
    {
        private readonly CeilingFan _ceilingFan;
        private int _prevSpeed;

        public CeilingFanLowCommand(CeilingFan ceilingFan)
        {
            _ceilingFan = ceilingFan;
        }

        public void Execute()
        {
            _prevSpeed = _ceilingFan.GetSpeed();
            _ceilingFan.Low();
            _ceilingFan.On();
        }

        public void Undo()
        {
            if (_prevSpeed == CeilingFan.HIGH)
                _ceilingFan.High();
            if (_prevSpeed == CeilingFan.MEDIUM)
                _ceilingFan.Medium();
            if (_prevSpeed == CeilingFan.LOW)
                _ceilingFan.Low();
            if (_prevSpeed == CeilingFan.OFF)
                _ceilingFan.Off();
        }
    }
}