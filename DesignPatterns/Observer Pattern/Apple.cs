using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns
{
    class Apple : StockObserver
    {
        public Apple(Subject subject)
        {
            this.price = 0;
            this.subject = subject;
            this.subject.register(this);
        }

        public override void update()
        {
            this.price += 1 ;
            Console.WriteLine($"Apple stock price : {this.price}");
        }
    }
}
