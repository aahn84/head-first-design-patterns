using System;
using System.Collections.Generic;
using System.Text;

namespace app.HeadFirstDesignPatterns.Decorator
{
    public abstract class Beverage
    {
        public virtual string GetDescription()
        {
            return "Unknown Beverage";
        }

        public abstract decimal Cost();
    }
}
