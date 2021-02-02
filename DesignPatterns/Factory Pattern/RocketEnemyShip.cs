using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns
{
    class RocketEnemyShip : EnemyShip
    {
        public RocketEnemyShip()
        {
            name = "rocket enemy ship";
            damage = "50";
            speed = "100";
        }
    }
}
