namespace DesignPatterns.Behavioral.Command
{
    public class AddCommand : ICommand
    {
        public int Operand { get; set; }
        private readonly Calculator _calculator;

        public AddCommand(Calculator calculator, int operand)
        {
            Operand = operand;
            _calculator = calculator;
        }

        public void Execute()
        {
            _calculator.DoOperation(OperationType.Add, Operand);
        }

        public void Undo()
        {
            _calculator.DoOperation(OperationType.Sub, Operand);
        }

        public override string ToString()
        {
            return $"Operation: Add, Operand: {Operand}";
        }
    }
}
