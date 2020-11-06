using System;
using System.Collections.Generic;
using System.Text;

namespace app.Strategy.Duck.Behaviors
{
    public class MuteQuack : QuackBehavior
    {
        public void quack()
        {
            Console.WriteLine("<<Silence>>");
        }
    }
}
