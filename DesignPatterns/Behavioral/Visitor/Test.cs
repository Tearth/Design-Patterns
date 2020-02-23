using System.Collections.Generic;

namespace DesignPatterns.Behavioral.Visitor
{
    public static class Test
    {
        public static void Run()
        {
            var nodes = new List<INode>
            {
                new NodeNumber(10),
                new NodeNumber(20),
                new NodeString("test")
            };

            nodes.ForEach(p => p.Accept(new ValueDisplay()));
        }
    }
}
