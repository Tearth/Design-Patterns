namespace DesignPatterns.Structural.Decorator
{
    public static class Test
    {
        public static void Run()
        {
            var christmasTree = new ChristmasTree();
            var christmasTreeWithLights = new ChristmasTreeWithLights(christmasTree);
            var christmasTreeWithLightsAndOrnaments = new ChristmasTreeWithOrnaments(christmasTreeWithLights);

            christmasTreeWithLightsAndOrnaments.WriteInfo();
        }
    }
}
