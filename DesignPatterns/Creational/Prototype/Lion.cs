namespace DesignPatterns.Creational.Prototype
{
    public class Lion : IAnimal
    {
        public int Age { get; set; }

        public Lion(int age)
        {
            Age = age;
        }

        public IAnimal Clone()
        {
            return (IAnimal) MemberwiseClone();
        }
    }
}
