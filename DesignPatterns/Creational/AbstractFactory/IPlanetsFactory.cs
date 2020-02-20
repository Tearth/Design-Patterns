namespace DesignPatterns.Creational.AbstractFactory
{
    public interface IPlanetsFactory
    {
        IPlanet GenerateSmallPlanet(string name);
        IPlanet GenerateLargePlanet(string name);
    }
}
