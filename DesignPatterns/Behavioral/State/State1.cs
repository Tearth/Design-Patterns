using System;

namespace DesignPatterns.Behavioral.State
{
    public class State1 : IState
    {
        public void Process(Counter counter)
        {
            Console.WriteLine("1");
            counter.State = new State2();
        }
    }
}
