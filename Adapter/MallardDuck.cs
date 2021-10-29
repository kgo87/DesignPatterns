using System;
namespace Adapter
{
    public class MallardDuck: Duck
    {
        public MallardDuck()
        {
        }

        public void Fly()
        {
            Console.WriteLine("Duck is flying");
        }

        public void Quack()
        {
            Console.WriteLine("Duck is quacking");
        }
    }
}
