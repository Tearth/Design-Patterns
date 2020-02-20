namespace DesignPatterns.Creational.Builder
{
    public class VehicleAssembly
    {
        public Rocket Construct(IRocketBuilder rocketBuilder)
        {
            rocketBuilder.AddFirstStage();
            rocketBuilder.AddSecondStage();
            rocketBuilder.AddThirdStage();
            rocketBuilder.AddPayload();

            return rocketBuilder.GetRocket();
        }
    }
}
