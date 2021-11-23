using System;
using System.Collections.Generic;

namespace Iterator
{
    public class PancakeHouseMenuIterator: Iterator
    {
        private readonly List<MenuItem> _items;
        int _position = 0;

        public PancakeHouseMenuIterator(List<MenuItem> items)
        {
            this._items = items;
        }

        public bool hasNext()
        {
            return (_position < (_items.Count - 1));
        }

        public MenuItem next()
        {
            var item = _items[_position];
            _position++;
            return item;
        }
    }
}
