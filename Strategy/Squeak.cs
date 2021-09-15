using System;
namespace Strategy
{
    public class Squeak: QuackBehavior
    {
        public Squeak()
        {
        }

        public void quack()
        {
            try
            {
                Console.WriteLine("Squek");
            }
            catch
            {
                throw new NotImplementedException();
            }
            
        }
    }
}
