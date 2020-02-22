using System;
using System.Linq;

namespace DesignPatterns.Behavioral.Mediator
{
    public class Bot : IParticipant
    {
        public string Name { get; set; }
        private readonly IChatroom _chatroom;

        public Bot(string name, IChatroom chatroom)
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
            var charArray = message.ToCharArray();
            Array.Reverse(charArray);
            Send($"Reversed string = {new string(charArray)}");
        }
    }
}
