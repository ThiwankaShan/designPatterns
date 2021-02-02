using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns
{
    interface IType
    {
        string work();

    }

    class butcher : IType {
    
        public string work()
        {
            return "butchering";
        }

        public string sound()
        {
            return "I'm a the butcherrr";
        }
    }

    class cachier : IType{

        public string work()
        {   
            return "Cachiering";
        }
    }

    class clerk : IType
    {

        public string work()
        {
            return "Clerking";
        }
    }

}
