using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                temp = b; //Store in temp to not lose original value
                b = a % b; //if remainder = 0, it means HCF have been reached.
                a = temp; 
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
