using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Abstract_Factory_Pattern
{
    internal class ArmyShipFactory : ShipFactoryBase
    {
        public override ShipBase getShip(ShipType shipType)
        {
            if (shipType == ShipType.fastBoat)
            {
                var ship = new FastBoat();

                ship.setWeapon(20);

                ship.setEngine(400);

                return ship;
            }
            else
            {
                throw new Exception("Invalid ship type");
            }
        }
    }
}
