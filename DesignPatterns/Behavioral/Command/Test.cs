using System;

namespace DesignPatterns.Behavioral.Command
{
    public static class Test
    {
        public static void Run()
        {
            var calculator = new Calculator();
            var calculatorInvoker = new CalculatorInvoker();

            Console.WriteLine("Calculating...");

            calculatorInvoker.SetCommand(new AddCommand(calculator, 50));
            calculatorInvoker.Execute();
            calculator.DisplayState();

            calculatorInvoker.SetCommand(new MulCommand(calculator, 4));
            calculatorInvoker.Execute();
            calculator.DisplayState();

            calculatorInvoker.SetCommand(new AddCommand(calculator, -100));
            calculatorInvoker.Execute();
            calculator.DisplayState();

            calculatorInvoker.SetCommand(new MulCommand(calculator, 2));
            calculatorInvoker.Execute();
            calculator.DisplayState();

            Console.WriteLine();
            Console.WriteLine("History:");

            calculatorInvoker.DisplayHistory();

            Console.WriteLine();
            Console.WriteLine("Undo all operations:");

            calculatorInvoker.UndoAllOperations();
            calculator.DisplayState();
        }
    }
}
