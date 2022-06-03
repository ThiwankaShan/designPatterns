using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Abstract_Factory_Pattern
{
    internal class ShipFactoryProducer
    {
        public ShipFactoryBase getShipFactory(MilitaryType militaryType)
        {
            if (militaryType == MilitaryType.army)
            {
                return new ArmyShipFactory();
            }

            throw new NotImplementedException();
        }
    }
}
