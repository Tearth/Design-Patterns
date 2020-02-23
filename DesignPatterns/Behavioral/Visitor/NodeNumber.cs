namespace DesignPatterns.Behavioral.Visitor
{
    public class NodeNumber : INode
    {
        public int Value { get; set; }

        public NodeNumber(int value)
        {
            Value = value;
        }

        public void Accept(IVisitor visitor)
        {
            visitor.VisitNodeNumber(this);
        }
    }
}
