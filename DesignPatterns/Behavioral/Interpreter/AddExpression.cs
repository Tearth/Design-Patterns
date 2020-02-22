namespace DesignPatterns.Behavioral.Interpreter
{
    public class AddExpression : NonTerminalExpression, IExpression
    {
        public int Interpret()
        {
            var sum = 0;
            foreach (var expression in Children)
            {
                sum += expression.Interpret();
            }

            return sum;
        }
    }
}
