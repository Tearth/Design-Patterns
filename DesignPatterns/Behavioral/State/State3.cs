using System;

namespace DesignPatterns.Behavioral.State
{
    public class State3 : IState
    {
        public void Process(Counter counter)
        {
            Console.WriteLine("3");
            counter.State = new State1();
        }
    }
}