using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns
{
    class UFOEnemyShip : EnemyShip
    {
       

        public UFOEnemyShip(IEnemyShipFactory shipFactory)
        {
            engine = shipFactory.installEngine();
        }
    }
}
