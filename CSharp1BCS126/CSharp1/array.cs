using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharp1
{
    class array
    {
        int[] arr;
        int maxELement;
        int size;
        public array()
        {
            this.size = 10;
            arr = new int[10];
        }
        public array(int size) 
        {
            this.size = size;
            arr = new int[size];
        }
        public void setelements()
        {
            Console.WriteLine("Enter " + size + " Elements");
            for (int i = 0; i < size; i++) 
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
                if (maxELement <= arr[i])
                {
                    maxELement = arr[i];
                }
            }
        }
        public int getMax() 
        {
            return maxELement;
        }
        public void searchKey(int key)
        {
            int count = 0;
            bool flag = false;
            int[] foundIndex = new int[size];

            for (int i = 0; i < size; i++)
            {
                if (arr[i] == key)
                {
                    foundIndex[count++] = i;
                    flag = true;
                }
            }

            if (flag == false)
            {
                Console.WriteLine("Not found");
            }
            else
            {
                Console.WriteLine(key + " found " + count +" times.");
                Console.Write("Location/s : ");

                for (int i = 0; i < count; i++)
                {
                    Console.Write(foundIndex[i]+" ");
                }
            }
        }

        
    }
}
