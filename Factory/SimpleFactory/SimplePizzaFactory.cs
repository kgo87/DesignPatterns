using System;
namespace Factory.SimpleFactory
{
    public class SimplePizzaFactory
    {
        public Pizza CreatePizza( string type)
        {
            Pizza pizza = null;

            if (type == "cheese")
            {
                pizza = new CheesePizza();
            }
            else if (type == "veggie")
            {
                pizza = new VeggiePizza();
            }
            else if (type == "clam")
            {
                pizza = new ClamPizza();
            }
            else
            {
                pizza = new PepperoniPizza();
            }
            return pizza;
        }
    }
}
