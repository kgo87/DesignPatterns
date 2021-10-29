using System;

namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            Duck duck = new MallardDuck();
            Turkey turkey = new WildTurkey();

            Duck turkeyAdapter = new TurkeyAdapter(turkey);

            testDuck(turkeyAdapter);


            Console.WriteLine("Hello World!");
        }

        static void testDuck(Duck duck)
        {
            duck.Fly();
            duck.Quack();
        }
    }
}
