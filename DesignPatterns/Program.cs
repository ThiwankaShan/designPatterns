using DesignPatterns.Abstract_Factory_Pattern;
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
            //==================================================================

            ShipFactoryProducer producer = new ShipFactoryProducer();

            ShipFactoryBase factory = producer.getShipFactory(MilitaryType.army);

            ShipBase ship = factory.getShip(ShipType.fastBoat);

            ship.shoot();
            ship.move();
        //=====================================================================



        //===========   OBSERVER PATTERN    ================================
        /*==================================================================
        Subject subject = new Subject();
        StockObserver google = new Google(subject);
        StockObserver apple = new Apple(subject);

        subject.update();
        subject.update();
        subject.update();

        =====================================================================*/



        //===========   SINGLETON PATTERN    ================================
        /*==================================================================

        Singleton item = Singleton.getInstains();

        item.number = 1;

        Console.WriteLine($"first instaince {item.number}");

        Singleton item2 = Singleton.getInstains();

        Console.WriteLine($"second instaince {item2.number}");

        =====================================================================*/

        //===========   BUILDER PATTERN    ================================
        /*=================================================================
        IRobotBuilder robot = new OldRobotBuilder();

        IEngineer engineer = new Engineer(robot);

        Robot robot_1 = engineer.buildRobot();

        robot_1.attack();

        ===================================================================*/


        //===========   PROTOTYPE PATTERN    ================================
        /*================================================================= 

        ShapeCache cache = new ShapeCache();

        Shape shape1 = cache.getShape();
        Shape shape2 = cache.getShape();

        Console.WriteLine($" Shape 1 ID : {shape1.ID}");
        shape1.ID = 3;
        Console.WriteLine(" Changes shape 1 ID to 3 ");
        Console.WriteLine($" Shape 1 ID : {shape1.ID}");
        Console.WriteLine($" Shape 2 ID : {shape2.ID}\n");

        Console.WriteLine($" Shape 1 area : {shape1.area.area}");
        shape1.area.area = 60;
        Console.WriteLine(" Changed shape 1 area to 60");
        Console.WriteLine($" Shape 1 area : {shape1.area.area}");
        Console.WriteLine($" Shape 1 area : {shape2.area.area}");

        Console.WriteLine("Above result due to shallow copy (object(area) inside the shape object \ndoesnt get copied instead copy the memory location of the same area object");
        ===================================================================*/

    }
    }
}
