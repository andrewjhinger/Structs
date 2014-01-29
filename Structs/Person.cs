using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structs
{
    public struct Person
    {

        // Fields
        public string First;
        public string Middle;
        public string Last;

        // Constructor
        public Person(string first, string middle, string last)
        {
            First = first;
            Middle = middle;
            Last = last;
        }

        // Method
        public string FullName()
        {
            string result = "";
            if (!String.IsNullOrEmpty(First))
                result += First;
            if (!String.IsNullOrEmpty(Middle))
                result += result.Length > 0 ? " " + Middle : Middle;
            if (!String.IsNullOrEmpty(Last))
                result += result.Length > 0 ? " " + Last : Last;
            return result;
        }
    }
}
