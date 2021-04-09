using System;

namespace app.HeadFirstDesignPatterns.IteratorAndCompositePattern.Composite
{
    public abstract class MenuComponent
    {
        public virtual void Add(MenuComponent menuComponent)
        {
            throw new NotImplementedException();
        }

        public virtual void Remove(MenuComponent menuComponent)
        {
            throw new NotImplementedException();
        }

        public virtual MenuComponent GetChild(int i)
        {
            throw new NotImplementedException();
        }

        public virtual void Print()
        {
            throw new NotImplementedException();
        }

        public virtual string Name => throw new NotImplementedException();

        public virtual string Description => throw new NotImplementedException();

        public virtual double Price => throw new NotImplementedException();

        public virtual bool IsVegetarian => throw new NotImplementedException();
    }
}