namespace DesignPatterns.Behavioral.Strategy
{
    public class FibonacciSimple : IFibonacciAlgorithm
    {
        public ulong Calculate(int n)
        {
            if (n <= 1)
            {
                return (ulong)n;
            }

            return Calculate(n - 1) + Calculate(n - 2);
        }
    }
}
