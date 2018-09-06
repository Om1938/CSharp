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
            int n,key;
            Console.WriteLine("Enter Array Size");
            n = Convert.ToInt32(Console.ReadLine());
            array arr = new array(n);
            arr.setelements();
            
            Console.WriteLine("Max Element : " +arr.getMax());

            Console.Write("Enter the search element : ");
            key = Convert.ToInt32(Console.ReadLine());
            arr.searchKey(key);
            
            Console.ReadKey();
        }
    }
}
