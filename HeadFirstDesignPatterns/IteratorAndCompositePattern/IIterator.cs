using System;

namespace app.HeadFirstDesignPatterns.IteratorAndCompositePattern
{
    public interface IIterator
    {
        bool HasNext();

        object Next();
    }
}