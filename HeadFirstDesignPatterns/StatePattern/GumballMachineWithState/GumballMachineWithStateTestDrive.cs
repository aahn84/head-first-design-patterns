using System;
using System.Collections.Generic;
using System.Text;
using app.HeadFirstDesignPatterns.IteratorAndCompositePattern;

namespace app.HeadFirstDesignPatterns.StatePattern.GumballMachineWithState
{
    public static class GumballMachineWithStateTestDrive
    {
        public static void Run()
        {
            var gumballMachine = new GumballMachineWithState(5);

            Console.WriteLine(gumballMachine);

            gumballMachine.InsertQuarter();
            gumballMachine.TurnCrank();

            Console.WriteLine(gumballMachine);

            gumballMachine.InsertQuarter();
            gumballMachine.TurnCrank();
            gumballMachine.InsertQuarter();
            gumballMachine.TurnCrank();

            Console.WriteLine(gumballMachine);

            gumballMachine.InsertQuarter();
            gumballMachine.TurnCrank();
            gumballMachine.InsertQuarter();
            gumballMachine.TurnCrank();
            gumballMachine.InsertQuarter();
            gumballMachine.TurnCrank();
            gumballMachine.InsertQuarter();
            gumballMachine.TurnCrank();
            gumballMachine.Refill(15);
            gumballMachine.InsertQuarter();
            gumballMachine.TurnCrank();
            gumballMachine.EjectQuarter();
        }
    }
}