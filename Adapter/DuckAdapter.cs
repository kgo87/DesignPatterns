using System;
namespace Adapter
{
    public class DuckAdapter: Turkey
    {
        Duck duck;
        public DuckAdapter(Duck duck)
        {
            this.duck = duck;
        }

        public void fly()
        {
            for (int i = 0; i < 5; i++)
            {
                //do nothing;
            }
            duck.Fly();
        }

        public void gobble()
        {
            duck.Quack();
        }
    }
}
