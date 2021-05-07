namespace app.HeadFirstDesignPatterns.StatePattern.GumballMachineWithState
{
    public interface IState
    {
        void InsertQuarter();
        void EjectQuarter();
        void TurnCrank();
        void Dispense();
        void Refill();
    }
}