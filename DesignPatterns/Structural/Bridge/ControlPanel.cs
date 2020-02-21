using System;

namespace DesignPatterns.Structural.Bridge
{
    public class ControlPanel : IControlPanel
    {
        public IEngine Engine { get; set; }

        public ControlPanel(IEngine engine)
        {
            Engine = engine;
        }

        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Control panel - engine serial number: {Engine.GetSerialNumber()}");
        }
    }
}
