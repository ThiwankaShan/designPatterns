using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns
{
    abstract class StockObserver
    {
        public Subject subject;

        public double price;

        abstract public void update();

        
    }
}
