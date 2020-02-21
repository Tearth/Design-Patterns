using System;

namespace DesignPatterns.Structural.Adapter
{
    public class NewImplementation
    {
        public void Write(string name, int age)
        {
            Console.WriteLine($"My name is {name} ({age} years old)");
        }
    }
}
