using System;
using System.Collections.Generic;
using System.Text;

namespace Homework_Recursion
{
    class TestCode
    {
        private static string ArrayPermutation(int[] array, int elements = 3)
        {
            if (elements < 1)
            {
                return string.Empty;
            }
            else
            {
                /*if (elements % 2 == 1)
                {
                    Console.WriteLine(string.Join("", array));
                    return ArrayPermutation(new int[] { array[1], array[0], array[2] }, elements - 1) + " ";
                }
                else
                {
                    Console.WriteLine(string.Join("", array));
                    return ArrayPermutation(new int[] { array[0], array[2], array[1] }, elements - 1) + " ";
                }*/
                Console.WriteLine(string.Join("", array));
                int[] array2 = new int[] { array[0], array[2], array[1] };
                Console.WriteLine(string.Join("", array2));

                //return ArrayPermutation(new int[] { array[1], array[0], array[2] }, new int[] { array[0], array[2], array[1] }, elements - 1);
                //return ArrayPermutation(new int[] { array[1], array[0], array[2] }, elements - 1);
                return ArrayPermutation(new int[] { array2[1], array2[0], array2[2] }, elements - 1);
            }
        }


        private static int NumberCombination(int n, int m)
        {
            if ((m == 0 || n > 0) && (m == n & n >= 0))
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
            }

            /*if ((n + 1) == 1 || (m + 1) == 1 || n == m)
            {
                return 1;
            }
            else
            {
                return NumberCombination(n - 1, m - 1) + NumberCombination(n - 1, m);
            }*/

            /*if (1 <= n && n <= m - 1)
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
            }*/

            /*if (n == 0) return 1;
            if (m == 0) return 0;
            //return NumberCombination(n - 1, m - 1) + NumberCombination(n - 1, m);
            return NumberCombination(m - 1, n - 1) + NumberCombination(m, n - 1);*/
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
        private static string ArrayPermutationZZ(int[] array, int elements = -1)
        {
            if (elements == -1)
            {
                elements = 1;
                for (int i = 0; i < array.Length; i++)
                {
                    elements *= array.Length - i;
                }
                elements = elements / 2;
            }

            if (elements < 1)
            {
                return string.Join("", array); //string.Empty;
            }
            else
            {
                int[] array2 = new int[] { array[0], array[2], array[1] };

                Console.Write(string.Join("", array) + " ");
                Console.Write(string.Join("", array2) + " ");
                Console.Write(Environment.NewLine);

                return ArrayPermutationZZ(new int[] { array2[1], array2[0], array2[2] }, elements - 1);
            }
        }

        private static string ArrayPermutationDynamic(int[] array, int elements = -1)
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
                    return string.Join("", array) + " " + ArrayPermutationDynamic(new int[] { array[0], array[2], array[1] }, elements - 1);
                }
                else
                {
                    return string.Join("", array) + " " + ArrayPermutationDynamic(new int[] { array[1], array[0], array[2] }, elements - 1);
                }
            }
        }

        private static void ArrayPermutationDefault(int[] array, int elements = -1)
        {
            if (elements == -1)
            {
                elements = 1;
                for (int i = 0; i < array.Length; i++)
                {
                    elements *= array.Length - i;
                }
                elements = elements / 2;
            }

            if (elements > 0)
            {
                int[] array2 = new int[] { array[0], array[2], array[1] };

                Console.Write(string.Join("", array) + " ");
                Console.Write(string.Join("", array2) + " ");
                Console.Write(Environment.NewLine);

                ArrayPermutationDefault(new int[] { array2[1], array2[0], array2[2] }, elements - 1);
            }
        }
    }
}
