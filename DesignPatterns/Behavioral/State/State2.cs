using System;

namespace DesignPatterns.Behavioral.State
{
    public class State2 : IState
    {
        public void Process(Counter counter)
        {
            Console.WriteLine("2");
            counter.State = new State3();
        }
    }
}