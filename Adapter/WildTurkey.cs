using System;
namespace Adapter
{
    public class WildTurkey: Turkey
    {
        public WildTurkey()
        {
        }

        public void fly()
        {
            Console.WriteLine("Turkey flies a little");
        }

        public void gobble()
        {
            Console.WriteLine("Turkey is gobbling");
        }
    }
}
