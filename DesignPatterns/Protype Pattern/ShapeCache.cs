using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns
{
    class ShapeCache
    {
        public Shape shape { get; set; } 
        

        public ShapeCache()
        {
            shape = new Circle();
            shape.name = "Circle";
            
        }
        public Shape getShape()
        {

            return (Shape)shape.Clone();
        }
    }
}
