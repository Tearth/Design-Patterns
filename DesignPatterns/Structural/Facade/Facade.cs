namespace DesignPatterns.Structural.Facade
{
    public class Facade
    {
        private readonly IService1 _service1;
        private readonly IService2 _service2;
        private readonly IService3 _service3;

        public Facade()
        {
            _service1 = new Service1();
            _service2 = new Service2();
            _service3 = new Service3();
        }

        public void DoOperation()
        {
            _service1.DoOperationA();
            _service2.DoOperationB();
            _service3.DoOperationC();
        }
    }
}
