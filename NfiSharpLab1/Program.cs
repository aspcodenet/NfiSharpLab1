using System;
using System.Runtime.InteropServices;

namespace NfiSharpLab1
{
    class Program
    {
        static void Main(string[] args)
        {
            char ch = 'S';
            int i = 12;

            i = i + 1;
            i += 4;
            i++;

            i = i - 1;
            i--;



            decimal price = 12.12m;
            string namn1 = "Hello ";

            namn1 = namn1 + " World";


            namn1 += "wORLD";

            DateTime dt = DateTime.Now;
            bool b = true; //false

            float f = 12.23f;
            //float ff = "3121231323123";
            double d = 12.23;

            Console.WriteLine("Vad heter du?");
            
            string namn = Console.ReadLine();
            Console.WriteLine("Hej " + namn);

            Console.WriteLine("RAST TILL 14:05");

            Console.WriteLine("2021-05-10");
            Console.WriteLine("2021");
            Console.WriteLine(2021);
            Console.WriteLine(2021-05-10);

            





        }
    }
}

