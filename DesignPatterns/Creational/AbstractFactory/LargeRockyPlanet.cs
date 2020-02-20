namespace DesignPatterns.Creational.AbstractFactory
{
    public class LargeRockyPlanet : IPlanet
    {
        private string _name;

        public LargeRockyPlanet(string name)
        {
            _name = name;
        }

        public string GetInfo()
        {
            return $"I'm large rocky planet called \"{_name}\"";
        }
    }
}
