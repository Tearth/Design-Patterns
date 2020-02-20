namespace DesignPatterns.Creational.Builder
{
    public class SaturnRocketBuilder : IRocketBuilder
    {
        private readonly Rocket _rocket;

        public SaturnRocketBuilder()
        {
            _rocket = new Rocket();
        }

        public void AddFirstStage()
        {
            _rocket.FirstStage = "S-IC";
        }

        public void AddSecondStage()
        {
            _rocket.SecondStage = "S-II";
        }

        public void AddThirdStage()
        {
            _rocket.ThirdStage = "S-IVB";
        }

        public void AddPayload()
        {
            _rocket.Payload = "CSM & LM";
        }

        public Rocket GetRocket()
        {
            return _rocket;
        }
    }
}
