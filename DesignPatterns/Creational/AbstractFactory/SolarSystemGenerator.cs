using System;

namespace DesignPatterns.Creational.AbstractFactory
{
    public class SolarSystemGenerator
    {
        private readonly IPlanetsFactory _planetsFactory;

        public SolarSystemGenerator(IPlanetsFactory planetsFactory)
        {
            _planetsFactory = planetsFactory;
        }

        public void Generate()
        {
            Console.WriteLine(_planetsFactory.GenerateSmallPlanet("Alpha").GetInfo());
            Console.WriteLine(_planetsFactory.GenerateLargePlanet("Beta").GetInfo());
        }
    }
}
