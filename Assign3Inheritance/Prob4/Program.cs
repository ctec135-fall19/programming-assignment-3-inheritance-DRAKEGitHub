/* 
Author: Allison Drake and Kyle McDonald
Date: 10/18/2019

Assignment 3: Problem 4

Create a hierarchy of classes than demonstrates polymorphic behavior:
- an array of base class type initialized with each member of each class
- show a method belonging to the base class is called from child instance
- demonstrate overriding base class method by a child and calling parent method
- Demonstrate use of "as" and "is" keywords
- Call method in a for loop iterating over the instances in an array
- Demonstrate a switch statement that responds to the type of object
- create an object of "object" type and initialize to a child type with method
- call method using casting
 */


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob4
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Array of base class type
            // array of base class
            ParentClass[] myArray = new ParentClass[3];
            myArray[0] = new ParentClass();
            myArray[1] = new ChildClass();
            myArray[2] = new GrandChildClass();

            // print array using a foreach
            Console.WriteLine("Print ParentClass Array: ");
            foreach (ParentClass entry in myArray)
            {
                Console.WriteLine("{0}: ", entry.GetType());
                entry.ParentClassMethod();
            }
            Console.WriteLine();
            #endregion

            #region switch and foreach print
            // foreach with switch, prints based on class type
            Console.WriteLine("Foreach with switch: ");
            foreach (ParentClass entry in myArray)
            {
                switch (entry)
                {
                    case GrandChildClass x:
                        Console.WriteLine("GrandChildClass");
                        break;
                    case ChildClass b:
                        Console.WriteLine("ChildClass");
                        break;
                    case ParentClass c:
                        Console.WriteLine("ParentClass");
                        break;
                    default:
                        Console.WriteLine("Default.");
                        break;
                }
            }
            Console.WriteLine();
            #endregion

            #region call parent method in a foreach loop through the array
            // uses as keyword and calls parent class from child class
            Console.WriteLine("Print foreach loop based on class:");
            foreach (ParentClass entry in myArray)
            {
                ChildClass c1 = entry as ChildClass;
                GrandChildClass g1 = entry as GrandChildClass;
                ParentClass p1 = entry as ParentClass;
                if (c1 == null)
                {
                    Console.Write("{0} is not a child class: ",
                        entry.GetType());
                    entry.ParentClassMethod();
                }

                else
                {
                    Console.Write("{0} is a child class that can call: ",
                        entry.GetType());
                    entry.ParentClassMethod();
                }
            }
            Console.WriteLine();
            #endregion

            #region create object of parentclass demonstrate is
            Console.WriteLine("Identify Child or Parent from myArray:");
            foreach (object o in myArray)
            {
                // if-else with is: children print trap line, else gets types
                if (o is ChildClass)
                {
                    Console.Write("Child class: ");
                    Console.WriteLine(o.GetType());
                }
                else
                {
                    Console.Write("Parent Class: ");
                    Console.WriteLine(o.GetType());
                }
            }
            Console.WriteLine();
            #endregion

            #region creates new instances of classes 
            ParentClass pc = new ParentClass();
            ChildClass cc = new ChildClass();
            ParentClass pccc = new ChildClass();

            // cast the grandchild class onto the parent class
            ParentClass p2 = new GrandChildClass();
            ((GrandChildClass)p2).ParentClassMethod();
            Console.WriteLine();

            // calls the parent method using the child method
            Console.WriteLine("Children calling the Parent Method:");
            pc.ParentClassMethod();
            cc.ParentClassMethod();
            pccc.ParentClassMethod();
            Console.WriteLine();

            // array of objects, with object set to parent class
            object[] AnotherArray = new object[3];
            AnotherArray[0] = pc;
            AnotherArray[1] = cc;
            AnotherArray[2] = pccc;

            Console.WriteLine("AnotherArray has pc {0}, cc {1}, and pccc {2}.", 
                AnotherArray);
            Console.WriteLine();
            #endregion
        }
    }
}
