namespace DesignPatterns.Creational.Builder
{
    public class Rocket
    {
        public string FirstStage { get; set; }
        public string SecondStage { get; set; }
        public string ThirdStage { get; set; }
        public string Payload { get; set; }

        public override string ToString()
        {
            return $"{FirstStage} - {SecondStage} - {ThirdStage} - {Payload}";
        }
    }
}
