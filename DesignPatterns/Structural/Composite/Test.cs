namespace DesignPatterns.Structural.Composite
{
    public static class Test
    {
        public static void Run()
        {
            IRocketComponent rocket = new RocketComposite("Falcon 9");

            IRocketComponent firstStage = new RocketComposite("First stage");
            firstStage.Add(new RocketElement("9 engines"));
            firstStage.Add(new RocketElement("Tanks"));
            firstStage.Add(new RocketElement("Interstage"));

            IRocketComponent secondStage = new RocketComposite("Second stage");
            secondStage.Add(new RocketElement("1 engine"));
            secondStage.Add(new RocketElement("Tanks"));
            secondStage.Add(new RocketElement("Payload"));

            rocket.Add(firstStage);
            rocket.Add(secondStage);

            rocket.Display(0);
        }
    }
}
