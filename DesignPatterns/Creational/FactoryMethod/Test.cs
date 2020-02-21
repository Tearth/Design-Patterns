using System;

namespace DesignPatterns.Creational.FactoryMethod
{
    public static class Test
    {
        public static void Run()
        {
            var planetsFactory = new PlanetsFactory();

            IPlanet earth = planetsFactory.Create(PlanetType.Earth);
            IPlanet mars = planetsFactory.Create(PlanetType.Mars);
            IPlanet jupiter = planetsFactory.Create(PlanetType.Jupiter);

            Console.WriteLine($"Created Earth with {earth.Color} color");
            Console.WriteLine($"Created Mars with {mars.Color} color");
            Console.WriteLine($"Created Jupiter with {jupiter.Color} color");
        }
    }
}
