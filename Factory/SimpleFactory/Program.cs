using System;

namespace Factory.SimpleFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            SimplePizzaFactory factory = new SimplePizzaFactory();
            PizzaStore store = new PizzaStore(factory);

            Pizza pizza = store.OrderPizza("cheese");
            Console.WriteLine("We ordered a " + pizza.Name);

            pizza = store.OrderPizza("veggie");
            Console.WriteLine("We ordered a " + pizza.Name);
            
        }
    }
}
