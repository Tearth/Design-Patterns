namespace DesignPatterns.Behavioral.Mediator
{
    public static class Test
    {
        public static void Run()
        {
            IChatroom globalChatroom = new GlobalChatroom();
            IParticipant human = new Human("Human 1", globalChatroom);
            IParticipant bot = new Bot("Bot 1", globalChatroom);

            globalChatroom.AddParticipant(human);
            globalChatroom.AddParticipant(bot);

            human.Send("Lorem Ipsum");
            human.Send("Hello World");
        }
    }
}
