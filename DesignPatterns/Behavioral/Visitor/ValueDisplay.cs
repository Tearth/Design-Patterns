using System;

namespace DesignPatterns.Behavioral.Visitor
{
    public class ValueDisplay : IVisitor
    {
        public void VisitNodeNumber(NodeNumber node)
        {
            Console.WriteLine($"{node.GetType().Name} has value {node.Value}");
        }

        public void VisitNodeString(NodeString node)
        {
            Console.WriteLine($"{node.GetType().Name} has value {node.Value}");
        }
    }
}
