using System;
using System.Collections.Generic;
using System.Text;

namespace app.HeadFirstDesignPatterns.Strategy
{
    public class MuteQuack : QuackBehavior
    {
        public void Quacking()
        {
            Console.WriteLine("<<Silence>>");
        }
    }
}
