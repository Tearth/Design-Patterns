using System;

namespace DesignPatterns.Structural.Proxy
{
    public class EngineProxy : IEngine
    {
        public bool Running
        {
            get => _engine.Value.Running;
            set => _engine.Value.Running = value;
        }

        private readonly Lazy<IEngine> _engine;

        public EngineProxy()
        {
            _engine = new Lazy<IEngine>(() => new Engine());
        }

        public void Start()
        {
            if (_engine.Value.Running)
            {
                Console.WriteLine("Engine is already working");
            }
            else
            {
                _engine.Value.Start();
            }
        }

        public void Stop()
        {
            if (!_engine.Value.Running)
            {
                Console.WriteLine("Engine is already stopped");
            }
            else
            {
                _engine.Value.Stop();
            }
        }
    }
}
