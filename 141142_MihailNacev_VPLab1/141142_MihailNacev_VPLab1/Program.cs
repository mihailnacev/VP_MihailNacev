using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _141142_MihailNacev_VPLab1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Lab11
            double firstNumber, secondNumber;
            string username;
            Console.WriteLine("Enter your name:");
            username = Console.ReadLine();
            Console.WriteLine("Welcome {0}!", username);
            Console.WriteLine("Now give me a number:");
            firstNumber = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Now give me another number:");
            secondNumber = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("The sum of {0} and {1} is {2}.",firstNumber,secondNumber,firstNumber+secondNumber);
            Console.WriteLine("The result of substracting {0} from {1} is {2}.",secondNumber,firstNumber,firstNumber-secondNumber);
            Console.WriteLine("The product of {0} and {1} is {2}.",firstNumber,secondNumber,firstNumber*secondNumber);
            Console.WriteLine("The result of dividing {0} by {1} is {2}.", firstNumber, secondNumber, firstNumber / secondNumber);
            Console.WriteLine("The remainder after dividing {0} by {1} is {2}.", firstNumber, secondNumber, firstNumber % secondNumber);
            Console.ReadKey();

        }
    }
}
