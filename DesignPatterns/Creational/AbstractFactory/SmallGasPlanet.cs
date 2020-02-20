namespace DesignPatterns.Creational.AbstractFactory
{
    public class SmallGasPlanet : IPlanet
    {
        private string _name;

        public SmallGasPlanet(string name)
        {
            _name = name;
        }

        public string GetInfo()
        {
            return $"I'm small gas planet called \"{_name}\"";
        }
    }
}
