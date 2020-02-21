using System;

namespace DesignPatterns.Structural.Adapter
{
    public class OldImplementation
    {
        public virtual void Write(string name)
        {
            Console.WriteLine($"My name is {name}");
        }
    }
}
