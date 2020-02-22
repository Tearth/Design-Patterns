namespace DesignPatterns.Behavioral.Mediator
{
    public class Human : IParticipant
    {
        public string Name { get; set; }
        private readonly IChatroom _chatroom;

        public Human(string name, IChatroom chatroom)
        {
            Name = name;
            _chatroom = chatroom;
        }

        public void Send(string message)
        {
            _chatroom.Send(Name, message);
        }

        public void Receive(string from, string message)
        {
            
        }
    }
}
