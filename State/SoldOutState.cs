using System;
namespace State
{
    public class SoldOutState: State
    {
        private readonly GumballMachine _gumballMachine;

        public SoldOutState(GumballMachine gumballMachine)
        {
            this._gumballMachine = gumballMachine;
        }
        public void insertQuarter()
        {
            Console.WriteLine("Sorry, the machine is out of gumballs");
        }
        public void ejectQuarter()
        {
            Console.WriteLine("You can't eject, you haven't inserted a quarter yet");
        }
        public void turnCrank()
        {
            Console.WriteLine("You turned, but there are no gumballs");
        }

        public void dispense()
        {
            Console.WriteLine("No gumball dispensed");
        }

        public void refill()
        {
            _gumballMachine.setState(_gumballMachine.NoQuarterState);
        }

        public override string ToString()
        {
            return "sold out";
        }
    }
}
