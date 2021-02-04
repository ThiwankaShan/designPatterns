using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns
{
    class Subject
    {
        private static int id = 0;
        public List<StockObserver> observers = new List<StockObserver>();

        public void register(StockObserver observer)
        {
            observers.Add(observer);
        }

        public void update()
        {
            id++;
            Console.WriteLine($"state changed id : {id} ");
            foreach(StockObserver observer in observers)
            {
                observer.update();
            }
        }
    }
}
