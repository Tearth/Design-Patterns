namespace DesignPatterns.Behavioral.ChainOfResp
{
    public abstract class ValueHandler
    {
        protected ValueHandler Successor;

        protected ValueHandler(ValueHandler successor = null)
        {
            Successor = successor;
        }

        public virtual void Process(string value)
        {
            Successor?.Process(value);
        }
    }
}
