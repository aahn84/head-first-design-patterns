using System;
using System.Text;

namespace app.HeadFirstDesignPatterns.IteratorAndCompositePattern.Composite
{
    public class MenuItem : MenuComponent
    {
        public override string Name { get; }
        public override string Description { get; }
        public override double Price { get; }
        public override bool IsVegetarian { get; }

        public MenuItem(string name, string description, bool isVegetarian, double price)
        {
            Name = name;
            Description = description;
            IsVegetarian = isVegetarian;
            Price = price;
        }

        public override void Print()
        {
            var sb = new StringBuilder();
            sb.Append(" " + Name);
            if (IsVegetarian)
                sb.Append("(v)");
            sb.Append(", " + Price);
            sb.Append(Environment.NewLine);
            sb.Append("    -- " + Description);
            Console.WriteLine(sb);
        }
    }
}