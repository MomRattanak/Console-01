using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 5;
            int num2 = 3;
            int num3;

            //
            num3 = -num1;
            Console.WriteLine("num1 is {0}", num1);

            bool isSunny = true;
            Console.WriteLine(" Is Sunny? {0}", isSunny);

            bool Equal =true;
            Equal = num1 == num2;
            Console.WriteLine("Is num1==num2? {0}", Equal);

            bool Great = true;
            Great = num1 > num2;
            Console.WriteLine("Is num1>num2? {0}", Great);

            bool EG = true;
            EG = Equal && Great;
            Console.WriteLine("EG {0}", EG);

            bool EH = true;
            EH = Equal || Great;
            Console.WriteLine("EG {0}", EH);

            Console.ReadKey();
        }
    }
}
