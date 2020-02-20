using System;

namespace DesignPatterns.Structural.Proxy
{
    public class Engine : IEngine
    {
        public bool Running { get; set; }

        public void Start()
        {
            Running = true;
            Console.WriteLine("Engine started");
        }

        public void Stop()
        {
            Running = false;
            Console.WriteLine("Engine stopped");
        }
    }
}
