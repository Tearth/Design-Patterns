namespace DesignPatterns.Structural.Proxy
{
    public interface IEngine
    {
        bool Running { get; set; }
        void Start();
        void Stop();
    }
}
