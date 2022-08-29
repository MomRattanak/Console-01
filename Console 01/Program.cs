using System;

namespace Console_01
{
    class Program
    {
        public class myclass
        {
            static int num1, num2;
            static float proE = 20.1f;
            public static void Main(string[] args)
            {
                
                string a = Console.ReadLine();
                Console.WriteLine(a);
                string b = Console.ReadLine();
                Console.WriteLine(b);
                //Convert
                int num1 = int.Parse(a);
                int num2 = int.Parse(b);


                //Console.WriteLine(a + b);
                Console.WriteLine(div(10, 30));
                Console.WriteLine(Add(30, 20));
                //Console.WriteLine(na(rattanak, sreynich));
                int result = Add(10, 20);
                Console.WriteLine(result);
                suu();
                sum();
                writeline();
                dod();
                Console.Read();
            }
            public static void writeline()
            {
                Console.WriteLine("I am called from a method");
                Console.Read();
            }
            public static void sum()
            {
                Console.WriteLine("Sum of"+(Add(3,7)));
            }
            public static void suu(string names = "Srey Nich")
            {
                Console.WriteLine(names);
                
            }
            public static int Add(int num1, int num2)
            {

                return num1 + num2;
            }
            public static float div(float num1, float num2)
            {
                return num1/ num2;
            }
            public static void dod()
            {
                Console.WriteLine("I Love You.");
                Console.Read();
            }
        }

        
    }
}
