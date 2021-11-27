using System;
namespace State
{
    public class NoQuarterState: State
    {
        private readonly GumballMachine _gumballMachine;

        public NoQuarterState(GumballMachine gumballMachine)
        {
            this._gumballMachine = gumballMachine;
        }

        public void insertQuarter()
        {
            Console.WriteLine("You inserted a quarter");
            _gumballMachine.setState(_gumballMachine.HasQuarterState);
        }
        public void ejectQuarter()
        {
            Console.WriteLine("You haven't inserted a quarter");
        }
        public void turnCrank()
        {
            Console.WriteLine("You turned but haven't inserted a quarter");
        }
        public void dispense()
        {
            Console.WriteLine("You inserted a quarter");
        }
        public void refill() { }

        public override string ToString()
        {
            return "waiting for quarter";
        }
    }
}
