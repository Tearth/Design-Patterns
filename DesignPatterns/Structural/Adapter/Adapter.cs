namespace DesignPatterns.Structural.Adapter
{
    public class Adapter : OldImplementation
    {
        private readonly NewImplementation _newImplementation;

        public Adapter()
        {
            _newImplementation = new NewImplementation();
        }

        public override void Write(string name)
        {
            _newImplementation.Write(name, 25);
        }
    }
}
