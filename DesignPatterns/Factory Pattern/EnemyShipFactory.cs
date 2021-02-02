using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns
{
    class EnemyShipFactory
    {
        public EnemyShip makeEnemyShip(string type)
        {
            if (type == "U")
            {
                return new UFOEnemyShip();
            }
            else if (type == "R")
            {
                return new RocketEnemyShip();
            }
            else
            {
                return null;
            }
        }
    }
}
