using System;

namespace DesignPatterns.Structural.Flyweight
{
    public class KeyA : IKey
    {
        public string Name { get; set; }
        public int Code { get; set; }

        public KeyA()
        {
            Name = "A";
            Code = 65;
        }
    }
}
