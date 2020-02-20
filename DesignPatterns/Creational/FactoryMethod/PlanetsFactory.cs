namespace DesignPatterns.Creational.FactoryMethod
{
    public class PlanetsFactory
    {
        public IPlanet Create(PlanetType type)
        {
            switch (type)
            {
                case PlanetType.Earth: return new Earth();
                case PlanetType.Mars: return new Mars();
                case PlanetType.Jupiter: return new Jupiter();
            }

            return null;
        }
    }
}
