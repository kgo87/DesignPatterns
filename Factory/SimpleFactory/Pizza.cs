using System;
using System.Collections.Generic;
using System.Text;

namespace Factory.SimpleFactory
{
    public abstract class Pizza
    {
        public string Name { get; protected set; }
        public string Dough { get; protected set; }
        public string Sauce { get; protected set; }
        public List<string> Toppings { get; protected set; } = new List<string>();


        public virtual void Prepare()
        {
            Console.WriteLine("Preparing " + Name);
        }

        public virtual void Bake()
        {
            Console.WriteLine("Bake for 25 minutes at 350");
        }

        public virtual void Cut()
        {
            Console.WriteLine("Cut into diagonal slices");
        }

        public virtual void Box()
        {
            Console.WriteLine("Place pizza in official PizzaStore box");
        }

        public override string ToString()
        {
            var result = new StringBuilder();
            result.AppendLine("---- " + Name + "----");
            result.AppendLine(Dough);
            result.AppendLine(Sauce);
            foreach (var item in Toppings)
            {
                result.AppendLine(item);
            }

            return result.ToString();
        }
    }
}
