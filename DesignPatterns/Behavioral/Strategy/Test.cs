namespace DesignPatterns.Behavioral.Strategy
{
    public static class Test
    {
        public static void Run()
        {
            const int n = 40;

            var fibonacci = new Fibonacci(new FibonacciSimple());
            fibonacci.Calculate(n);

            fibonacci = new Fibonacci(new FibonacciWithCache());
            fibonacci.Calculate(n);
        }
    }
}
