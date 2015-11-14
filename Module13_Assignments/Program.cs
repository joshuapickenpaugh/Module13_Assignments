using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module13_Assignments
{
    //1a:
    class Class1
    {
        static void Main(string[] args)
        {
            //1b:
            byte b = 127;
            char c = 'A';
            short s = 23;
            int i = 1;
            long l = 53;
            float f = 23.34f;
            double d = 23.42;
            bool bl = true;
            string str = "Hello World (from the string variable).";

            Console.WriteLine(str + " Value of byte is = {0}.", b);

            //1c:
            int[] ary = { 41, 52, 73, 84, 95 };

            Console.WriteLine("ForEach loop:");
            foreach (int number in ary)
            {
                Console.WriteLine(number);
            }

            Console.WriteLine();

            Console.WriteLine("While loop:");
            int counterWhileLoop = ary.Length;
            int j = 0;
            while (j < counterWhileLoop)
            {
                Console.WriteLine(ary[j]);
                j++;
            }

            Console.WriteLine();

            Console.WriteLine("For loop:");
            for (int x = 0; x < ary.Length; ++x)
            {
                Console.WriteLine(ary[x]);
            }

            Console.WriteLine();

            Console.WriteLine("Do loop:");
            int t = 0;
            do
            {
                Console.WriteLine(ary[t]);
                t++;
            }
            while (t < ary.Length);

            Console.WriteLine();

            //1d:
            Console.WriteLine("Press any key EXCEPT 'enter':");
            if (Console.ReadKey().Key != ConsoleKey.Enter)
            {
                Console.WriteLine("Good Job!");
            }
            else
            {
                Console.WriteLine("You pressed the ENTER key!");
            }

            //1e:
            AddNumbers(5, 7);

            Console.WriteLine("Press any key to EXIT.");
            Console.ReadKey();
        }

        static void AddNumbers(int x, int y)
        {
            int total = 0;
            total = x + y;
            Console.WriteLine(total);
        }
    }
}
