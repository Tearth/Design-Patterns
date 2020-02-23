namespace DesignPatterns.Behavioral.Visitor
{
    public interface INode
    {
        void Accept(IVisitor visitor);
    }
}
