using System;

namespace DesignPatterns.Behavioral.Memento
{
    public class Product
    {
        public decimal Price { get; set; }
        public int Amount { get; set; }

        public Product(decimal price, int amount)
        {
            Price = price;
            Amount = amount;
        }

        public Memento CreateMemento()
        {
            return new Memento(Price, Amount);
        }

        public void SetMemento(Memento memento)
        {
            Price = memento.Price;
            Amount = memento.Amount;
        }

        public void DisplayStatus()
        {
            Console.WriteLine($"Price: {Price}, Amount: {Amount}");
        }
    }
}
