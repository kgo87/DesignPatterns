using System;
namespace Factory.SimpleFactory
{
    public class CheesePizza: Pizza
    {
        public CheesePizza()
        {
            Name = "Cheese Pizza";
            Dough = "Regular Crust";
            Sauce = "Marinara";
            Toppings.Add("Mozarella");
            Toppings.Add("Parmesan");
        }
    }
}
