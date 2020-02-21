using System;

namespace DesignPatterns.Structural.Bridge
{
    public class ExtendedControlPanel : ControlPanel
    {
        public ExtendedControlPanel(IEngine engine) : base(engine)
        {

        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Extended control panel - engine serial number: {Engine.GetSerialNumber()}");
        }
    }
}
