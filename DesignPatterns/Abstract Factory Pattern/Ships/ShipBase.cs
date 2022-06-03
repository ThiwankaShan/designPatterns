using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Abstract_Factory_Pattern
{
    internal class ShipBase
    {
        public int weaponDamage = 0;

        public int engineSpeed = 0;
        public void shoot()
        {
            if (engineSpeed == 0)
            {
                Console.WriteLine("no engine attached");
            }
            else
            {
                Console.WriteLine("shooting " + weaponDamage.ToString());
            }     
        }

        public void move()
        {
            if(weaponDamage == 0)
            {
                Console.WriteLine("no weapon attached");
            }
            else
            {
                Console.WriteLine("Moving " + engineSpeed.ToString());
            }        
        }

        public void setEngine(int speed)
        {
            engineSpeed = speed;
        }

        public void setWeapon(int damage)
        {
            weaponDamage = damage;
        }
    }
}
