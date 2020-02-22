using System.Collections.Generic;

namespace DesignPatterns.Behavioral.Iterator
{
    public class Collection<T> : List<T>
    {
        public IIterator<T> CreateIterator()
        {
            return new Iterator<T>(this);
        }
    }
}
