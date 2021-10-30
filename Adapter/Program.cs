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

            Turkey duckAdapter = new DuckAdapter(duck);

            Console.WriteLine("\nTesting TurkeyAdapter...");
            testDuck(turkeyAdapter);

            Console.WriteLine("\nTesting DuckAdapter...");
            testTurkey(duckAdapter);

        }

        static void testDuck(Duck duck)
        {
            duck.Fly();
            duck.Quack();
        }

        static void testTurkey(Turkey turkey)
        {
            turkey.fly();
            turkey.gobble();
        }
    }
}
