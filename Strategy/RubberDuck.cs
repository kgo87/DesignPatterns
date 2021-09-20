using System;
namespace Strategy
{
    public class RubberDuck: Duck
    {
        public RubberDuck()
        {
            QuackBehavior quackBeh = new Squeak();
            FlyBehavior flyBeh = new FlyWithWings();
        }
        public override void display()
        {
            try
            {
                Console.WriteLine("I'm a Rubber Duck");
            }
            catch
            {
                throw new NotImplementedException();
            }

        }
    }
}
