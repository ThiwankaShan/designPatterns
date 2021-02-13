using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns
{
    class Robot
    {
        public string arm;

        public string head;

        public void attack()
        {
            Console.WriteLine($"robot with {arm } and {head}");
        }
    }
}
