using System;
namespace Strategy
{
    public class FlyWithWings: FlyBehavior
    {
        public FlyWithWings()
        {
        }

        public void fly()
        {
            try
            {
                Console.WriteLine("I'm flying");
            }
            catch
            { 
                throw new NotImplementedException();
            }
        }
    }
}
