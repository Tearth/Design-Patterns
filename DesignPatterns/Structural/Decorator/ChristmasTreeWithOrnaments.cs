using System;

namespace DesignPatterns.Structural.Decorator
{
    public class ChristmasTreeWithOrnaments : TreeDecorator
    {
        public ChristmasTreeWithOrnaments(ITree tree) : base(tree)
        {

        }

        public override void WriteInfo()
        {
            base.WriteInfo();
            Console.Write(" with ornaments");
        }
    }
}
