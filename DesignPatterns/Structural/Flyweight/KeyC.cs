namespace DesignPatterns.Structural.Flyweight
{
    public class KeyC : IKey
    {
        public string Name { get; set; }
        public int Code { get; set; }

        public KeyC()
        {
            Name = "C";
            Code = 67;
        }
    }
}
