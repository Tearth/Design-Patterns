namespace DesignPatterns.Behavioral.Iterator
{
    public class Iterator<T> : IIterator<T>
    {
        private readonly Collection<T> _collection;
        private int _currentIndex;

        public Iterator(Collection<T> collection)
        {
            _collection = collection;
        }

        public T First()
        {
            return _collection[0];
        }

        public T Next()
        {
            _currentIndex++;
            if (IsDone())
            {
                return default(T);
            }

            return _collection[_currentIndex];
        }

        public T Current()
        {
            return _collection[_currentIndex];
        }

        public bool IsDone()
        {
            return _currentIndex == _collection.Count;
        }
    }
}
