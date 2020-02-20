namespace DesignPatterns.Creational.FactoryMethod
{
    public class Mars : IPlanet
    {
        public string Color { get; set; }

        public Mars()
        {
            Color = "Red";
        }
    }
}
