namespace DesignPatterns.Structural.Proxy
{
    public static class Test
    {
        public static void Run()
        {
            var engine = new EngineProxy();
            engine.Start();
            engine.Start();
            engine.Stop();
            engine.Stop();
        }
    }
}
