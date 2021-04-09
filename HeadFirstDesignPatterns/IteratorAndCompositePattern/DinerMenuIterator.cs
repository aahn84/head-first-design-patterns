using System;

namespace app.HeadFirstDesignPatterns.IteratorAndCompositePattern
{
    public class DinerMenuIterator : IIterator
    {
        private readonly MenuItem[] _menuItems;
        private int _position;

        public DinerMenuIterator(MenuItem[] menuItems)
        {
            _menuItems = menuItems;
            _position = 0;
        }

        public object Next()
        {
            var menuItem = _menuItems[_position];
            _position = _position + 1;
            return menuItem;
        }

        public bool HasNext()
        {
            return _position < _menuItems.Length && _menuItems[_position] != null;
        }
    }
}