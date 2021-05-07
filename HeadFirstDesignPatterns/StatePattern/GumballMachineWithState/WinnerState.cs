using System;

namespace app.HeadFirstDesignPatterns.StatePattern.GumballMachineWithState
{
    public class WinnerState : IState
    {
        private readonly GumballMachineWithState _gumballMachine;

        public WinnerState(GumballMachineWithState gumballMachine)
        {
            _gumballMachine = gumballMachine;
        }

        public void InsertQuarter()
        {
            Console.WriteLine("Please wait, we're already giving you a gumball");
        }

        public void EjectQuarter()
        {
            Console.WriteLine("Sorry, you already turned the crank");
        }

        public void TurnCrank()
        {
            Console.WriteLine("Turning twice doesn't get you another gumball!");
        }

        public void Dispense()
        {
            Console.WriteLine("You are a WINNER! You get two gumballs for your quarter");
            _gumballMachine.ReleaseBall();
            if (_gumballMachine.Count > 0)
            {
                _gumballMachine.ReleaseBall();
                if (_gumballMachine.Count > 0)
                {
                    _gumballMachine.SetState(_gumballMachine.GetNoQuarterState());
                }
                else
                {
                    Console.WriteLine("Oops, out of gumballs!");
                    _gumballMachine.SetState(_gumballMachine.GetSoldOutState());

                }
            }
            else
            {
                _gumballMachine.SetState(_gumballMachine.GetSoldOutState());
            }
        }

        public void Refill()
        {
            throw new NotImplementedException();
        }
    }
}