namespace DesignPatterns.Behavioral.TemplateMethod
{
    public static class Test
    {
        public static void Run()
        {
            Algorithm algorithm1 = new ConcreteAlgorithm1();
            algorithm1.DoOperation();

            Algorithm algorithm2 = new ConcreteAlgorithm2();
            algorithm2.DoOperation();
        }
    }
}
