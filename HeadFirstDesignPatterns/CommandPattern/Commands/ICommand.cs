using System;
using System.Collections.Generic;
using System.Text;

namespace app.HeadFirstDesignPatterns.CommandPattern.Commands
{
    public interface ICommand
    {
        public void Execute();

        public void Undo();
    }
}