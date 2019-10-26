using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob4
{
    // grandchild class inheritance from child class
    class GrandChildClass : ChildClass
    {
        // overried parentclass method
        public override void ParentClassMethod()
        {
            base.ParentClassMethod();
            Console.WriteLine("Child.ParentClassMethod");
        }
    }
}
