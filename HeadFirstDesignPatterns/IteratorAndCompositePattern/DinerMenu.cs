using System;
using System.Runtime.ConstrainedExecution;

namespace app.HeadFirstDesignPatterns.IteratorAndCompositePattern
{
    public class DinerMenu : IMenu
    {
        private static readonly int MAX_ITEMS = 6;
        private int numberOfItems = 0;
        private readonly MenuItem[] _menuItems;

        public DinerMenu()
        {
            _menuItems = new MenuItem[MAX_ITEMS];

            AddItem("Vegetarian BLT", "(Fakin') Bacon with lettuce & tomato on whole wheat", true, 2.99);

            AddItem("BLT", "Bacon with lettuce & tomato on whole wheat", false, 2.99);

            AddItem("Soup of the day", "Soup of the day, with a side of potato salad", false, 3.29);

            AddItem("Hotdog", "A hot dog, with sauerkraut, relish, onion, topped with cheese", false, 3.05);

            // a couple of other Diner Menu items added here
        }

        public void AddItem(string name, string description, bool vegetarian, double price)
        {
            var menuItem = new MenuItem(name, description, vegetarian, price);
            if (numberOfItems >= MAX_ITEMS)
            {
                Console.WriteLine("Sorry, menu is full! Can't add item to menu");
            }
            else
            {
                _menuItems[numberOfItems] = menuItem;
                numberOfItems = numberOfItems + 1;
            }
        }

        //public MenuItem[] GetMenuItems()
        //{
        //    return _menuItems;
        //}

        public IIterator CreateIterator()
        {
            return new DinerMenuIterator(_menuItems);
        }

        // other menu methods here
    }
}