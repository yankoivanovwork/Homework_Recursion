using System;

namespace Homework_Recursion
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //zad1
            long nNumber;
            if (long.TryParse(Console.ReadLine(), out nNumber))
            {
                Console.WriteLine("Sum of first Nth natural numbers: " + NNaturalRecursion(nNumber));
            }

            //zad2
            int numberToTest;
            Console.Write("Enter a number to check if its prime: ");
            if (int.TryParse(Console.ReadLine(), out numberToTest))
            {
                Console.WriteLine(PrimeNumberCheck(numberToTest));
            }

            //zad3
            Console.WriteLine("Enter word or number to check if its a palindrome:");
            Console.WriteLine(PalindromeCheck(Console.ReadLine()));

            //zad4
            /*Console.WriteLine("Permutations Recursion");
            Console.WriteLine("Enter number 2-5: ");
            int numberPermutation;
            if (int.TryParse(Console.ReadLine(), out numberPermutation) && (numberPermutation >= 2 & numberPermutation <= 5))
            {

            }*/
            //Console.WriteLine(ArrayPermutation(new int[] { 5, 7, 3 }));
            //Console.WriteLine(ArrayPermutationV2(new int[] { 1, 2, 3 }));
            //end zad4

            //zad5
            int decimalNumber;
            Console.Write("Enter decimal number to convert into binary: ");
            if (int.TryParse(Console.ReadLine(), out decimalNumber))
            {
                Console.WriteLine(DecimalToBinary(decimalNumber));
            }

            //zad6
            int m;
            int n;
            Console.WriteLine("Enter numer m: ");
            if (int.TryParse(Console.ReadLine(), out m))
            {
                Console.WriteLine("Enter number n: ");
                if (int.TryParse(Console.ReadLine(), out n))
                {
                    Console.WriteLine(NumberCombination(m, n));
                }
            }
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

        /*private static string ArrayPermutation(int[] array, int elements = 3)
        {
            if (elements < 1)
            {
                return string.Empty;
            }
            else
            {
                int[] array2 = new int[] { array[0], array[2], array[1] };

                Console.Write(string.Join("", array) + " ");
                Console.Write(string.Join("", array2) + " ");

                return ArrayPermutation(new int[] { array2[1], array2[0], array2[2] }, elements - 1);
            }
        }

        private static string ArrayPermutationV2(int[] array, int elements = 6)
        {
            if (elements < 1)
            {
                return string.Empty;
            }
            else
            {
                if (elements % 2 == 1)
                {
                    Console.Write(string.Join("", array) + " ");
                    return ArrayPermutationV2(new int[] { array[1], array[0], array[2] }, elements - 1) + " ";
                }
                else
                {
                    Console.Write(string.Join("", array) + " ");
                    return ArrayPermutationV2(new int[] { array[0], array[2], array[1] }, elements - 1) + " ";
                }
            }
        }*/

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