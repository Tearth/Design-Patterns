namespace DesignPatterns.Behavioral.Visitor
{
    public interface IVisitor
    {
        void VisitNodeNumber(NodeNumber node);
        void VisitNodeString(NodeString node);
    }
}
