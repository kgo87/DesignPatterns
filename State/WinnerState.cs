using System;
namespace State
{
    public class WinnerState: State
    {

        private readonly GumballMachine _gumballMachine;

        public WinnerState(GumballMachine gumballMachine)
        {
            _gumballMachine = gumballMachine;
        }

        public void insertQuarter()
        {
            Console.WriteLine("Please wait, we're already giving you a Gumball");
        }

        public void ejectQuarter()
        {
            Console.WriteLine("Please wait, we're already giving you a Gumball");
        }

        public void turnCrank()
        {
            Console.WriteLine("Please wait, we're already giving you a Gumball");
        }

        public void dispense()
        {
            _gumballMachine.ReleaseBall();
            if (_gumballMachine.Count == 0)
            {
                _gumballMachine.setState(_gumballMachine.SoldOutState);
            }
            else
            {
                _gumballMachine.ReleaseBall();
                Console.WriteLine("YOU'RE A WINNER! You got two gumballs for your quarter");
                if (_gumballMachine.Count > 0)
                {
                    _gumballMachine.setState(_gumballMachine.NoQuarterState);
                }
                else
                {
                    Console.WriteLine("Oops, out of gumballs!");
                    _gumballMachine.setState(_gumballMachine.SoldOutState);
                }
            }
        }

        public void refill() { }

        public override string ToString()
        {
            return "dispensing two gumballs for your quarter, because YOU'RE A WINNER!";
        }

    }
}
