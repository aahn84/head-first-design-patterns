using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace app.HeadFirstDesignPatterns.Decorator
{
    public class HouseBlend : Beverage
    {
        public override string GetDescription()
        {
            return "House Blend Coffee";
        }

        public override decimal Cost()
        {
            return .89m;
        }
    }
}
