namespace DesignPatterns.Behavioral.Memento
{
    public static class Test
    {
        public static void Run()
        {
            var product = new Product(123.10m, 20);
            var caretaker = new Caretaker();

            product.DisplayStatus();
            caretaker.Memento = product.CreateMemento();

            product.Price = 333.50m;
            product.Amount = 19;
            product.DisplayStatus();

            product.SetMemento(caretaker.Memento);
            product.DisplayStatus();
        }
    }
}
