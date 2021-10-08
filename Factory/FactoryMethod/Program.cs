using System;

namespace Factory.FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {

            PizzaStore nyStore = new NYPizzaStore();
            PizzaStore chicagoStore = new ChicagoPizzaStore();

            Pizza pizza = nyStore.OrderPizza("cheese");
            Console.WriteLine("We ordered a " + pizza.Name);

            pizza = chicagoStore.OrderPizza("veggie");
            Console.WriteLine("We ordered a " + pizza.Name);
            
        }
    }
}
