using System;
namespace Template
{
    public abstract class CaffeineDrink
    {

        public void prepareDrink()
        {
            boilWater();
            brew();
            pourInCup();
            if (clientWantsCondiment())
            {
                addCondiments();
            }
        }

        public abstract void brew();

        public abstract void addCondiments();

        void boilWater()
        {
            Console.WriteLine("Water is boiling");
        }

        void pourInCup()
        {
            Console.WriteLine("Pouring into a cup");
        }

        //hook
        public virtual bool clientWantsCondiment()
        {
            return true;
        }
    }
}
