namespace DesignPatterns.Behavioral.Interpreter
{
    public class MulExpression : NonTerminalExpression, IExpression
    {
        public int Interpret()
        {
            var sum = 1;
            foreach (var expression in Children)
            {
                sum *= expression.Interpret();
            }

            return sum;
        }
    }
}
