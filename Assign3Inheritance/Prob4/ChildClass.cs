using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob4
{
    class ChildClass : ParentClass
    {
        // child override calling parent class method
        public override void ParentClassMethod()
        {
            Console.WriteLine("ChildClass.ParentClassMethod");
        }
    }
}
