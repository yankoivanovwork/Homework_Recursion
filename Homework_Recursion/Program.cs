using System;
using System.Linq;

namespace Homework_Recursion
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //zad1
            long nNumber;
            Console.Write("Enter number for sum of Nth natural number: ");
            if (long.TryParse(Console.ReadLine(), out nNumber))
            {
                Console.WriteLine("Sum of first Nth natural numbers: " + NNaturalRecursion(nNumber));
            }
            Console.Write(Environment.NewLine);

            //zad2
            int numberToTest;
            Console.Write("Enter a number to check if its prime: ");
            if (int.TryParse(Console.ReadLine(), out numberToTest))
            {
                Console.WriteLine("Result: " + PrimeNumberCheck(numberToTest));
            }
            Console.Write(Environment.NewLine);

            //zad3
            Console.Write("Enter word or number to check if its a palindrome:");
            Console.WriteLine("Result: " + PalindromeCheck(Console.ReadLine()));
            Console.Write(Environment.NewLine);

            //zad4
            Console.WriteLine("Permutations Recursion");
            Console.Write("Enter number 2-5: ");
            int numberPermutation;
            if (int.TryParse(Console.ReadLine(), out numberPermutation) && (numberPermutation >= 2 & numberPermutation <= 5))
            {
                int[] numbersArray = new int[numberPermutation];
                for (int i = 0; i < numberPermutation; i++)
                {
                    Console.Write("Enter number "+(i + 1)+": ");
                    int.TryParse(Console.ReadLine(), out numbersArray[i]);
                }
                if (numberPermutation == 3)
                {
                    Console.WriteLine("Result: " + ArrayPermutation3Elements(numbersArray));
                }
                else if (numberPermutation == 4)
                {

                }
                else
                {
                    //numberPermutation == 5
                }
            }
            Console.Write(Environment.NewLine);

            //zad5
            int decimalNumber;
            Console.Write("Enter decimal number to convert into binary: ");
            if (int.TryParse(Console.ReadLine(), out decimalNumber))
            {
                Console.WriteLine("Result: " + DecimalToBinary(decimalNumber));
            }
            Console.Write(Environment.NewLine);

            //zad6
            int m;
            int n;
            Console.WriteLine("Number of combinations of n-different elements for m");
            Console.Write("Enter numer m: ");
            if (int.TryParse(Console.ReadLine(), out m))
            {
                Console.Write("Enter number n: ");
                if (int.TryParse(Console.ReadLine(), out n))
                {
                    Console.WriteLine("Result: " + NumberCombination(m, n));
                }
            }
            Console.Write(Environment.NewLine);
        }

        private static long NNaturalRecursion(long number)
        {
            if (number < 2)
            {
                return 1;
            }
            else
            {
                return number + NNaturalRecursion(number - 1);
            }
        }

        private static string PrimeNumberCheck(int number, int count = 2)
        {
            if (count > 3)
            {
                return "Prime number";
            }
            else
            {
                if (number % count == 0)
                    return "NOT prime";
                else
                    return PrimeNumberCheck(number, count + 1);
            }
        }

        private static string PalindromeCheck(string line)
        {
            if (line.Length < 2)
            {
                return "Is a Palindrome";
            }
            else
            {
                if (line[0] == line[line.Length - 1])
                {
                    return PalindromeCheck(line.Substring(1, line.Length - 2));
                }
                else
                {
                    return "NOT a palindrome";
                }
            }
        }

        private static string ArrayPermutation3Elements(int[] array, int elements = -1)
        {
            if (elements == -1)
            {
                elements = 1;
                for (int i = 0; i < array.Length; i++)
                {
                    elements *= array.Length - i;
                }
            }

            if (elements < 1)
            {
                return string.Empty;
            }
            else
            {
                if (elements % 2 == 0)
                {
                    return string.Join("", array) + " " + ArrayPermutation3Elements(new int[] { array[0], array[2], array[1] }, elements - 1);
                }
                else
                {
                    return string.Join("", array) + " " + ArrayPermutation3Elements(new int[] { array[1], array[0], array[2] }, elements - 1);
                }
            }
        }

        private static int DecimalToBinary(int number)
        {
            if (number < 1)
            {
                return 0;
            }
            else
            {
                return (number % 2 + 10 * DecimalToBinary(number / 2));
            }
        }

        private static int NumberCombination(int m, int n)
        {
            if (1 <= n && n <= m - 1)
            {
                return NumberCombination(m - 1, n - 1) + NumberCombination(m - 1, n);
            }
            else if (m > 0)
            {
                return 1;
            }
            else
            {
                return 0;
            }

            /*if (n == 0) return 1;
            if (m == 0) return 0;
            return NumberCombination(m - 1, n - 1) + NumberCombination(m - 1, n);*/

            /*if (m == 0)
            {
                return 1;
            }
            else if (m > n && n >= 0)
            {
                return 0;
            }
            else
            {
                return NumberCombination(m - 1, n - 1) + NumberCombination(m, n - 1);
            }*/
        }
    }
}