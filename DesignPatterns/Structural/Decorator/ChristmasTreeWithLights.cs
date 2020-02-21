using System;

namespace DesignPatterns.Structural.Decorator
{
    public class ChristmasTreeWithLights : TreeDecorator
    {
        public ChristmasTreeWithLights(ITree tree) : base(tree)
        {

        }

        public override void WriteInfo()
        {
            base.WriteInfo();
            Console.Write(" with lights");
        }
    }
}
