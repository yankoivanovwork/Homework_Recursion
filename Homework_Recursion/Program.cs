using System;

namespace Homework_Recursion
{
    public class Program
    {
        public static void Main(string[] args)
        {
            long number = 0;

            //zad1
            number = 5;
            Console.WriteLine("Sum of first Nth natural numbers: " + NNaturalRecursion(number));
            
            //zad2
            number = 17;
            Console.WriteLine("Prime number check: " + (PrimeNumberCheck(number, number / 2) == 1 ? "Prime number" : "NOT PRIME"));

            //zad3
            Console.WriteLine(PalindromeCheck("madam"));

            //zad4 - 3 do 5 digits
            Console.WriteLine("Permutations Recursion");
            Console.WriteLine(ArrayPermutation(new int[] { 5, 7, 3 }));

            Console.WriteLine(ArrayPermutationV2(new int[] { 1, 2, 3 }));
            //end zad4
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

        private static long PrimeNumberCheck(long number, long count)
        {
            if (count < 2)
            {
                return 1;
            }
            else
            {
                if (number % count == 0)
                    return 0;
                else
                    return PrimeNumberCheck(number, count - 1);
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

        private static string ArrayPermutation(int[] array, int elements = 3)
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
        }

        private static void DecimalToBinary(decimal number)
        {

        }
    }
}