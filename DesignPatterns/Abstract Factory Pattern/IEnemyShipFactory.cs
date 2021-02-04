using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns
{
    interface IEnemyShipFactory
    {
        IEnemyShipEngine installEngine();
    }
}
