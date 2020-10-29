using System;

// Dylan McFarlin
// Date revised: 9-2-20
// MiniChallenge#2 - Add 2 Numbers
// Console application that asks the user for 2 numbers and gets the sum

namespace MiniChallenge_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("Welcome to the addition calculator.");
            Console.WriteLine("Enter a number:");
            string num1string = Console.ReadLine();
            Console.WriteLine("Enter a second number:");
            string num2string = Console.ReadLine();

            int num1 = Convert.ToInt16(num1string);
            int num2 = Convert.ToInt16(num2string);

            int sum = num1 + num2;

            Console.WriteLine("The sum is: " + sum);
        }
    }
}
