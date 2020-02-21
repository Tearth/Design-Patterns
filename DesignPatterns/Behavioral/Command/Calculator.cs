using System;

namespace DesignPatterns.Behavioral.Command
{
    public class Calculator
    {
        public int Result { get; set; }

        public void DoOperation(OperationType operationType, int operand)
        {
            switch (operationType)
            {
                case OperationType.Add:
                {
                    Result += operand;
                    break;
                }

                case OperationType.Sub:
                {
                    Result -= operand;
                    break;
                }

                case OperationType.Mul:
                {
                    Result *= operand;
                    break;
                }

                case OperationType.Div:
                {
                    Result /= operand;
                    break;
                }
            }
        }

        public void DisplayState()
        {
            Console.WriteLine($"Current state: {Result}");
        }
    }
}
