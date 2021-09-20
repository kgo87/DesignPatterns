using System;
namespace Strategy
{
    public class ModelDuck: Duck
    {
        public ModelDuck()
        {
            QuackBehavior quackBeh = new Quack();
            FlyBehavior flyBeh = new FlyNoWay();
        }

        public override void display()
        {
            try
            {
                Console.WriteLine("I'm a Model Duck");
            }
            catch
            {
                throw new NotImplementedException();
            }
        }
    }
}
