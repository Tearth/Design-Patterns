namespace DesignPatterns.Structural.Bridge
{
    public interface IControlPanel
    {
        IEngine Engine { get; set; }
        void DisplayInfo();
    }
}
