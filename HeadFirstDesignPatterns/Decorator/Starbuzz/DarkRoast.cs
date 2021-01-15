using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace app.HeadFirstDesignPatterns.Decorator
{
    public class DarkRoast : Beverage
    {
        public override string GetDescription()
        {
            return "Dark Roast Coffee";
        }

        public override decimal Cost()
        {
            return .99m;
        }
    }
}
