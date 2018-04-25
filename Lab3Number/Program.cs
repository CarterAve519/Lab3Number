using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1;
            
            Console.WriteLine("Enter a number between 1 and 100");
            number1 = Convert.ToInt32(Console.ReadLine());
            if (number1 % 2 != 0)
            {
                Console.WriteLine($"{number1} Odd");
            }
            else if (number1 % 2 == 0 && number1 <= 25)
            {
                Console.WriteLine("Even and less that 25");
            }
            else if (number1 % 2 == 0 && number1 <= 60)
            {
                Console.WriteLine("Even");
            }
            else if (number1 % 2 == 0 && number1 > 60)
            {
                Console.WriteLine("Even");
            }
            else if (number1 % 2 != 0 && number1 > 60) //Not equel to 0 bc it's not odd
            {
                Console.WriteLine("Odd");
            }
        }
}   }