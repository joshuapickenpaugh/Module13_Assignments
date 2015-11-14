using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module13_Assignments
{
    class Class1
    {
        static void Main(string[] args)
        {
            byte b = 127;
            char c = 'A';
            short s = 23;
            int i = 1;
            long l = 53;
            float f = 23.34f;
            double d = 23.42;
            bool bl = true;
            string str = "Hello World (from the string variable).";


            i = (int)b + 1;

            double d2 = 23.34;
            int i2 = 23;

            int[] ary = { 41, 52, 73, 84, 95 };
            int counterWhileLoop = ary.Length;
            int j = 0;
            while (j < counterWhileLoop)
            {
                Console.WriteLine(ary[j]);
                j++;
            }

            Console.WriteLine();

            for (int x = 0; x < ary.Length; ++x)
            {
                Console.WriteLine(ary[x]);
            }

            Console.WriteLine(str + " Value of byte is = {0}.", b);
            Console.ReadKey();
        }
    }
}
