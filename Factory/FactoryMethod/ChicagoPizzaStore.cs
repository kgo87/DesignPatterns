using System;
namespace Factory.FactoryMethod
{
    public class ChicagoPizzaStore: PizzaStore
    {
        protected override Pizza CreatePizza(string item)
        {
            Pizza pizza = null;

            switch (item)
            {
                case "cheese":
                    pizza = new ChicagoStyleCheesePizza();
                    break;
                case "veggie":
                    pizza = new ChicagoStyleVeggiePizza();
                    break;
            }

            return pizza;
        }
    }
}
