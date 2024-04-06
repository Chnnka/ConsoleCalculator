using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1;
            int num2;
            int result;

            string answer;
            Console.WriteLine("Hello, Let's test our calculator");

            Console.WriteLine("Type your first Number");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Type your Second Number");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("What type of operation would you like to do?");
            Console.WriteLine("Please enter for additon, s for substraction, m for multiplication, or d for division");

            answer=Console.ReadLine();

            if (answer == "a")
            {
                result = num1 + num2;
            }
            else if (answer == "s")
            {
                result = num1 - num2;
            }
            else if (answer == "m")
            {
                result = num1 * num2;
            }
            else
            { 
                result = num1 / num2;
            }

            Console.WriteLine("Result"+result);
            Console.WriteLine("Thank you for using!!!");
            Console.ReadKey();
        }
    }
}
