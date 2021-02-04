using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns
{
    interface IEnemyShipEngine
    {
        string getEngine();
    }

    class ESBigEngine :IEnemyShipEngine 
    {
        public string getEngine()
        {
            return "200mph engine";
        }
    }

    class ESEngine : IEnemyShipEngine 
    { 
        public string getEngine()
        {
            return "100mph engine";
        }
    }


}
