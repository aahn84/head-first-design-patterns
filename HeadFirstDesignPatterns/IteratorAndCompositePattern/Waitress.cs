using System;

namespace app.HeadFirstDesignPatterns.IteratorAndCompositePattern
{
    public class Waitress
    {
        private readonly IMenu _pancakeHouseMenu;
        private readonly IMenu _dinerMenu;

        public Waitress(IMenu pancakeHouseMenu, IMenu dinerMenu)
        {
            _pancakeHouseMenu = pancakeHouseMenu;
            _dinerMenu = dinerMenu;
        }

        public void PrintMenu()
        {
            var pancakeIterator = _pancakeHouseMenu.CreateIterator();
            var dinerIterator = _dinerMenu.CreateIterator();

            Console.WriteLine();
            Console.WriteLine("MENU\n----\nBREAKFAST");
            PrintMenu(pancakeIterator);
            Console.WriteLine();
            Console.WriteLine("LUNCH");
            PrintMenu(dinerIterator);
        }

        private static void PrintMenu(IIterator iterator)
        {
            while (iterator.HasNext())
            {
                var menuItem = (MenuItem)iterator.Next();
                Console.WriteLine($"{menuItem.Name}, {menuItem.Price} -- {menuItem.Description}");
            }
        }

        // other methods here
    }
}