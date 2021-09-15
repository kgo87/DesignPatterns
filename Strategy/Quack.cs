using System;
namespace Strategy
{
    public class Quack: QuackBehavior
    {
        public Quack()
        {
        }

        public void quack()
        {
            try
            {
                Console.WriteLine("Quack");
            }
            catch
            {
                throw new NotImplementedException();
            }
            
        }
    }
}
