using System.Collections.Generic;

namespace DesignPatterns.Behavioral.Strategy
{
    public class FibonacciWithCache : IFibonacciAlgorithm
    {
        private readonly Dictionary<int, ulong> _cache;

        public FibonacciWithCache()
        {
            _cache = new Dictionary<int, ulong>();
        }

        public ulong Calculate(int n)
        {
            if (n <= 1)
            {
                return (ulong)n;
            }

            if (_cache.ContainsKey(n))
            {
                return _cache[n];
            }

            var result = Calculate(n - 1) + Calculate(n - 2);
            _cache[n] = result;

            return result;
        }
    }
}
