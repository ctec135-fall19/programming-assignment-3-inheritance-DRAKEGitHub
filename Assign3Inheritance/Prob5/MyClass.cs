using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob5
{
    class MyClass : IComparable
    {
        // fields
        private string firstString;
        private int firstInt;

        // properties to be able to access private members
        public string FirstString
        {
            get { return firstString; }
            set { firstString = value; }
        }

        public int FirstInt
        {
            get { return firstInt; }
            set { firstInt = value; }
        }

        // constructor
        public MyClass(string str, int x)
        {
            this.firstInt = x;
            this.firstString = str;
        }


        #region Interface method
        // sort alpha and then largest first according to int
        public int CompareTo(object obj)
        {
            // case obj to MyClass type
            MyClass mine = obj as MyClass;

            // for successful make comparisons
            if (mine != null)
            {
                // return corresponding value to make comparison
                if (string.Compare(this.FirstString, mine.FirstString) < 0) 
                    return -1;
                if (string.Compare(this.FirstString, mine.FirstString) > 0) 
                    return 1;
                else // strings are the same and compare ints
                {
                    if (this.FirstInt < mine.FirstInt) return -1;
                    if (this.FirstInt > mine.FirstInt) return 1;
                    else return 0;
                }
            }
            else
                throw new ArgumentException("Parameter is not a MyClass " +
                    "object.");
        }
        #endregion

        // override toString to be able to print object
        public override string ToString()
        {
            return $"{firstString}, {firstInt}";
            ;
        }
    }
}