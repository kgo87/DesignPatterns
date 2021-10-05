using System;
namespace Factory.SimpleFactory
{
    public class PizzaStore
    {
        private readonly SimplePizzaFactory _factory;
        public PizzaStore(SimplePizzaFactory factory)
        {
            _factory = factory;
        }
        public Pizza OrderPizza(string type)
        {
            Pizza pizza = _factory.CreatePizza(type);

            pizza.Prepare();
            pizza.Bake();
            pizza.Cut();
            pizza.Bake();

            return pizza;

        }
    }
}
