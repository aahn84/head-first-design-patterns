namespace app.HeadFirstDesignPatterns.IteratorAndCompositePattern
{
    public class MenuItem
    {
        public string Name { get; }
        public string Description { get; }
        public bool IsVegetarian { get; }
        public double Price { get; }

        public MenuItem(string name, string description, bool vegetarian, double price)
        {
            Name = name;
            Description = description;
            IsVegetarian = vegetarian;
            Price = price;
        }
    }
}