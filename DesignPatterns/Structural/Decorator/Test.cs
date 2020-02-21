namespace DesignPatterns.Structural.Decorator
{
    public static class Test
    {
        public static void Run()
        {
            ITree christmasTree = new ChristmasTree();
            ITree christmasTreeWithLights = new ChristmasTreeWithLights(christmasTree);
            ITree christmasTreeWithLightsAndOrnaments = new ChristmasTreeWithOrnaments(christmasTreeWithLights);

            christmasTreeWithLightsAndOrnaments.WriteInfo();
        }
    }
}
