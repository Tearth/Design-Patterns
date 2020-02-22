using System;
using System.Diagnostics;

namespace DesignPatterns.Behavioral.Strategy
{
    public class Fibonacci
    {
        private readonly IFibonacciAlgorithm _algorithm;

        public Fibonacci(IFibonacciAlgorithm algorithm)
        {
            _algorithm = algorithm;
        }

        public void Calculate(int n)
        {
            var stopwatch = Stopwatch.StartNew();
            var result = _algorithm.Calculate(n);
            var time = (ulong)stopwatch.Elapsed.TotalMilliseconds;

            Console.WriteLine($"{_algorithm.GetType().Name}({n}) = {result}, calculated in {time} ms");
        }
    }
}
