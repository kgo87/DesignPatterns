using System;
namespace Factory.FactoryMethod
{
    public class NYPizzaStore: PizzaStore
    {
        protected override Pizza CreatePizza(string item)
        {
            Pizza pizza = null;
            switch (item)
            {
                case "cheese":
                    pizza = new NYStyleCheesePizza();
                    break;
                case "veggie":
                    pizza = new NYStyleVeggiePizza();
                    break;
            }

            return pizza;
        }
    }
}
