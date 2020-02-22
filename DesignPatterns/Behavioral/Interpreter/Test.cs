using System;

namespace DesignPatterns.Behavioral.Interpreter
{
    public static class Test
    {
        public static void Run()
        {
            var tree = new AddExpression();
            var mulExpression = new MulExpression();
            mulExpression.AddChild(new NumberExpression(3));
            mulExpression.AddChild(new NumberExpression(5));
            tree.AddChild(mulExpression);
            tree.AddChild(new NumberExpression(2));

            var result = tree.Interpret();
            Console.WriteLine($"2 + 3 * 5 = {result}");
        }
    }
}
