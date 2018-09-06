using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharp1
{
    class rectangle
    {
        public double len;
        public double wid;

        public double getArea() 
        {
            return len * wid;
        }

        public void display()
        {
            Console.WriteLine("Length: {0} \nWidth: {1} \nArea: {2}",len,wid,getArea());
        }
    }
}
