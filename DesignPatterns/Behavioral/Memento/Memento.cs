namespace DesignPatterns.Behavioral.Memento
{
    public class Memento
    {
        public decimal Price { get; set; }
        public int Amount { get; set; }

        public Memento(decimal price, int amount)
        {
            Price = price;
            Amount = amount;
        }
    }
}
