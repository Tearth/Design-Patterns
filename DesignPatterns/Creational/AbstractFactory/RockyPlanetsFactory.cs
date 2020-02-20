namespace DesignPatterns.Creational.AbstractFactory
{
    public class RockyPlanetsFactory : IPlanetsFactory
    {
        public IPlanet GenerateSmallPlanet(string name)
        {
            return new SmallRockyPlanet(name);
        }

        public IPlanet GenerateLargePlanet(string name)
        {
            return new LargeRockyPlanet(name);
        }
    }
}
