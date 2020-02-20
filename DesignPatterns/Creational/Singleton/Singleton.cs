using System;

namespace DesignPatterns.Creational.Singleton
{
    public static class Singleton
    {
        private static readonly Lazy<Target> Target;
        public static Target Instance => Target.Value;

        static Singleton()
        {
            Target = new Lazy<Target>(() => new Target());
        }
    }
}
