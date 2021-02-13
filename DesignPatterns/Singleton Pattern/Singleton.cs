using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns
{
    class Singleton
    {
        private static Singleton instainse = null;

        public int number;

        private Singleton() { }

        public static Singleton getInstains()
        {
            if (instainse == null)
            {
                instainse = new Singleton();              
            }

            return instainse;
                    
        }
    }
}
