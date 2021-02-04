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
            /*==================================================================

            UFOEnemyshipFactory shipFactory = new UFOEnemyshipFactory();

            EnemyShip ship = new UFOEnemyShip(shipFactory);

            Console.WriteLine(ship.upgrade());

            =====================================================================*/

            //===========   OBSERVER PATTERN    ================================
            /*==================================================================
            Subject subject = new Subject();
            StockObserver google = new Google(subject);
            StockObserver apple = new Apple(subject);

            subject.update();
            subject.update();
            subject.update();

            =====================================================================*/

        }
    }
}
