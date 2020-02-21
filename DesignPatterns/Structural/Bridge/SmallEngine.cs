namespace DesignPatterns.Structural.Bridge
{
    public class SmallEngine : IEngine
    {
        public string GetSerialNumber()
        {
            return "SMALL-01";
        }
    }
}
