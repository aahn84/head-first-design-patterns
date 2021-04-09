using System;
using System.Collections.Generic;
using System.Text;

namespace app.HeadFirstDesignPatterns.IteratorAndCompositePattern
{
    public static class DinerMenuTestDrive
    {
        public static void Run()
        {
            var pancakeHouseMenu = new PancakeHouseMenu();
            var dinerMenu = new DinerMenu();

            var waitress = new Waitress(pancakeHouseMenu, dinerMenu);

            waitress.PrintMenu();
        }
    }
}