namespace DesignPatterns.Behavioral.State
{
    public static class Test
    {
        public static void Run()
        {
            var counter = new Counter();

            counter.Process();
            counter.Process();
            counter.Process();
            counter.Process();
        }
    }
}
