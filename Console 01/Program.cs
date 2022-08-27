using System;

namespace Console_01
{
    class Program
    {
        public class myclass
        {
            static float proE = 20.1f;
            public static void Main(string[] args)
            {
                int a = 3;
                int b = 5;

                Console.WriteLine(a + b);
                writeline();
                Console.ReadLine();
            }
            public static void writeline()
            {
                Console.WriteLine("I am called from a method");
                Console.Read();
            }

        }

        
    }
}
