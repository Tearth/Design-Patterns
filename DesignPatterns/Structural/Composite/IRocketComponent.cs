namespace DesignPatterns.Structural.Composite
{
    public interface IRocketComponent
    {
        string Name { get; set; }

        void Add(IRocketComponent component);
        void Remove(IRocketComponent component);
        void Display(int indentation);
    }
}
