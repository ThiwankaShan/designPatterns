using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns
{
    class Worker : User
    {

        private string _title;

        private IType _type;

        public string Title {
            get
            {
                return _title;
            }
            set
            {
                _title = value;
            }
        }

        public IType Type {
            get { 
                return _type;
            }
            set
            {
                _type = value;
            }
            }


        public Worker()
        {
            _type = new clerk();
        }

        public string startWork()
        {
            return _type.work();
        }
    }
}
