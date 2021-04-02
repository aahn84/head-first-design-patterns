using System;
using System.Collections.Generic;
using System.Text;

namespace app.HeadFirstDesignPatterns.TemplateMethodPattern.DuckSort
{
    public class Duck : IComparable<Duck>
    {
        private string _name;
        private int _weight;

        public Duck(string name, int weight)
        {
            _name = name;
            _weight = weight;
        }

        public override string ToString()
        {
            return $"{_name} weighs {_weight}";
        }

        public int CompareTo(Duck otherDuck)
        {
            if (_weight < otherDuck._weight)
            {
                return -1;
            }
            else if (_weight == otherDuck._weight)
            {
                return 0;
            }
            else //_weight > otherDuck._weight
            {
                return 1;
            }
        }
    }
}