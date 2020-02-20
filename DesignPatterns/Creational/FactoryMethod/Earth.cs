namespace DesignPatterns.Creational.FactoryMethod
{
    public class Earth : IPlanet
    {
        public string Color { get; set; }

        public Earth()
        {
            Color = "Blue";
        }
    }
}
