using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first number");
            int n1 = 0;
            int n2 = 0;
            while (!Int32.TryParse(Console.ReadLine(), out n1) || n1 == 0)
            {
                Console.WriteLine("Please enter a valid number");
            }
            Console.WriteLine("Enter second number");
            while (!Int32.TryParse(Console.ReadLine(), out n2) || n2 == 0)
            {
                Console.WriteLine("Please enter a valid number");
            }
            int sum = n1 + n2;
            int product = n1 * n2;
            int difference = n1 - n2;
            Console.WriteLine("Sum is: {0} and Product is: {1} and Difference is{2}", sum, product, difference);
            //  Console.WriteLine("Divide is:{0} ", div);
            Console.ReadKey();
        }
    }
}
