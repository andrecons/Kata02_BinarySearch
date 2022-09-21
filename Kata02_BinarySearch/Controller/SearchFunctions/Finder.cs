using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata02_BinarySearch.Controller.BinaryFunctions
{
    public class Finder
    {

        public static int AskValue()
        {
            Console.Write("Write a value between 0 and 499 to find the index: ");
            int value = 0;

            try
            {
                value = Int16.Parse(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return value;
        }

        public static int IndexByLinear(int[] array, int userValue)
        {
            int index = -1;

            for (int i = 0; i < array.Length; i++)
            {
                if (userValue == array[i])
                {
                    index = i;
                }
            }
            return index;
        }

        public static int IndexByBinaryIterative(int[] array, int userInput)
        {
            int min = 0;
            int max = array.Length - 1;
            while (min <= max)
            {
                int mid = (min + max) / 2;

                if (userInput == array[mid])
                {
                    return (mid);
                }
                else if (userInput < array[mid])
                {
                    max = mid - 1;
                }
                else
                {
                    min = mid + 1;
                }
            }
            //return -1 when the value is not found
            return -1;
        }

        public static int IndexByBinaryRecursive(int[] array, int userInput, int min, int max)
        {

            if (min > max)
            {
                return -1;
            }
            else
            {

                int mid = (min + max) / 2;
                if (userInput == array[mid])
                {
                    return (mid);
                }
                else if (userInput < array[mid])
                {
                    return IndexByBinaryRecursive(array, userInput, min, (mid - 1));
                }
                else
                {
                    return IndexByBinaryRecursive(array, userInput, (mid + 1), max);
                }
            }
        }


    }
}
