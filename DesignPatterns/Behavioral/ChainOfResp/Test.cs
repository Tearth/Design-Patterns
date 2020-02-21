namespace DesignPatterns.Behavioral.ChainOfResp
{
    public static class Test
    {
        public static void Run()
        {
            var boolHandler = new BoolHandler();
            var floatHandler = new FloatHandler(boolHandler);
            var handler = new IntHandler(floatHandler);

            handler.Process("123");
            handler.Process("123,456");
            handler.Process("true");
        }
    }
}
