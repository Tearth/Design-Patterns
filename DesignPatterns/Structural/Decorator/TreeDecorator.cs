namespace DesignPatterns.Structural.Decorator
{
    public abstract class TreeDecorator : ITree
    {
        private readonly ITree _tree;

        protected TreeDecorator(ITree tree)
        {
            _tree = tree;
        }

        public virtual void WriteInfo()
        {
            _tree?.WriteInfo();
        }
    }
}
