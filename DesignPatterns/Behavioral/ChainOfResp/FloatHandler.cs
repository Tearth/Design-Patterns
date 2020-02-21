using System;

namespace DesignPatterns.Behavioral.ChainOfResp
{
    public class FloatHandler : ValueHandler
    {
        public FloatHandler(ValueHandler successor = null) : base(successor)
        {

        }

        public override void Process(string value)
        {
            if (float.TryParse(value, out _))
            {
                Console.WriteLine($"{value} is float");
            }
            else
            {
                base.Process(value);
            }
        }
    }
}
