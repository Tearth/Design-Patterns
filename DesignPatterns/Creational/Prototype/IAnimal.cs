namespace DesignPatterns.Creational.Prototype
{
    public interface IAnimal
    {
        int Age { get; set; }
        IAnimal Clone();
    }
}
