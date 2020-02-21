namespace DesignPatterns.Structural.Adapter
{
    public static class Test
    {
        public static void Run()
        {
            OldImplementation oldImplementation = new OldImplementation();
            oldImplementation.Write("Paweł");

            OldImplementation newImplementation = new Adapter();
            newImplementation.Write("Paweł");
        }
    }
}
