using System;
namespace State
{
    public class SoldState:State
    {
        private readonly GumballMachine _gumballMachine;

        public SoldState(GumballMachine gumballMachine)
        {
            this._gumballMachine = gumballMachine;
        }
        public void insertQuarter()
        {
            Console.WriteLine("Please wait...The gumball is coming.");
        }
        public void ejectQuarter()
        {
            Console.WriteLine("The gumball is coming. You can't eject a quarter now");
        }
        public void turnCrank()
        {
            Console.WriteLine("You've already turned... The gumball is coming");
        }
        public void dispense()
        {
            _gumballMachine.ReleaseBall();
            if (_gumballMachine.Count > 0)
            {
                _gumballMachine.setState(_gumballMachine.NoQuarterState);
            }
            else
            {
                Console.WriteLine("No gumballs any more");
                _gumballMachine.setState(_gumballMachine.SoldOutState);
            }
        }
        public void refill() { }

        public override string ToString()
        {
            return "dispensing a gumball";
        }
    }
}
