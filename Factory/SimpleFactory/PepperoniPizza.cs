using System;
namespace Factory.SimpleFactory
{
    public class PepperoniPizza: Pizza
    {
        public PepperoniPizza()
        {
            Name = "Pepperoni Pizza";
            Dough = "Regular Crust";
            Sauce = "Marinara";
            Toppings.Add("Sliced Pepperoni");
            Toppings.Add("Parmesan");
        }
    }
}
