using System;

namespace DesignPatterns.Structural.Composite
{
    public class RocketElement : IRocketComponent
    {
        public string Name { get; set; }

        public RocketElement(string name)
        {
            Name = name;
        }

        public void Add(IRocketComponent component)
        {
            throw new NotImplementedException();
        }

        public void Remove(IRocketComponent component)
        {
            throw new NotImplementedException();
        }

        public void Display(int indentation)
        {
            Console.Write(new string(' ', indentation));
            Console.WriteLine(Name);
        }
    }
}
