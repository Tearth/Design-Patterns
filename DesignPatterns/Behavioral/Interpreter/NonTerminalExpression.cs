using System.Collections.Generic;

namespace DesignPatterns.Behavioral.Interpreter
{
    public class NonTerminalExpression
    {
        protected readonly List<IExpression> Children;

        public NonTerminalExpression()
        {
            Children = new List<IExpression>();
        }

        public void AddChild(IExpression expression)
        {
            Children.Add(expression);
        }
    }
}
