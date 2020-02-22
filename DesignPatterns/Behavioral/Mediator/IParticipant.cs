namespace DesignPatterns.Behavioral.Mediator
{
    public interface IParticipant
    {
        string Name { get; set; }

        void Send(string message);
        void Receive(string from, string message);
    }
}
