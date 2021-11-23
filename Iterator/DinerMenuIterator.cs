using System;
namespace Iterator
{
    public class DinerMenuIterator: Iterator
    {
        MenuItem[] _items;
        int position = 0;


        public DinerMenuIterator(MenuItem [] items)
        {
            this._items = items;
        }

        public MenuItem next()
        {
            MenuItem item = _items[position];
            position += 1; 
            return item;
        }

        public bool hasNext() => position < _items.Length && _items[position] != null;
    }
}
