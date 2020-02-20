using System;

namespace DesignPatterns.Creational.Builder
{
    public static class Test
    {
        public static void Run()
        {
            var falconRocketBuilder = new FalconRocketBuilder();
            var saturnRocketBuilder = new SaturnRocketBuilder();
            var vehicleAssembly = new VehicleAssembly();

            var falconRocket = vehicleAssembly.Construct(falconRocketBuilder);
            var saturnRocket = vehicleAssembly.Construct(saturnRocketBuilder);

            Console.WriteLine($"Falcon: {falconRocket}");
            Console.WriteLine($"Saturn V: {saturnRocket}");
        }
    }
}
