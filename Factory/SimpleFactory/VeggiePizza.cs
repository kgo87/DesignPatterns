using System;
namespace Factory.SimpleFactory
{
    public class VeggiePizza: Pizza
    {
        public VeggiePizza()
        {
            Name = "Veggie Pizza";
            Dough = "Regular Crust";
            Sauce = "Marinara";
            Toppings.Add("Mushrooms");
            Toppings.Add("Peppers");
        }
    }
}
