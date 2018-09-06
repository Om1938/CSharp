using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharp1
{
    class Printdata
    {
        public void print(int i) {
            Console.WriteLine("Printing int : {0}", i);
        }
        public void print(double i)
        {
            Console.WriteLine("Printing double : {0}", i);
        }
        public void print(string i)
        {
            Console.WriteLine("Printing string : {0}", i);
        }
    }
    
}
