using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/*
 * Class with Public only vars
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
*/

/*
 * Class with internal only vars
namespace CSharp1
{
    class rectangle
    {
        internal double len;
        internal double wid;

        public double getArea()
        {
            return len * wid;
        }

        public void display()
        {
            Console.WriteLine("Length: {0} \nWidth: {1} \nArea: {2}", len, wid, getArea());
        }
    }
}
*/

/*
 * Class with internal only vars
 */
namespace CSharp1
{
    class parentRectangle 
    {
        protected double len;
        protected double wid;
    }
    class rectangle : parentRectangle
    {       

        public rectangle(double p, double p_2)
        {
            // TODO: Complete member initialization
            this.len = p;
            this.wid = p_2;
        } 

        public double getArea()
        {
            return len * wid;
        }        

        public void display()
        {
            Console.WriteLine("Length: {0} \nWidth: {1} \nArea: {2}", len, wid, getArea());
        }
    }
}