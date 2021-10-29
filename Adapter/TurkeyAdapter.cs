using System;
namespace Adapter
{
    public class TurkeyAdapter:Duck
    {
        Turkey turkey;

        public TurkeyAdapter(Turkey turkey)
        {
            this.turkey = turkey;
        }

        public void Quack()
        {
            turkey.gobble();
        }

        public void Fly()
        {
            for (int i = 0; i < 5; i++)
            {
                turkey.fly();
            };
        }
    }
}
