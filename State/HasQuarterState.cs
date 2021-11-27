using System;
namespace State
{
    public class HasQuarterState: State
    {
        private readonly GumballMachine _gumballMachine;
        private readonly Random _random = new Random();

        public HasQuarterState(GumballMachine gumballMachine)
        {
            this._gumballMachine = gumballMachine;
        }
        public void insertQuarter()
        {
            Console.WriteLine("You've already inserted a quarter");
        }
        public void ejectQuarter()
        {
            Console.WriteLine("Quarter returned");
            _gumballMachine.setState(_gumballMachine.NoQuarterState);
        }
        public void turnCrank()
        {
            Console.WriteLine("You turned... ");
            int winner = _random.Next(10);
            if (winner == 0 && _gumballMachine.Count > 1)
            {
                _gumballMachine.setState(_gumballMachine.WinnerState);
            }
            else
            {
                _gumballMachine.setState(_gumballMachine.SoldState);
            }
           
        }
        public void dispense()
        {
            Console.WriteLine("You turned... The gumball is coming");
        }
        public void refill() { }

        public override string ToString()
        {
            return "waiting to turn a crank";
        }
    }
}
