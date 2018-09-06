using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharp1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            /*
             * main for array.cs
             * 
            int n,key;
            Console.WriteLine("Enter Array Size");
            n = Convert.ToInt32(Console.ReadLine());
            array arr = new array(n);
            arr.setelements();
            
            Console.WriteLine("Max Element : " +arr.getMax());

            Console.Write("Enter the search element : ");
            key = Convert.ToInt32(Console.ReadLine());
            arr.searchKey(key);            
             */
            
            /*
             * main for Rectangle.cs for public and internal vars
             
            rectangle r = new rectangle();
            r.len = 4.5;
            r.wid = 4.5;
            r.display();
            */
            
            /*
             * main for Rectangle.cs protected vars
             */
            rectangle r = new rectangle(4.5, 4.5);
            r.display();

            Console.ReadKey();
        }
    }
}
