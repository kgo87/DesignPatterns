using System;
namespace Iterator
{
    public class Waitress
    {
        private readonly Menu _pancakeHouseMenu;
        private readonly Menu _dinerMenu;

        public Waitress(Menu pancakeHouseMenu, Menu dinerMenu)
        {
            this._pancakeHouseMenu = pancakeHouseMenu;
            this._dinerMenu = dinerMenu;
        }
        public void PrintMenu()
        {
            Iterator pancakeIterator = _pancakeHouseMenu.createIterator();
            Iterator dinerIterator = _dinerMenu.createIterator();

            Console.WriteLine("MENU\n----\nBREAKFAST");
            PrintMenu(pancakeIterator);
            Console.WriteLine("\nLUNCH");
            PrintMenu(dinerIterator);
        }

        private void PrintMenu(Iterator iterator)
        {
            while (iterator.hasNext())
            {
                MenuItem menuItem = iterator.next();
                Console.WriteLine($"{menuItem.getPrice().ToString()}, {menuItem.getPrice().ToString()} -- ");
                Console.WriteLine(menuItem.getDescription().ToString());
            }
        }


    }
}
