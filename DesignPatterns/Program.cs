using System;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {

            //============  STRATERGY PATTERN   =============================
            /*=============================================== 
             
            Worker shan = new Worker();

            shan.Type = new butcher();

            Console.WriteLine(shan.startWork());

            shan.Type = new clerk();

            Console.WriteLine(shan.startWork());

            ==================================================*/



            //===========   FACTORY PATTERN    ================================
            /*================================================
             
            EnemyShipFactory shipFactory = new EnemyShipFactory();

            EnemyShip ship = shipFactory.makeEnemyShip("R");

            Console.WriteLine(ship.attack());

            ==================================================*/


        }
    }
}
