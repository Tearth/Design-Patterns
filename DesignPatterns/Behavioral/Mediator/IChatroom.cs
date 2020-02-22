namespace DesignPatterns.Behavioral.Mediator
{
    public interface IChatroom
    {
        void AddParticipant(IParticipant participant);
        void Send(string from, string message);
    }
}
