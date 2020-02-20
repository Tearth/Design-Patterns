namespace DesignPatterns.Creational.Prototype
{
    public class Tiger : IAnimal
    {
        public int Age { get; set; }

        public Tiger(int age)
        {
            Age = age;
        }

        public IAnimal Clone()
        {
            return (IAnimal)MemberwiseClone();
        }
    }
}
