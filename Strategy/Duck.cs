using System;
namespace Strategy
{
    public abstract class Duck
    {
        FlyBehavior flyBeh;
        QuackBehavior quackBeh;
        
        public Duck()
        {
        }
        public abstract void display();

        public void performFly()
        {
            flyBeh.fly();
            Console.WriteLine("Implementation of flight behavior");
        }
        public void performQuack()
        {
            quackBeh.quack();
            Console.WriteLine("Implementation of quack behavior");
        }
        public void swim()
        {
            Console.WriteLine("All ducks float");
        }
        public void setFlyBehavior(FlyBehavior fb)
        {
            flyBeh = fb;
        }
        public void setQuackBehavior(QuackBehavior qb)
        {
            quackBeh = qb;
        }
    }
}
