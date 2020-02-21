using System;

namespace DesignPatterns.Behavioral.ChainOfResp
{
    public class BoolHandler : ValueHandler
    {
        public BoolHandler(ValueHandler successor = null) : base(successor)
        {

        }

        public override void Process(string value)
        {
            if (bool.TryParse(value, out _))
            {
                Console.WriteLine($"{value} is bool");
            }
            else
            {
                base.Process(value);
            }
        }
    }
}
