using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = {10,20,30,40,50};

            foreach(int i in myArray)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();
        }
    }
}
