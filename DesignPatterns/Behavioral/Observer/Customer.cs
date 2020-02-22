using System;

namespace DesignPatterns.Behavioral.Observer
{
    public class Customer : IObserver
    {
        private readonly int _id;

        public Customer(int id)
        {
            _id = id;
        }

        public void Notify()
        {
            Console.WriteLine($"Customer {_id}: Prices in shop have changed");
        }
    }
}
