using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericDemo
{
    class GenericMethod
    {
        public static void Display<T>(T[] test)
        {
            for (int i = 0; i < test.Length; i++)
            {
                Console.Write(test[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
