namespace DesignPatterns.Structural.Proxy
{
    public static class Test
    {
        public static void Run()
        {
            IEngine engine = new EngineProxy();
            engine.Start();
            engine.Start();
            engine.Stop();
            engine.Stop();
        }
    }
}
