
namespace DesignPatterns.Behavioral.Visitor
{
    public class NodeString : INode
    {
        public string Value { get; set; }

        public NodeString(string value)
        {
            Value = value;
        }

        public void Accept(IVisitor visitor)
        {
            visitor.VisitNodeString(this);
        }
    }
}
