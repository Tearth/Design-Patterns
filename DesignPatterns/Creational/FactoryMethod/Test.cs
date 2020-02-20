using System;

namespace DesignPatterns.Creational.FactoryMethod
{
    public static class Test
    {
        public static void Run()
        {
            var planetsFactory = new PlanetsFactory();
            var earth = planetsFactory.Create(PlanetType.Earth);
            var mars = planetsFactory.Create(PlanetType.Mars);
            var jupiter = planetsFactory.Create(PlanetType.Jupiter);

            Console.WriteLine($"Created Earth with {earth.Color} color");
            Console.WriteLine($"Created Mars with {mars.Color} color");
            Console.WriteLine($"Created Jupiter with {jupiter.Color} color");
        }
    }
}
