using System;
using System.Collections.Generic;

namespace DesignPatterns.Structural.Composite
{
    public class RocketComposite : IRocketComponent
    {
        public string Name { get; set; }

        private readonly List<IRocketComponent> _components;

        public RocketComposite(string name)
        {
            Name = name;
            _components = new List<IRocketComponent>();
        }

        public void Add(IRocketComponent component)
        {
            _components.Add(component);
        }

        public void Remove(IRocketComponent component)
        {
            _components.Remove(component);
        }

        public void Display(int indentation)
        {
            Console.Write(new string(' ', indentation));
            Console.WriteLine(Name);

            _components.ForEach(p => p.Display(indentation + 4));
        }
    }
}
