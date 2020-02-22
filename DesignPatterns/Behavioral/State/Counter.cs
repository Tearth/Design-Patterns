namespace DesignPatterns.Behavioral.State
{
    public class Counter
    {
        public IState State { get; set; }

        public Counter()
        {
            State = new State1();
        }

        public void Process()
        {
            State.Process(this);
        }
    }
}
