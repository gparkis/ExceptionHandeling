using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_Handeling
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();
            for(int i=0; i<10; i++)
            {
                int multiplied = 19 * i;
                numbers.Add(multiplied);
                
            }

            try
            {
                Console.WriteLine("Enter a whole number");
                int userInput = Convert.ToInt32(Console.ReadLine());
                foreach (int number in numbers)
                {
                    int result = number / userInput;
                    Console.WriteLine(result);
                }
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("I WILL ALWAYS RUN SUCKA");
            }
           

            Console.Read();
        }
    }
}
