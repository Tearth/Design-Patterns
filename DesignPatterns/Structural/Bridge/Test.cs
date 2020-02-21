namespace DesignPatterns.Structural.Bridge
{
    public static class Test
    {
        public static void Run()
        {
            IEngine smallEngine = new SmallEngine();
            IEngine bigEngine = new BigEngine();

            IControlPanel controlPanel = new ControlPanel(smallEngine);
            IControlPanel extendedControlPanel = new ExtendedControlPanel(smallEngine);

            controlPanel.DisplayInfo();
            extendedControlPanel.DisplayInfo();

            controlPanel.Engine = bigEngine;
            extendedControlPanel.Engine = bigEngine;

            controlPanel.DisplayInfo();
            extendedControlPanel.DisplayInfo();
        }
    }
}
