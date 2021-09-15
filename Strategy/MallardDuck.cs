using System;
namespace Strategy
{
    public class MallardDuck: Duck
    {
        public MallardDuck()
        {
            QuackBehavior quackBeh = new Quack();
            FlyBehavior flyBeh = new FlyWithWings();
        }

        public override void display()
        {
            try
            {
                Console.WriteLine("I'm a Mallard Duck");
            }
            catch
            {
                throw new NotImplementedException();
            }
            
        }
    }
}
