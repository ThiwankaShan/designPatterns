using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Abstract_Factory_Pattern
{
    abstract class ShipFactoryBase
    {
        public abstract ShipBase getShip(ShipType shipType);
    }
}
