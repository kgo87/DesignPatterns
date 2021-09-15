using System;
namespace Strategy
{
    public class FlyNoWay: FlyBehavior
    {
        public FlyNoWay()
        {
        }

        public void fly()
        {
            try
            {
                Console.WriteLine("I can't fly");
            }
            catch
            { 
                throw new NotImplementedException();
            }
        }
    }
}
