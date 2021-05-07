using System;
using System.Text;

namespace app.HeadFirstDesignPatterns.StatePattern.GumballMachineWithState
{
    public class GumballMachineWithState
    {
        private readonly IState _soldOutState;
        private readonly IState _noQuarterState;
        private readonly IState _hasQuarterState;
        private readonly IState _soldState;
        private readonly IState _winnerState;
        private IState _state;
        public int Count { get; private set; }

        public GumballMachineWithState(int numberOfGumballs)
        {
            _soldOutState = new SoldOutState(this);
            _noQuarterState = new NoQuarterState(this);
            _hasQuarterState = new HasQuarterState(this);
            _soldState = new SoldState(this);
            _winnerState = new WinnerState(this);
            Count = numberOfGumballs;
            if (numberOfGumballs > 0)
            {
                _state = _noQuarterState;
            }
        }

        public void SetState(IState state)
        {
            _state = state;
        }

        public IState GetHasQuarterState()
        {
            return _hasQuarterState;
        }

        public IState GetSoldOutState()
        {
            return _soldOutState;
        }

        public IState GetSoldState()
        {
            return _soldState;
        }

        public IState GetNoQuarterState()
        {
            return _noQuarterState;
        }

        public IState GetWinnerState()
        {
            return _winnerState;
        }

        public void InsertQuarter()
        {
            _state.InsertQuarter();
        }

        public void EjectQuarter()
        {
            _state.EjectQuarter();
        }

        public void TurnCrank()
        {
            _state.TurnCrank();
            _state.Dispense();
        }

        public void ReleaseBall()
        {
            Console.WriteLine("A gumball comes rolling out the slot...");
            if (Count != 0)
            {
                Count--;
            }
        }

        public override string ToString()
        {
            var result = new StringBuilder();
            result.AppendLine("Mighty Gumball, Inc.");
            result.AppendLine("C#-enabled Standing Gumball Model #2021");
            result.AppendLine(Count == 1 ? $"Inventory: {Count} gumball" : $"Inventory: {Count} gumballs");
            if (_state == _soldOutState)
            {
                result.AppendLine("Machine is sold out");
            }
            else if (_state == _noQuarterState)
            {
                result.AppendLine("Machine is waiting for quarter");
            }
            else if (_state == _hasQuarterState)
            {
                result.AppendLine("Machine is waiting for turn of crank");
            }
            else if (_state == _soldState)
            {
                result.AppendLine("Machine is delivering a gumball");
            }
            result.AppendLine();
            return result.ToString();
        }

        internal void Refill(int numberOfGumballs)
        {
            Count += numberOfGumballs;
            Console.WriteLine($"Refilling: {numberOfGumballs} gumballs added!");
            Console.WriteLine(Count == 1 ? $"New Inventory: {Count} gumball" : $"New Inventory: {Count} gumballs");
            _soldOutState.Refill();
        }
    }
}