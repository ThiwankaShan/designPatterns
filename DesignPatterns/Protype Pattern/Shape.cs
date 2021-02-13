using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns
{
    abstract class Shape : ICloneable
    {
        public string name { get; set; }
        public string type { get; set; }
        public static int id { get; set; }
        public int ID { get; set; }
        public Area area { get; set; }

        public void show (){
            Console.WriteLine($"name of the shape : {name}");
        }

        public object Clone()
        {
            Object clone = null;

            try
            {
                clone = base.MemberwiseClone();
            }
            catch
            {
                Console.WriteLine("Failed to clone");
            }
            

            return clone;
        }
    }
}
