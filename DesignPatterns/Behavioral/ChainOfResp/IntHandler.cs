using System;

namespace DesignPatterns.Behavioral.ChainOfResp
{
    public class IntHandler : ValueHandler
    {
        public IntHandler(ValueHandler successor = null) : base(successor)
        {

        }

        public override void Process(string value)
        {
            if (int.TryParse(value, out _))
            {
                Console.WriteLine($"{value} is int");
            }
            else
            {
                base.Process(value);
            }
        }
    }
}
