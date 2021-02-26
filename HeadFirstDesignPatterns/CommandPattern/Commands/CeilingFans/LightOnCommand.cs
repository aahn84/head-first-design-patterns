using System;
using System.Collections.Generic;
using System.Text;

namespace app.HeadFirstDesignPatterns.CommandPattern.Commands.CeilingFans
{
    public class CeilingFanOnCommand : ICommand
    {
        private readonly CeilingFan _ceilingFan;

        public CeilingFanOnCommand(CeilingFan ceilingFan)
        {
            _ceilingFan = ceilingFan;
        }

        public void Execute()
        {
            _ceilingFan.On();
        }
    }
}