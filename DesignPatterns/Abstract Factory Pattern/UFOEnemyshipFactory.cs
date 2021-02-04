using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns
{
    class UFOEnemyshipFactory : IEnemyShipFactory
    {
        
        public IEnemyShipEngine installEngine()
        {
            return new ESEngine();
        }
    }
}
