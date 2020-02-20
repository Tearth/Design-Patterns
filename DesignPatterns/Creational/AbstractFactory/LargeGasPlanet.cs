namespace DesignPatterns.Creational.AbstractFactory
{
    public class LargeGasPlanet : IPlanet
    {
        private string _name;

        public LargeGasPlanet(string name)
        {
            _name = name;
        }

        public string GetInfo()
        {
            return $"I'm large gas planet called \"{_name}\"";
        }
    }
}
