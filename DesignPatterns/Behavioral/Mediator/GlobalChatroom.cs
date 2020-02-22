using System;
using System.Collections.Generic;
using System.Linq;

namespace DesignPatterns.Behavioral.Mediator
{
    public class GlobalChatroom : IChatroom
    {
        private readonly List<IParticipant> _participants;

        public GlobalChatroom()
        {
            _participants = new List<IParticipant>();
        }

        public void AddParticipant(IParticipant participant)
        {
            _participants.Add(participant);
        }

        public void Send(string from, string message)
        {
            Console.WriteLine($"{from}: {message}");
            foreach (var participant in _participants.Where(p => p.Name != from))
            {
                participant.Receive(from, message);
            }
        }
    }
}
