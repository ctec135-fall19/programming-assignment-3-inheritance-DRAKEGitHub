using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob4
{
    class ParentClass
    {
        // getType setup 
        public GrandChildClass getType { get; internal set; }

        // create parent class method to be called by child classes
        public virtual void ParentClassMethod()
        {
            Console.WriteLine("ParentClass.ParentClassMethod");
        }
    }
}
