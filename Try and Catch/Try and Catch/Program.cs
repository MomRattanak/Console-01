using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Try_and_Catch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Inter a number");
            string UserInput = Console.ReadLine();
            try
            {
                int num = int.Parse(UserInput);
            }
            catch (FormatException)
            {

                Console.WriteLine("Incorrect Number. Please Inter again...");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Long number or Short");
            }
            catch(ArgumentNullException)
            {
                Console.WriteLine("Null Number");
            }
            finally
            {
                Console.WriteLine("This is call anyways");
            }

           
            Console.ReadKey();
        }
    }
}
