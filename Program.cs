using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_11
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaring variables
            ulong[] a = new ulong [100];
            ulong num = 0;

            a[0] = 0;
            a[1] = 1;

            //Calculated
            for (int i = 1; i < 99; i++)
            {

                a[i + 1] = a[i] + num;
                num = a[i];
                
            }

            //Showing results
            Console.WriteLine(" La serie Fibonacci: ");
            for (int j = 0; j < 100; j++)
            {
                Console.Write(" {0}", a[j]);
            }

            Console.ReadKey();
        }
    }
}
