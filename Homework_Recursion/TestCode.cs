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
    }
}
