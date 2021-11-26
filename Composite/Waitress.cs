using System;
namespace Composite
{
    public class Waitress
    {
        MenuComponent _allMenus;

        public Waitress(MenuComponent allMenus)
        {
            this._allMenus = allMenus;
        }

        public void printMenu()
        {
            _allMenus.print();
        }
    }
}
