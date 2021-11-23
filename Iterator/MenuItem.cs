using System;
namespace Iterator
{
    public class MenuItem
    {
        string _name;
        string _description;
        bool _isVegetarian;
        decimal _price;

        public MenuItem(string name, string description, bool veg, decimal price)
        {
            this._name = name;
            this._description = description;
            this._isVegetarian = veg;
            this._price = price;
        }

        public string getName()
        {
            return _name;
        }

        public string getDescription()
        {
            return _description;
        }

        public bool ifItemIsVeg()
        {
            return _isVegetarian;
        }

        public decimal getPrice()
        {
            return _price;
        }
    }
}
