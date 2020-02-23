namespace DesignPatterns.Behavioral.TemplateMethod
{
    public abstract class Algorithm
    {
        public void DoOperation()
        {
            Step1();
            Step2();
            Step3();
        }

        public abstract void Step1();
        public abstract void Step2();
        public abstract void Step3();
    }
}
