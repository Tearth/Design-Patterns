using System.Collections.Generic;

namespace DesignPatterns.Behavioral.Observer
{
    public class Shop : IObservable
    {
        private readonly List<IObserver> _observers;

        public Shop()
        {
            _observers = new List<IObserver>();
        }

        public void Attach(IObserver observer)
        {
            _observers.Add(observer);
        }

        public void Detach(IObserver observer)
        {
            _observers.Remove(observer);
        }

        public void UpdatePrices()
        {
            _observers.ForEach(p => p.Notify());
        }
    }
}
