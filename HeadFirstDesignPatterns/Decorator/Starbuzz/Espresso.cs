using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace app.HeadFirstDesignPatterns.Decorator
{
    public class Espresso : Beverage
    {
        public override string GetDescription()
        {
            return "Espresso";
        }

        public override decimal Cost()
        {
            return 1.99m;
        }
    }
}
