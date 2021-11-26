using System;
namespace Composite
{
    public class MenuItem: MenuComponent
    {
        string _name;
        string _description;
        bool _isVeg;
        double _price;


        public MenuItem(string name, string description, bool isVeg, double price)
        {
            this._name = name;
            this._description = description;
            this._isVeg = isVeg;
            this._price = price;
        }

        public override string getName()
        {
            return _name;
        }
        public override string getDescription()
        {
            return _description;
        }
        public override double getPrice()
        {
            return _price;
        }
        public override bool isVeg()
        {
            return _isVeg;
        }

        public override void print()
        {
            Console.WriteLine(getName() + ", " + getDescription());
            if (isVeg())
            {
                Console.WriteLine("v");
            }
            Console.WriteLine(", " + getPrice() + "USD");
        }
    }
}
