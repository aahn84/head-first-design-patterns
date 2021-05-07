using System;

namespace app.HeadFirstDesignPatterns.StatePattern.GumballMachineWithState
{
    public class SoldOutState : IState
    {
        private readonly GumballMachineWithState _gumballMachine;

        public SoldOutState(GumballMachineWithState gumballMachine)
        {
            _gumballMachine = gumballMachine;
        }

        public void InsertQuarter()
        {
            Console.WriteLine("You cannot insert a quarter, the machine is sold out");
        }

        public void EjectQuarter()
        {
            Console.WriteLine("You cannot eject, you haven't inserted a quarter yet");
        }

        public void TurnCrank()
        {
            Console.WriteLine("You turned, but there are no gumballs");
        }

        public void Dispense()
        {
            Console.WriteLine("No gumball dispensed");
        }

        public void Refill()
        {
            _gumballMachine.SetState(_gumballMachine.GetNoQuarterState());
        }
    }
}