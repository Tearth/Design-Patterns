namespace DesignPatterns.Behavioral.Interpreter
{
    public class NumberExpression : IExpression
    {
        public int Value { get; set; }

        public NumberExpression(int value)
        {
            Value = value;
        }

        public int Interpret()
        {
            return Value;
        }
    }
}
