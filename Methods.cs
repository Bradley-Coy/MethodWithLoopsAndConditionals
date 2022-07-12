using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace MethodsWithLoopsAndConditionals
{
    internal class Methods
    {
        public static void PrintNumbers1000()
        {
            for (int i = 1000; i >= -1000; i--)
            {
                Console.WriteLine(i);
            }
        }

        public static void PrintNumbers999()
        {
            for (int i = 3; i <= 999; i += 3)
            {
                Console.WriteLine(i);
            }
        }

        public static void IsEqualOrNot(int x, int y)
        {
            if (x == y)
            {
                Console.WriteLine("These two numbers are equal");
            }

            else
            {
                Console.WriteLine("These numbers are not equal");
            }    
        }

        public static void EvenOrOdd(int x)
        {
            if (x % 2 == 0)
            {
                Console.WriteLine("This is an even number");
            }

            else
            {
                Console.WriteLine("This is an odd number");
            }
        }

        public static void IsPositiveOrNegative(int x)
        {
            if (x > 0)
            {
                Console.WriteLine("This number is positive");
            }

            else if (x == 0)
            {
                Console.WriteLine("This number is 0");
            }
            else
            {
                Console.WriteLine("This number is negative");
            }
        }

        public static void CanVote()
        {
            Console.Write("Please enter your age: ");
            var age = Convert.ToInt32(Console.ReadLine());

            if (age >= 18)
            {
                Console.WriteLine("You are old enough to vote");
            }

            else
            {
                Console.WriteLine("You are not old enough to vote");
            }
        }

        public static void InputCheck()
        {
            var num = Convert.ToInt32(Console.ReadLine());

            if (num >= -10 && num <= 10)
            {
                Console.WriteLine($"{num}" is in range);
            }
        }

        public static void MultiplicationTable(int number)
        {
            for (int i = 1; i <= 12; i++)
            {
                Console.WriteLine($"{i} * {number} = {i * number}");
            }
        }
    }

}