/* 
Author: Allison Drake and Kyle McDonald
Date: 10/26/2019

Assignment 3: Problem 5

- Create a class with two fields, one a string and the other an int.
- Class implements IComparable interface
- create appropriate methods for the class
- Objects in the class should be ordered in the following manner:
- primary sort is alpha, secondary is largest first according to int
- Demoing that objects can be sorted according to requirement
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob5
{
    class Program
    {
        static void Main(string[] args)
        {
            // create objects to use
            MyClass sa1 = new MyClass("This", 4);
            MyClass sa2 = new MyClass("Hello", 600);
            MyClass sa3 = new MyClass("Goodbye", 101);
            MyClass sa4 = new MyClass("What?", 45);

            // test logic and plan for positive (a then b)
            Console.WriteLine(sa1.CompareTo(sa2));
            Console.WriteLine();

            // put test objects in array
            MyClass[] superDuperArray = new MyClass[4];
            superDuperArray[0] = sa1;
            superDuperArray[1] = sa2;
            superDuperArray[2] = sa3;
            superDuperArray[3] = sa4;

            // print each entry in the array 
            Console.WriteLine("Print superDuperArray before Sort");
            foreach (MyClass entry in superDuperArray)
                Console.WriteLine(entry);
            Console.WriteLine();

            // sort my array
            Array.Sort(superDuperArray);

            // print sorted array
            Console.WriteLine("Print superDuperArray after Sort");
            foreach (MyClass entry in superDuperArray)
                Console.WriteLine(entry);

        }
    }
}
