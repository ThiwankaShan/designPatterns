using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns
{
    class Google : StockObserver
    {
        public Google(Subject subject)
        {
            this.price = 0;
            this.subject = subject;
            this.subject.register(this);
        }

        public override void update()
        {
            this.price += 10;
            Console.WriteLine($"Google stock price : {this.price}");
        }
    }
}
