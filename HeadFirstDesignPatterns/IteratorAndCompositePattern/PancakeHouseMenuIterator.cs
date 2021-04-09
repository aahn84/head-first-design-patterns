using System;
using System.Collections.Generic;

namespace app.HeadFirstDesignPatterns.IteratorAndCompositePattern
{
    public class PancakeHouseMenuIterator : IIterator
    {
        private readonly List<MenuItem> _menuItems;
        private int _position = 0;

        public PancakeHouseMenuIterator(List<MenuItem> menuItems)
        {
            _menuItems = menuItems;
        }

        public object Next()
        {
            var menuItem = _menuItems[_position];
            _position = _position + 1;
            return menuItem;
        }

        public bool HasNext()
        {
            return _position + 1 <= _menuItems.Count;
        }
    }
}