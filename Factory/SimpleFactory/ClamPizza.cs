using System;
namespace Factory.SimpleFactory
{
    public class ClamPizza: Pizza
    {
        public ClamPizza()
        {
            Name = "Clam Pizza";
            Dough = "Regular Crust";
            Sauce = "Plum Tomato";
            Toppings.Add("Sea Salt");
            Toppings.Add("Parmesan");
        }
    }
}
