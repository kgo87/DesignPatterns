using System;
namespace Strategy
{
    public class MuteQuack: QuackBehavior
    {
        public MuteQuack()
        {
        }

        public void quack()
        {
            try
            {
                Console.WriteLine("This is silence");
            }
            catch
            {
                throw new NotImplementedException();
            }
            
        }
    }
}
