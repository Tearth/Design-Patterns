namespace DesignPatterns.Behavioral.Observer
{
    public static class Test
    {
        public static void Run()
        {
            var shop = new Shop();
            shop.Attach(new Customer(1));
            shop.Attach(new Customer(2));
            shop.Attach(new Customer(3));
            shop.Attach(new Customer(4));
            shop.Attach(new Customer(5));

            shop.UpdatePrices();
        }
    }
}
