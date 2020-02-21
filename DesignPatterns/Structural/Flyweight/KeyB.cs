namespace DesignPatterns.Structural.Flyweight
{
    public class KeyB : IKey
    {
        public string Name { get; set; }
        public int Code { get; set; }

        public KeyB()
        {
            Name = "B";
            Code = 66;
        }
    }
}
