namespace DesignPatterns.Creational.Builder
{
    public class FalconRocketBuilder : IRocketBuilder
    {
        private readonly Rocket _rocket;

        public FalconRocketBuilder()
        {
            _rocket = new Rocket();
        }

        public void AddFirstStage()
        {
            _rocket.FirstStage = "F9 booster";
        }

        public void AddSecondStage()
        {
            _rocket.SecondStage = "F9 second stage";
        }

        public void AddThirdStage()
        {
            _rocket.ThirdStage = null;
        }

        public void AddPayload()
        {
            _rocket.Payload = "Dragon";
        }

        public Rocket GetRocket()
        {
            return _rocket;
        }
    }
}
