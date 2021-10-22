using System;

namespace FindHCFandLCM
{
    class Program
    {
        static void Main(string[] args)
        {
            int temp,a,b,HCF,LCM;

            Console.WriteLine("Enter first number: ");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number: ");
            int y = int.Parse(Console.ReadLine());

            //No change to original input
            a = x;
            b = y;

            //Finding HCF
            while (b != 0)
            {
                temp = b;
                //Console.WriteLine($"temp {temp}"); //for testing
                b = a % b;
                //Console.WriteLine($"b {b}"); //for testing
                a = temp;
                //Console.WriteLine($"a {a}"); //for testing
            }

            HCF = a;
            LCM = (x * y) / HCF; 

            Console.WriteLine("HCF is " + HCF);
            Console.WriteLine("LCM is " + LCM);

            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
