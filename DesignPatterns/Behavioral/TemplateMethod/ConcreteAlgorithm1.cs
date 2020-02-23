using System;

namespace DesignPatterns.Behavioral.TemplateMethod
{
    public class ConcreteAlgorithm1 : Algorithm
    {
        public override void Step1()
        {
            Console.WriteLine("Concrete algorithm 1: Step 1");
        }

        public override void Step2()
        {
            Console.WriteLine("Concrete algorithm 1: Step 2");
        }

        public override void Step3()
        {
            Console.WriteLine("Concrete algorithm 1: Step 3");
        }
    }
}
