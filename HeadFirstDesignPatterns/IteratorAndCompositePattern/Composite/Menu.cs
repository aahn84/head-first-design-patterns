﻿using System;
using System.Collections.Generic;
using System.Security.Cryptography;

namespace app.HeadFirstDesignPatterns.IteratorAndCompositePattern.Composite
{
    public class Menu : MenuComponent
    {
        private readonly List<MenuComponent> _menuComponents = new List<MenuComponent>();

        public Menu(string name, string description)
        {
            Name = name;
            Description = description;
        }

        public override string Name { get; }
        public override string Description { get; }

        public override void Add(MenuComponent menuComponent)
        {
            _menuComponents.Add(menuComponent);
        }

        public override void Remove(MenuComponent menuComponent)
        {
            _menuComponents.Remove(menuComponent);
        }

        public override MenuComponent GetChild(int i)
        {
            return _menuComponents[i];
        }

        public override void Print()
        {
            Console.WriteLine();
            Console.WriteLine($"{Name}, {Description}");
            Console.WriteLine("--------------------");

            var iterator = _menuComponents.GetEnumerator();
            while (iterator.MoveNext())
            {
                var menuComponent = iterator.Current;
                menuComponent?.Print();
            }
        }
    }
}