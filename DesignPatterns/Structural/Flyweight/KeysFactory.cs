using System.Collections.Generic;

namespace DesignPatterns.Structural.Flyweight
{
    public class KeysFactory
    {
        private Dictionary<string, IKey> _keys;

        public KeysFactory()
        {
            _keys = new Dictionary<string, IKey>();
        }

        public IKey GetKey(string name)
        {
            IKey key;
            if (!_keys.ContainsKey(name))
            {
                switch (name)
                {
                    case "A":
                    {
                        key = new KeyA();
                        break;
                    }
                    case "B":
                    {
                        key = new KeyB();
                        break;
                    }
                    case "C":
                    {
                        key = new KeyC();
                        break;
                    }
                    default: return null;
                }

                _keys.Add(name, key);
            }
            else
            {
                key = _keys[name];
            }

            return key;
        }
    }
}
