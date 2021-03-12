using System;
using System.Collections.Generic;
using System.Text;
using app.Strategy.Duck.Behaviors;

namespace app.HeadFirstDesignPatterns.AdapterPattern
{
    public interface IDuck
    {
        public void Quack();

        public void Fly();
    }
}