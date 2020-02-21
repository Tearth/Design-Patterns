using System;

namespace DesignPatterns.Creational.AbstractFactory
{
    public static class Test
    {
        public static void Run()
        {
            IPlanetsFactory rockyPlanetsFactory = new RockyPlanetsFactory();
            IPlanetsFactory gasPlanetsFactory = new GasPlanetsFactory();

            var firstSolarSystemGenerator = new SolarSystemGenerator(rockyPlanetsFactory);
            var secondSolarSystemGenerator = new SolarSystemGenerator(gasPlanetsFactory);

            Console.WriteLine("First solar system");
            firstSolarSystemGenerator.Generate();

            Console.WriteLine();
            Console.WriteLine("Second solar system");
            secondSolarSystemGenerator.Generate();
        }
    }
}
