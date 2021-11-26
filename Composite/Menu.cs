using System;
using System.Collections.Generic;
namespace Composite
{
    public class Menu: MenuComponent
    {
        private readonly List<MenuComponent> _menuComponents = new List<MenuComponent>();
        string _name;
        string _description;

        public Menu(string name, string description)
        {
            this._name = name;
            this._description = description;
        }

        public override void add(MenuComponent menuComponent)
        {
            _menuComponents.Add(menuComponent);
        }
        public override void remove(MenuComponent menuComponent)
        {
            _menuComponents.Remove(menuComponent);
        }
        public override MenuComponent getChild(int i)
        {
            return _menuComponents[i];
        }
        public override string getName()
        {
            return _name;
        }
        public override string getDescription()
        {
            return _description;
        }
        public override void print()
        {
            Console.WriteLine(getName() + ", " + getDescription());

            foreach (MenuComponent menuComponent in _menuComponents)
            {
                menuComponent.print();
            }
        }
    }
}
