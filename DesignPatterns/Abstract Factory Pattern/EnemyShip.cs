using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns
{
    abstract class EnemyShip
    {
        public string name;

        public string damage;

        public string speed;

        public IEnemyShipEngine engine;

        public string attack()
        {
            return $"{name} does {damage} damage";
        }

        public string move()
        {
            return $"{name} sailing at a speed of {speed}";
        }

        public string upgrade()
        {
            return engine.getEngine();
        }
        
    }
}
