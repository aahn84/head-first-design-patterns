using System;

namespace app.HeadFirstDesignPatterns.StatePattern.GumballMachineWithState
{
    public class NoQuarterState : IState
    {
        private readonly GumballMachineWithState _gumballMachine;

        public NoQuarterState(GumballMachineWithState gumballMachine)
        {
            _gumballMachine = gumballMachine;
        }

        public void InsertQuarter()
        {
            Console.WriteLine("You inserted a quarter");
            _gumballMachine.SetState(_gumballMachine.GetHasQuarterState());
        }

        public void EjectQuarter()
        {
            Console.WriteLine("You haven't inserted a quarter");
        }

        public void TurnCrank()
        {
            Console.WriteLine("You turned, but there's no quarter");
        }

        public void Dispense()
        {
            Console.WriteLine("You need to pay first");
        }

        public void Refill()
        {
            throw new NotImplementedException();
        }
    }
}