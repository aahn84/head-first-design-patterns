using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace app.HeadFirstDesignPatterns.Decorator
{
    public class Decaf : Beverage
    {
        public override string GetDescription()
        {
            return "Decaf Coffee";
        }

        public override decimal Cost()
        {
            return 1.05m;
        }
    }
}
