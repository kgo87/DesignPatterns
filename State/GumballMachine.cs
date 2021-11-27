using System;
using System.Text;

namespace State
{
    public class GumballMachine
    {
        public int Count { get; private set; }
        public State State { get; private set; }

        public State SoldOutState { get; }
        public State NoQuarterState { get; }
        public State HasQuarterState { get; }
        public State SoldState { get; }
        public State WinnerState { get; }

        public GumballMachine(int numberGumballs)
        {
            SoldOutState = new SoldOutState(this);
            NoQuarterState = new NoQuarterState(this);
            HasQuarterState = new HasQuarterState(this);
            SoldState = new SoldState(this);
            WinnerState = new WinnerState(this);

            Count = numberGumballs;

            State = numberGumballs > 0 ? NoQuarterState : SoldOutState;
        }

        public void setState(State state)
        {
            this.State = state;
        }

        public void insertQuarter()
        {
            State.insertQuarter();
        }

        public void ejectQuarter()
        {
            State.ejectQuarter();
        }

        public void turnCrank()
        {
            State.turnCrank();
            State.dispense();
        }

        public void refill(int count)
        {
            Count += count;
            Console.WriteLine($"The gumball machine was just refilled; it's new count is: {Count.ToString()}");
            State.refill();
        }

        public void ReleaseBall()
        {
            Console.WriteLine("The ball is rolling out of the slot");
            if (Count > 0)
            {
                Count--;
            }
        }
        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            result.Append("\nMighty Gumball, Inc.");
            result.Append("\nC#-enabled Standing Gumball Model #2016");
            result.Append("\nInventory: " + Count.ToString() + " gumball");
            if (Count != 1)
            {
                result.Append("s");
            }
            result.Append("\n");
            result.Append("Machine is " + State + "\n");

            return result.ToString();
        }
    }
}
