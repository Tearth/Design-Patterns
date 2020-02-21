namespace DesignPatterns.Behavioral.Command
{
    public class MulCommand : ICommand
    {
        public int Operand { get; set; }
        private readonly Calculator _calculator;

        public MulCommand(Calculator calculator, int operand)
        {
            Operand = operand;
            _calculator = calculator;
        }

        public void Execute()
        {
            _calculator.DoOperation(OperationType.Mul, Operand);
        }

        public void Undo()
        {
            _calculator.DoOperation(OperationType.Div, Operand);
        }

        public override string ToString()
        {
            return $"Operation: Sub, Operand: {Operand}";
        }
    }
}
