namespace DesignPatterns.Creational.FactoryMethod
{
    public class Jupiter : IPlanet
    {
        public string Color { get; set; }

        public Jupiter()
        {
            Color = "Orange";
        }
    }
}
