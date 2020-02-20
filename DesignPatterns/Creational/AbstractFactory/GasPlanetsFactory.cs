namespace DesignPatterns.Creational.AbstractFactory
{
    public class GasPlanetsFactory : IPlanetsFactory
    {
        public IPlanet GenerateSmallPlanet(string name)
        {
            return new SmallGasPlanet(name);
        }

        public IPlanet GenerateLargePlanet(string name)
        {
            return new LargeGasPlanet(name);
        }
    }
}
