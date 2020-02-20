namespace DesignPatterns.Creational.Builder
{
    public interface IRocketBuilder
    {
        void AddFirstStage();
        void AddSecondStage();
        void AddThirdStage();
        void AddPayload();

        Rocket GetRocket();
    }
}
