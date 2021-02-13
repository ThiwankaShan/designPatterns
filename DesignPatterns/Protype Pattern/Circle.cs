using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns
{
    class Circle : Shape
    {
        public Circle()
        {
            id++;
            this.ID = id;
            Area a = new Area();
            a.area = 20;
            area = a;
        }
    }
}
