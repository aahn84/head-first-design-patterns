using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Encodings.Web;

namespace app.HeadFirstDesignPatterns.SingletonPattern
{
    public class ChocolateBoiler
    {
        private bool _empty;
        private bool _boiled;

        private static ChocolateBoiler _chocolateBoiler;

        private ChocolateBoiler()
        {
            _empty = true;
            _boiled = false;
        }

        public static ChocolateBoiler GetInstance()
        {
            if (_chocolateBoiler is null)
                _chocolateBoiler = new ChocolateBoiler();

            return _chocolateBoiler;
        }

        public void Fill()
        {
            if (IsEmpty())
            {
                //fill the boiler with a milk/chocolate mixture
                Console.WriteLine("Filling...");
                _empty = false;
                _boiled = false;
                Console.WriteLine("Filled!");
                _chocolateBoiler.Boil();
            }
        }

        public void Drain()
        {
            if (!IsEmpty() && IsBoiled())
            {
                //drain the boiled milk and chocolate
                Console.WriteLine("Draining...");
                _empty = true;
                Console.WriteLine("Drained!");
            }
        }

        public void Boil()
        {
            if (!IsEmpty() && !IsBoiled())
            {
                //bring the contents to a boil
                Console.WriteLine("Boiling...");
                _boiled = true;
                Console.WriteLine("Boiled!");
            }
        }

        public bool IsEmpty()
        {
            return _empty;
        }

        public bool IsBoiled()
        {
            return _boiled;
        }
    }
}