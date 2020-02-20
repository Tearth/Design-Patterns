namespace DesignPatterns.Creational.AbstractFactory
{
    public class SmallRockyPlanet : IPlanet
    {
        private string _name;

        public SmallRockyPlanet(string name)
        {
            _name = name;
        }

        public string GetInfo()
        {
            return $"I'm small rocky planet called \"{_name}\"";
        }
    }
}
